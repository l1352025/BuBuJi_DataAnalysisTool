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
        private const int _msgPoolSize = 20000;
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
        }

        #endregion

        #region 数据初始化
        private void DataInit()
        {
            // 数据库创建
            InitialDb();

            // 总数、日期/基站/设备列表更新
            MainInfoListUpdate();

            // 档案信息
            ReadDocInfo();

            // 当前记录/页数
            _resultCnt = _recordCnt;
            UpdateResultCnt(_resultCnt);

            // 查询第1页显示
            _currSelCondition = "";
            _currPage = 0;
            QuerySpecifyPage(_currPage + 1);
        }
        #endregion

        #region 数据库操作：创建、插入
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

                // index idx on tblLog
                sql = "CREATE INDEX IF NOT EXISTS idx ON tblLog ( " +
                    "deviceId," +
                    "stationId," +
                    "frameSn," +
                    "stepSum," +
                    "date," +
                    "datetime," +
                    "isRepeatRpt" + 
                ")";
                _sqldb.ExecuteNonQuery(sql);

                // table tblDoc
                sql = "CREATE TABLE IF NOT EXISTS tblDoc ( " +
                    "id            INTEGER PRIMARY KEY AUTOINCREMENT," +
                    "deviceId      INTEGER (8)," +
                    "reportCnt     INTEGER (4)," +
                    "rptCntDay1    INTEGER (4)," +
                    "rptCntDay2    INTEGER (4)," +
                    "rptCntDay3    INTEGER (4)," +
                    "rptCntDay4    INTEGER (4)," +
                    "rptCntDay5    INTEGER (4)," +
                    "stepStatus    TEXT" +
                ")";
                _sqldb.ExecuteNonQuery(sql);

                // index idx2 on tblDoc
                sql = "CREATE INDEX IF NOT EXISTS idx2 ON tblDoc ( " +
                    "deviceId" + 
                ")";
                _sqldb.ExecuteNonQuery(sql);

            }
        }

        private string GetInsertSqlText(object[] fileds)
        {
            string sqlText;

            sqlText = "insert into tblLog values ("
                + "NULL,"   // fileds[0] id列自动生成
                + fileds[1] + ","
                + fileds[2] + ","
                + fileds[3] + ","
                + fileds[4] + ","
                + fileds[5] + ","
                + fileds[6] + ","
                + "'" + fileds[7] + "',"
                + "'" + fileds[8] + "',"
                + fileds[9] + ","
                + fileds[10] + ","
                + fileds[11] + ")";
            return sqlText;
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
            if(e.ColumnIndex >= 2  && e.ColumnIndex <= 6)
            {
                e.Value = ((int)e.Value == 0 ? "" : e.Value);
            }
        }

        private void dgv_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            int iStart = 0;

            if (sender == dgvLog)
            {
                iStart += (_currPage - 1) * _pageSize;
            }

            for (int i = e.RowIndex; i < ((DataGridView)sender).Rows.Count; )
            {
                ((DataGridView)sender).Rows[i].HeaderCell.Value = ( iStart + (++i)).ToString();
            }
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

            StreamReader sr = new StreamReader(strFileName, Encoding.UTF8);

            int index, len, cnt = 0, repeatCnt = 0;
            DateTime timeStart = DateTime.Now;
            object[] dataFields = new object[12];
            StringBuilder strRead = new StringBuilder();
            string strReadStr;
            DateTime time;

            if (_sqldb == null) return;

            // 打开数据库、创建事务处理
            SQLiteConnection con = new SQLiteConnection(_sqldb.ConnectionString);
            try
            {
                con.Open();
            }
            catch(Exception)
            {
                ShowMsg("数据库打开失败！\r\n", Color.Red);
                return;
            }
            SQLiteTransaction trans = con.BeginTransaction();
            SQLiteCommand cmd = new SQLiteCommand(con);

            while ((strReadStr = sr.ReadLine()) != null)
            {
                try
                {
#if true
                    index = strReadStr.IndexOf("\"di\"");
                    if (index < 0) continue;

                    // id 列自动生成，此处用来统计重复次数
                    dataFields[0] = repeatCnt;

                    index += 6;
                    // devId
                    dataFields[1] = strReadStr.Substring(index, 12);
                    index += 20;
                    // devStatus
                    dataFields[2] = strReadStr.Substring(index, 1);
                    index += 9;
                    // devVbat
                    dataFields[3] = strReadStr.Substring(index, 3);
                    index += 11;
                    // stationId
                    dataFields[4] = strReadStr.Substring(index, 12);
                    index += 20;
                    // signal
                    len = strReadStr.IndexOf("\"", index) - index;
                    dataFields[5] = strReadStr.Substring(index, len);
                    index += len + 8;
                    // steps
                    len = strReadStr.IndexOf("\"", index) - index;
                    dataFields[6] = strReadStr.Substring(index, len);
                    index += len + 8;
                    // date
                    dataFields[7] = strReadStr.Substring(index, 10);
                    // time
                    dataFields[8] = strReadStr.Substring(index, 19);
                    index += 30;
                    // version
                    len = strReadStr.IndexOf("\"", index) - index;
                    dataFields[9] = strReadStr.Substring(index, len);
                    index += len + 8;
                    // frameSn
                    len = strReadStr.IndexOf("\"", index) - index;
                    dataFields[10] = strReadStr.Substring(index, len);

                    // isRepeatRpt 列，默认0-没有重复
                    dataFields[11] = 0;
#endif

#if fa
                    index = strReadStr.IndexOf("\"di\"");
                    if (index < 0) continue;

                    strRead.Clear();
                    strRead.Append(strReadStr);

                    // id 列自动生成，此处用来统计重复次数
                    dataFields[0] = repeatCnt;

                    index += 6;
                    // devId
                    dataFields[1] = strRead.ToString(index, 12);
                    index += 20;
                    // devStatus
                    dataFields[2] = strRead.ToString(index, 1);
                    index += 9;
                    // devVbat
                    dataFields[3] = strRead.ToString(index, 3);
                    index += 11;
                    // stationId
                    dataFields[4] = strRead.ToString(index, 12);
                    index += 20;
                    // signal
                    len = strReadStr.IndexOf("\"", index) - index;
                    dataFields[5] = strRead.ToString(index, len);
                    index += len + 8;
                    // steps
                    len = strReadStr.IndexOf("\"", index) - index;
                    dataFields[6] = strRead.ToString(index, len);
                    index += len + 8;
                    // date
                    dataFields[7] = strRead.ToString(index, 10);
                    // time
                    dataFields[8] = strRead.ToString(index, 19);
                    index += 30;
                    // version
                    len = strReadStr.IndexOf("\"", index) - index;
                    dataFields[9] = strRead.ToString(index, len);
                    index += len + 8;
                    // frameSn
                    len = strReadStr.IndexOf("\"", index) - index;
                    dataFields[10] = strRead.ToString(index, len);

                    // isRepeatRpt 列，默认0-没有重复
                    dataFields[11] = 0;
#endif

                    if (repeatCnt != 0xFFFF)
                    {
                        // 重复导入检查, 前2条重复则停止导入
                        cmd.CommandText = "select id from tblLog where "
                            + "deviceId = " + dataFields[1] + " and "
                            + "stationId = " + dataFields[4] + " and "
                            + "datetime = '" + dataFields[8] + "'";
                        if (cmd.ExecuteScalar() != null)
                        {
                            repeatCnt++;
                            if (repeatCnt == 2)
                                break;
                            else
                                continue;
                        }
                            
                        repeatCnt = 0xFFFF;
                    }

                    // 重复上报标记设置
                    time = Convert.ToDateTime(dataFields[8]);
                    cmd.CommandText = "select id from tblLog where "
                        + "deviceId = " + dataFields[1] + " and "
                        + "frameSn = " + dataFields[10] + " and "
                        + "stepSum = " + dataFields[6] + " and "
                        + "datetime between '" + time.AddSeconds(-3).ToString("yyyy-MM-dd HH:mm:ss")
                        + "' and '" + time.AddSeconds(3).ToString("yyyy-MM-dd HH:mm:ss") + "'"
                        + " limit 1";
                    if (cmd.ExecuteScalar() != null)
                    {
                        dataFields[11] = 1;
                    }

                    // 提交插入命令
                    cmd.CommandText = GetInsertSqlText(dataFields);
                    cmd.ExecuteNonQuery();

                    cnt++;
                }
                catch (Exception ex)
                {
                    ShowMsg("第" + tbLog.Rows.Count.ToString() + "行日志格式错误，" + ex.Message + "\r\n", Color.Red);
                    break;
                }
            }
            sr.Close();
            //dgvLog.FirstDisplayedScrollingRowIndex = dgvLog.Rows.Count - 1;

            // 提交事务处理
            trans.Commit();

            // 关闭数据库
            con.Close();

            if(repeatCnt == 2)
            {
                ShowMsg("导入已终止：前2条记录数据库中已存在，可能该日志文件已导入过了\r\n", Color.Red, false);
            }
            else
            {
                // 数据、界面初始化
                DataInit();
            }
                
            ShowMsg("导入 " + cnt + " 条记录完成！ 用时 " + 
                (DateTime.Now - timeStart).TotalSeconds.ToString("F3") + " s\r\n", Color.Blue, false);

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
                conditon += " group by deviceId";
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
            DateTime timeStart = DateTime.Now;

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

            ShowMsg("查询完成！ 用时 " +
                    (DateTime.Now - timeStart).TotalSeconds.ToString("F3") + " s\r\n", Color.Blue, false);
        }
        #endregion

        #region 导出查询结果、选择设备id/基站id/日期

        private void cMenuLog_ItemClicked(object sender, EventArgs e)
        {
            switch (((ToolStripMenuItem)sender).Text)
            {
                case "导出本页":
                    {
                        if (tbLog.Rows.Count == 0) return;

                        // 选择文件位置
                        SaveFileDialog savefileDlg = new SaveFileDialog();
                        savefileDlg.Filter = "*.txt(文本文件)|*.txt|*.*(所有文件)|*.*";
                        savefileDlg.DefaultExt = ".txt";
                        savefileDlg.FileName = "XX查询结果-第" + _currPage + "页";

                        if (DialogResult.OK != savefileDlg.ShowDialog() || savefileDlg.FileName == "") return;

                        // 导出
                        DataGridViewToFile(dgvLog, savefileDlg.FileName);

                        ShowMsg("导出 当前结果-第" + _currPage + "页 完成！\r\n", Color.Green, false);
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
                        DataTableToFile(tb, savefileDlg.FileName);

                        ShowMsg("导出 当前结果-所有记录 完成！\r\n", Color.Green, false);
                    }
                    break;

                case "选择当前行-设备ID":
                    {
                        if (dgvLog.SelectedRows[0].Index < 0) return;

                        txtDeviceId.Text = dgvLog.Rows[dgvLog.SelectedRows[0].Index].Cells[0].Value.ToString();
                    }
                    break;

                case "选择当前行-基站ID":
                    {
                        if (dgvLog.SelectedRows[0].Index < 0) return;

                        txtStationId.Text = dgvLog.Rows[dgvLog.SelectedRows[0].Index].Cells[3].Value.ToString();
                    }
                    break;

                case "选择当前行-日期":
                    {
                        if (dgvLog.SelectedRows[0].Index < 0) return;

                        txtDate.Text = Convert.ToDateTime(dgvLog.Rows[dgvLog.SelectedRows[0].Index].Cells[6].Value).ToString("yyyy-MM-dd");
                    }
                    break;

                default:
                    break;
            }
        }
        #endregion

        #region 统计-日期列表、基站列表、设备列表、设备档案信息

        // 总数、日期/基站/设备列表更新
        private void MainInfoListUpdate()
        {
            string sqlText = "";
            SQLiteDataReader reader;
            string whereDate = "";
            DateTime date = DateTime.Now;

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
            tbDates.Clear();
            while (reader.Read())
            {
                DataRow row = tbDates.NewRow();
                row.BeginEdit();
                row["日期"] = reader.GetString(0);
                row["记录条数"] = reader.GetInt64(1);
                row.EndEdit();
                tbDates.Rows.Add(row);
            }
            reader.Close();

            // 查询基站列表
            sqlText = "Select stationId, count(t.stationId)" +
                " From ( select stationId,deviceId from tblLog " 
                + whereDate + "group by stationId, deviceId ) as t" +
                " group by stationId";
            reader = _sqldb.ExecuteReader(sqlText);
            tbStations.Clear();
            while (reader.Read())
            {
                DataRow row = tbStations.NewRow();
                row.BeginEdit();
                row["基站ID"] = reader.GetInt64(0);
                row["设备个数"] = reader.GetInt32(1);
                row.EndEdit();
                tbStations.Rows.Add(row);
            }
            reader.Close();

            // 查询设备列表
            sqlText = "Select deviceId, count(*)" +
                " From tblLog "
                + whereDate + (whereDate != "" ? " and isRepeatRpt = 0 " : " where isRepeatRpt = 0") +
                " group by deviceId";
            reader = _sqldb.ExecuteReader(sqlText);
            tbDevices.Clear();
            while (reader.Read())
            {
                DataRow row = tbDevices.NewRow();
                row.BeginEdit();
                row["设备ID"] = reader.GetInt64(0);
                row["上报次数"] = reader.GetInt32(1);
                row.EndEdit();
                tbDevices.Rows.Add(row);
            }
            reader.Close();

            whereDate = (whereDate != "" ? "" + date.ToString("yyyy-MM-dd") : "所有");
            UpdateGrpDates(tbDates.Rows.Count);
            UpdateGrpStations(tbStations.Rows.Count, whereDate);
            UpdateGrpDevices(tbDevices.Rows.Count, whereDate);
        }

        // 设备档案信息更新
        private void DocInfoUpdate()
        {
            string sqlText = "";
            SQLiteDataReader reader;
            string whereDate = "";
            DateTime date = DateTime.Now;
            DataTable tbZeroStep_Devs, tbAllRpt_DevSteps;
            DataRow[] selRows;
            int stepStat, stepStatLast;
            int tmpCnt, stepErrorCnt;
            StringBuilder strBuilder = new StringBuilder();

            if (chkDate.Checked && DateTime.TryParse(txtDate.Text, out date))
            {
                whereDate = " where date = '" + date.ToString("yyyy-MM-dd") + "' ";
            }

            // 读出档案列表
            ReadDocInfo();

            // 查询步数为0档案
            sqlText = "select distinct deviceId from tblLog "
                + whereDate + (whereDate != "" ? " and stepSum = 0 " : " where stepSum = 0")
                + " order by deviceId";
            tbZeroStep_Devs = _sqldb.ExecuteReaderToDataTable(sqlText);

            // 查询所有上报的设备ID、步数、时间
            sqlText = "select deviceId, stepSum, date from tblLog "
                + whereDate + (whereDate != "" ? " and isRepeatRpt = 0 " : " where isRepeatRpt = 0")
                + " order by deviceId, datetime";
            tbAllRpt_DevSteps = _sqldb.ExecuteReaderToDataTable(sqlText);

            // 统计-上报次数、步数状态
            foreach (DataRow row in tbDoc.Rows)
            {
                selRows = tbAllRpt_DevSteps.Select("deviceId = " + row["设备ID"]);
                if (selRows.Length > 0)
                {
                    if (whereDate != "")
                    {
                        row[1] = selRows.Length;     // total
                        row[2] = selRows.Length;     // day1
                    }
                    else
                    {
                        row[1] = selRows.Length;     // total , day1 -> day5
                        row[2] = selRows.Count(q => Convert.ToDateTime(q[2]).ToString("yyyy-MM-dd") == dgvDoc.Columns[2].HeaderText);
                        row[3] = selRows.Count(q => Convert.ToDateTime(q[2]).ToString("yyyy-MM-dd") == dgvDoc.Columns[3].HeaderText);
                        row[4] = selRows.Count(q => Convert.ToDateTime(q[2]).ToString("yyyy-MM-dd") == dgvDoc.Columns[4].HeaderText);
                        row[5] = selRows.Count(q => Convert.ToDateTime(q[2]).ToString("yyyy-MM-dd") == dgvDoc.Columns[5].HeaderText);
                        row[6] = selRows.Count(q => Convert.ToDateTime(q[2]).ToString("yyyy-MM-dd") == dgvDoc.Columns[6].HeaderText);
                    }

                    // having stepSum = 0 
                    if (tbZeroStep_Devs.Select("deviceId = " + row["设备ID"]).Length > 0)
                    {
                        strBuilder.Clear();
                        stepStatLast = 0xFF;
                        foreach (DataRow dr in selRows)
                        {
                            stepStat = ((long)dr[1] == 0 ? 0 : 1);
                            if (stepStat != stepStatLast)
                            {
                                stepStatLast = stepStat;
                                strBuilder.Append(stepStat + "->");
                            }
                        }
                        row[7] = strBuilder.ToString(0, strBuilder.Length - 2);
                    }
                }
                else
                {
                    row[1] = 0;     // total
                    row[2] = 0;     // day1 -> day5
                    row[3] = 0;
                    row[4] = 0;
                    row[5] = 0;
                    row[6] = 0;
                    row[7] = "";    // stepStatus
                }
            }

            // 统计-未上报的设备数
            strBuilder.Clear();
            tmpCnt = tbDoc.Select(tbDoc.Columns[1].ColumnName + " = 0").Length;
            if (whereDate != "")
            {
                strBuilder.AppendLine(dgvDoc.Columns[2].HeaderText + " 未上报 " 
                    + tbDoc.Select("第1天上报 = 0").Length);
            }
            else
            {
                for(int i = 2; i < 5 + 2; i++)
                {
                    if (dgvDoc.Columns[i].Visible)
                    {
                        strBuilder.AppendLine(dgvDoc.Columns[i].HeaderText + " 未上报 "
                        + tbDoc.Select(tbDoc.Columns[i].ColumnName + " = 0").Length);
                    }
                }
            }
            UpdateCurrDocCnt(tbDoc.Rows.Count, tmpCnt);
            ShowMsg("\r\n档案中未上报的设备数：" + tmpCnt + "\r\n" + strBuilder.ToString(), Color.Red, false);

            // 统计-不在档案中的设备
            tmpCnt = 0;
            strBuilder.Clear();
            sqlText = "select distinct deviceId from tblLog " + whereDate + " order by deviceId";
            tbAllRpt_DevSteps = _sqldb.ExecuteReaderToDataTable(sqlText);
            foreach(DataRow row in tbAllRpt_DevSteps.Rows)
            {
                if (tbDoc.Select("设备ID = " + row[0]).Length == 0)
                {
                    tmpCnt++;
                    strBuilder.Append(tmpCnt + " " + row[0] + "\r\n");
                }
            }
            if(tmpCnt > 0)
            {
                ShowMsg("\r\n不在档案中的设备数：" + tmpCnt + "\r\n" + strBuilder.ToString(), Color.Red, false);
            }

        }

        // 统计按钮单击
        private void btQueryCountInfo_Click(object sender, EventArgs e)
        {
            DateTime timeStart = DateTime.Now;
            ShowMsg("统计中...\r\n", Color.Blue, false, true);

            // 总数、日期/基站/设备列表更新
            MainInfoListUpdate();

            // 设备每天上报次数/步数状态
            DocInfoUpdate();

            ShowMsg("统计完成！ 用时 "
                + (DateTime.Now - timeStart).TotalSeconds.ToString("F3") + " s\r\n", Color.Blue, false);
        }
        #endregion

        #region 导出-日期列表/基站列表/设备列表
        // 导出列表
        private void DataTableToFile(DataTable tb, string toSaveName)
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
                    if(tb.Columns[i].ColumnName == "日期") dateIdx = i;
                    strBuilder.Append(tb.Columns[i].ColumnName + "  ");
                }
                strBuilder.Remove(strBuilder.Length - 2, 2);

                writer.WriteLine(strBuilder.ToString());
                writer.Flush();
            }

            // 表行记录
            for(int k = 0; k < tb.Rows.Count; k++)
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

        private void DataGridViewToFile(DataGridView dgv, string toSaveName)
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
                    if (dgv.Columns[i].HeaderText == "日期") dateIdx = i;
                    strBuilder.Append(dgv.Columns[i].HeaderText + "  ");
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
                    strBuilder.Append((i == dateIdx ? ((DateTime)dr.Cells[i].Value).ToString("yyyy-MM-dd") :
                        dr.Cells[i].Value) + "  ");
                }
                strBuilder.Remove(strBuilder.Length - 2, 2);

                writer.WriteLine(strBuilder.ToString());
            }
            writer.Flush();
            writer.Close();
        }
        private void devices导出列表ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tbDevices.Rows.Count == 0) return;

            // 选择文件位置
            SaveFileDialog savefileDlg = new SaveFileDialog();
            savefileDlg.Filter = "*.txt(文本文件)|*.txt|*.*(所有文件)|*.*";
            savefileDlg.DefaultExt = ".txt";
            savefileDlg.InitialDirectory = Path.GetDirectoryName(Application.ExecutablePath) + "\\data";
            savefileDlg.FileName = "设备列表";

            if (DialogResult.OK != savefileDlg.ShowDialog() || savefileDlg.FileName == "") return;

            // 导出
            DataGridViewToFile(dgvDevice, savefileDlg.FileName);

            ShowMsg("导出设备列表成功！\r\n", Color.Green, false);
        }

        private void devices统计设备数上报次数ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string sqlText = "Select deviceId, count(t.deviceId) as reportCnt " +
                " From ( select deviceId, frameSn from tblLog group by deviceId, frameSn, date, stepSum ) as t" +
                " group by deviceId"; // deviceid -- count
            sqlText = "Select reportCnt, count(tt.reportCnt) as devCnt" +
                " From ( " + sqlText + " ) as tt" +
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
            savefileDlg.Filter = "*.txt(文本文件)|*.txt|*.*(所有文件)|*.*";
            savefileDlg.DefaultExt = ".txt";
            savefileDlg.InitialDirectory = Path.GetDirectoryName(Application.ExecutablePath) + "\\data";
            savefileDlg.FileName = "基站列表";

            if (DialogResult.OK != savefileDlg.ShowDialog() || savefileDlg.FileName == "") return;

            // 导出
            DataGridViewToFile(dgvStation, savefileDlg.FileName);

            ShowMsg("导出基站列表成功！\r\n", Color.Green, false);
        }

        private void dates导出列表ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (tbDates.Rows.Count == 0) return;

            // 选择文件位置
            SaveFileDialog savefileDlg = new SaveFileDialog();
            savefileDlg.Filter = "*.txt(文本文件)|*.txt|*.*(所有文件)|*.*";
            savefileDlg.DefaultExt = ".txt";
            savefileDlg.InitialDirectory = Path.GetDirectoryName(Application.ExecutablePath) + "\\data";
            savefileDlg.FileName = "日期列表";

            if (DialogResult.OK != savefileDlg.ShowDialog() || savefileDlg.FileName == "") return;

            // 导出
            DataGridViewToFile(dgvDate, savefileDlg.FileName);

            ShowMsg("导出日期列表成功！\r\n", Color.Green, false);
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
            if("0123456789\r\b".IndexOf(e.KeyChar) < 0)
            {
                e.Handled = true;
            }

            if(e.KeyChar == '\r' && txtCurrPage.Text != "")
            {
                int pageNum = Convert.ToInt32(txtCurrPage.Text);
                if(pageNum > _pageCnt || pageNum == 0)
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

            if(reader.HasRows)
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

        #region 设备档案信息-导入、统计、导出
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

            //ShowMsg("导入中。。。\r\n", Color.Blue, false);
            rtbMsg.Text = "档案导入中。。。\r\n";
            rtbMsg.ForeColor = Color.Blue;
            rtbMsg.Refresh();

            StreamReader sr = new StreamReader(strFileName, Encoding.UTF8);

            int index, len, cnt = 0;
            DateTime timeStart = DateTime.Now;
            object[] dataFields = new object[9];
            string strReadStr, strSplit;

            if (_sqldb == null) return;

            // 打开数据库、创建事务处理
            SQLiteConnection con = new SQLiteConnection(_sqldb.ConnectionString);
            try
            {
                con.Open();
            }
            catch (Exception)
            {
                ShowMsg("数据库打开失败！\r\n", Color.Red);
                return;
            }
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
                    // ReportCnt
                    dataFields[2] = 0;
                    // RptDay1-5
                    dataFields[3] = 0;
                    dataFields[4] = 0;
                    dataFields[5] = 0;
                    dataFields[6] = 0;
                    dataFields[7] = 0;
                    // Stepstatus
                    dataFields[8] = "";

                    // 重复档案检查
                    cmd.CommandText = "select id from tblDoc where deviceId = " + dataFields[1];
                    if (cmd.ExecuteScalar() != null)
                    {
                        continue;
                    }

                    // 提交插入命令
                    cmd.CommandText = "insert into tblDoc values ("
                        + "NULL,"   // fileds[0] id列自动生成
                        + dataFields[1] + ","
                        + dataFields[2] + ","
                        + dataFields[3] + ","
                        + dataFields[4] + ","
                        + dataFields[5] + ","
                        + dataFields[6] + ","
                        + dataFields[7] + ","
                        + "'" + dataFields[8] + "'" + 
                        ")";
                    cmd.ExecuteNonQuery();

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

            // 关闭数据库
            con.Close();

            if (cnt == 0)
            {
                ShowMsg("导入已终止：所有档案数据库中已存在\r\n", Color.Red, false);
            }
            else
            {
                // 读出档案到列表
                ReadDocInfo();
            }

            ShowMsg("导入 " + cnt + " 条档案完成！ 用时 " +
                (DateTime.Now - timeStart).TotalSeconds.ToString("F3") + " s\r\n", Color.Blue, false);
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
                if (dates.Count > 0)
                {
                    row["总上报次数"] = reader.GetInt32(2);
                    row["第1天上报"] = reader.GetInt32(3);
                    row["第2天上报"] = reader.GetInt32(4);
                    row["第3天上报"] = reader.GetInt32(5);
                    row["第4天上报"] = reader.GetInt32(6);
                    row["第5天上报"] = reader.GetInt32(7);
                    row["步数状态"] = reader.GetString(8);
                }
                row.EndEdit();
                tbDoc.Rows.Add(row);
            }

            // change view's columns
            if (dates.Count == 0)
            {
                for (int i = 1; i < 8; i++)
                {
                    dgvDoc.Columns[i].Visible = false;
                }
            }
            else
            {
                // reportCnt
                dgvDoc.Columns[1].Visible = true; 
                // rptDay1~rptDay5
                for (int i = 0; i < 5 && i < dates.Count; i++ )
                {
                    dgvDoc.Columns[i + 2].Visible = true;
                    dgvDoc.Columns[i + 2].HeaderText = dates[i];
                }
                for (int i = dates.Count + 2; i < 7; i++ )
                {
                    dgvDoc.Columns[i].Visible = false;
                }
                // stepStatus
                dgvDoc.Columns[7].Visible = true;       
            }
            tbDoc.EndLoadData();
        }

        // 删除档案
        private void btDocDelete_Click(object sender, EventArgs e)
        {
            if(dgvDoc.SelectedRows.Count == 0)
            {
                ShowMsg("请先在列表中选择要删除的档案！\r\n", Color.Red);
                return;
            }

            DateTime timeStart = DateTime.Now;
            List<string> sqlTexts = new List<string>();

            foreach(DataGridViewRow row in dgvDoc.SelectedRows)
            {
                sqlTexts.Add("delete from tblDoc where deviceId = " + row.Cells[0].Value);
                tbDoc.Rows.Remove(((DataRowView)row.DataBoundItem).Row);
            }
            _sqldb.ExecuteNonQueryBatch(sqlTexts);

            ShowMsg("删除档案完成！ 用时 " +
                (DateTime.Now - timeStart).TotalSeconds.ToString("F3") + " s\r\n", Color.Blue, false);
        }

        // 清除档案视图
        private void btClearDocView_Click(object sender, EventArgs e)
        {
            _currDocCnt = 0;
            UpdateCurrDocCnt(_currDocCnt, 0);
            tbDoc.Clear();
            rtbMsg.Clear();
        }
        #endregion
    }
}
