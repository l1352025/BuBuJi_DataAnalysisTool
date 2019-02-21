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
        private int _pageCnt;
        private int _resultCnt;
        private int _recordCnt;
        private string _currSelCondition;

        public FormMain()
        {
            InitializeComponent();
            this.Text = Application.ProductName + "_v" + Application.ProductVersion + "   " + Application.CompanyName;

            _uiMsgQueue = new ConcurrentQueue<UiMsg>();
            _thrUpdateUI = new Thread(UiUpdateTask);
            _thrUpdateUI.IsBackground = true;
            _thrUpdateUI.Start();
            _uiMsgPool = new Stack<UiMsg>(_msgPoolSize);
            
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            UiMsg initMsg;
            for (int i = 0; i < _msgPoolSize; i++)
            {
                initMsg = new UiMsg();
                _uiMsgPool.Push(initMsg);
            }

            DataInit();
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
        private void UpdateGrpDates(int cnt)
        {
            UiMsg uiMsg = _uiMsgPool.Pop();
            uiMsg.Ctrl = grpDates;
            uiMsg.Msg = "日期列表 【" + cnt + "】";
            _uiMsgQueue.Enqueue(uiMsg);
        }
        private void UpdateGrpStations(int cnt)
        {
            UiMsg uiMsg = _uiMsgPool.Pop();
            uiMsg.Ctrl = grpStations;
            uiMsg.Msg = "基站列表 【" + cnt + "】";
            _uiMsgQueue.Enqueue(uiMsg);
        }
        private void UpdateGrpDevices(int cnt)
        {
            UiMsg uiMsg = _uiMsgPool.Pop();
            uiMsg.Ctrl = grpDevices;
            uiMsg.Msg = "设备列表 【" + cnt + "】";
            _uiMsgQueue.Enqueue(uiMsg);
        }
        private void UpdateRecordCnt(int cnt)
        {
            string strcnt = (cnt < 10000 ? cnt.ToString() : ((float)cnt / 10000).ToString("N1") + "万");

            UiMsg uiMsg = _uiMsgPool.Pop();
            uiMsg.Ctrl = lbRecordCnt;
            uiMsg.Msg = "记录总数\r\n " + strcnt + " 条";
            _uiMsgQueue.Enqueue(uiMsg);
        }
        private void UpdateResultCnt(int cnt)
        {
            _pageCnt = (cnt + _pageSize - 1) / _pageSize;

            UiMsg uiMsg = _uiMsgPool.Pop();
            uiMsg.Ctrl = lbResultCnt;
            uiMsg.Msg = "当前结果： " + cnt + " 条  " + _pageCnt + " 页";
            _uiMsgQueue.Enqueue(uiMsg);

            uiMsg = _uiMsgPool.Pop();
            uiMsg.Ctrl = lbPageCnt;
            uiMsg.Msg = "/ " + _pageCnt;
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

        #region 数据初始化
        private void DataInit()
        {
            string sqlText = "";

            // 数据库创建
            InitialDb();

            // 查询总数
            sqlText = "select count(id) from tblLog";
            _recordCnt = Convert.ToInt32(_sqldb.ExecuteScalar(sqlText));
            _resultCnt = _recordCnt;

            UpdateRecordCnt(_recordCnt);
            UpdateResultCnt(_resultCnt);

            // 日期、基站、设备列表更新
            MainInfoListUpdate();

            // 查询第1页显示
            _currSelCondition = "";
            _currPage = 0;
            QuerySpecifyPage(_currPage + 1);
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
                    "date          DATETIME," +
                    "datetime      DATETIME," +
                    "version       INTEGER (1)," + 
                    "frameSn       INTEGER (1)"  + 
                ")";
                _sqldb.ExecuteNonQuery(sql);

                sql = "CREATE INDEX IF NOT EXISTS idx ON tblLog ( " +
                    "deviceId," + 
                    "stationId," + 
                    "date," +
                    "deviceVoltage" +
                ")";
                _sqldb.ExecuteNonQuery(sql);
            }
        }

        private bool SaveDataToDb(object[] objs)
        {
            int cnt = 0;
            string sqlText;

            sqlText = "insert into tblLog values ("
                + "NULL,"   // objs[0] id列自动生成
                + "'" + objs[1] + "',"
                + "'" + objs[2] + "',"
                + "'" + objs[3] + "',"
                + "'" + objs[4] + "',"
                + "'" + objs[5] + "',"
                + "'" + objs[6] + "',"
                + "'" + objs[7] + "',"
                + "'" + objs[8] + "',"
                + "'" + objs[9] + "',"
                + "'" + objs[10] + "')";
            cnt = _sqldb.ExecuteNonQuery(sqlText);

            return (cnt > 0);
        }

        private string GetInsertSqlText(object[] objs)
        {
            string sqlText;

            sqlText = "insert into tblLog values ("
                + "NULL,"   // objs[0] id列自动生成
                + "'" + objs[1] + "',"
                + "'" + objs[2] + "',"
                + "'" + objs[3] + "',"
                + "'" + objs[4] + "',"
                + "'" + objs[5] + "',"
                + "'" + objs[6] + "',"
                + "'" + objs[7] + "',"
                + "'" + objs[8] + "',"
                + "'" + objs[9] + "',"
                + "'" + objs[10] + "')";
            return sqlText;
        }

        private DataTable FindDataByWebIdOrEpc(string IdOrEpc)
        {
            string sqlText;

            sqlText = "select * from DocInfo where WebId=" + "'" + IdOrEpc + "'" + " or EPC=" + "'" + IdOrEpc + "'";
            DataTable tb = _sqldb.ExecuteReaderToDataTable(sqlText);

            return tb;
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
            row[id] = ((long)objs[0] == 0 ? tbLog.Rows.Count + 1 : objs[0]);
            row[设备ID]   = objs[1];
            row[设备状态] = objs[2];
            row[设备电压] = objs[3];
            row[基站ID] = objs[4];
            row[信号量] = objs[5];
            row[步数总计] = objs[6];
            row[日期] = objs[7]; 
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
                DateTime timeStart = DateTime.Now;
                object[] dataFields = new object[11];

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

                dataFields[0] = 0;      // id 列置0 自动生成
                ShowMsg("导入中。。。\r\n", Color.Blue, false);

                while ((strRead = sr.ReadLine()) != null)
                {
                    try
                    {
                        index = strRead.IndexOf("\"di\"");

                        if (index < 0) continue;

                        index += 6;
                        // devId
                        dataFields[1] = Convert.ToInt64(strRead.Substring(index, 12));
                        index += 20;
                        // devStatus
                        dataFields[2] = Convert.ToByte(strRead.Substring(index, 1));
                        index += 9;
                        // devVbat
                        dataFields[3] = Convert.ToSingle(strRead.Substring(index, 3));
                        index += 11;
                        // stationId
                        dataFields[4] = Convert.ToInt64(strRead.Substring(index, 12));
                        index += 20;
                        // signal
                        len = strRead.IndexOf("\"", index) - index;
                        dataFields[5] = Convert.ToByte(strRead.Substring(index, len));
                        index += len + 8;
                        // steps
                        len = strRead.IndexOf("\"", index) - index;
                        dataFields[6] = Convert.ToInt64(strRead.Substring(index, len));
                        index += len + 8;
                        // time
                        dataFields[8] = DateTime.ParseExact(strRead.Substring(index, 23), "yyyy-MM-dd HH:mm:ss,fff", null);
                        // date
                        dataFields[7] = ((DateTime)dataFields[8]).Date;
                        index += 30;
                        // version
                        len = strRead.IndexOf("\"", index) - index;
                        dataFields[9] = Convert.ToByte(strRead.Substring(index, len));
                        index += len + 8;
                        // frameSn
                        len = strRead.IndexOf("\"", index) - index;
                        dataFields[10] = Convert.ToByte(strRead.Substring(index, len));

                        if(_resultCnt < _pageSize)
                        {
                            //AddToDataView(dataFields);
                            //UpdateDataTbl(dataFields);
                        }

                        // 提交插入命令
                        cmd.CommandText = GetInsertSqlText(dataFields);
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

                // 关闭数据库
                con.Close();

                _recordCnt += _resultCnt;
                UpdateRecordCnt(_recordCnt);
                UpdateResultCnt(_resultCnt);

                // 日期、基站、设备列表更新
                MainInfoListUpdate();

                // 查询第1页显示
                _currSelCondition = "";
                _currPage = 0;
                QuerySpecifyPage(_currPage + 1);

                ShowMsg("导入完成！ 用时 " + 
                    (DateTime.Now - timeStart).TotalSeconds.ToString("F3") + " s\r\n", Color.Blue, false);
            //}));
            //t.IsBackground = true;
            //t.Start();


        }
        #endregion

        #region 查询数据库
        private void dgvDate_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtDate.Text = ((DateTime)(tbDates.Rows[e.RowIndex][1])).ToString("yyyy-MM-dd");
        }

        private void dgvStation_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtStationId.Text = tbStations.Rows[e.RowIndex][1].ToString();
        }

        private void dgvDevice_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtDeviceId.Text = tbDevices.Rows[e.RowIndex][1].ToString();
        }
        private string GetQueryCondition()
        {
            string date = "", devid = "", staid = "", steps = "", stat = "", volt = "", fsn = "";

            try
            {
                if(chkDate.Checked && txtDate.Text != "") 
                    date = "date = '" + DateTime.Parse(txtDate.Text) + "' and ";
                if(chkDeviceId.Checked && txtDeviceId.Text != "")
                    devid = "deviceId = '" + Convert.ToInt64(txtDeviceId.Text) + "' and ";
                if(chkStationId.Checked && txtStationId.Text != "")
                    staid = "stationId = '" + Convert.ToInt64(txtStationId.Text) + "' and ";
                if (chkFsn.Checked && txtFsn.Text != "")
                    fsn = "frameSn = '" + Convert.ToByte(txtFsn.Text, 16) + "' and ";
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
            }
            catch(Exception)
            {
                return "error";
            }

            string conditon = " where "
                + (date != "" ? date : "")
                + (devid != "" ? devid : "")
                + (staid != "" ? staid : "")
                + (fsn != "" ? fsn : "")
                + (volt != "" ? volt : "")
                + (steps != "" ? steps : "")
                + (stat != "" ? stat : "");
            conditon = (conditon.EndsWith("and ") ? conditon.Substring(0, conditon.Length - 4) : "");

            conditon += (chkRemoveRepeat.Checked ? " group by deviceId, frameSn" : "");

            return conditon;
        }
        private void btQuery_Click(object sender, EventArgs e)
        {
            string sqlText = "";

            // 查询条件设置
            if((sqlText = GetQueryCondition()) == "error")
            {
                ShowMsg("查询条件输入值无效，请修正!\r\n", Color.Red);
                return;
            }
            _currSelCondition = sqlText;

            // 查询总数
            sqlText = "select count(t.id) from ( select * from tblLog" + _currSelCondition + ") as t";
            _resultCnt = Convert.ToInt32(_sqldb.ExecuteScalar(sqlText));

            UpdateResultCnt(_resultCnt);

            // 查询第1页显示
            _currPage = 0;
            QuerySpecifyPage(_currPage + 1);
        }
        #endregion

        #region 统计概要信息
        // 日期、基站、设备列表更新
        private void MainInfoListUpdate()
        {
            string sqlText = "";
            SQLiteDataReader reader;

            // 查询总数
            sqlText = "select count(id) from tblLog";
            _recordCnt = Convert.ToInt32(_sqldb.ExecuteScalar(sqlText));

            UpdateRecordCnt(_recordCnt);

            // 查询日期列表
            sqlText = "Select Distinct date From tblLog";
            reader = _sqldb.ExecuteReader(sqlText);
            tbDates.Clear();
            while (reader.Read())
            {
                DataRow row = tbDates.NewRow();
                row.BeginEdit();
                row["序号"] = tbDates.Rows.Count + 1;
                row["日期"] = reader.GetString(0);
                row.EndEdit();
                tbDates.Rows.Add(row);
            }
            reader.Close();

            // 查询基站列表
            sqlText = "Select stationId,count(*)" +
                " From ( select stationId,deviceId from tblLog group by stationId, deviceId ) as t" +
                " group by stationId";
            reader = _sqldb.ExecuteReader(sqlText);
            tbStations.Clear();
            while (reader.Read())
            {
                DataRow row = tbStations.NewRow();
                row.BeginEdit();
                row["序号"] = tbStations.Rows.Count + 1;
                row["基站ID"] = reader.GetInt64(0);
                row["侦听设备数"] = reader.GetInt32(1);
                row.EndEdit();
                tbStations.Rows.Add(row);
            }
            reader.Close();

            // 查询设备列表
            sqlText = "Select deviceId, count(*)" +
                " From ( select deviceId, frameSn from tblLog group by deviceId, frameSn) as t" +
                " group by deviceId";
            reader = _sqldb.ExecuteReader(sqlText);
            tbDevices.Clear();
            while (reader.Read())
            {
                DataRow row = tbDevices.NewRow();
                row.BeginEdit();
                row["序号"] = tbDevices.Rows.Count + 1;
                row["设备ID"] = reader.GetInt64(0);
                row["上报次数"] = reader.GetInt32(1);
                row.EndEdit();
                tbDevices.Rows.Add(row);
            }
            reader.Close();

            UpdateGrpDates(tbDates.Rows.Count);
            UpdateGrpStations(tbStations.Rows.Count);
            UpdateGrpDevices(tbDevices.Rows.Count);
        }

        private void btQueryCountInfo_Click(object sender, EventArgs e)
        {
            DateTime timeStart = DateTime.Now;
            ShowMsg("概要信息统计中...\r\n", Color.Blue, false);

            MainInfoListUpdate();

            ShowMsg("概要信息统计完成！ 用时 "
                + (DateTime.Now - timeStart).TotalSeconds.ToString("F3") + " s\r\n", Color.Blue, false);
        }
        #endregion

        #region 查看上一页/下一页 、清除当前记录

        // 查询 上一页
        private void btPagePrev_Click(object sender, EventArgs e)
        {
            if (_currPage == 1) return;

            QuerySpecifyPage(_currPage - 1);
        }
        // 查询 下一页
        private void btPageNext_Click(object sender, EventArgs e)
        {
            if (_currPage == _pageCnt) return;

            QuerySpecifyPage(_currPage + 1);
        }

        // 查询第 N 页显示
        private void QuerySpecifyPage(int pageNum)
        {
            string sqlText = "";
            int cnt = (pageNum - 1) * _pageSize;

            sqlText = "select * from tblLog" + _currSelCondition + " limit " + _pageSize + " offset " + (pageNum - 1) * _pageSize;
            SQLiteDataReader reader = _sqldb.ExecuteReader(sqlText);
            tbLog.Clear();
            while (reader.Read())
            {
                cnt++;
                DataRow row = tbLog.NewRow();
                row.BeginEdit();
                row[id] = cnt;
                row[设备ID] = reader.GetInt64(1);
                row[设备状态] = reader.GetByte(2);
                row[设备电压] = reader.GetFloat(3);
                row[基站ID] = reader.GetInt64(4);
                row[信号量] = reader.GetByte(5);
                row[步数总计] = reader.GetInt64(6);
                row[日期] = reader.GetString(7);
                row[时间] = reader.GetString(8);
                row[版本号] = reader.GetByte(9);
                row[帧序号] = reader.GetByte(10);
                row.EndEdit();
                tbLog.Rows.Add(row);
            }
            reader.Close();
            _currPage = pageNum;

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

        #region 删除数据库
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

            string sql = "delete from tblLog";
            _sqldb.ExecuteNonQuery(sql);
            sql = "update sqlite_sequence set seq = 0 where name = 'tblLog'";
            _sqldb.ExecuteNonQuery(sql);

            _recordCnt = 0;
            _resultCnt = 0;
            _currPage = 0;
            UpdateRecordCnt(_recordCnt);
            UpdateResultCnt(_resultCnt);
            UpdateCurrentPage(_currPage);
        }
        #endregion

    }
}
