namespace BuBuJi_DataAnalysisTool
{
    partial class FormMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);

            this.Clear();
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvLog = new System.Windows.Forms.DataGridView();
            this.dsLog = new System.Data.DataSet();
            this.tbLog = new System.Data.DataTable();
            this.id = new System.Data.DataColumn();
            this.设备ID = new System.Data.DataColumn();
            this.设备状态 = new System.Data.DataColumn();
            this.设备电压 = new System.Data.DataColumn();
            this.基站ID = new System.Data.DataColumn();
            this.信号量 = new System.Data.DataColumn();
            this.步数总计 = new System.Data.DataColumn();
            this.时间 = new System.Data.DataColumn();
            this.版本号 = new System.Data.DataColumn();
            this.帧序号 = new System.Data.DataColumn();
            this.tbDevices = new System.Data.DataTable();
            this.tbStations = new System.Data.DataTable();
            this.tbDates = new System.Data.DataTable();
            this.btImport = new System.Windows.Forms.Button();
            this.openFileDlg = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDlg = new System.Windows.Forms.SaveFileDialog();
            this.btQuery = new System.Windows.Forms.Button();
            this.btClearAll = new System.Windows.Forms.Button();
            this.grpDevices = new System.Windows.Forms.GroupBox();
            this.dgvDevice = new System.Windows.Forms.DataGridView();
            this.grpStations = new System.Windows.Forms.GroupBox();
            this.dgvStation = new System.Windows.Forms.DataGridView();
            this.grpDates = new System.Windows.Forms.GroupBox();
            this.dgvDate = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbResultCnt = new System.Windows.Forms.Label();
            this.btPagePrev = new System.Windows.Forms.Button();
            this.btPageNext = new System.Windows.Forms.Button();
            this.txtCurrPage = new System.Windows.Forms.TextBox();
            this.lbPageCnt = new System.Windows.Forms.Label();
            this.rtbMsg = new System.Windows.Forms.RichTextBox();
            this.tblDevices_id = new System.Data.DataColumn();
            this.tblDevices_deviceId = new System.Data.DataColumn();
            this.tblStations_id = new System.Data.DataColumn();
            this.tblStations_stationId = new System.Data.DataColumn();
            this.tblDates_id = new System.Data.DataColumn();
            this.tblDates_date = new System.Data.DataColumn();
            this.序号DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.日期DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.序号DataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.基站IDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.序号DataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.设备IDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.序号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.设备IDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.设备状态DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.设备电压DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.基站IDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.信号量DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.步数总计DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.时间DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.版本号DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbLog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbDevices)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbStations)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbDates)).BeginInit();
            this.grpDevices.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDevice)).BeginInit();
            this.grpStations.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStation)).BeginInit();
            this.grpDates.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDate)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvLog
            // 
            this.dgvLog.AllowUserToAddRows = false;
            this.dgvLog.AllowUserToDeleteRows = false;
            this.dgvLog.AllowUserToOrderColumns = true;
            this.dgvLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvLog.AutoGenerateColumns = false;
            this.dgvLog.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvLog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvLog.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.序号,
            this.设备IDDataGridViewTextBoxColumn,
            this.设备状态DataGridViewTextBoxColumn,
            this.设备电压DataGridViewTextBoxColumn,
            this.基站IDDataGridViewTextBoxColumn,
            this.信号量DataGridViewTextBoxColumn,
            this.步数总计DataGridViewTextBoxColumn,
            this.时间DataGridViewTextBoxColumn,
            this.版本号DataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn1});
            this.dgvLog.DataMember = "tblLog";
            this.dgvLog.DataSource = this.dsLog;
            this.dgvLog.Location = new System.Drawing.Point(276, 85);
            this.dgvLog.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvLog.Name = "dgvLog";
            this.dgvLog.RowHeadersWidth = 60;
            this.dgvLog.RowTemplate.Height = 23;
            this.dgvLog.Size = new System.Drawing.Size(909, 499);
            this.dgvLog.TabIndex = 0;
            // 
            // dsLog
            // 
            this.dsLog.DataSetName = "NewDataSet";
            this.dsLog.Tables.AddRange(new System.Data.DataTable[] {
            this.tbLog,
            this.tbDevices,
            this.tbStations,
            this.tbDates});
            // 
            // tbLog
            // 
            this.tbLog.Columns.AddRange(new System.Data.DataColumn[] {
            this.id,
            this.设备ID,
            this.设备状态,
            this.设备电压,
            this.基站ID,
            this.信号量,
            this.步数总计,
            this.时间,
            this.版本号,
            this.帧序号});
            this.tbLog.TableName = "tblLog";
            // 
            // id
            // 
            this.id.AutoIncrement = true;
            this.id.AutoIncrementSeed = ((long)(1));
            this.id.ColumnName = "id";
            this.id.DataType = typeof(int);
            // 
            // 设备ID
            // 
            this.设备ID.ColumnName = "设备ID";
            this.设备ID.DataType = typeof(int);
            // 
            // 设备状态
            // 
            this.设备状态.ColumnName = "设备状态";
            this.设备状态.DataType = typeof(byte);
            // 
            // 设备电压
            // 
            this.设备电压.ColumnName = "设备电压";
            this.设备电压.DataType = typeof(float);
            // 
            // 基站ID
            // 
            this.基站ID.ColumnName = "基站ID";
            this.基站ID.DataType = typeof(int);
            // 
            // 信号量
            // 
            this.信号量.ColumnName = "信号量";
            this.信号量.DataType = typeof(byte);
            // 
            // 步数总计
            // 
            this.步数总计.ColumnName = "步数总计";
            this.步数总计.DataType = typeof(int);
            // 
            // 时间
            // 
            this.时间.ColumnName = "时间";
            this.时间.DataType = typeof(System.DateTime);
            // 
            // 版本号
            // 
            this.版本号.ColumnName = "版本号";
            this.版本号.DataType = typeof(byte);
            // 
            // 帧序号
            // 
            this.帧序号.ColumnName = "帧序号";
            this.帧序号.DataType = typeof(byte);
            // 
            // tbDevices
            // 
            this.tbDevices.Columns.AddRange(new System.Data.DataColumn[] {
            this.tblDevices_id,
            this.tblDevices_deviceId});
            this.tbDevices.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Constraint1", new string[] {
                        "序号"}, false),
            new System.Data.UniqueConstraint("Constraint2", new string[] {
                        "设备ID"}, false)});
            this.tbDevices.TableName = "tblDevices";
            // 
            // tbStations
            // 
            this.tbStations.Columns.AddRange(new System.Data.DataColumn[] {
            this.tblStations_id,
            this.tblStations_stationId});
            this.tbStations.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Constraint1", new string[] {
                        "序号"}, false),
            new System.Data.UniqueConstraint("Constraint2", new string[] {
                        "基站ID"}, false)});
            this.tbStations.TableName = "tblStations";
            // 
            // tbDates
            // 
            this.tbDates.Columns.AddRange(new System.Data.DataColumn[] {
            this.tblDates_id,
            this.tblDates_date});
            this.tbDates.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Constraint1", new string[] {
                        "序号"}, false),
            new System.Data.UniqueConstraint("Constraint2", new string[] {
                        "日期"}, false)});
            this.tbDates.TableName = "tblDates";
            // 
            // btImport
            // 
            this.btImport.Location = new System.Drawing.Point(16, 21);
            this.btImport.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btImport.Name = "btImport";
            this.btImport.Size = new System.Drawing.Size(133, 29);
            this.btImport.TabIndex = 1;
            this.btImport.Text = "导入日志文件";
            this.btImport.UseVisualStyleBackColor = true;
            this.btImport.Click += new System.EventHandler(this.btImport_Click);
            // 
            // openFileDlg
            // 
            this.openFileDlg.FileName = "openFileDialog1";
            // 
            // btQuery
            // 
            this.btQuery.Location = new System.Drawing.Point(968, 21);
            this.btQuery.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btQuery.Name = "btQuery";
            this.btQuery.Size = new System.Drawing.Size(77, 29);
            this.btQuery.TabIndex = 1;
            this.btQuery.Text = "查询";
            this.btQuery.UseVisualStyleBackColor = true;
            this.btQuery.Click += new System.EventHandler(this.btQuery_Click);
            // 
            // btClearAll
            // 
            this.btClearAll.Location = new System.Drawing.Point(1084, 56);
            this.btClearAll.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btClearAll.Name = "btClearAll";
            this.btClearAll.Size = new System.Drawing.Size(101, 29);
            this.btClearAll.TabIndex = 1;
            this.btClearAll.Text = "删除数据库";
            this.btClearAll.UseVisualStyleBackColor = true;
            this.btClearAll.Click += new System.EventHandler(this.btClearAll_Click);
            // 
            // grpDevices
            // 
            this.grpDevices.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.grpDevices.Controls.Add(this.dgvDevice);
            this.grpDevices.Location = new System.Drawing.Point(8, 491);
            this.grpDevices.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpDevices.Name = "grpDevices";
            this.grpDevices.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpDevices.Size = new System.Drawing.Size(260, 262);
            this.grpDevices.TabIndex = 2;
            this.grpDevices.TabStop = false;
            this.grpDevices.Text = "设备列表 【**】";
            // 
            // dgvDevice
            // 
            this.dgvDevice.AllowUserToAddRows = false;
            this.dgvDevice.AllowUserToDeleteRows = false;
            this.dgvDevice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvDevice.AutoGenerateColumns = false;
            this.dgvDevice.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvDevice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvDevice.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.序号DataGridViewTextBoxColumn2,
            this.设备IDDataGridViewTextBoxColumn1});
            this.dgvDevice.DataMember = "tblDevices";
            this.dgvDevice.DataSource = this.dsLog;
            this.dgvDevice.Location = new System.Drawing.Point(0, 25);
            this.dgvDevice.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvDevice.Name = "dgvDevice";
            this.dgvDevice.RowHeadersVisible = false;
            this.dgvDevice.RowTemplate.Height = 23;
            this.dgvDevice.Size = new System.Drawing.Size(260, 238);
            this.dgvDevice.TabIndex = 0;
            // 
            // grpStations
            // 
            this.grpStations.Controls.Add(this.dgvStation);
            this.grpStations.Location = new System.Drawing.Point(8, 259);
            this.grpStations.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpStations.Name = "grpStations";
            this.grpStations.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpStations.Size = new System.Drawing.Size(260, 229);
            this.grpStations.TabIndex = 2;
            this.grpStations.TabStop = false;
            this.grpStations.Text = "基站列表 【**】";
            // 
            // dgvStation
            // 
            this.dgvStation.AllowUserToAddRows = false;
            this.dgvStation.AllowUserToDeleteRows = false;
            this.dgvStation.AutoGenerateColumns = false;
            this.dgvStation.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvStation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvStation.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.序号DataGridViewTextBoxColumn1,
            this.基站IDDataGridViewTextBoxColumn1});
            this.dgvStation.DataMember = "tblStations";
            this.dgvStation.DataSource = this.dsLog;
            this.dgvStation.Location = new System.Drawing.Point(0, 25);
            this.dgvStation.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvStation.Name = "dgvStation";
            this.dgvStation.RowHeadersVisible = false;
            this.dgvStation.RowTemplate.Height = 23;
            this.dgvStation.Size = new System.Drawing.Size(260, 196);
            this.dgvStation.TabIndex = 0;
            // 
            // grpDates
            // 
            this.grpDates.Controls.Add(this.dgvDate);
            this.grpDates.Location = new System.Drawing.Point(8, 85);
            this.grpDates.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpDates.Name = "grpDates";
            this.grpDates.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpDates.Size = new System.Drawing.Size(260, 166);
            this.grpDates.TabIndex = 2;
            this.grpDates.TabStop = false;
            this.grpDates.Text = "统计天数 【**】";
            // 
            // dgvDate
            // 
            this.dgvDate.AllowUserToAddRows = false;
            this.dgvDate.AllowUserToDeleteRows = false;
            this.dgvDate.AutoGenerateColumns = false;
            this.dgvDate.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvDate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvDate.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.序号DataGridViewTextBoxColumn,
            this.日期DataGridViewTextBoxColumn});
            this.dgvDate.DataMember = "tblDates";
            this.dgvDate.DataSource = this.dsLog;
            this.dgvDate.Location = new System.Drawing.Point(0, 25);
            this.dgvDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvDate.Name = "dgvDate";
            this.dgvDate.RowHeadersVisible = false;
            this.dgvDate.RowTemplate.Height = 23;
            this.dgvDate.Size = new System.Drawing.Size(260, 134);
            this.dgvDate.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.groupBox3.Controls.Add(this.textBox3);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.textBox2);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.textBox1);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.btImport);
            this.groupBox3.Controls.Add(this.btQuery);
            this.groupBox3.Controls.Add(this.btClearAll);
            this.groupBox3.Location = new System.Drawing.Point(0, -8);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Size = new System.Drawing.Size(1185, 85);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(802, 21);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(132, 25);
            this.textBox3.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(695, 28);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "基站ID";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(532, 21);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(132, 25);
            this.textBox2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(469, 28);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "设备ID";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(315, 21);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(132, 25);
            this.textBox1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(268, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "日期";
            // 
            // lbResultCnt
            // 
            this.lbResultCnt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbResultCnt.AutoSize = true;
            this.lbResultCnt.Location = new System.Drawing.Point(273, 599);
            this.lbResultCnt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbResultCnt.Name = "lbResultCnt";
            this.lbResultCnt.Size = new System.Drawing.Size(244, 15);
            this.lbResultCnt.TabIndex = 3;
            this.lbResultCnt.Text = "当前结果：总数 ** 条， 共 ** 页";
            // 
            // btPagePrev
            // 
            this.btPagePrev.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btPagePrev.Font = new System.Drawing.Font("宋体", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btPagePrev.Location = new System.Drawing.Point(637, 595);
            this.btPagePrev.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btPagePrev.Name = "btPagePrev";
            this.btPagePrev.Size = new System.Drawing.Size(71, 22);
            this.btPagePrev.TabIndex = 4;
            this.btPagePrev.Text = "上一页";
            this.btPagePrev.UseVisualStyleBackColor = true;
            this.btPagePrev.Click += new System.EventHandler(this.btPagePrev_Click);
            // 
            // btPageNext
            // 
            this.btPageNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btPageNext.Font = new System.Drawing.Font("宋体", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btPageNext.Location = new System.Drawing.Point(873, 595);
            this.btPageNext.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btPageNext.Name = "btPageNext";
            this.btPageNext.Size = new System.Drawing.Size(71, 22);
            this.btPageNext.TabIndex = 4;
            this.btPageNext.Text = "下一页";
            this.btPageNext.UseVisualStyleBackColor = true;
            this.btPageNext.Click += new System.EventHandler(this.btPageNext_Click);
            // 
            // txtCurrPage
            // 
            this.txtCurrPage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtCurrPage.Location = new System.Drawing.Point(731, 591);
            this.txtCurrPage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCurrPage.Name = "txtCurrPage";
            this.txtCurrPage.Size = new System.Drawing.Size(59, 25);
            this.txtCurrPage.TabIndex = 5;
            // 
            // lbPageCnt
            // 
            this.lbPageCnt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbPageCnt.AutoSize = true;
            this.lbPageCnt.Location = new System.Drawing.Point(799, 599);
            this.lbPageCnt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbPageCnt.Name = "lbPageCnt";
            this.lbPageCnt.Size = new System.Drawing.Size(47, 15);
            this.lbPageCnt.TabIndex = 6;
            this.lbPageCnt.Text = "/ ***";
            // 
            // rtbMsg
            // 
            this.rtbMsg.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbMsg.Location = new System.Drawing.Point(276, 626);
            this.rtbMsg.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rtbMsg.Name = "rtbMsg";
            this.rtbMsg.Size = new System.Drawing.Size(908, 126);
            this.rtbMsg.TabIndex = 7;
            this.rtbMsg.Text = "";
            // 
            // tblDevices_id
            // 
            this.tblDevices_id.AutoIncrement = true;
            this.tblDevices_id.AutoIncrementSeed = ((long)(1));
            this.tblDevices_id.ColumnName = "序号";
            this.tblDevices_id.DataType = typeof(int);
            // 
            // tblDevices_deviceId
            // 
            this.tblDevices_deviceId.ColumnName = "设备ID";
            this.tblDevices_deviceId.DataType = typeof(int);
            // 
            // tblStations_id
            // 
            this.tblStations_id.AutoIncrement = true;
            this.tblStations_id.AutoIncrementSeed = ((long)(1));
            this.tblStations_id.ColumnName = "序号";
            this.tblStations_id.DataType = typeof(int);
            // 
            // tblStations_stationId
            // 
            this.tblStations_stationId.ColumnName = "基站ID";
            this.tblStations_stationId.DataType = typeof(int);
            // 
            // tblDates_id
            // 
            this.tblDates_id.AutoIncrement = true;
            this.tblDates_id.AutoIncrementSeed = ((long)(1));
            this.tblDates_id.ColumnName = "序号";
            this.tblDates_id.DataType = typeof(int);
            // 
            // tblDates_date
            // 
            this.tblDates_date.ColumnName = "日期";
            this.tblDates_date.DataType = typeof(System.DateTime);
            // 
            // 序号DataGridViewTextBoxColumn
            // 
            this.序号DataGridViewTextBoxColumn.DataPropertyName = "序号";
            this.序号DataGridViewTextBoxColumn.HeaderText = "序号";
            this.序号DataGridViewTextBoxColumn.Name = "序号DataGridViewTextBoxColumn";
            this.序号DataGridViewTextBoxColumn.Width = 60;
            // 
            // 日期DataGridViewTextBoxColumn
            // 
            this.日期DataGridViewTextBoxColumn.DataPropertyName = "日期";
            this.日期DataGridViewTextBoxColumn.HeaderText = "日期";
            this.日期DataGridViewTextBoxColumn.Name = "日期DataGridViewTextBoxColumn";
            // 
            // 序号DataGridViewTextBoxColumn1
            // 
            this.序号DataGridViewTextBoxColumn1.DataPropertyName = "序号";
            this.序号DataGridViewTextBoxColumn1.HeaderText = "序号";
            this.序号DataGridViewTextBoxColumn1.Name = "序号DataGridViewTextBoxColumn1";
            this.序号DataGridViewTextBoxColumn1.Width = 60;
            // 
            // 基站IDDataGridViewTextBoxColumn1
            // 
            this.基站IDDataGridViewTextBoxColumn1.DataPropertyName = "基站ID";
            this.基站IDDataGridViewTextBoxColumn1.HeaderText = "基站ID";
            this.基站IDDataGridViewTextBoxColumn1.Name = "基站IDDataGridViewTextBoxColumn1";
            // 
            // 序号DataGridViewTextBoxColumn2
            // 
            this.序号DataGridViewTextBoxColumn2.DataPropertyName = "序号";
            this.序号DataGridViewTextBoxColumn2.HeaderText = "序号";
            this.序号DataGridViewTextBoxColumn2.Name = "序号DataGridViewTextBoxColumn2";
            this.序号DataGridViewTextBoxColumn2.Width = 60;
            // 
            // 设备IDDataGridViewTextBoxColumn1
            // 
            this.设备IDDataGridViewTextBoxColumn1.DataPropertyName = "设备ID";
            this.设备IDDataGridViewTextBoxColumn1.HeaderText = "设备ID";
            this.设备IDDataGridViewTextBoxColumn1.Name = "设备IDDataGridViewTextBoxColumn1";
            // 
            // 序号
            // 
            this.序号.HeaderText = "序号";
            this.序号.Name = "序号";
            this.序号.Width = 60;
            // 
            // 设备IDDataGridViewTextBoxColumn
            // 
            this.设备IDDataGridViewTextBoxColumn.DataPropertyName = "设备ID";
            this.设备IDDataGridViewTextBoxColumn.HeaderText = "设备ID";
            this.设备IDDataGridViewTextBoxColumn.Name = "设备IDDataGridViewTextBoxColumn";
            // 
            // 设备状态DataGridViewTextBoxColumn
            // 
            this.设备状态DataGridViewTextBoxColumn.DataPropertyName = "设备状态";
            this.设备状态DataGridViewTextBoxColumn.HeaderText = "设备状态";
            this.设备状态DataGridViewTextBoxColumn.Name = "设备状态DataGridViewTextBoxColumn";
            this.设备状态DataGridViewTextBoxColumn.Width = 80;
            // 
            // 设备电压DataGridViewTextBoxColumn
            // 
            this.设备电压DataGridViewTextBoxColumn.DataPropertyName = "设备电压";
            this.设备电压DataGridViewTextBoxColumn.HeaderText = "设备电压";
            this.设备电压DataGridViewTextBoxColumn.Name = "设备电压DataGridViewTextBoxColumn";
            this.设备电压DataGridViewTextBoxColumn.Width = 80;
            // 
            // 基站IDDataGridViewTextBoxColumn
            // 
            this.基站IDDataGridViewTextBoxColumn.DataPropertyName = "基站ID";
            this.基站IDDataGridViewTextBoxColumn.HeaderText = "基站ID";
            this.基站IDDataGridViewTextBoxColumn.Name = "基站IDDataGridViewTextBoxColumn";
            // 
            // 信号量DataGridViewTextBoxColumn
            // 
            this.信号量DataGridViewTextBoxColumn.DataPropertyName = "信号量";
            this.信号量DataGridViewTextBoxColumn.HeaderText = "信号量";
            this.信号量DataGridViewTextBoxColumn.Name = "信号量DataGridViewTextBoxColumn";
            this.信号量DataGridViewTextBoxColumn.Width = 70;
            // 
            // 步数总计DataGridViewTextBoxColumn
            // 
            this.步数总计DataGridViewTextBoxColumn.DataPropertyName = "步数总计";
            this.步数总计DataGridViewTextBoxColumn.HeaderText = "步数总计";
            this.步数总计DataGridViewTextBoxColumn.Name = "步数总计DataGridViewTextBoxColumn";
            this.步数总计DataGridViewTextBoxColumn.Width = 80;
            // 
            // 时间DataGridViewTextBoxColumn
            // 
            this.时间DataGridViewTextBoxColumn.DataPropertyName = "时间";
            this.时间DataGridViewTextBoxColumn.HeaderText = "时间";
            this.时间DataGridViewTextBoxColumn.Name = "时间DataGridViewTextBoxColumn";
            this.时间DataGridViewTextBoxColumn.Width = 140;
            // 
            // 版本号DataGridViewTextBoxColumn
            // 
            this.版本号DataGridViewTextBoxColumn.DataPropertyName = "版本号";
            this.版本号DataGridViewTextBoxColumn.HeaderText = "版本号";
            this.版本号DataGridViewTextBoxColumn.Name = "版本号DataGridViewTextBoxColumn";
            this.版本号DataGridViewTextBoxColumn.Width = 70;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "帧序号";
            this.dataGridViewTextBoxColumn1.HeaderText = "帧序号";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 70;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1185, 761);
            this.Controls.Add(this.rtbMsg);
            this.Controls.Add(this.lbPageCnt);
            this.Controls.Add(this.txtCurrPage);
            this.Controls.Add(this.btPageNext);
            this.Controls.Add(this.btPagePrev);
            this.Controls.Add(this.lbResultCnt);
            this.Controls.Add(this.grpDates);
            this.Controls.Add(this.grpStations);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.grpDevices);
            this.Controls.Add(this.dgvLog);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormMain";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvLog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbLog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbDevices)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbStations)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbDates)).EndInit();
            this.grpDevices.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDevice)).EndInit();
            this.grpStations.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStation)).EndInit();
            this.grpDates.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDate)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLog;
        private System.Data.DataSet dsLog;
        private System.Data.DataTable tbLog;
        private System.Data.DataColumn id;
        private System.Data.DataColumn 设备ID;
        private System.Data.DataColumn 设备状态;
        private System.Data.DataColumn 设备电压;
        private System.Data.DataColumn 基站ID;
        private System.Data.DataColumn 信号量;
        private System.Data.DataColumn 步数总计;
        private System.Data.DataColumn 时间;
        private System.Data.DataColumn 版本号;
        private System.Windows.Forms.Button btImport;
        private System.Windows.Forms.OpenFileDialog openFileDlg;
        private System.Windows.Forms.SaveFileDialog saveFileDlg;
        private System.Data.DataColumn 帧序号;
        private System.Windows.Forms.Button btQuery;
        private System.Windows.Forms.Button btClearAll;
        private System.Windows.Forms.GroupBox grpDevices;
        private System.Windows.Forms.GroupBox grpStations;
        private System.Windows.Forms.GroupBox grpDates;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbResultCnt;
        private System.Windows.Forms.Button btPagePrev;
        private System.Windows.Forms.Button btPageNext;
        private System.Windows.Forms.TextBox txtCurrPage;
        private System.Windows.Forms.Label lbPageCnt;
        private System.Windows.Forms.RichTextBox rtbMsg;
        private System.Data.DataTable tbDevices;
        private System.Data.DataTable tbStations;
        private System.Data.DataTable tbDates;
        private System.Windows.Forms.DataGridView dgvDevice;
        private System.Windows.Forms.DataGridView dgvStation;
        private System.Windows.Forms.DataGridView dgvDate;
        private System.Data.DataColumn tblDevices_id;
        private System.Data.DataColumn tblDevices_deviceId;
        private System.Data.DataColumn tblStations_id;
        private System.Data.DataColumn tblStations_stationId;
        private System.Data.DataColumn tblDates_id;
        private System.Data.DataColumn tblDates_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn 序号DataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn 基站IDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn 序号DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 日期DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 序号DataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn 设备IDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn 序号;
        private System.Windows.Forms.DataGridViewTextBoxColumn 设备IDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 设备状态DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 设备电压DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 基站IDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 信号量DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 步数总计DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 时间DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 版本号DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
    }
}

