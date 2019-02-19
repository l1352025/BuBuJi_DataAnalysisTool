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
        private int _msgPoolSize = 1000;

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
            int pageCnt = (cnt + 999) / 1000;

            UiMsg uiMsg = _uiMsgPool.Pop();
            uiMsg.Ctrl = lbResultCnt;
            uiMsg.Msg = "当前结果：总数 " + cnt + " 条，共 " + pageCnt + " 页";
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
                   // "                          UNIQUE" + 
                   // "                          NOT NULL," + 
                    "deviceId      INTEGER (4)," + 
                    "deviceStatus  INTEGER (1)," + 
                    "deviceVoltage CHAR (4)," + 
                    "stationId     INTEGER (4)," +
                    "signalVal     INTEGER (1)," + 
                    "stepSum       INTEGER (4)," +
                    "date          DATE," +
                    "time          TIME," +
                    "version       INTEGER (4)," + 
                    "frameSn       INTEGER (1)" + 
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

        private bool SaveDataToDb(string webId, string epc)
        {
            int cnt = 0;
            string sqlText;

            sqlText = "insert into DocInfo values ("
                        + "NULL,"
                        + "'" + webId + "',"
                        + "'" + epc + "',"
                        + "'" + DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss") + "',"
                        + "'" + 0 + "')";
            cnt = _sqldb.ExecuteNonQuery(sqlText);

            return (cnt > 0);
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

        #region 存档视图
        private void AddToDataView(string id, string epc)
        {
            DataRow row = tbLog.NewRow();

            row["ID"] = id;
            row["EPC"] = epc;
            row["导出标志"] = 0;
            row["存档时间"] = DateTime.Now.ToString("MM/dd HH:mm:ss");

            tbLog.Rows.Add(row);
            dgvLog.Rows[dgvLog.Rows.Count - 1].DefaultCellStyle.ForeColor = Color.Olive;
            dgvLog.FirstDisplayedScrollingRowIndex = dgvLog.Rows.Count - 1;
        }
        #endregion

        #region 导入日志文件
        private void btImport_Click(object sender, EventArgs e)
        {
            string strFileName, strRead;

            openFileDlg.Filter = "*.TXT(文本文件)|*.TXT|*.*(所有文件)|*.*";
            openFileDlg.DefaultExt = "TXT";
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

            StreamReader sr = new StreamReader(strFileName, Encoding.UTF8);

            String strNo, strDate, strTime;
            string[] strSplit;
            byte[] byteArray;
            int startIndex;

            while ((strRead = sr.ReadLine()) != null)
            {
                try
                {
                    strSplit = strRead.Trim().Split(' ');
                    if (strSplit.Length < 4)
                    {
                        continue;
                    }

                    DateTime timeCheck;

                    if (strRead.StartsWith("@"))
                    {
                        strNo = strSplit[1];
                        strDate = strSplit[0].Substring(1);
                        strTime = strSplit[2];
                        startIndex = 3;
                    }
                    else if (strSplit[1].Length == 12)
                    {
                        strNo = strSplit[0];
                        strDate = "";
                        strTime = strSplit[1];
                        startIndex = 2;
                    }
                    else
                    {
                        strNo = strSplit[0];
                        strDate = strSplit[1];
                        strTime = strSplit[2];
                        startIndex = 3;
                    }

                    timeCheck = DateTime.ParseExact(strTime, "HH:mm:ss.fff", null);

                    byteArray = new byte[strSplit.Length - startIndex];
                    for (int iLoop = startIndex; iLoop < strSplit.Length; iLoop++)
                    {
                        byteArray[iLoop - startIndex] = Convert.ToByte(strSplit[iLoop], 16);
                    }

                    
                }
                catch (Exception ex)
                {
                    ShowMsg("第" + tbLog.Rows.Count.ToString() + "行日志格式错误，" + ex.Message, Color.Red);
                    break;
                }
            }
            sr.Close();

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

        #region 查看 上一页/下一页
        private void btPagePrev_Click(object sender, EventArgs e)
        {

        }

        private void btPageNext_Click(object sender, EventArgs e)
        {

        }
        #endregion
    }
}
