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
        private Stack<UiMsg> _uiMsgPool;
        private const int _msgPoolSize = 20000;
        private const int _pageSize = 1000;
        private int _currPage;
        private int _resultCnt;

        public FormMain()
        {
            InitializeComponent();
            this.Text = Application.ProductName + "_v" + Application.ProductVersion + "   " + Application.CompanyName;

            _uiMsgQueue = new ConcurrentQueue<UiMsg>();
            _thrUpdateUI = new Thread(UiUpdateTask);
            _thrUpdateUI.IsBackground = true;
            _thrUpdateUI.Start();
            _uiMsgPool = new Stack<UiMsg>(_msgPoolSize);
            UiMsg initMsg;
            for(int i = 0; i < _msgPoolSize; i++)
            {
                initMsg = new UiMsg();
                _uiMsgPool.Push(initMsg);
            }

            InitialDb();
        }

        #region UI更新-方法
        private void ShowMsg(string msg, Color fgColor, bool showTime = true)
        {
            if (msg == "") return;

            msg = (showTime ? "[" + DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss.fff") + "]  " : "") + msg;

            UiMsg uiMsg = _uiMsgPool.Pop();
            uiMsg.Ctrl = rtbMsg;
            uiMsg.Msg = msg;
            uiMsg.Param = fgColor;
            _uiMsgQueue.Enqueue(uiMsg);
        }
        private void UpdateGrpDates(string msg)
        {
            if (msg == "") return;

            UiMsg uiMsg = _uiMsgPool.Pop();
            uiMsg.Ctrl = grpDates;
            uiMsg.Msg = msg;
            _uiMsgQueue.Enqueue(uiMsg);
        }
        private void UpdateGrpStations(string msg)
        {
            if (msg == "") return;

            UiMsg uiMsg = _uiMsgPool.Pop();
            uiMsg.Ctrl = grpStations;
            uiMsg.Msg = msg;
            _uiMsgQueue.Enqueue(uiMsg);
        }
        private void UpdateGrpDevices(string msg)
        {
            if (msg == "") return;

            UiMsg uiMsg = _uiMsgPool.Pop();
            uiMsg.Ctrl = grpDevices;
            uiMsg.Msg = msg;
            _uiMsgQueue.Enqueue(uiMsg);
        }
        private void UpdateResultCnt(int cnt)
        {
            int pageCnt = (cnt + _pageSize - 1) / _pageSize;

            UiMsg uiMsg = _uiMsgPool.Pop();
            uiMsg.Ctrl = lbResultCnt;
            uiMsg.Msg = "当前结果： " + cnt + " 行， " + pageCnt + " 页";
            _uiMsgQueue.Enqueue(uiMsg);

            uiMsg = _uiMsgPool.Pop();
            uiMsg.Ctrl = lbPageCnt;
            uiMsg.Msg = "/ " + pageCnt;
            _uiMsgQueue.Enqueue(uiMsg);
        }
        private void UpdateCurrentPage(int pageNum)
        {
            UiMsg uiMsg = _uiMsgPool.Pop();
            uiMsg.Ctrl = txtCurrPage;
            uiMsg.Msg = pageNum.ToString();
            _uiMsgQueue.Enqueue(uiMsg);
        }
        private void UpdateDataTbl(object[] objs)
        {
            UiMsg uiMsg = _uiMsgPool.Pop();
            uiMsg.Ctrl = dgvLog;
            uiMsg.Param = objs.Clone();
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

                rtb.Clear();    // 不需要追加时，清空之前文本
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

            _uiMsgPool.Push(uiMsg);
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

                Thread.Sleep(10);
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

        #region 数据库操作：创建、插入、查询
        private void InitialDb()
        {
            string dbName = "AppData\\bubujiData.db";

            if (_sqldb == null)
            {
                _sqldb = new SQLiteHelper("provider=System.Data.SQLite; data source=" + dbName);
                _sqldb.CreateDb(dbName);

                string sql = "CREATE TABLE IF NOT EXISTS tblLog ( " +
                    "id            INTEGER PRIMARY KEY AUTOINCREMENT," +  
                    "deviceId      INTEGER (8)," + 
                    "deviceStatus  INTEGER (1)," +
                    "deviceVoltage NUMERIC (4)," + 
                    "stationId     INTEGER (8)," +
                    "signalVal     INTEGER (1)," + 
                    "stepSum       INTEGER (8)," +
                    "date          DATE," +
                    "datetime      DATETIME," +
                    "version       INTEGER (1)," + 
                    "frameSn       INTEGER (1)"  + 
                ")";
                _sqldb.ExecuteNonQuery(sql);

                sql = "CREATE INDEX IF NOT EXISTS idx ON tblLog ( " +
                    "deviceId," + 
                    "stationId," + 
                    "date" +
                ")";
                //_sqldb.ExecuteNonQuery(sql);
            }
        }

        private bool SaveDataToDb(object[] objs)
        {
            int cnt = 0;
            string sqlText;

            sqlText = "insert into tblLog values ("
                + "NULL,"
                + "'" + objs[0] + "',"
                + "'" + objs[1] + "',"
                + "'" + objs[2] + "',"
                + "'" + objs[3] + "',"
                + "'" + objs[4] + "',"
                + "'" + objs[5] + "',"
                + "'" + ((DateTime)objs[6]).Date + "',"
                + "'" + objs[6] + "',"
                + "'" + objs[7] + "',"
                + "'" + objs[8] + "')";
            cnt = _sqldb.ExecuteNonQuery(sqlText);

            return (cnt > 0);
        }

        private string GetInsertSql(object[] objs)
        {
            string sqlText;

            sqlText = "insert into tblLog values ("
                + "NULL,"
                + "'" + objs[0] + "',"
                + "'" + objs[1] + "',"
                + "'" + objs[2] + "',"
                + "'" + objs[3] + "',"
                + "'" + objs[4] + "',"
                + "'" + objs[5] + "',"
                + "'" + ((DateTime)objs[6]).Date + "',"
                + "'" + objs[6] + "',"
                + "'" + objs[7] + "',"
                + "'" + objs[8] + "')";
            return sqlText;
        }

        private int DeleteDataByWebIdAndEpc(string webId, string epc)
        {
            int cnt = 0;
            string sqlText;

            sqlText = "delete from DocInfo where WebId='" + webId + "' and EPC='" + epc + "'";
            cnt = _sqldb.ExecuteNonQuery(sqlText);

            return cnt;
        }

        private DataTable FindDataByWebIdOrEpc(string IdOrEpc)
        {
            string sqlText;

            sqlText = "select * from DocInfo where WebId=" + "'" + IdOrEpc + "'" + " or EPC=" + "'" + IdOrEpc + "'";
            DataTable tb = _sqldb.ExecuteReaderToDataTable(sqlText);

            return tb;
        }

        private bool IsWebIdExist(string webId)
        {
            bool rslt = false;
            string sqlText;

            sqlText = "select WebId from DocInfo where WebId=" + "'" + webId + "'";
            SQLiteDataReader reader = _sqldb.ExecuteReader(sqlText);
            if (reader.HasRows) rslt = true;
            reader.Close();

            return rslt;
        }

        private bool IsEpcExist(string epc)
        {
            bool rslt = false;
            string sqlText;

            sqlText = "select EPC from DocInfo where EPC=" + "'" + epc + "'";
            SQLiteDataReader reader = _sqldb.ExecuteReader(sqlText);
            if (reader.HasRows) rslt = true;
            reader.Close();

            return rslt;
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

        #region 添加到表格显示
        private void AddToDataView(object[] objs)
        {
            DataRow row = tbLog.NewRow();

            row.BeginEdit();
            row[id] = tbLog.Rows.Count + 1;
            row[设备ID]   = objs[0];
            row[设备状态] = objs[1];
            row[设备电压] = objs[2];
            row[基站ID] = objs[3];
            row[信号量] = objs[4];
            row[步数总计] = objs[5];
            row[时间]   = objs[6];
            row[版本号] = objs[7];
            row[帧序号] = objs[8];
            row.EndEdit();
            tbLog.Rows.Add(row);
            //dgvLog.FirstDisplayedScrollingRowIndex = dgvLog.Rows.Count - 1;
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
                e.CellStyle.Format = "X2";
            }
            
        }
        #endregion

        #region 导入日志文件
        private void btImport_Click(object sender, EventArgs e)
        {
            string strFileName, strRead;

            openFileDlg.Filter = "*.log(文本文件)|*.log|*.*(所有文件)|*.*";
            openFileDlg.DefaultExt = "log";
            openFileDlg.FileName = "";
            if (DialogResult.OK != openFileDlg.ShowDialog())
            {
                return;
            }

            strFileName = openFileDlg.FileName;
            if (strFileName.Length == 0)
            {
                MessageBox.Show("导入失败！\n", "错误", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //Thread t = new Thread(new ThreadStart(delegate
            //{
                StreamReader sr = new StreamReader(strFileName, Encoding.UTF8);

                int index, len;
                DateTime timeuse = DateTime.Now;
                object[] dataFields = new object[9];

                _resultCnt = 0;
                _currPage = 1;

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

                while ((strRead = sr.ReadLine()) != null)
                {
                    try
                    {
                        index = strRead.IndexOf("\"di\"");

                        if (index < 0) continue;

                        index += 6;
                        // devId
                        dataFields[0] = Convert.ToInt64(strRead.Substring(index, 12));
                        index += 20;
                        // devStatus
                        dataFields[1] = Convert.ToByte(strRead.Substring(index, 1));
                        index += 9;
                        // devVbat
                        dataFields[2] = Convert.ToSingle(strRead.Substring(index, 3));
                        index += 11;
                        // stationId
                        dataFields[3] = Convert.ToInt64(strRead.Substring(index, 12));
                        index += 20;
                        // signal
                        len = strRead.IndexOf("\"", index) - index;
                        dataFields[4] = Convert.ToByte(strRead.Substring(index, len));
                        index += len + 8;
                        // steps
                        len = strRead.IndexOf("\"", index) - index;
                        dataFields[5] = Convert.ToInt64(strRead.Substring(index, len));
                        index += len + 8;
                        // time
                        dataFields[6] = DateTime.ParseExact(strRead.Substring(index, 23), "yyyy-MM-dd HH:mm:ss,fff", null);
                        index += 30;
                        // version
                        len = strRead.IndexOf("\"", index) - index;
                        dataFields[7] = Convert.ToByte(strRead.Substring(index, len));
                        index += len + 8;
                        // frameSn
                        len = strRead.IndexOf("\"", index) - index;
                        dataFields[8] = Convert.ToByte(strRead.Substring(index, len));

                        if(_resultCnt < _pageSize)
                        {
                            //AddToDataView(dataFields);
                            //UpdateDataTbl(dataFields);
                        }

                        // 提交插入命令
                        cmd.CommandText = GetInsertSql(dataFields);
                        cmd.ExecuteNonQuery();

                        _resultCnt++;
                    }
                    catch (Exception ex)
                    {
                        ShowMsg("第" + tbLog.Rows.Count.ToString() + "行日志格式错误，" + ex.Message, Color.Red);
                        break;
                    }
                }
                sr.Close();
                //dgvLog.FirstDisplayedScrollingRowIndex = dgvLog.Rows.Count - 1;

                // 提交事务处理
                trans.Commit();

                // 查询一页显示
                cmd.CommandText = "select * from tblLog limit " + _pageSize;
                SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
                da.Fill(tbLog);

                // 关闭数据库
                con.Close();

                UpdateResultCnt(_resultCnt);
                UpdateCurrentPage(_currPage);

                TimeSpan tsp = DateTime.Now - timeuse;
                ShowMsg("导入完成， 用时 " + tsp.TotalSeconds.ToString("F3") + " s\r\n", Color.Blue, false);

            //}));
            //t.Start();
            

        }
        #endregion

        #region 查询数据库
        private void btQuery_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region 删除数据库
        private void btClearAll_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region 查看上一页/下一页 、清除当前记录
        private void btPagePrev_Click(object sender, EventArgs e)
        {

        }

        private void btPageNext_Click(object sender, EventArgs e)
        {

        }

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

    }
}
