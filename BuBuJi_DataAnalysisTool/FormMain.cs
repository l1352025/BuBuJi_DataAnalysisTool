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

namespace BuBuJi_DataAnalysisTool
{
    public partial class FormMain : Form
    {
        private SQLiteHelper sqldb;

        public FormMain()
        {
            InitializeComponent();
            this.Text = Application.ProductName + "_v" + Application.ProductVersion + "   " + Application.CompanyName;


        }

        #region 数据存档、检索、删除
        private void InitialDb()
        {
            string dbName = "AppData\\bubujiData.db";

            if (sqldb == null)
            {
                sqldb = new SQLiteHelper("provider=System.Data.SQLite; data source=" + dbName);
                sqldb.CreateDb(dbName);
                sqldb.CreateTable("DocInfo", new string[] { "id", "WebId", "EPC", "SaveTime", "IsExported" }, new string[] { "INTEGER primary key AUTOINCREMENT", "TEXT", "TEXT", "TEXT", "INTEGER" });
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
            cnt = sqldb.ExecuteNonQuery(sqlText);

            return (cnt > 0);
        }

        private int DeleteDataByWebIdAndEpc(string webId, string epc)
        {
            int cnt = 0;
            string sqlText;

            sqlText = "delete from DocInfo where WebId='" + webId + "' and EPC='" + epc + "'";
            cnt = sqldb.ExecuteNonQuery(sqlText);

            return cnt;
        }

        private DataTable FindDataByWebIdOrEpc(string IdOrEpc)
        {
            string sqlText;

            sqlText = "select * from DocInfo where WebId=" + "'" + IdOrEpc + "'" + " or EPC=" + "'" + IdOrEpc + "'";
            DataTable tb = sqldb.ExecuteReaderToDataTable(sqlText);

            return tb;
        }

        private bool IsWebIdExist(string webId)
        {
            bool rslt = false;
            string sqlText;

            sqlText = "select WebId from DocInfo where WebId=" + "'" + webId + "'";
            SQLiteDataReader reader = sqldb.ExecuteReader(sqlText);
            if (reader.HasRows) rslt = true;
            reader.Close();

            return rslt;
        }

        private bool IsEpcExist(string epc)
        {
            bool rslt = false;
            string sqlText;

            sqlText = "select EPC from DocInfo where EPC=" + "'" + epc + "'";
            SQLiteDataReader reader = sqldb.ExecuteReader(sqlText);
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
    }
}
