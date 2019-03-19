using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Threading;
using System.Collections.Concurrent;
using System.Diagnostics;

namespace BuBuJi_DataAnalysisTool
{
    public partial class FormMain : Form
    {
        private SQLiteHelper _sqldb;
        public class UiMsg
        {
            public Control Ctrl;
            public string Msg;
            public object Param;
            public UiMsg()
                :this(null, null, null)
            {

            }
            public UiMsg(Control c, string s, object o)
            {
                Ctrl = c;
                Msg = s;
                Param = o;
            }
        }
        private Thread _thrUpdateUI;
        private ConcurrentQueue<UiMsg> _uiMsgQueue;
        private Queue<UiMsg> _uiMsgPool;
        private const int _msgPoolSize = 1000;
        private int _pageSize = 1000;
        private int _currPage;
        private int _pageCnt;
        private int _resultCnt;
        private int _recordCnt;
        private string _currSelCondition;
        private int _currDocCnt;
        
        public FormMain()
        {
            InitializeComponent();
            this.Text = Application.ProductName + "_v" + Application.ProductVersion + "   " + Application.CompanyName;

            _uiMsgQueue = new ConcurrentQueue<UiMsg>();
            _thrUpdateUI = new Thread(UiUpdateTask);
            _thrUpdateUI.IsBackground = true;
            _thrUpdateUI.Start();
            _uiMsgPool = new Queue<UiMsg>(_msgPoolSize);
            
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            UiMsg initMsg;
            for (int i = 0; i < _msgPoolSize; i++)
            {
                initMsg = new UiMsg();
                _uiMsgPool.Enqueue(initMsg);
            }

            cbxStat.SelectedIndex = 0;
            cbxVolt.SelectedIndex = 2;
            cbxVer.SelectedIndex = 0;
            cbxSteps.SelectedIndex = 1;

            dgvLog.TopLeftHeaderCell.Value = "序号";
            dgvDoc.TopLeftHeaderCell.Value = "序号";
            dgvDate.TopLeftHeaderCell.Value = "序号";
            dgvStation.TopLeftHeaderCell.Value = "序号";
            dgvDevice.TopLeftHeaderCell.Value = "序号";

            DataInit();
            ReadDocInfo();
        }

        #region UI更新-方法
        private void ShowMsg(string msg, Color fgColor, bool showTime = true, bool refreshNow = false)
        {
            if (msg == "") return;

            msg = (showTime ? "[" + DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss.fff") + "]  " : "") + msg;

            if(refreshNow)
            {
                rtbMsg.Text = msg;
                rtbMsg.ForeColor = fgColor;
                rtbMsg.Refresh();
                return;
            }

            UiMsg uiMsg = _uiMsgPool.Dequeue();
            uiMsg.Ctrl = rtbMsg;
            uiMsg.Msg = (string)msg.Clone();
            uiMsg.Param = fgColor;
            
            _uiMsgQueue.Enqueue(uiMsg);
        }
        private void UpdateGrpDates(int cnt)
        {
            UiMsg uiMsg = _uiMsgPool.Dequeue();
            uiMsg.Ctrl = grpDates;
            uiMsg.Msg = "记录的天数【" + cnt + "】";
            _uiMsgQueue.Enqueue(uiMsg);
        }
        private void UpdateGrpStations(int cnt, string date)
        {
            UiMsg uiMsg = _uiMsgPool.Dequeue();
            uiMsg.Ctrl = grpStations;
            uiMsg.Msg = "接收的基站【" + cnt + "】 - " + date;
            _uiMsgQueue.Enqueue(uiMsg);
        }
        private void UpdateGrpDevices(int cnt, string date)
        {
            UiMsg uiMsg = _uiMsgPool.Dequeue();
            uiMsg.Ctrl = grpDevices;
            uiMsg.Msg = "上报的设备【" + cnt + "】 - " + date;
            _uiMsgQueue.Enqueue(uiMsg);
        }
        private void UpdateRecordCnt(int cnt)
        {
            string strcnt = (cnt < 10000 ? cnt.ToString() : ((float)cnt / 10000).ToString("N1") + "万");

            UiMsg uiMsg = _uiMsgPool.Dequeue();
            uiMsg.Ctrl = lbRecordCnt;
            uiMsg.Msg = "记录总数 " + strcnt + " 条";
            _uiMsgQueue.Enqueue(uiMsg);
        }
        private void UpdateResultCnt(int cnt)
        {
            _pageSize = (int)updownPagesize.Value;
            _pageCnt = (cnt + _pageSize - 1) / _pageSize;

            UiMsg uiMsg = _uiMsgPool.Dequeue();
            uiMsg.Ctrl = lbResultCnt;
            uiMsg.Msg = "当前结果： " + cnt + " 条  " + _pageCnt + " 页";
            _uiMsgQueue.Enqueue(uiMsg);

            uiMsg = _uiMsgPool.Dequeue();
            uiMsg.Ctrl = lbPageCnt;
            uiMsg.Msg = "/ " + _pageCnt;
            _uiMsgQueue.Enqueue(uiMsg);
        }
        private void UpdateCurrentPage(int pageNum)
        {
            UiMsg uiMsg = _uiMsgPool.Dequeue();
            uiMsg.Ctrl = txtCurrPage;
            uiMsg.Msg = pageNum.ToString();
            _uiMsgQueue.Enqueue(uiMsg);
        }
        private void UpdateDataTbl(object[] objs)
        {
            UiMsg uiMsg = _uiMsgPool.Dequeue();
            uiMsg.Ctrl = dgvLog;
            uiMsg.Param = objs.Clone();
            _uiMsgQueue.Enqueue(uiMsg);
        }
        private void UpdateCurrDocCnt(int DocCnt, int RptCnt)
        {
            UiMsg uiMsg = _uiMsgPool.Dequeue();
            uiMsg.Ctrl = lbCurrDocCnt;
            uiMsg.Msg = "当前档案：总共 " + DocCnt + " ，未上报 " + RptCnt;
            _uiMsgQueue.Enqueue(uiMsg);
        }
        #endregion

        #region UI更新-线程
        delegate void Uinvoke();
        delegate void UiUpdateInvoke(UiMsg uiMsg);
        private void UiUpdate(UiMsg uiMsg)
        {
            if (uiMsg.Ctrl is RichTextBox)
            {
                RichTextBox rtb = (RichTextBox)uiMsg.Ctrl;

                //rtb.Clear();    // 不需要追加时，清空之前文本
                int iStart = rtb.Text.Length;
                rtb.AppendText(uiMsg.Msg);
                rtb.Select(iStart, rtb.Text.Length);
                rtb.SelectionColor = (Color)uiMsg.Param;
                rtb.Select(rtb.Text.Length, 0);
                rtb.ScrollToCaret();
            }
            else if (uiMsg.Ctrl is DataGridView)
            {
                object[] objs = (object[])uiMsg.Param;
                AddToDataView(objs);
            }
            else
            {
                uiMsg.Ctrl.Text = uiMsg.Msg;
            }

            _uiMsgPool.Enqueue(uiMsg);
        }

        // UI更新线程
        private void UiUpdateTask()
        {
            UiMsg uiMsg;

            while (Thread.CurrentThread.IsAlive)
            {
                while (_uiMsgQueue.Count > 0 && _uiMsgQueue.TryDequeue(out uiMsg))
                {
                    Invoke(new UiUpdateInvoke(UiUpdate), uiMsg);
                }

                Thread.Sleep(50);
            }
        }

        #endregion

        #region 窗口关闭处理

        private void Clear()
        {
            if(_thrUpdateUI != null)
            {
                _thrUpdateUI.Abort();
                _thrUpdateUI = null;
            }
            _uiMsgQueue = null;
            _uiMsgPool = null;

            if(_sqldb != null)
            {
                _sqldb.MemoryDatabaseToDisk();
                _sqldb.CloseConnection();
                _sqldb = null;
            }
        }

        #endregion

        #region 数据初始化
        private void DataInit()
        {
            // 数据库创建
            InitialDb();

            // 总数、日期/基站/设备列表更新
            MainInfoListUpdate();

            // 当前记录/页数
            _resultCnt = _recordCnt;
            UpdateResultCnt(_resultCnt);

            // 查询第1页显示
            _currSelCondition = "";
            _currPage = 0;
            QuerySpecifyPage(_currPage + 1);
        }
        #endregion

        #region 数据库创建、载入内存
        private void InitialDb()
        {
            string dbName = Path.GetDirectoryName(Application.ExecutablePath) + "\\database.db";

            if (_sqldb == null)
            {
                _sqldb = new SQLiteHelper("provider=System.Data.SQLite; data source=" + dbName);

                if (_sqldb.CreateDb(dbName) == false) return;

                // table tblLog
                string sql = "CREATE TABLE IF NOT EXISTS tblLog ( " +
                    "id            INTEGER PRIMARY KEY AUTOINCREMENT," +
                    "deviceId      INTEGER (8)," + 
                    "deviceStatus  INTEGER (1)," +
                    "deviceVoltage NUMERIC (4)," +
                    "stationId     INTEGER (8)," +
                    "signalVal     INTEGER (1)," +
                    "stepSum       INTEGER (8)," +
                    "date          DATETIME   ," +
                    "datetime      DATETIME   ," +
                    "version       INTEGER (1)," +
                    "frameSn       INTEGER (1)," +
                    "isRepeatRpt   INTEGER (1)" + 
                ")";
                _sqldb.ExecuteNonQuery(sql);

#if true
                // index idx on tblLog
                sql = "CREATE INDEX IF NOT EXISTS idx ON tblLog ( " +
                    "deviceId," +
                    "deviceStatus," +
                    "deviceVoltage," +
                    "stationId," +
                    "stepSum," +
                    "date," +
                    "datetime," +
                    "version," +
                    "frameSn," +
                    "isRepeatRpt" + 
                ")";
                _sqldb.ExecuteNonQuery(sql);
#endif

                // table tblDoc
                sql = "CREATE TABLE IF NOT EXISTS tblDoc ( " +
                    "id            INTEGER PRIMARY KEY AUTOINCREMENT," +
                    "deviceId      INTEGER (8)" +
                ")";
                _sqldb.ExecuteNonQuery(sql);

                // index idx2 on tblDoc
                sql = "CREATE INDEX IF NOT EXISTS idx2 ON tblDoc ( " +
                    "deviceId" + 
                ")";
                _sqldb.ExecuteNonQuery(sql);

            }

            // 使用内存数据库
            _sqldb.MemoryDatabaseEable();
        }
        #endregion

        #region 数据视图-格式化、行号刷新
        private void AddToDataView(object[] objs)
        {
            DataRow row = tbLog.NewRow();

            row.BeginEdit();
            row[设备ID]   = objs[1];
            row[设备状态] = objs[2];
            row[设备电压] = objs[3];
            row[基站ID] = objs[4];
            row[信号量] = objs[5];
            row[步数总计] = objs[6];
            //row[日期] = objs[7];  // don't show this col
            row[时间] = objs[8];
            row[版本号] = objs[9];
            row[帧序号] = objs[10];
            row.EndEdit();
            tbLog.Rows.Add(row);
        }

        private void dgvLog_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 设备状态DataGridViewTextBoxColumn.Index)
            {
                byte status = (byte)e.Value;
                e.Value = (status == 1 ? "正常" : (status == 2 ? "损坏" : "其他"));
            }
            else if (e.ColumnIndex == 设备电压DataGridViewTextBoxColumn.Index)
            {
                e.CellStyle.Format = "N1";
            }
            else if(e.ColumnIndex == 时间DataGridViewTextBoxColumn.Index)
            {
                e.CellStyle.Format = "yyyy-MM-dd HH:mm:ss";
            }
            else if(e.ColumnIndex == 帧序号DataGridViewTextBoxColumn.Index)
            {
            //    e.CellStyle.Format = "X2";
            }
        }

        private void dgvDoc_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex >= 2 && e.ColumnIndex < dgvDoc.Columns.GetColumnCount(DataGridViewElementStates.Visible) - 1)
            {
                e.Value = ( e.Value.ToString() == "0" ? "" : e.Value);
            }
        }

        private void dgv_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            int iStart = 0;
            DataGridView dgv = ((DataGridView)sender);

            if (sender == dgvLog)
            {
                iStart += (_currPage - 1) * _pageSize;
            }

            for (int i = e.RowIndex; i < ((DataGridView)sender).Rows.Count; )
            {
                dgv.Rows[i].HeaderCell.Value = ( iStart + (++i)).ToString();
            }
            //dgv.FirstDisplayedScrollingRowIndex = dgv.RowCount - 1;
        }
        private void dgv_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            int iStart = 0;

            if (sender == dgvLog)
            {
                iStart += (_currPage - 1) * _pageSize;
            }

            for (int i = e.RowIndex; i < ((DataGridView)sender).Rows.Count; )
            {
                ((DataGridView)sender).Rows[i].HeaderCell.Value = (iStart + (++i)).ToString();
            }
        }

        private void OnRowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            SolidBrush solidBrush = new SolidBrush(dgvLog.RowHeadersDefaultCellStyle.ForeColor);
            e.Graphics.DrawString((e.RowIndex + 1).ToString(), 
                e.InheritedRowStyle.Font, solidBrush, 
                e.RowBounds.Location.X + 15, 
                e.RowBounds.Location.Y + 5);
        }
        
        #endregion

        #region 数据表/数据视图-导出
        private void ExportToFile(DataTable tb, string toSaveName)
        {
            FileStream fstream = File.Open(toSaveName, FileMode.Create, FileAccess.Write);
            StreamWriter writer = new StreamWriter(fstream);
            StringBuilder strBuilder = new StringBuilder(1024);

            int dateIdx = 0xFF;

            // 表头
            if (tb.Rows.Count > 0)
            {
                strBuilder.Clear();

                strBuilder.Append("序号" + "  ");
                for (int i = 0; i < tb.Columns.Count; i++)
                {
                    if (tb.Columns[i].ColumnName == "日期") dateIdx = i;
                    strBuilder.Append(tb.Columns[i].ColumnName + "  ");
                }
                strBuilder.Remove(strBuilder.Length - 2, 2);

                writer.WriteLine(strBuilder.ToString());
                writer.Flush();
            }

            // 表行记录
            for (int k = 0; k < tb.Rows.Count; k++)
            {
                strBuilder.Clear();

                strBuilder.Append(k + 1 + "  ");
                for (int i = 0; i < tb.Columns.Count; i++)
                {
                    strBuilder.Append((i == dateIdx ? ((DateTime)tb.Rows[k][i]).ToString("yyyy-MM-dd") : tb.Rows[k][i]) + "  ");
                }
                strBuilder.Remove(strBuilder.Length - 2, 2);

                writer.WriteLine(strBuilder.ToString());
            }
            writer.Flush();
            writer.Close();
        }

        private void ExportToFile(DataGridView dgv, string toSaveName)
        {
            FileStream fstream = File.Open(toSaveName, FileMode.Create, FileAccess.Write);
            StreamWriter writer = new StreamWriter(fstream);
            StringBuilder strBuilder = new StringBuilder(1024);

            int dateIdx = 0xFF;

            // 表头
            if (dgv.Rows.Count > 0)
            {
                strBuilder.Clear();

                strBuilder.Append("序号" + "  ");
                for (int i = 0; i < dgv.Columns.Count; i++)
                {
                    if (dgv.Columns[i].Visible)
                    {
                        if (dgv.Columns[i].HeaderText == "日期") dateIdx = i;
                        strBuilder.Append(dgv.Columns[i].HeaderText + "  ");
                    }
                }
                strBuilder.Remove(strBuilder.Length - 2, 2);

                writer.WriteLine(strBuilder.ToString());
                writer.Flush();
            }

            // 表行记录
            foreach (DataGridViewRow dr in dgv.Rows)
            {
                strBuilder.Clear();

                strBuilder.Append(dr.Index + 1 + "  ");
                for (int i = 0; i < dgv.Columns.Count; i++)
                {
                    if (dgv.Columns[i].Visible)
                    {
                        strBuilder.Append((i == dateIdx ? ((DateTime)dr.Cells[i].Value).ToString("yyyy-MM-dd") :
                            dr.Cells[i].Value) + "  ");
                    }
                }
                strBuilder.Remove(strBuilder.Length - 2, 2);

                writer.WriteLine(strBuilder.ToString());
            }
            writer.Flush();
            writer.Close();
        }

        public DataTable ExcelToDataTable(string dataSource, string tblName)
        {
            DataTable tb = new DataTable();
            string strConn = string.Empty;
            string extension = Path.GetExtension(dataSource);

            if (File.Exists(dataSource) == false) return tb;

            if (extension == ".xls")
                strConn = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + dataSource + ";Extended Properties='Excel 8.0;HDR=YES;IMEX=1'";
            else if (extension == ".xlsx")
                strConn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + dataSource + ";Extended Properties='Excel 12.0;HDR=YES;IMEX=1'";
            else
                strConn = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + dataSource + ";";

            OleDbConnection conn = new OleDbConnection(strConn);
            conn.Open();

            string strSql = "select * from " + tblName;

            OleDbDataAdapter oda = new OleDbDataAdapter(strSql, strConn);
            oda.Fill(tb);
            conn.Close();

            return tb;
        }
        public void DataTableToExcel(string dataSource, string tblName, DataTable srcTable)
        {
            string strConn = string.Empty;
            string extension = Path.GetExtension(dataSource);

            if (File.Exists(dataSource) == false) throw new Exception("数据源不存在");

            if (extension == ".xls")
                strConn = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + dataSource + ";Extended Properties='Excel 8.0;HDR=YES;IMEX=1'";
            else if (extension == ".xlsx")
                strConn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + dataSource + ";Extended Properties='Excel 12.0;HDR=YES;IMEX=1'";
            else
                strConn = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + dataSource + ";";

            OleDbConnection conn = new OleDbConnection(strConn);
            conn.Open();
            OleDbTransaction trans = conn.BeginTransaction();



            trans.Commit();
            conn.Close();

        }
        public void ExportToExcel(DataTable dt, string toSaveName, string[,] formatCols = null)
        {
            Microsoft.Office.Interop.Excel.Application appexcel = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook workbook;
            Microsoft.Office.Interop.Excel.Worksheet worksheet;
            Microsoft.Office.Interop.Excel.Range range;
            System.Reflection.Missing miss = System.Reflection.Missing.Value;

            // 设置对象不可见
            appexcel.Visible = false;

            // 保存/切换当前环境
            System.Globalization.CultureInfo currentCI = System.Threading.Thread.CurrentThread.CurrentCulture;
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-us");

            // 创建工作簿、工作表
            workbook = appexcel.Workbooks.Add(miss);
            worksheet = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Worksheets.Add(miss);

            // 给工作表赋名称
            worksheet.Name = "saved";

            int iRowCnt = dt.Rows.Count;       // 总行数
            int iColumnCnt = dt.Columns.Count; // 总列数
            int iParstedRows = 0, iCurrRows = 0, iBufferRowCnt = 1000;   //iBufferRowCnt为每次写行的数值，可以自己设置

            // 表头
            for (int i = 0; i < dt.Columns.Count; i++)
            {
                worksheet.Cells[1, i + 1] = dt.Columns[i].ColumnName.ToString();
            }

            // 表内容

            //在内存中声明一个iBufferRowCnt×iColumnCnt的数组，iBufferRowCnt是每次最大存储的行数，iColumnCnt就是存储的实际列数
            object[,] objval = new object[iBufferRowCnt, iColumnCnt];

            iCurrRows = iBufferRowCnt;

            while (iParstedRows < iRowCnt)
            {
                if ((iRowCnt - iParstedRows) < iBufferRowCnt)
                    iCurrRows = iRowCnt - iParstedRows;

                //用for循环给数组赋值
                for (int i = 0; i < iCurrRows; i++)
                {
                    for (int j = 0; j < iColumnCnt; j++)
                        objval[i, j] = dt.Rows[i + iParstedRows][j].ToString();
                    System.Windows.Forms.Application.DoEvents();
                }

                string cellBegin = "A" + ((int)(iParstedRows + 2)).ToString();
                string cellEnd = "";

                if (iColumnCnt <= 26)
                {
                    cellEnd = ((char)('A' + iColumnCnt - 1)).ToString() + ((int)(iParstedRows + iCurrRows + 1)).ToString();
                }
                else
                {
                    cellEnd = ((char)('A' + (iColumnCnt / 26 - 1))).ToString() + ((char)('A' + (iColumnCnt % 26 - 1))).ToString() + ((int)(iParstedRows + iCurrRows + 1)).ToString();
                }
                range = worksheet.get_Range(cellBegin, cellEnd);

                // 调用range的value2属性，把内存中的值赋给excel
                range.Value2 = objval;

                iParstedRows = iParstedRows + iCurrRows;
            }

            // 设置单元格格式 - 所有
            range = worksheet.get_Range("A1", (char)('A' + iColumnCnt - 1) + (iRowCnt + 1).ToString());
            range.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter; //居中
            //加边框
            //range.BorderAround(Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous, Microsoft.Office.Interop.Excel.XlBorderWeight.xlThin, Microsoft.Office.Interop.Excel.XlColorIndex.xlColorIndexAutomatic, null);
            range.EntireColumn.AutoFit();   //自动调整列宽
            //range.EntireRow.AutoFit();      //自动调整行高

            // 设置单元格格式 - 表头
            range = worksheet.get_Range("A1", (char)('A' + iColumnCnt - 1) + "1");
            range.Font.Bold = true; //粗体

            // 设置单元格格式 - 某列
            if (formatCols != null)
            {
                for (int i = 0; i < formatCols.GetLength(0); i++)
                {
                    range = worksheet.get_Range(formatCols[i, 0] + ":" + formatCols[i, 0]);     // 设置某列格式
                    range.NumberFormat = formatCols[i, 1];
                }
            }

            System.Runtime.InteropServices.Marshal.ReleaseComObject(range);
            range = null;

            //设置禁止弹出保存和覆盖的询问提示框
            appexcel.DisplayAlerts = false;
            appexcel.AlertBeforeOverwriting = false;

            //恢复文化环境
            System.Threading.Thread.CurrentThread.CurrentCulture = currentCI;

            try
            {
                //保存excel文件
                //appexcel.Save(toSaveName); //自动创建一个新的Excel文档保存在“我的文档”里
                workbook.Saved = true;
                workbook.SaveCopyAs(toSaveName);//以复制的形式保存在已有的文档里
            }
            catch (Exception ex)
            {
                ShowMsg("导出Excel文件失败：" + ex.Message + "\r\n", Color.Red);
            }
            finally
            {
                //确保Excel进程关闭
                appexcel.Quit();
                System.Runtime.InteropServices.Marshal.ReleaseComObject(appexcel);
                System.Runtime.InteropServices.Marshal.ReleaseComObject(worksheet);
                System.Runtime.InteropServices.Marshal.ReleaseComObject(workbook);
                appexcel = null;
            }

        }

        public void ExportToExcel(DataGridView dgv, string toSaveName, string[,] formatCols = null)
        {

            Microsoft.Office.Interop.Excel.Application appexcel = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook workbook;
            Microsoft.Office.Interop.Excel.Worksheet worksheet;
            Microsoft.Office.Interop.Excel.Range range;
            System.Reflection.Missing miss = System.Reflection.Missing.Value;

            // 设置对象不可见
            appexcel.Visible = false;

            // 保存/切换当前环境
            System.Globalization.CultureInfo currentCI = System.Threading.Thread.CurrentThread.CurrentCulture;
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-us");

            // 创建工作簿、工作表
            workbook = appexcel.Workbooks.Add(miss);
            worksheet = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Worksheets.Add(miss);

            // 给工作表赋名称
            worksheet.Name = "saved";

            int iRowCnt = dgv.Rows.Count;       // 总行数
            int iColumnCnt = dgv.Columns.GetColumnCount(DataGridViewElementStates.Visible); // 总列数
            int iParstedRows = 0, iCurrRows = 0, iBufferRowCnt = 1000;   //iBufferRowCnt为每次写行的数值，可以自己设置

            // 表头
            for (int i = 0; i < iColumnCnt; i++)
            {
                worksheet.Cells[1, i + 1] = dgv.Columns[i].HeaderText;
            }

            // 表内容

            //在内存中声明一个iBufferRowCnt×iColumnCnt的数组，iBufferRowCnt是每次最大存储的行数，iColumnCnt就是存储的实际列数
            object[,] objval = new object[iBufferRowCnt, iColumnCnt];

            iCurrRows = iBufferRowCnt;

            while (iParstedRows < iRowCnt)
            {
                if ((iRowCnt - iParstedRows) < iBufferRowCnt)
                    iCurrRows = iRowCnt - iParstedRows;

                //用for循环给数组赋值
                for (int i = 0; i < iCurrRows; i++)
                {
                    for (int j = 0; j < iColumnCnt; j++)
                        objval[i, j] = dgv.Rows[i + iParstedRows].Cells[j].Value.ToString();
                    System.Windows.Forms.Application.DoEvents();
                }

                string cellBegin = "A" + ((int)(iParstedRows + 2)).ToString();
                string cellEnd = "";

                if (iColumnCnt <= 26)
                {
                    cellEnd = ((char)('A' + iColumnCnt - 1)).ToString() + ((int)(iParstedRows + iCurrRows + 1)).ToString();
                }
                else
                {
                    cellEnd = ((char)('A' + (iColumnCnt / 26 - 1))).ToString() + ((char)('A' + (iColumnCnt % 26 - 1))).ToString() + ((int)(iParstedRows + iCurrRows + 1)).ToString();
                }
                range = worksheet.get_Range(cellBegin, cellEnd);

                // 调用range的value2属性，把内存中的值赋给excel
                range.Value2 = objval;

                iParstedRows = iParstedRows + iCurrRows;
            }

            // 设置单元格格式 - 所有
            range = worksheet.get_Range("A1", (char)('A' + iColumnCnt - 1) + (iRowCnt + 1).ToString());
            range.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter; //居中
            //加边框
            //range.BorderAround(Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous, Microsoft.Office.Interop.Excel.XlBorderWeight.xlThin, Microsoft.Office.Interop.Excel.XlColorIndex.xlColorIndexAutomatic, null);
            range.EntireColumn.AutoFit();   //自动调整列宽
            //range.EntireRow.AutoFit();      //自动调整行高

            // 设置单元格格式 - 表头
            range = worksheet.get_Range("A1", (char)('A' + iColumnCnt - 1) + "1");
            range.Font.Bold = true; //粗体

            // 设置单元格格式 - 某列
            if (formatCols != null)
            {
                for (int i = 0; i < formatCols.GetLength(0); i++)
                {
                    range = worksheet.get_Range(formatCols[i, 0] + ":" + formatCols[i, 0]);     // 设置某列格式
                    range.NumberFormat = formatCols[i, 1];
                }
            }

            System.Runtime.InteropServices.Marshal.ReleaseComObject(range);
            range = null;

            //设置禁止弹出保存和覆盖的询问提示框
            appexcel.DisplayAlerts = false;
            appexcel.AlertBeforeOverwriting = false;

            //恢复文化环境
            System.Threading.Thread.CurrentThread.CurrentCulture = currentCI;

            try
            {
                //保存excel文件
                //appexcel.Save(toSaveName); //自动创建一个新的Excel文档保存在“我的文档”里
                workbook.Saved = true;
                workbook.SaveCopyAs(toSaveName);//以复制的形式保存在已有的文档里
            }
            catch (Exception ex)
            {
                ShowMsg("导出Excel文件失败：" + ex.Message + "\r\n", Color.Red);
            }
            finally
            {
                //确保Excel进程关闭
                appexcel.Quit();
                System.Runtime.InteropServices.Marshal.ReleaseComObject(appexcel);
                System.Runtime.InteropServices.Marshal.ReleaseComObject(worksheet);
                System.Runtime.InteropServices.Marshal.ReleaseComObject(workbook);
                appexcel = null;
            }

        }
        #endregion

        #region 导入日志文件
        private void btImport_Click(object sender, EventArgs e)
        {
            string strFileName;
            OpenFileDialog openFileDlg = new OpenFileDialog();

            openFileDlg.Filter = "*.log(文本文件)|*.log|*.*(所有文件)|*.*";
            openFileDlg.DefaultExt = "log";
            openFileDlg.FileName = "";
            if (DialogResult.OK != openFileDlg.ShowDialog() || openFileDlg.FileName.Length == 0)
            {
                return;
            }
            strFileName = openFileDlg.FileName;

            ShowMsg("Log导入中。。。\r\n", Color.Blue, false, true);

            Thread t = new Thread(new ThreadStart(delegate
            {
                StreamReader sr = new StreamReader(strFileName, Encoding.UTF8);

                int index, len, cnt = 0, repeatCnt = 0;
                StringBuilder sbSql = new StringBuilder();
                string strReadStr;
                //DateTime time;

                if (_sqldb == null) return;

                Stopwatch timer = new Stopwatch();
                timer.Start();

                // 打开数据库、创建事务处理
                SQLiteConnection con = _sqldb.OpenConnection();
                SQLiteCommand cmd = new SQLiteCommand(con);

                cmd.CommandText = "PRAGMA synchronous = OFF";
                cmd.ExecuteNonQuery();

                SQLiteTransaction trans = con.BeginTransaction();
                SQLiteParameter[] values = new SQLiteParameter[12];

                values[0] = new SQLiteParameter("@id");
                values[1] = new SQLiteParameter("@deviceId");
                values[2] = new SQLiteParameter("@deviceStatus");
                values[3] = new SQLiteParameter("@deviceVoltage");
                values[4] = new SQLiteParameter("@stationId");
                values[5] = new SQLiteParameter("@signalVal");
                values[6] = new SQLiteParameter("@stepSum");
                values[7] = new SQLiteParameter("@date");
                values[8] = new SQLiteParameter("@dateTime");
                values[9] = new SQLiteParameter("@version");
                values[10] = new SQLiteParameter("@frameSn");
                values[11] = new SQLiteParameter("@isRepeatRpt");

                cmd.Transaction = trans;
                cmd.CommandText = "insert into tblLog"
                    + " ( id, deviceId, deviceStatus, deviceVoltage, stationId, "
                    + "signalVal, stepSum, date, dateTime, version, frameSn, isRepeatRpt )"
                    + " values ( @id, @deviceId, @deviceStatus, @deviceVoltage, @stationId, "
                    + "@signalVal, @stepSum, @date, @dateTime, @version, @frameSn, @isRepeatRpt )";
                cmd.Parameters.AddRange(values);

                while ((strReadStr = sr.ReadLine()) != null)
                {
                    try
                    {
                        index = strReadStr.IndexOf("\"di\"");
                        if (index < 0) continue;

                        // id 列自动生成
                        //values[0].Value = 0;

                        index += 6;
                        // devId
                        values[1].Value = strReadStr.Substring(index, 12);
                        index += 20;
                        // devStatus
                        values[2].Value = strReadStr.Substring(index, 1);
                        index += 9;
                        // devVbat
                        values[3].Value = strReadStr.Substring(index, 3);
                        index += 11;
                        // stationId
                        values[4].Value = strReadStr.Substring(index, 12);
                        index += 20;
                        // signal
                        len = strReadStr.IndexOf("\"", index) - index;
                        values[5].Value = strReadStr.Substring(index, len);
                        index += len + 8;
                        // steps
                        len = strReadStr.IndexOf("\"", index) - index;
                        values[6].Value = strReadStr.Substring(index, len);
                        index += len + 8;
                        // date
                        values[7].Value = strReadStr.Substring(index, 10);
                        // time
                        values[8].Value = strReadStr.Substring(index, 19);
                        index += 30;
                        // version
                        len = strReadStr.IndexOf("\"", index) - index;
                        values[9].Value = strReadStr.Substring(index, len);
                        index += len + 8;
                        // frameSn
                        len = strReadStr.IndexOf("\"", index) - index;
                        values[10].Value = strReadStr.Substring(index, len);
                        // isRepeatRpt 列，0-没有重复, 1 - 重复
                        values[11].Value = 1;

                        // 重复导入检查, 前2条重复则停止导入
                        if (repeatCnt != 0xFFFF)
                        {
                            if (_sqldb.ExecuteScalar( "select id from tblLog where"
                                + " deviceId = " + values[1].Value + " and"
                                + " stationId = " + values[4].Value + " and"
                                + " datetime = '" + values[8].Value + "'") != null)
                            {
                                repeatCnt++;
                                if (repeatCnt == 2) 
                                    break;
                                else 
                                    continue;
                            }
                            repeatCnt = 0xFFFF;
                        }
#if fa
                    // 重复上报标记设置
                    time = Convert.ToDateTime(values[8].Value);
                    sbSql.Clear();
                    sbSql.Append("select id from tblLog where "
                        + "deviceId = " + values[1].Value + " and "
                        + "frameSn = " + values[10].Value + " and "
                        + "stepSum = " + values[6].Value + " and "
                        + "datetime between '" + time.AddSeconds(-3).ToString("yyyy-MM-dd HH:mm:ss")
                        + "' and '" + time.AddSeconds(3).ToString("yyyy-MM-dd HH:mm:ss") + "'");
                    if (_sqldb.ExecuteScalar(sbSql.ToString()) != null)
                    {
                        values[11].Value = 1;
                    }
#endif
                        // 提交插入命令
                        _sqldb.ExecuteNonQuery(cmd);

                        cnt++;
                    }
                    catch (Exception ex)
                    {
                        ShowMsg("第" + tbLog.Rows.Count.ToString() + "行日志格式错误，" + ex.Message + "\r\n", Color.Red);
                        break;
                    }
                }
                sr.Close();

#if true
                if (repeatCnt == 0xFFFF)
                {
                    // 重复上报标记设置
                    DataTable tbZeroStep_devs = _sqldb.ExecuteReaderToDataTable(
                        "select distinct deviceId from tblLog ");
                    DateTime srcRptTime = DateTime.Now, tmpTime;
                    byte srcRptFsn = 0xFF, tmpFsn;
                    List<int> srcRptIDs = new List<int>();
                    int tmpCnt;
                    SQLiteDataReader reader;
                    foreach (DataRow row in tbZeroStep_devs.Rows)
                    {
                        tmpCnt = 0;
                        reader = _sqldb.ExecuteReader(
                            "select id, datetime, frameSn, isRepeatRpt from tblLog" +
                            " where deviceId = " + row[0] + " order by frameSn, datetime");
                        while (reader.Read())
                        {
                            tmpCnt++;
                            if (tmpCnt == 1)
                            {
                                srcRptTime = reader.GetDateTime(1);
                                srcRptFsn = reader.GetByte(2);
                                if (reader.GetByte(3) == 0) continue;

                                srcRptIDs.Add(reader.GetInt32(0));
                            }
                            else
                            {
                                tmpTime = reader.GetDateTime(1);
                                tmpFsn = reader.GetByte(2);
                                if (tmpFsn == srcRptFsn && tmpTime <= srcRptTime.AddSeconds(3)) continue;

                                srcRptTime = tmpTime;
                                srcRptFsn = tmpFsn;
                                if (reader.GetByte(3) == 0) continue;

                                srcRptIDs.Add(reader.GetInt32(0));
                            }
                        }
                    }
                    foreach (int id in srcRptIDs)
                    {
                        _sqldb.ExecuteNonQuery("update tblLog set isRepeatRpt = 0 where id = " + id);
                    }
                }
#endif

                // 提交事务处理
                trans.Commit();

                // 通知写入数据库文件
                _sqldb.SendStartWriteDbEvent();

                if (repeatCnt == 2)
                {
                    ShowMsg("导入已终止：前2条记录数据库中已存在，可能该日志文件已导入过了\r\n", Color.Red, false);
                }
                else
                {
                    // 查询总数
                    Invoke(new Uinvoke(MainInfoListUpdate), null);
                }

                timer.Stop();
                ShowMsg("导入 " + cnt + " 条记录完成！ 当前记录总数 " + _recordCnt + " 用时 " +
                    timer.Elapsed.TotalSeconds.ToString("F3") + " s\r\n", Color.Blue, false);

            }));
            t.IsBackground = true;
            t.Start();

            //ShowMsg((repeatCnt == 0 ? "" : "排除重复记录 " + repeatCnt + " 条\r\n"), Color.Red, false);
        }
        #endregion
        
        #region 查询数据库
        private void dgvDate_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            txtDate.Text = ((DateTime)(dgvDate.Rows[e.RowIndex].Cells[0].Value)).ToString("yyyy-MM-dd");
        }

        private void dgvStation_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            txtStationId.Text = dgvStation.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

        private void dgvDevice_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            txtDeviceId.Text = dgvDevice.Rows[e.RowIndex].Cells[0].Value.ToString();
        }
        // 查询条件设置
        private string GetQueryCondition()
        {
            string date = "", devid = "", staid = "", steps = "", stat = "", volt = "", ver = "";

            try
            {
                if(chkDate.Checked && txtDate.Text != "") 
                    date = "date = '" + DateTime.Parse(txtDate.Text).ToString("yyyy-MM-dd") + "' and ";
                if(chkDeviceId.Checked && txtDeviceId.Text != "")
                    devid = "deviceId = '" + Convert.ToInt64(txtDeviceId.Text) + "' and ";
                if(chkStationId.Checked && txtStationId.Text != "")
                    staid = "stationId = '" + Convert.ToInt64(txtStationId.Text) + "' and ";
                //if (chkFsn.Checked && txtFsn.Text != "")
                //    fsn = "frameSn = '" + Convert.ToByte(txtFsn.Text, 16) + "' and ";
                if (chkVoltage.Checked && txtVolt.Text != "")
                {
                    switch(cbxVolt.SelectedIndex)
                    {
                        case 0: volt = "deviceVoltage = '" + Convert.ToSingle(txtVolt.Text) + "' and "; break;
                        case 1: volt = "deviceVoltage > '" + Convert.ToSingle(txtVolt.Text) + "' and "; break;
                        case 2: volt = "deviceVoltage < '" + Convert.ToSingle(txtVolt.Text) + "' and "; break;
                        default: break;
                    }
                }
                if (chkSteps.Checked && txtSteps.Text != "")
                {
                    switch (cbxSteps.SelectedIndex)
                    {
                        case 0: steps = "stepSum = '" + Convert.ToInt64(txtSteps.Text) + "' and "; break;
                        case 1: steps = "stepSum > '" + Convert.ToInt64(txtSteps.Text) + "' and "; break;
                        case 2: steps = "stepSum < '" + Convert.ToInt64(txtSteps.Text) + "' and "; break;
                        default: break;
                    }
                }
                if (chkStatus.Checked)
                {
                    switch (cbxStat.SelectedIndex)
                    {
                        case 0: stat = "deviceStatus = '1' and "; break;
                        case 1: stat = "deviceStatus = '2' and "; break;
                        case 2: stat = "deviceStatus = '3' and "; break;
                        default: break;
                    }
                }
                if (chkVer.Checked)
                {
                    switch (cbxVer.SelectedIndex)
                    {
                        case 0: ver = "version = '" + Convert.ToByte(txtVer.Text) + "' and "; break;
                        case 1: ver = "version > '" + Convert.ToByte(txtVer.Text) + "' and "; break;
                        case 2: ver = "version < '" + Convert.ToByte(txtVer.Text) + "' and "; break;
                        default: break;
                    }
                }
            }
            catch(Exception)
            {
                return "error";
            }

            string conditon = " where "
                + (date != "" ? date : "")
                + (devid != "" ? devid : "")
                + (staid != "" ? staid : "")
                //+ (fsn != "" ? fsn : "")
                + (volt != "" ? volt : "")
                + (steps != "" ? steps : "")
                + (stat != "" ? stat : "")
                + (ver != "" ? ver : "");
            conditon = (conditon.EndsWith("and ") ? conditon.Substring(0, conditon.Length - 4) : "");

            if (chkRmSameDev.Checked)
            {
                conditon += " group by deviceId having min(deviceVoltage)";
            }
            else if (chkRmSameReport.Checked)
            {
                conditon += (conditon != "" ? " and isRepeatRpt = 0" : " where isRepeatRpt = 0");
            }
            else
            {
                conditon += "";
            }
            conditon += " order by deviceId, datetime asc";
            
            return conditon;
        }

        // 执行查询
        private void btQuery_Click(object sender, EventArgs e)
        {
            string sqlText = "";
            Stopwatch timer = new Stopwatch();
            timer.Start();

            // 查询条件设置
            if((sqlText = GetQueryCondition()) == "error")
            {
                ShowMsg("查询条件输入值无效，请修正!\r\n", Color.Red);
                return;
            }
            _currSelCondition = sqlText;

            // 查询总数
            sqlText = "select count(*) from ( select id from tblLog" + _currSelCondition + " )";
            _resultCnt = Convert.ToInt32(_sqldb.ExecuteScalar(sqlText));
            UpdateResultCnt(_resultCnt);

            // 查询第1页显示
            _currPage = 0;
            QuerySpecifyPage(_currPage + 1);

            tabControl1.SelectedTab = tabPage1;

            timer.Stop();
            ShowMsg("查询完成！ 用时 " +
                    timer.Elapsed.TotalSeconds.ToString("F3") + " s\r\n", Color.Blue, false);
        }
        #endregion

        #region 查询结果右键-导出、选择设备id/基站id/日期

        private void cMenuLog_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            e.ClickedItem.Owner.Visible = false;

            switch (e.ClickedItem.Text)
            {
                case "导出本页":
                    {
                        if (tbLog.Rows.Count == 0) return;

                        // 选择文件位置
                        SaveFileDialog savefileDlg = new SaveFileDialog();
                        savefileDlg.Filter = "*.xls(Excel文件)|*.xls|*.txt(文本文件)|*.txt|*.*(所有文件)|*.*";
                        savefileDlg.DefaultExt = ".xls";
                        savefileDlg.FileName = "XX查询结果-第" + _currPage + "页";

                        if (DialogResult.OK != savefileDlg.ShowDialog() || savefileDlg.FileName == "") return;

                        // 导出
                        ShowMsg("导出中。。。\r\n", Color.Green, false, true);

                        if (savefileDlg.FileName.Contains("xls"))
                        {
                            string[,] formatCols = new string[,] { { "A", "00" }, { "D", "00" }, { "G", "yyyy-MM-dd HH:mm:ss" } };
                            ExportToExcel(dgvLog, savefileDlg.FileName, formatCols);
                        }
                        else
                        {
                            ExportToFile(dgvLog, savefileDlg.FileName);
                        }

                        ShowMsg("导出[当前结果-第" + _currPage + "页]完成！\r\n", Color.Green, false);
                    }
                    break;

                case "导出所有":
                    {
                        if (tbLog.Rows.Count == 0) return;

                        string sqlText = "select * from tblLog" + _currSelCondition;
                        SQLiteDataReader reader = _sqldb.ExecuteReader(sqlText);

                        DataTable tb = tbLog.Clone();
                        tb.BeginLoadData();
                        while (reader.Read())
                        {
                            DataRow row = tb.NewRow();
                            row.BeginEdit();
                            // row["序号"] = tb.Rows.Count + 1; // don't use this col
                            row["设备ID"] = reader.GetInt64(1);
                            row["设备状态"] = reader.GetByte(2);
                            row["设备电压"] = reader.GetFloat(3);
                            row["基站ID"] = reader.GetInt64(4);
                            row["信号量"] = reader.GetByte(5);
                            row["步数总计"] = reader.GetInt64(6);
                            //row["日期"] = reader.GetDateTime(7); // don't use this col
                            row["时间"] = reader.GetDateTime(8);
                            row["版本号"] = reader.GetByte(9);
                            row["帧序号"] = reader.GetByte(10);
                            row.EndEdit();
                            tb.Rows.Add(row);
                        }
                        tb.EndLoadData();
                        reader.Close();

                        // 选择文件位置
                        SaveFileDialog savefileDlg = new SaveFileDialog();
                        savefileDlg.Filter = "*.txt(文本文件)|*.txt|*.*(所有文件)|*.*";
                        savefileDlg.DefaultExt = ".txt";
                        savefileDlg.FileName = "XX查询结果-共" + _resultCnt + "条";

                        if (DialogResult.OK != savefileDlg.ShowDialog() || savefileDlg.FileName == "") return;

                        // 导出
                        ShowMsg("导出中。。。\r\n", Color.Green, false, true);

                        if (savefileDlg.FileName.Contains("xls"))
                        {
                            string[,] formatCols = new string[,] { { "A", "00" }, { "D", "00" }, { "G", "yyyy-MM-dd HH:mm:ss" } };
                            ExportToExcel(tb, savefileDlg.FileName, formatCols);
                        }
                        else
                        {
                            ExportToFile(tb, savefileDlg.FileName);
                        }

                        ShowMsg("导出[当前结果-所有记录]完成！\r\n", Color.Green, false);
                    }
                    break;

                case "选择当前行-设备ID":
                    {
                        if (dgvLog.SelectedRows.Count == 0) return;

                        txtDeviceId.Text = dgvLog.Rows[dgvLog.SelectedRows[0].Index].Cells[0].Value.ToString();
                    }
                    break;

                case "选择当前行-基站ID":
                    {
                        if (dgvLog.SelectedRows.Count == 0) return;

                        txtStationId.Text = dgvLog.Rows[dgvLog.SelectedRows[0].Index].Cells[3].Value.ToString();
                    }
                    break;

                case "选择当前行-日期":
                    {
                        if (dgvLog.SelectedRows.Count == 0) return;

                        txtDate.Text = Convert.ToDateTime(dgvLog.Rows[dgvLog.SelectedRows[0].Index].Cells[6].Value).ToString("yyyy-MM-dd");
                    }
                    break;

                default:
                    break;
            }
        }
        #endregion

        #region 统计概要信息-日期列表、基站列表、设备列表

        // 统计-总数、日期/基站/设备列表
        private void MainInfoListUpdate()
        {
            SQLiteDataReader reader;
            DataRow row;
            string sqlText = "";
            string whereDate = "";
            DateTime date = DateTime.Now;

            tbDates.Clear();
            tbStations.Clear();
            tbDevices.Clear();
            
            if(chkDate.Checked && DateTime.TryParse(txtDate.Text, out date))
            {
                whereDate = " where date = '" + date.ToString("yyyy-MM-dd") + "' ";
            }

            // 查询总数
            sqlText = "select count(*) from tblLog";
            _recordCnt = Convert.ToInt32(_sqldb.ExecuteScalar(sqlText));

            UpdateRecordCnt(_recordCnt);

            // 查询日期列表
            sqlText = (chkRmSameReport.Checked ?
                "select date, count(*) from tblLog where isRepeatRpt = 0 group by date" :
                "select date, count(*) from tblLog group by date");
            reader = _sqldb.ExecuteReader(sqlText);
            tbDates.BeginLoadData();
            while (reader.Read())
            {
                row = tbDates.NewRow();
                row.BeginEdit();
                row["日期"] = reader.GetDateTime(0);
                row["记录条数"] = reader.GetInt64(1);
                row.EndEdit();
                tbDates.Rows.Add(row);
            }
            tbDates.EndLoadData();
            reader.Close();
            
            // 查询基站列表
            sqlText = "Select stationId, count(t.stationId)" +
                " From ( select stationId,deviceId from tblLog " 
                + whereDate + "group by stationId, deviceId ) as t" +
                " group by stationId";
            reader = _sqldb.ExecuteReader(sqlText);
            tbStations.BeginLoadData();
            while (reader.Read())
            {
                row = tbStations.NewRow();
                row.BeginEdit();
                row["基站ID"] = reader.GetInt64(0);
                row["设备个数"] = reader.GetInt32(1);
                row.EndEdit();
                tbStations.Rows.Add(row);
            }
            tbStations.EndLoadData();
            reader.Close();

            // 查询设备列表
            sqlText = "Select deviceId, count(*)" +
                " From tblLog "
                + whereDate + (whereDate != "" ? " and isRepeatRpt = 0 " : " where isRepeatRpt = 0") +
                " group by deviceId";
            reader = _sqldb.ExecuteReader(sqlText);
            tbDevices.BeginLoadData();
            while (reader.Read())
            {
                row = tbDevices.NewRow();
                row.BeginEdit();
                row["设备ID"] = reader.GetInt64(0);
                row["上报次数"] = reader.GetInt32(1);
                row.EndEdit();
                tbDevices.Rows.Add(row);
            }
            tbDevices.EndLoadData();
            reader.Close();

            whereDate = (whereDate != "" ? "" + date.ToString("yyyy-MM-dd") : "所有");
            UpdateGrpDates(tbDates.Rows.Count);
            UpdateGrpStations(tbStations.Rows.Count, whereDate);
            UpdateGrpDevices(tbDevices.Rows.Count, whereDate);
        }

        // 统计按钮单击
        private void btQueryCountInfo_Click(object sender, EventArgs e)
        {
            Stopwatch timer = new Stopwatch();
            ShowMsg("统计中...\r\n", Color.Blue, false, true);
            timer.Start();

            // 总数、日期/基站/设备列表更新
            MainInfoListUpdate();

            timer.Stop();
            ShowMsg("统计[概要信息]完成！ 用时 " + timer.Elapsed.TotalSeconds.ToString("F3") + " s\r\n", Color.Blue, false);
        }
        #endregion

        #region 导出-日期列表/基站列表/设备列表
        private void devices导出列表ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tbDevices.Rows.Count == 0) return;

            // 选择文件位置
            SaveFileDialog savefileDlg = new SaveFileDialog();
            savefileDlg.Filter = "*.xls(Excel文件)|*.xls|*.txt(文本文件)|*.txt|*.*(所有文件)|*.*";
            savefileDlg.DefaultExt = ".xls";
            savefileDlg.InitialDirectory = Path.GetDirectoryName(Application.ExecutablePath) + "\\data";
            savefileDlg.FileName = "上报的设备";

            if (DialogResult.OK != savefileDlg.ShowDialog() || savefileDlg.FileName == "") return;

            // 导出
            ShowMsg("导出中。。。\r\n", Color.Green, false, true);

            if (savefileDlg.FileName.Contains("xls"))
            {
                string[,] formatCols = new string[,] { { "A", "00" } };
                ExportToExcel(dgvDevice, savefileDlg.FileName, formatCols);
            }
            else
            {
                ExportToFile(dgvDevice, savefileDlg.FileName);
            }

            ShowMsg("导出[上报的设备]完成！\r\n", Color.Green, false);
        }

        private void devices统计设备数上报次数ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string sqlText = "Select reportCnt, count(tt.reportCnt) as devCnt" +
                " From ( select deviceId, count(*) as reportCnt from tblLog where isRepeatRpt = 0 group by deviceId) as tt" +
                " group by reportCnt"; // reportCnt -- devCnt

            DataTable tb = _sqldb.ExecuteReaderToDataTable(sqlText);
            if (tb.Rows.Count == 0) return;

            StringBuilder msg = new StringBuilder(4096);
            msg.AppendLine("上报次数  设备个数");
            foreach(DataRow row in tb.Rows)
            {
                msg.AppendLine(row[0].ToString().PadLeft(5) + "      " + row[1]);
            }

            // 结果输出
            rtbMsg.Text = msg.ToString();
        }

        private void stations导出列表ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (tbStations.Rows.Count == 0) return;

            // 选择文件位置
            SaveFileDialog savefileDlg = new SaveFileDialog();
            savefileDlg.Filter = "*.xls(Excel文件)|*.xls|*.txt(文本文件)|*.txt|*.*(所有文件)|*.*";
            savefileDlg.DefaultExt = ".xls";
            savefileDlg.InitialDirectory = Path.GetDirectoryName(Application.ExecutablePath) + "\\data";
            savefileDlg.FileName = "接收的基站";

            if (DialogResult.OK != savefileDlg.ShowDialog() || savefileDlg.FileName == "") return;

            // 导出
            ShowMsg("导出中。。。\r\n", Color.Green, false, true);

            if (savefileDlg.FileName.Contains("xls"))
            {
                string[,] formatCols = new string[,] { { "A", "00" } };
                ExportToExcel(dgvStation, savefileDlg.FileName, formatCols);
            }
            else
            {
                ExportToFile(dgvStation, savefileDlg.FileName);
            }

            ShowMsg("导出[接收的基站]完成！\r\n", Color.Green, false);
        }

        private void dates导出列表ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (tbDates.Rows.Count == 0) return;

            // 选择文件位置
            SaveFileDialog savefileDlg = new SaveFileDialog();
            savefileDlg.Filter = "*.xls(Excel文件)|*.xls|*.txt(文本文件)|*.txt|*.*(所有文件)|*.*";
            savefileDlg.DefaultExt = ".xls";
            savefileDlg.InitialDirectory = Path.GetDirectoryName(Application.ExecutablePath) + "\\data";
            savefileDlg.FileName = "记录的天数";

            if (DialogResult.OK != savefileDlg.ShowDialog() || savefileDlg.FileName == "") return;

            // 导出
            ShowMsg("导出中。。。\r\n", Color.Green, false, true);

            if (savefileDlg.FileName.Contains("xls"))
            {
                string[,] formatCols = new string[,] { { "A", "yyyy-MM-dd" } };
                ExportToExcel(dgvDate, savefileDlg.FileName, formatCols);
            }
            else
            {
                ExportToFile(dgvDate, savefileDlg.FileName);
            }

            ShowMsg("导出[记录的天数]完成！\r\n", Color.Green, false);
        }
        private void dates删除记录ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvDate.SelectedRows.Count == 0) return;

            if (DialogResult.OK != MessageBox.Show("删除数据库记录吗？ \r\n 删除后将是无法恢复的！",
                "警告", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning))
            {
                return;
            }

            if (dgvDate.SelectedRows.Count == tbDates.Rows.Count)
            {
                btClearAll_Click(null, null);
            }
            else
            {
                StringBuilder sbDate = new StringBuilder();
                foreach(DataGridViewRow row in dgvDate.SelectedRows)
                {
                    sbDate.Clear();
                    sbDate.Append(Convert.ToDateTime(row.Cells[0].Value).ToString("yyyy-MM-dd"));
                    _sqldb.ExecuteNonQuery("delete from tblLog where date = '" + sbDate.ToString() + "'");
                    tbDates.Rows.Remove(((DataRowView)(row.DataBoundItem)).Row);
                    ShowMsg(sbDate.ToString() + " 数据库记录已删除！\r\n", Color.Green, false);
                }
                DataInit();
            }
        }
        #endregion

        #region 查看上一页/下一页 、跳到指定页

        // 查询 上一页
        private void btPagePrev_Click(object sender, EventArgs e)
        {
            if (_currPage <= 1) return;

            QuerySpecifyPage(_currPage - 1);
        }
        // 查询 下一页
        private void btPageNext_Click(object sender, EventArgs e)
        {
            if (_currPage >= _pageCnt) return;

            QuerySpecifyPage(_currPage + 1);
        }
        // 跳转到指定页
        private void txtCurrPage_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ("0123456789\r\b".IndexOf(e.KeyChar) < 0)
            {
                e.Handled = true;
            }

            if (e.KeyChar == '\r' && txtCurrPage.Text != "")
            {
                int pageNum = Convert.ToInt32(txtCurrPage.Text);
                if (pageNum > _pageCnt || pageNum == 0)
                {
                    ShowMsg("请输入正确的页序号：最小为1，最大为" + _pageCnt + "\r\n", Color.Red);
                    txtCurrPage.Text = _currPage.ToString();
                    return;
                }

                QuerySpecifyPage(pageNum);
            }
        }

        // 查询第 N 页显示
        private void QuerySpecifyPage(int pageNum)
        {
            string sqlText = "";
            int rsltOffset = (pageNum - 1) * _pageSize;

            sqlText = "select * from tblLog" + _currSelCondition + " limit " + _pageSize + " offset " + rsltOffset;
            SQLiteDataReader reader = _sqldb.ExecuteReader(sqlText);

            if (reader.HasRows)
            {
                _currPage = pageNum;
            }

            tbLog.Clear();
            tbLog.BeginLoadData();
            while (reader.Read())
            {
                rsltOffset++;
                DataRow row = tbLog.NewRow();
                row.BeginEdit();
                // row["序号"] = rsltOffset;          // don't use this col
                row[设备ID] = reader.GetInt64(1);
                row[设备状态] = reader.GetByte(2);
                row[设备电压] = reader.GetFloat(3);
                row[基站ID] = reader.GetInt64(4);
                row[信号量] = reader.GetByte(5);
                row[步数总计] = reader.GetInt64(6);
                // row[日期] = reader.GetDateTime(7); // don't use this col
                row[时间] = reader.GetDateTime(8);
                row[版本号] = reader.GetByte(9);
                row[帧序号] = reader.GetByte(10);
                row.EndEdit();
                tbLog.Rows.Add(row);
            }
            reader.Close();
            tbLog.EndLoadData();

            UpdateCurrentPage(_currPage);
        }

        #endregion 

        #region 删除数据库 、清空当前显示
        // 删除数据库
        private void btClearAll_Click(object sender, EventArgs e)
        {
            if (_recordCnt <= 0) return;

            if (DialogResult.OK != MessageBox.Show("删除数据库所有记录吗？ \r\n 删除后将是无法恢复的！", 
                "警告", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning))
            {
                return;
            }

            tbDates.Clear();
            tbDevices.Clear();
            tbStations.Clear();
            tbLog.Clear();
            rtbMsg.Clear();

            string sql = "delete from tblLog";
            _sqldb.ExecuteNonQuery(sql);
            sql = "update sqlite_sequence set seq = 0 where name = 'tblLog'";
            _sqldb.ExecuteNonQuery(sql);

            tbDoc.Clear();
            sql = "delete from tblDoc";
            _sqldb.ExecuteNonQuery(sql);
            sql = "update sqlite_sequence set seq = 0 where name = 'tblDoc'";
            _sqldb.ExecuteNonQuery(sql);

            _recordCnt = 0;
            _resultCnt = 0;
            _currPage = 0;
            UpdateRecordCnt(_recordCnt);
            UpdateResultCnt(_resultCnt);
            UpdateCurrentPage(_currPage);
        }
        // 清空当前显示
        private void btClearCurrent_Click(object sender, EventArgs e)
        {
            tbLog.Clear();
            rtbMsg.Clear();
            _resultCnt = 0;
            _currPage = 0;
            UpdateResultCnt(_resultCnt);
            UpdateCurrentPage(_currPage);
        }
        #endregion

        #region 设备档案信息-导入、读出、删除、导出
        // 导入档案
        private void btDocImport_Click(object sender, EventArgs e)
        {
            string strFileName;
            OpenFileDialog openFileDlg = new OpenFileDialog();

            openFileDlg.Filter = "*.csv(文本文件)|*.csv|*.*(所有文件)|*.*";
            openFileDlg.DefaultExt = "csv";
            openFileDlg.FileName = "";
            if (DialogResult.OK != openFileDlg.ShowDialog() || openFileDlg.FileName.Length == 0)
            {
                return;
            }
            strFileName = openFileDlg.FileName;

            ShowMsg("档案导入中。。。\r\n", Color.Blue, false, true);

            StreamReader sr = new StreamReader(strFileName, Encoding.UTF8);

            int index, len, cnt = 0;
            object[] dataFields = new object[2];
            string strReadStr, strSplit;
            Stopwatch timer = new Stopwatch();

            if (_sqldb == null) return;

            timer.Start();
            // 打开数据库、创建事务处理
            SQLiteConnection con = _sqldb.OpenConnection();
            SQLiteTransaction trans = con.BeginTransaction();
            SQLiteCommand cmd = new SQLiteCommand(con);

            while ((strReadStr = sr.ReadLine()) != null)
            {
                try
                {
                    strSplit = ",";
                    index = strReadStr.IndexOf(strSplit);
                    if (index < 0)
                    {
                        strSplit = "  ";
                        if( (index = strReadStr.IndexOf(strSplit)) < 0)
                        {
                            continue;
                        }
                        index++;
                    }
                    index++;

                    // id 列自动生成
                    dataFields[0] = 0;

                    // deviceId
                    len = strReadStr.IndexOf(strSplit, index) - index;
                    dataFields[1] = strReadStr.Substring(index, len);
                    if(len != 12)
                    {
                        continue;
                    }

                    // 重复档案检查
                    cmd.CommandText = "select distinct deviceId from tblDoc where deviceId = " + dataFields[1];
                    if (cmd.ExecuteScalar() != null)
                    {
                        continue;
                    }

                    // 提交插入命令
                    cmd.CommandText = "insert into tblDoc values ("
                        + "NULL,"   // id列自动生成
                        + dataFields[1] + 
                        ")";
                    _sqldb.ExecuteNonQuery(cmd);

                    cnt++;
                }
                catch (Exception ex)
                {
                    ShowMsg("第" + tbLog.Rows.Count.ToString() + "行档案格式错误，" + ex.Message + "\r\n", Color.Red);
                    break;
                }
            }
            sr.Close();

            // 提交事务处理
            trans.Commit();

            if (cnt == 0)
            {
                ShowMsg("导入已终止：所有档案数据库中已存在\r\n", Color.Red, false);
            }

            // 读出档案到列表
            ReadDocInfo();

            timer.Stop();
            ShowMsg("导入 " + cnt + " 条档案完成！ 用时 " +
                timer.Elapsed.TotalSeconds.ToString("F3") + " s\r\n", Color.Blue, false);
        }

        // 从数据库中读出档案信息
        private void ReadDocInfo()
        {
            List<string> dates = new List<string>();
            DataRow row = null;
            string sqlText;
            SQLiteDataReader reader;

            // get dates 
            sqlText = "select distinct date from tblLog order by date";
            reader = _sqldb.ExecuteReader(sqlText);
            while (reader.Read())
            {
                dates.Add(reader.GetString(0));
            }
            reader.Close();

            // get docinfo
            sqlText = "select * from tblDoc order by deviceId";
            reader = _sqldb.ExecuteReader(sqlText);
            tbDoc.Clear();
            tbDoc.BeginLoadData();
            while(reader.Read())
            {
                row = tbDoc.NewRow();
                row.BeginEdit();
                row["设备ID"] = reader.GetInt64(1);
                row.EndEdit();
                tbDoc.Rows.Add(row);
            }
            reader.Close();

            // disable view's columns visible
            for (int i = 1; i < dgvDoc.Columns.Count; i++)
            {
                dgvDoc.Columns[i].Visible = false;
            }

            // set view's columns visible
            if (dates.Count > 0)
            {
                int colIdx = 1;
                // reportCnt / minVbat / maxVbat
                dgvDoc.Columns[colIdx].Visible = true;
                dgvDoc.Columns[colIdx].HeaderText = (rbtRptCnt.Checked ? "总上报次数" :
                    (rbtVbatMin.Checked ? "总最低电压" : "总最高电压"));
                colIdx++;

                // rptDay1~rptDay5
                if(chkDate.Checked && txtDate.Text != "")
                {
                    dgvDoc.Columns[colIdx].Visible = true;
                    dgvDoc.Columns[colIdx].HeaderText = txtDate.Text;
                    colIdx++;
                }
                else
                {
                    for (int i = 0; i < 5 && i < dates.Count; i++)
                    {
                        dgvDoc.Columns[colIdx].Visible = true;
                        dgvDoc.Columns[colIdx].HeaderText = dates[i];
                        colIdx++;
                    }
                }
                
                // stepStatus
                if (rbtRptCnt.Checked)
                {
                    dgvDoc.Columns[colIdx].Visible = true;
                    dgvDoc.Columns[colIdx].HeaderText = "步数状态";
                }
            }
            tbDoc.EndLoadData();
        }

        // 删除档案
        private void DeleteDocInfo()
        {
            if(dgvDoc.SelectedRows.Count == 0)
            {
                ShowMsg("请先在列表中选择要删除的档案！\r\n", Color.Red);
                return;
            }

            Stopwatch timer = new Stopwatch();
            timer.Start();
            List<string> sqlTexts = new List<string>();

            foreach(DataGridViewRow row in dgvDoc.SelectedRows)
            {
                sqlTexts.Add("delete from tblDoc where deviceId = " + row.Cells[0].Value);
                tbDoc.Rows.Remove(((DataRowView)row.DataBoundItem).Row);
            }
            _sqldb.ExecuteNonQueryBatch(sqlTexts);

            timer.Stop();
            ShowMsg("删除档案完成！ 用时 " +
                timer.Elapsed.TotalSeconds.ToString("F3") + " s\r\n", Color.Blue, false);
        }

        // 清除档案视图
        private void btClearDocView_Click(object sender, EventArgs e)
        {
            _currDocCnt = 0;
            UpdateCurrDocCnt(_currDocCnt, 0);
            tbDoc.Clear();
            rtbMsg.Clear();
        }

        // 右键-导出档案信息、选择设备ID、导入档案、删除档案
        private void cMenuDocs_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            e.ClickedItem.Owner.Visible = false;

            switch (e.ClickedItem.Text)
            {
                case "导出列表":
                    {
                        if (tbDoc.Rows.Count == 0) return;

                        string info = (rbtRptCnt.Checked ? "上报次数" : (rbtVbatMin.Checked ? "最低电压" : "最高电压"));

                        // 选择文件位置
                        SaveFileDialog savefileDlg = new SaveFileDialog();
                        savefileDlg.Filter = "*.xls(Excel文件)|*.xls|*.txt(文本文件)|*.txt|*.*(所有文件)|*.*";
                        savefileDlg.DefaultExt = ".xls";
                        savefileDlg.FileName = "设备" + info;

                        if (DialogResult.OK != savefileDlg.ShowDialog() || savefileDlg.FileName == "") return;

                        // 导出
                        ShowMsg("导出中。。。\r\n", Color.Green, false, true);

                        if (savefileDlg.FileName.Contains("xls"))
                        {
                            string[,] formatCols = new string[,] { { "A", "00" } };
                            ExportToExcel(dgvDoc, savefileDlg.FileName, formatCols);
                        }
                        else
                        {
                            ExportToFile(dgvDoc, savefileDlg.FileName);
                        }

                        ShowMsg("导出[设备" + info + "]完成！\r\n", Color.Green, false);
                    }
                    break;


                case "选择当前行-设备ID":
                    {
                        if (dgvDoc.SelectedRows.Count == 0) return;

                        txtDeviceId.Text = dgvDoc.Rows[dgvDoc.SelectedRows[0].Index].Cells[0].Value.ToString();
                    }
                    break;

                case"导入档案":
                    btDocImport_Click(null, null);
                    break;

                case"删除档案":
                    DeleteDocInfo();
                    break;

                default:
                    break;
            }
        }

        #endregion

        #region 统计上报次数/步数状态、最低/最高电压
        // 统计-设备上报次数和步数状态
        private void CountDocRptCntInfo()
        {
            string sqlText = "";
            SQLiteDataReader reader;
            string whereDate = "";
            DateTime date = DateTime.Now;
            DataRow[] selRows;
            int stepStat, stepStatLast;
            int tmpCnt, dayStepErrCnt, dayUnRptCnt;
            long cnt;
            StringBuilder strBuilder = new StringBuilder();
            DataTable tbZeroStep_Devs = null, tbAllRpt_Devs = null;

            if (chkDate.Checked && DateTime.TryParse(txtDate.Text, out date))
            {
                whereDate = " where date = '" + date.ToString("yyyy-MM-dd") + "' ";
            }

            // 读出档案列表
            ReadDocInfo();

            int dgvDocVisialeCols = dgvDoc.Columns.GetColumnCount(DataGridViewElementStates.Visible);

            if (tbDoc.Rows.Count == 0)
            {
                ShowMsg("如果要统计每个设备每天上报和步数情况，请先导入档案！\r\n", Color.Red);
                return;
            }

            // 查询步数为0设备ID
            sqlText = "select distinct deviceId from tblLog "
                + whereDate + (whereDate != "" ? " and stepSum = 0 order by deviceId"
                : " where stepSum = 0 order by deviceId");
            tbZeroStep_Devs = _sqldb.ExecuteReaderToDataTable(sqlText);

            // 统计-上报次数
            foreach (DataRow row in tbDoc.Rows)
            {
                cnt = (long)_sqldb.ExecuteScalar("select count(*) from tblLog "
                    + whereDate + (whereDate != "" ? " and isRepeatRpt = 0 and deviceId = " + row["设备ID"]
                    : " where isRepeatRpt = 0 and deviceId = " + row["设备ID"]));
                if (cnt > 0)
                {
                    // total
                    row[1] = cnt;

                    // day1 -> day5
                    for (int i = 2; i < dgvDocVisialeCols - 1; i++)
                    {
                        row[i] = (long)_sqldb.ExecuteScalar("select count(*) from tblLog"
                            + " where date = '" + dgvDoc.Columns[i].HeaderText + "' and isRepeatRpt = 0 and deviceId = " + row["设备ID"]
                        );
                    }
                }
                else
                {
                    // total
                    row[1] = 0;
                    // day1 -> day5
                    for (int i = 2; i < dgvDocVisialeCols - 1; i++)
                    {
                        row[i] = 0;
                    }
                }

                // step status
                row[dgvDocVisialeCols - 1] = "";
            }

            // 统计-步数为0的步数状态
            foreach (DataRow row in tbZeroStep_Devs.Rows)
            {
                selRows = tbDoc.Select("设备ID = " + row[0]);

                if (selRows.Length == 0) continue;

                strBuilder.Clear();
                stepStatLast = 0xFF;
                sqlText = "select deviceId, stepSum from tblLog "
                    + whereDate + (whereDate != "" ? " and isRepeatRpt = 0 and deviceId = " + row[0]
                    : " where isRepeatRpt = 0 and deviceId = " + row[0])
                    + " order by deviceId, datetime";
                reader = _sqldb.ExecuteReader(sqlText);
                while (reader.Read())
                {
                    stepStat = (reader.GetInt32(1) == 0 ? 0 : 1);
                    if (stepStat != stepStatLast)
                    {
                        stepStatLast = stepStat;
                        strBuilder.Append(stepStat + "->");
                    }
                }
                reader.Close();

                selRows[0][dgvDocVisialeCols - 1] = strBuilder.ToString(0, strBuilder.Length - 2);
            }

            // 统计-未上报的设备数
            strBuilder.Clear();
            tmpCnt = tbDoc.Select(tbDoc.Columns[1].ColumnName + " = 0").Length;
            for (int i = 2; i < dgvDocVisialeCols - 1; i++)
            {
                dayUnRptCnt = tbDoc.Select(tbDoc.Columns[i].ColumnName + " = 0").Length;
                dayStepErrCnt = 0;
                reader = _sqldb.ExecuteReader("select distinct deviceId from tblLog"
                    + " where isRepeatRpt = 0 and stepSum = 0 and date = '" + dgvDoc.Columns[i].HeaderText + "'");
                while (reader.Read())
                {
                    dayStepErrCnt += tbDoc.Select("设备ID = " + reader.GetInt64(0)).Length;
                }
                reader.Close();

                strBuilder.AppendLine(dgvDoc.Columns[i].HeaderText + "  "
                    + dayUnRptCnt.ToString().PadRight(13)
                    + dayStepErrCnt.ToString().PadRight(13));
            }
            UpdateCurrDocCnt(tbDoc.Rows.Count, tmpCnt);
            ShowMsg("\r\n日期        未上报设备数 步数为0设备数\r\n" + strBuilder.ToString(), Color.Red, false);

            // 统计-不在档案中的设备
            tmpCnt = 0;
            strBuilder.Clear();
            sqlText = "select distinct deviceId from tblLog " + whereDate + " order by deviceId";
            tbAllRpt_Devs = _sqldb.ExecuteReaderToDataTable(sqlText);
            foreach (DataRow row in tbAllRpt_Devs.Rows)
            {
                if (tbDoc.Select("设备ID = " + row[0]).Length == 0)
                {
                    tmpCnt++;
                    strBuilder.Append(tmpCnt.ToString().PadRight(6) + row[0] + "\r\n");
                }
            }
            if (tmpCnt > 0)
            {
                ShowMsg("\r\n序号  不在档案中的设备\r\n" + strBuilder.ToString(), Color.Red, false);
            }

            // clear
            tbAllRpt_Devs = null;
            tbZeroStep_Devs = null;
        }

        // 统计-最低/最高电压
        private void CountDocVbatInfo()
        {
            string whereDate = "", strMaxOrMin;
            DateTime date = DateTime.Now;
            object vbat;
   
            if (chkDate.Checked && DateTime.TryParse(txtDate.Text, out date))
            {
                whereDate = " where date = '" + date.ToString("yyyy-MM-dd") + "' ";
            }

            // 读出档案列表
            ReadDocInfo();

            int dgvDocVisialeCols = dgvDoc.Columns.GetColumnCount(DataGridViewElementStates.Visible);

            if (tbDoc.Rows.Count == 0)
            {
                ShowMsg("如果要统计每个设备每天上报/步数/电压情况，请先导入档案！\r\n", Color.Red);
                return;
            }

            // 统计-最小/最大电压
            strMaxOrMin = (rbtVbatMin.Checked ? "min" : "max");
            foreach (DataRow row in tbDoc.Rows)
            {
                vbat = _sqldb.ExecuteScalar("select " + strMaxOrMin + "(deviceVoltage) from tblLog "
                    + whereDate + (whereDate != "" ? " and isRepeatRpt = 0 and deviceId = " + row["设备ID"]
                    : " where isRepeatRpt = 0 and deviceId = " + row["设备ID"]));
                if (vbat != null)
                {
                    // total
                    row[1] = vbat;

                    // day1 -> day5
                    for (int i = 2; i < dgvDocVisialeCols; i++)
                    {
                        row[i] = _sqldb.ExecuteScalar("select " + strMaxOrMin + "(deviceVoltage) from tblLog "
                            + " where date = '" + dgvDoc.Columns[i].HeaderText + "' and isRepeatRpt = 0 and deviceId = " + row["设备ID"]
                        );
                    }
                }
                else
                {
                    // total
                    row[1] = 0;
                    // day1 -> day5
                    for (int i = 2; i < dgvDocVisialeCols; i++)
                    {
                        row[i] = 0;
                    }
                }
            }
        }

        // 统计上报次数、设备电压
        private void btCountDocInfo_Click(object sender, EventArgs e)
        {
            Stopwatch timer = new Stopwatch();
            ShowMsg("统计中...\r\n", Color.Blue, false, true);
            timer.Start();
            string info = (rbtRptCnt.Checked ? "上报次数" : (rbtVbatMin.Checked ? "最低电压" : "最高电压"));

            if (rbtRptCnt.Checked)
            {
                // 设备每天上报次数/步数状态
                CountDocRptCntInfo();
            }
            else
            {
                // 设备每天设备电压
                CountDocVbatInfo();
            }
            tabControl1.SelectedTab = tabPage2;

            timer.Stop();
            ShowMsg("统计[" + info + "]完成！ 用时 " + timer.Elapsed.TotalSeconds.ToString("F3") + " s\r\n", Color.Blue, false);
        }
        #endregion
    }
}
