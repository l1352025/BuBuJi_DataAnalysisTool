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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvLog = new System.Windows.Forms.DataGridView();
            this.序号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.设备IDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.设备状态DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.设备电压DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.基站IDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.信号量DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.步数总计DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.时间DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.版本号DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.帧序号DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dsLog = new System.Data.DataSet();
            this.tbLog = new System.Data.DataTable();
            this.id = new System.Data.DataColumn();
            this.设备ID = new System.Data.DataColumn();
            this.设备状态 = new System.Data.DataColumn();
            this.设备电压 = new System.Data.DataColumn();
            this.基站ID = new System.Data.DataColumn();
            this.信号量 = new System.Data.DataColumn();
            this.步数总计 = new System.Data.DataColumn();
            this.日期 = new System.Data.DataColumn();
            this.时间 = new System.Data.DataColumn();
            this.版本号 = new System.Data.DataColumn();
            this.帧序号 = new System.Data.DataColumn();
            this.tbDevices = new System.Data.DataTable();
            this.tblDevices_id = new System.Data.DataColumn();
            this.tblDevices_deviceId = new System.Data.DataColumn();
            this.上报次数 = new System.Data.DataColumn();
            this.tbStations = new System.Data.DataTable();
            this.tblStations_id = new System.Data.DataColumn();
            this.tblStations_stationId = new System.Data.DataColumn();
            this.侦听设备数 = new System.Data.DataColumn();
            this.tbDates = new System.Data.DataTable();
            this.tblDates_id = new System.Data.DataColumn();
            this.tblDates_date = new System.Data.DataColumn();
            this.记录条数 = new System.Data.DataColumn();
            this.btImport = new System.Windows.Forms.Button();
            this.openFileDlg = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDlg = new System.Windows.Forms.SaveFileDialog();
            this.btQuery = new System.Windows.Forms.Button();
            this.btClearAll = new System.Windows.Forms.Button();
            this.grpDevices = new System.Windows.Forms.GroupBox();
            this.dgvDevice = new System.Windows.Forms.DataGridView();
            this.序号DataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.设备IDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpStations = new System.Windows.Forms.GroupBox();
            this.dgvStation = new System.Windows.Forms.DataGridView();
            this.序号DataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.基站IDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpDates = new System.Windows.Forms.GroupBox();
            this.dgvDate = new System.Windows.Forms.DataGridView();
            this.序号DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.日期DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.updownPagesize = new System.Windows.Forms.NumericUpDown();
            this.txtSteps = new System.Windows.Forms.TextBox();
            this.txtVer = new System.Windows.Forms.TextBox();
            this.txtVolt = new System.Windows.Forms.TextBox();
            this.cbxVer = new System.Windows.Forms.ComboBox();
            this.cbxSteps = new System.Windows.Forms.ComboBox();
            this.cbxVolt = new System.Windows.Forms.ComboBox();
            this.cbxStat = new System.Windows.Forms.ComboBox();
            this.chkRemoveRepeat = new System.Windows.Forms.CheckBox();
            this.chkSteps = new System.Windows.Forms.CheckBox();
            this.chkStationId = new System.Windows.Forms.CheckBox();
            this.chkVer = new System.Windows.Forms.CheckBox();
            this.chkStatus = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chkVoltage = new System.Windows.Forms.CheckBox();
            this.btQueryCountInfo = new System.Windows.Forms.Button();
            this.chkDeviceId = new System.Windows.Forms.CheckBox();
            this.chkDate = new System.Windows.Forms.CheckBox();
            this.txtStationId = new System.Windows.Forms.TextBox();
            this.lbRecordCnt = new System.Windows.Forms.Label();
            this.txtDeviceId = new System.Windows.Forms.TextBox();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.lbResultCnt = new System.Windows.Forms.Label();
            this.btPagePrev = new System.Windows.Forms.Button();
            this.btPageNext = new System.Windows.Forms.Button();
            this.txtCurrPage = new System.Windows.Forms.TextBox();
            this.lbPageCnt = new System.Windows.Forms.Label();
            this.rtbMsg = new System.Windows.Forms.RichTextBox();
            this.btClearCurrent = new System.Windows.Forms.Button();
            this.cMenuDevices = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.devices导出列表ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cMenuStations = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.stations导出列表ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cMenuDates = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.dates导出列表ToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.devices统计上报次数设备个数ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            ((System.ComponentModel.ISupportInitialize)(this.updownPagesize)).BeginInit();
            this.cMenuDevices.SuspendLayout();
            this.cMenuStations.SuspendLayout();
            this.cMenuDates.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvLog
            // 
            this.dgvLog.AllowUserToAddRows = false;
            this.dgvLog.AllowUserToDeleteRows = false;
            this.dgvLog.AllowUserToOrderColumns = true;
            this.dgvLog.AllowUserToResizeRows = false;
            this.dgvLog.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvLog.AutoGenerateColumns = false;
            this.dgvLog.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLog.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
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
            this.帧序号DataGridViewTextBoxColumn});
            this.dgvLog.DataMember = "tblLog";
            this.dgvLog.DataSource = this.dsLog;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvLog.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvLog.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvLog.Location = new System.Drawing.Point(239, 71);
            this.dgvLog.Name = "dgvLog";
            this.dgvLog.ReadOnly = true;
            this.dgvLog.RowHeadersVisible = false;
            this.dgvLog.RowHeadersWidth = 60;
            this.dgvLog.RowTemplate.Height = 23;
            this.dgvLog.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLog.Size = new System.Drawing.Size(730, 396);
            this.dgvLog.TabIndex = 0;
            this.dgvLog.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvLog_CellFormatting);
            // 
            // 序号
            // 
            this.序号.DataPropertyName = "id";
            this.序号.HeaderText = "序号";
            this.序号.Name = "序号";
            this.序号.ReadOnly = true;
            this.序号.Width = 60;
            // 
            // 设备IDDataGridViewTextBoxColumn
            // 
            this.设备IDDataGridViewTextBoxColumn.DataPropertyName = "设备ID";
            this.设备IDDataGridViewTextBoxColumn.HeaderText = "设备ID";
            this.设备IDDataGridViewTextBoxColumn.Name = "设备IDDataGridViewTextBoxColumn";
            this.设备IDDataGridViewTextBoxColumn.ReadOnly = true;
            this.设备IDDataGridViewTextBoxColumn.Width = 90;
            // 
            // 设备状态DataGridViewTextBoxColumn
            // 
            this.设备状态DataGridViewTextBoxColumn.DataPropertyName = "设备状态";
            this.设备状态DataGridViewTextBoxColumn.HeaderText = "设备状态";
            this.设备状态DataGridViewTextBoxColumn.Name = "设备状态DataGridViewTextBoxColumn";
            this.设备状态DataGridViewTextBoxColumn.ReadOnly = true;
            this.设备状态DataGridViewTextBoxColumn.Width = 65;
            // 
            // 设备电压DataGridViewTextBoxColumn
            // 
            this.设备电压DataGridViewTextBoxColumn.DataPropertyName = "设备电压";
            this.设备电压DataGridViewTextBoxColumn.HeaderText = "设备电压";
            this.设备电压DataGridViewTextBoxColumn.Name = "设备电压DataGridViewTextBoxColumn";
            this.设备电压DataGridViewTextBoxColumn.ReadOnly = true;
            this.设备电压DataGridViewTextBoxColumn.Width = 65;
            // 
            // 基站IDDataGridViewTextBoxColumn
            // 
            this.基站IDDataGridViewTextBoxColumn.DataPropertyName = "基站ID";
            this.基站IDDataGridViewTextBoxColumn.HeaderText = "基站ID";
            this.基站IDDataGridViewTextBoxColumn.Name = "基站IDDataGridViewTextBoxColumn";
            this.基站IDDataGridViewTextBoxColumn.ReadOnly = true;
            this.基站IDDataGridViewTextBoxColumn.Width = 90;
            // 
            // 信号量DataGridViewTextBoxColumn
            // 
            this.信号量DataGridViewTextBoxColumn.DataPropertyName = "信号量";
            this.信号量DataGridViewTextBoxColumn.HeaderText = "信号量";
            this.信号量DataGridViewTextBoxColumn.Name = "信号量DataGridViewTextBoxColumn";
            this.信号量DataGridViewTextBoxColumn.ReadOnly = true;
            this.信号量DataGridViewTextBoxColumn.Width = 50;
            // 
            // 步数总计DataGridViewTextBoxColumn
            // 
            this.步数总计DataGridViewTextBoxColumn.DataPropertyName = "步数总计";
            this.步数总计DataGridViewTextBoxColumn.HeaderText = "步数总计";
            this.步数总计DataGridViewTextBoxColumn.Name = "步数总计DataGridViewTextBoxColumn";
            this.步数总计DataGridViewTextBoxColumn.ReadOnly = true;
            this.步数总计DataGridViewTextBoxColumn.Width = 70;
            // 
            // 时间DataGridViewTextBoxColumn
            // 
            this.时间DataGridViewTextBoxColumn.DataPropertyName = "时间";
            this.时间DataGridViewTextBoxColumn.HeaderText = "时间";
            this.时间DataGridViewTextBoxColumn.Name = "时间DataGridViewTextBoxColumn";
            this.时间DataGridViewTextBoxColumn.ReadOnly = true;
            this.时间DataGridViewTextBoxColumn.Width = 120;
            // 
            // 版本号DataGridViewTextBoxColumn
            // 
            this.版本号DataGridViewTextBoxColumn.DataPropertyName = "版本号";
            this.版本号DataGridViewTextBoxColumn.HeaderText = "版本号";
            this.版本号DataGridViewTextBoxColumn.Name = "版本号DataGridViewTextBoxColumn";
            this.版本号DataGridViewTextBoxColumn.ReadOnly = true;
            this.版本号DataGridViewTextBoxColumn.Width = 50;
            // 
            // 帧序号DataGridViewTextBoxColumn
            // 
            this.帧序号DataGridViewTextBoxColumn.DataPropertyName = "帧序号";
            this.帧序号DataGridViewTextBoxColumn.HeaderText = "帧序号";
            this.帧序号DataGridViewTextBoxColumn.Name = "帧序号DataGridViewTextBoxColumn";
            this.帧序号DataGridViewTextBoxColumn.ReadOnly = true;
            this.帧序号DataGridViewTextBoxColumn.Width = 50;
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
            this.日期,
            this.时间,
            this.版本号,
            this.帧序号});
            this.tbLog.TableName = "tblLog";
            // 
            // id
            // 
            this.id.AutoIncrementSeed = ((long)(1));
            this.id.ColumnName = "id";
            this.id.DataType = typeof(int);
            // 
            // 设备ID
            // 
            this.设备ID.ColumnName = "设备ID";
            this.设备ID.DataType = typeof(long);
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
            this.基站ID.DataType = typeof(long);
            // 
            // 信号量
            // 
            this.信号量.ColumnName = "信号量";
            this.信号量.DataType = typeof(byte);
            // 
            // 步数总计
            // 
            this.步数总计.ColumnName = "步数总计";
            this.步数总计.DataType = typeof(long);
            // 
            // 日期
            // 
            this.日期.ColumnName = "日期";
            this.日期.DataType = typeof(System.DateTime);
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
            this.tblDevices_deviceId,
            this.上报次数});
            this.tbDevices.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Constraint1", new string[] {
                        "序号"}, false),
            new System.Data.UniqueConstraint("Constraint2", new string[] {
                        "设备ID"}, false)});
            this.tbDevices.TableName = "tblDevices";
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
            this.tblDevices_deviceId.DataType = typeof(long);
            // 
            // 上报次数
            // 
            this.上报次数.ColumnName = "上报次数";
            this.上报次数.DataType = typeof(int);
            // 
            // tbStations
            // 
            this.tbStations.Columns.AddRange(new System.Data.DataColumn[] {
            this.tblStations_id,
            this.tblStations_stationId,
            this.侦听设备数});
            this.tbStations.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Constraint1", new string[] {
                        "序号"}, false),
            new System.Data.UniqueConstraint("Constraint2", new string[] {
                        "基站ID"}, false)});
            this.tbStations.TableName = "tblStations";
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
            this.tblStations_stationId.DataType = typeof(long);
            // 
            // 侦听设备数
            // 
            this.侦听设备数.ColumnName = "侦听设备数";
            this.侦听设备数.DataType = typeof(int);
            // 
            // tbDates
            // 
            this.tbDates.Columns.AddRange(new System.Data.DataColumn[] {
            this.tblDates_id,
            this.tblDates_date,
            this.记录条数});
            this.tbDates.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Constraint1", new string[] {
                        "序号"}, false),
            new System.Data.UniqueConstraint("Constraint2", new string[] {
                        "日期"}, false)});
            this.tbDates.TableName = "tblDates";
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
            // 记录条数
            // 
            this.记录条数.ColumnName = "记录条数";
            this.记录条数.DataType = typeof(long);
            // 
            // btImport
            // 
            this.btImport.Location = new System.Drawing.Point(12, 17);
            this.btImport.Name = "btImport";
            this.btImport.Size = new System.Drawing.Size(100, 23);
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
            this.btQuery.Location = new System.Drawing.Point(833, 15);
            this.btQuery.Name = "btQuery";
            this.btQuery.Size = new System.Drawing.Size(100, 21);
            this.btQuery.TabIndex = 1;
            this.btQuery.Text = "查询";
            this.btQuery.UseVisualStyleBackColor = true;
            this.btQuery.Click += new System.EventHandler(this.btQuery_Click);
            // 
            // btClearAll
            // 
            this.btClearAll.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btClearAll.Location = new System.Drawing.Point(135, 44);
            this.btClearAll.Name = "btClearAll";
            this.btClearAll.Size = new System.Drawing.Size(86, 19);
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
            this.grpDevices.Location = new System.Drawing.Point(6, 376);
            this.grpDevices.Name = "grpDevices";
            this.grpDevices.Size = new System.Drawing.Size(227, 230);
            this.grpDevices.TabIndex = 2;
            this.grpDevices.TabStop = false;
            this.grpDevices.Text = "设备列表 【**】";
            // 
            // dgvDevice
            // 
            this.dgvDevice.AllowUserToAddRows = false;
            this.dgvDevice.AllowUserToDeleteRows = false;
            this.dgvDevice.AllowUserToResizeRows = false;
            this.dgvDevice.AutoGenerateColumns = false;
            this.dgvDevice.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("宋体", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDevice.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDevice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvDevice.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.序号DataGridViewTextBoxColumn2,
            this.设备IDDataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.dgvDevice.ContextMenuStrip = this.cMenuDevices;
            this.dgvDevice.DataMember = "tblDevices";
            this.dgvDevice.DataSource = this.dsLog;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDevice.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvDevice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDevice.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvDevice.Location = new System.Drawing.Point(3, 17);
            this.dgvDevice.Name = "dgvDevice";
            this.dgvDevice.RowHeadersVisible = false;
            this.dgvDevice.RowTemplate.Height = 23;
            this.dgvDevice.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDevice.Size = new System.Drawing.Size(221, 210);
            this.dgvDevice.TabIndex = 0;
            this.dgvDevice.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDevice_CellClick);
            // 
            // 序号DataGridViewTextBoxColumn2
            // 
            this.序号DataGridViewTextBoxColumn2.DataPropertyName = "序号";
            this.序号DataGridViewTextBoxColumn2.HeaderText = "序号";
            this.序号DataGridViewTextBoxColumn2.Name = "序号DataGridViewTextBoxColumn2";
            this.序号DataGridViewTextBoxColumn2.Width = 40;
            // 
            // 设备IDDataGridViewTextBoxColumn1
            // 
            this.设备IDDataGridViewTextBoxColumn1.DataPropertyName = "设备ID";
            this.设备IDDataGridViewTextBoxColumn1.HeaderText = "设备ID";
            this.设备IDDataGridViewTextBoxColumn1.Name = "设备IDDataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "上报次数";
            this.dataGridViewTextBoxColumn2.HeaderText = "上报次数";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 60;
            // 
            // grpStations
            // 
            this.grpStations.Controls.Add(this.dgvStation);
            this.grpStations.Location = new System.Drawing.Point(6, 186);
            this.grpStations.Name = "grpStations";
            this.grpStations.Size = new System.Drawing.Size(227, 183);
            this.grpStations.TabIndex = 2;
            this.grpStations.TabStop = false;
            this.grpStations.Text = "基站列表 【**】";
            // 
            // dgvStation
            // 
            this.dgvStation.AllowUserToAddRows = false;
            this.dgvStation.AllowUserToDeleteRows = false;
            this.dgvStation.AllowUserToResizeRows = false;
            this.dgvStation.AutoGenerateColumns = false;
            this.dgvStation.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("宋体", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStation.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvStation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvStation.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.序号DataGridViewTextBoxColumn1,
            this.基站IDDataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn1});
            this.dgvStation.ContextMenuStrip = this.cMenuStations;
            this.dgvStation.DataMember = "tblStations";
            this.dgvStation.DataSource = this.dsLog;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvStation.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvStation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvStation.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvStation.Location = new System.Drawing.Point(3, 17);
            this.dgvStation.Name = "dgvStation";
            this.dgvStation.RowHeadersVisible = false;
            this.dgvStation.RowTemplate.Height = 23;
            this.dgvStation.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStation.Size = new System.Drawing.Size(221, 163);
            this.dgvStation.TabIndex = 0;
            this.dgvStation.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStation_CellClick);
            // 
            // 序号DataGridViewTextBoxColumn1
            // 
            this.序号DataGridViewTextBoxColumn1.DataPropertyName = "序号";
            this.序号DataGridViewTextBoxColumn1.HeaderText = "序号";
            this.序号DataGridViewTextBoxColumn1.Name = "序号DataGridViewTextBoxColumn1";
            this.序号DataGridViewTextBoxColumn1.Width = 40;
            // 
            // 基站IDDataGridViewTextBoxColumn1
            // 
            this.基站IDDataGridViewTextBoxColumn1.DataPropertyName = "基站ID";
            this.基站IDDataGridViewTextBoxColumn1.HeaderText = "基站ID";
            this.基站IDDataGridViewTextBoxColumn1.Name = "基站IDDataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "侦听设备数";
            this.dataGridViewTextBoxColumn1.HeaderText = "设备数";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 60;
            // 
            // grpDates
            // 
            this.grpDates.Controls.Add(this.dgvDate);
            this.grpDates.Location = new System.Drawing.Point(6, 71);
            this.grpDates.Name = "grpDates";
            this.grpDates.Size = new System.Drawing.Size(227, 109);
            this.grpDates.TabIndex = 2;
            this.grpDates.TabStop = false;
            this.grpDates.Text = "日期列表 【**】";
            // 
            // dgvDate
            // 
            this.dgvDate.AllowUserToAddRows = false;
            this.dgvDate.AllowUserToDeleteRows = false;
            this.dgvDate.AllowUserToResizeRows = false;
            this.dgvDate.AutoGenerateColumns = false;
            this.dgvDate.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvDate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvDate.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.序号DataGridViewTextBoxColumn,
            this.日期DataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn3});
            this.dgvDate.ContextMenuStrip = this.cMenuDates;
            this.dgvDate.DataMember = "tblDates";
            this.dgvDate.DataSource = this.dsLog;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDate.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgvDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDate.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvDate.Location = new System.Drawing.Point(3, 17);
            this.dgvDate.Name = "dgvDate";
            this.dgvDate.RowHeadersVisible = false;
            this.dgvDate.RowTemplate.Height = 23;
            this.dgvDate.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDate.Size = new System.Drawing.Size(221, 89);
            this.dgvDate.TabIndex = 0;
            this.dgvDate.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDate_CellClick);
            // 
            // 序号DataGridViewTextBoxColumn
            // 
            this.序号DataGridViewTextBoxColumn.DataPropertyName = "序号";
            this.序号DataGridViewTextBoxColumn.HeaderText = "序号";
            this.序号DataGridViewTextBoxColumn.Name = "序号DataGridViewTextBoxColumn";
            this.序号DataGridViewTextBoxColumn.Width = 40;
            // 
            // 日期DataGridViewTextBoxColumn
            // 
            this.日期DataGridViewTextBoxColumn.DataPropertyName = "日期";
            this.日期DataGridViewTextBoxColumn.HeaderText = "日期";
            this.日期DataGridViewTextBoxColumn.Name = "日期DataGridViewTextBoxColumn";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "记录条数";
            this.dataGridViewTextBoxColumn3.HeaderText = "记录条数";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 60;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.groupBox3.Controls.Add(this.updownPagesize);
            this.groupBox3.Controls.Add(this.txtSteps);
            this.groupBox3.Controls.Add(this.txtVer);
            this.groupBox3.Controls.Add(this.txtVolt);
            this.groupBox3.Controls.Add(this.cbxVer);
            this.groupBox3.Controls.Add(this.cbxSteps);
            this.groupBox3.Controls.Add(this.cbxVolt);
            this.groupBox3.Controls.Add(this.cbxStat);
            this.groupBox3.Controls.Add(this.chkRemoveRepeat);
            this.groupBox3.Controls.Add(this.chkSteps);
            this.groupBox3.Controls.Add(this.chkStationId);
            this.groupBox3.Controls.Add(this.chkVer);
            this.groupBox3.Controls.Add(this.chkStatus);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.chkVoltage);
            this.groupBox3.Controls.Add(this.btQueryCountInfo);
            this.groupBox3.Controls.Add(this.chkDeviceId);
            this.groupBox3.Controls.Add(this.chkDate);
            this.groupBox3.Controls.Add(this.txtStationId);
            this.groupBox3.Controls.Add(this.lbRecordCnt);
            this.groupBox3.Controls.Add(this.txtDeviceId);
            this.groupBox3.Controls.Add(this.txtDate);
            this.groupBox3.Controls.Add(this.btImport);
            this.groupBox3.Controls.Add(this.btQuery);
            this.groupBox3.Controls.Add(this.btClearAll);
            this.groupBox3.Location = new System.Drawing.Point(0, -6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(969, 71);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // updownPagesize
            // 
            this.updownPagesize.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.updownPagesize.Location = new System.Drawing.Point(883, 43);
            this.updownPagesize.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.updownPagesize.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.updownPagesize.Name = "updownPagesize";
            this.updownPagesize.Size = new System.Drawing.Size(50, 21);
            this.updownPagesize.TabIndex = 10;
            this.updownPagesize.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // txtSteps
            // 
            this.txtSteps.Location = new System.Drawing.Point(607, 43);
            this.txtSteps.Name = "txtSteps";
            this.txtSteps.Size = new System.Drawing.Size(57, 21);
            this.txtSteps.TabIndex = 9;
            // 
            // txtVer
            // 
            this.txtVer.Location = new System.Drawing.Point(783, 43);
            this.txtVer.Name = "txtVer";
            this.txtVer.Size = new System.Drawing.Size(37, 21);
            this.txtVer.TabIndex = 9;
            // 
            // txtVolt
            // 
            this.txtVolt.Location = new System.Drawing.Point(451, 42);
            this.txtVolt.Name = "txtVolt";
            this.txtVolt.Size = new System.Drawing.Size(37, 21);
            this.txtVolt.TabIndex = 9;
            // 
            // cbxVer
            // 
            this.cbxVer.FormattingEnabled = true;
            this.cbxVer.Items.AddRange(new object[] {
            "等于",
            "大于",
            "小于"});
            this.cbxVer.Location = new System.Drawing.Point(729, 44);
            this.cbxVer.Name = "cbxVer";
            this.cbxVer.Size = new System.Drawing.Size(49, 20);
            this.cbxVer.TabIndex = 8;
            // 
            // cbxSteps
            // 
            this.cbxSteps.FormattingEnabled = true;
            this.cbxSteps.Items.AddRange(new object[] {
            "等于",
            "大于",
            "小于"});
            this.cbxSteps.Location = new System.Drawing.Point(553, 44);
            this.cbxSteps.Name = "cbxSteps";
            this.cbxSteps.Size = new System.Drawing.Size(49, 20);
            this.cbxSteps.TabIndex = 8;
            // 
            // cbxVolt
            // 
            this.cbxVolt.FormattingEnabled = true;
            this.cbxVolt.Items.AddRange(new object[] {
            "等于",
            "大于",
            "小于"});
            this.cbxVolt.Location = new System.Drawing.Point(397, 43);
            this.cbxVolt.Name = "cbxVolt";
            this.cbxVolt.Size = new System.Drawing.Size(49, 20);
            this.cbxVolt.TabIndex = 8;
            // 
            // cbxStat
            // 
            this.cbxStat.FormattingEnabled = true;
            this.cbxStat.Items.AddRange(new object[] {
            "正常",
            "损坏",
            "其他"});
            this.cbxStat.Location = new System.Drawing.Point(284, 42);
            this.cbxStat.Name = "cbxStat";
            this.cbxStat.Size = new System.Drawing.Size(47, 20);
            this.cbxStat.TabIndex = 8;
            // 
            // chkRemoveRepeat
            // 
            this.chkRemoveRepeat.AutoSize = true;
            this.chkRemoveRepeat.Checked = true;
            this.chkRemoveRepeat.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkRemoveRepeat.ForeColor = System.Drawing.SystemColors.Window;
            this.chkRemoveRepeat.Location = new System.Drawing.Point(239, 20);
            this.chkRemoveRepeat.Name = "chkRemoveRepeat";
            this.chkRemoveRepeat.Size = new System.Drawing.Size(72, 16);
            this.chkRemoveRepeat.TabIndex = 7;
            this.chkRemoveRepeat.Text = "去掉重复";
            this.chkRemoveRepeat.UseVisualStyleBackColor = true;
            // 
            // chkSteps
            // 
            this.chkSteps.AutoSize = true;
            this.chkSteps.ForeColor = System.Drawing.SystemColors.Window;
            this.chkSteps.Location = new System.Drawing.Point(508, 46);
            this.chkSteps.Name = "chkSteps";
            this.chkSteps.Size = new System.Drawing.Size(48, 16);
            this.chkSteps.TabIndex = 7;
            this.chkSteps.Text = "步数";
            this.chkSteps.UseVisualStyleBackColor = true;
            // 
            // chkStationId
            // 
            this.chkStationId.AutoSize = true;
            this.chkStationId.ForeColor = System.Drawing.SystemColors.Window;
            this.chkStationId.Location = new System.Drawing.Point(636, 20);
            this.chkStationId.Name = "chkStationId";
            this.chkStationId.Size = new System.Drawing.Size(60, 16);
            this.chkStationId.TabIndex = 7;
            this.chkStationId.Text = "基站ID";
            this.chkStationId.UseVisualStyleBackColor = true;
            // 
            // chkVer
            // 
            this.chkVer.AutoSize = true;
            this.chkVer.ForeColor = System.Drawing.SystemColors.Window;
            this.chkVer.Location = new System.Drawing.Point(683, 47);
            this.chkVer.Name = "chkVer";
            this.chkVer.Size = new System.Drawing.Size(48, 16);
            this.chkVer.TabIndex = 7;
            this.chkVer.Text = "版本";
            this.chkVer.UseVisualStyleBackColor = true;
            // 
            // chkStatus
            // 
            this.chkStatus.AutoSize = true;
            this.chkStatus.ForeColor = System.Drawing.SystemColors.Window;
            this.chkStatus.Location = new System.Drawing.Point(239, 44);
            this.chkStatus.Name = "chkStatus";
            this.chkStatus.Size = new System.Drawing.Size(48, 16);
            this.chkStatus.TabIndex = 7;
            this.chkStatus.Text = "状态";
            this.chkStatus.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(831, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "每页显示";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // chkVoltage
            // 
            this.chkVoltage.AutoSize = true;
            this.chkVoltage.ForeColor = System.Drawing.SystemColors.Window;
            this.chkVoltage.Location = new System.Drawing.Point(351, 46);
            this.chkVoltage.Name = "chkVoltage";
            this.chkVoltage.Size = new System.Drawing.Size(48, 16);
            this.chkVoltage.TabIndex = 7;
            this.chkVoltage.Text = "电压";
            this.chkVoltage.UseVisualStyleBackColor = true;
            // 
            // btQueryCountInfo
            // 
            this.btQueryCountInfo.Location = new System.Drawing.Point(135, 18);
            this.btQueryCountInfo.Name = "btQueryCountInfo";
            this.btQueryCountInfo.Size = new System.Drawing.Size(86, 22);
            this.btQueryCountInfo.TabIndex = 1;
            this.btQueryCountInfo.Text = "统计";
            this.btQueryCountInfo.UseVisualStyleBackColor = true;
            this.btQueryCountInfo.Click += new System.EventHandler(this.btQueryCountInfo_Click);
            // 
            // chkDeviceId
            // 
            this.chkDeviceId.AutoSize = true;
            this.chkDeviceId.ForeColor = System.Drawing.SystemColors.Window;
            this.chkDeviceId.Location = new System.Drawing.Point(462, 20);
            this.chkDeviceId.Name = "chkDeviceId";
            this.chkDeviceId.Size = new System.Drawing.Size(60, 16);
            this.chkDeviceId.TabIndex = 7;
            this.chkDeviceId.Text = "设备ID";
            this.chkDeviceId.UseVisualStyleBackColor = true;
            // 
            // chkDate
            // 
            this.chkDate.AutoSize = true;
            this.chkDate.ForeColor = System.Drawing.SystemColors.Window;
            this.chkDate.Location = new System.Drawing.Point(321, 20);
            this.chkDate.Name = "chkDate";
            this.chkDate.Size = new System.Drawing.Size(48, 16);
            this.chkDate.TabIndex = 7;
            this.chkDate.Text = "日期";
            this.chkDate.UseVisualStyleBackColor = true;
            // 
            // txtStationId
            // 
            this.txtStationId.Location = new System.Drawing.Point(702, 17);
            this.txtStationId.Name = "txtStationId";
            this.txtStationId.Size = new System.Drawing.Size(92, 21);
            this.txtStationId.TabIndex = 3;
            // 
            // lbRecordCnt
            // 
            this.lbRecordCnt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbRecordCnt.AutoSize = true;
            this.lbRecordCnt.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbRecordCnt.ForeColor = System.Drawing.SystemColors.Window;
            this.lbRecordCnt.Location = new System.Drawing.Point(12, 47);
            this.lbRecordCnt.Name = "lbRecordCnt";
            this.lbRecordCnt.Size = new System.Drawing.Size(95, 12);
            this.lbRecordCnt.TabIndex = 6;
            this.lbRecordCnt.Text = "记录总数 *** 条";
            this.lbRecordCnt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtDeviceId
            // 
            this.txtDeviceId.Location = new System.Drawing.Point(528, 15);
            this.txtDeviceId.Name = "txtDeviceId";
            this.txtDeviceId.Size = new System.Drawing.Size(91, 21);
            this.txtDeviceId.TabIndex = 3;
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(375, 17);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(70, 21);
            this.txtDate.TabIndex = 3;
            // 
            // lbResultCnt
            // 
            this.lbResultCnt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbResultCnt.AutoSize = true;
            this.lbResultCnt.Location = new System.Drawing.Point(237, 479);
            this.lbResultCnt.Name = "lbResultCnt";
            this.lbResultCnt.Size = new System.Drawing.Size(143, 12);
            this.lbResultCnt.TabIndex = 3;
            this.lbResultCnt.Text = "当前结果： ** 条  ** 页";
            // 
            // btPagePrev
            // 
            this.btPagePrev.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btPagePrev.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btPagePrev.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btPagePrev.Location = new System.Drawing.Point(446, 474);
            this.btPagePrev.Name = "btPagePrev";
            this.btPagePrev.Size = new System.Drawing.Size(53, 24);
            this.btPagePrev.TabIndex = 4;
            this.btPagePrev.Text = "上一页";
            this.btPagePrev.UseVisualStyleBackColor = false;
            this.btPagePrev.Click += new System.EventHandler(this.btPagePrev_Click);
            // 
            // btPageNext
            // 
            this.btPageNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btPageNext.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btPageNext.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btPageNext.Location = new System.Drawing.Point(590, 474);
            this.btPageNext.Name = "btPageNext";
            this.btPageNext.Size = new System.Drawing.Size(53, 24);
            this.btPageNext.TabIndex = 4;
            this.btPageNext.Text = "下一页";
            this.btPageNext.UseVisualStyleBackColor = false;
            this.btPageNext.Click += new System.EventHandler(this.btPageNext_Click);
            // 
            // txtCurrPage
            // 
            this.txtCurrPage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtCurrPage.Location = new System.Drawing.Point(509, 475);
            this.txtCurrPage.Name = "txtCurrPage";
            this.txtCurrPage.Size = new System.Drawing.Size(38, 21);
            this.txtCurrPage.TabIndex = 5;
            // 
            // lbPageCnt
            // 
            this.lbPageCnt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbPageCnt.AutoSize = true;
            this.lbPageCnt.Location = new System.Drawing.Point(548, 482);
            this.lbPageCnt.Name = "lbPageCnt";
            this.lbPageCnt.Size = new System.Drawing.Size(35, 12);
            this.lbPageCnt.TabIndex = 6;
            this.lbPageCnt.Text = "/ ***";
            // 
            // rtbMsg
            // 
            this.rtbMsg.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbMsg.Location = new System.Drawing.Point(239, 501);
            this.rtbMsg.Name = "rtbMsg";
            this.rtbMsg.Size = new System.Drawing.Size(730, 102);
            this.rtbMsg.TabIndex = 7;
            this.rtbMsg.Text = "";
            // 
            // btClearCurrent
            // 
            this.btClearCurrent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btClearCurrent.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btClearCurrent.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btClearCurrent.Location = new System.Drawing.Point(670, 474);
            this.btClearCurrent.Name = "btClearCurrent";
            this.btClearCurrent.Size = new System.Drawing.Size(93, 24);
            this.btClearCurrent.TabIndex = 1;
            this.btClearCurrent.Text = "清除当前记录";
            this.btClearCurrent.UseVisualStyleBackColor = false;
            this.btClearCurrent.Click += new System.EventHandler(this.btClearCurrent_Click);
            // 
            // cMenuDevices
            // 
            this.cMenuDevices.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.devices导出列表ToolStripMenuItem,
            this.devices统计上报次数设备个数ToolStripMenuItem});
            this.cMenuDevices.Name = "cMenuDevices";
            this.cMenuDevices.Size = new System.Drawing.Size(234, 48);
            // 
            // devices导出列表ToolStripMenuItem
            // 
            this.devices导出列表ToolStripMenuItem.Name = "devices导出列表ToolStripMenuItem";
            this.devices导出列表ToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
            this.devices导出列表ToolStripMenuItem.Text = "导出列表";
            this.devices导出列表ToolStripMenuItem.Click += new System.EventHandler(this.devices导出列表ToolStripMenuItem_Click);
            // 
            // cMenuStations
            // 
            this.cMenuStations.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stations导出列表ToolStripMenuItem1});
            this.cMenuStations.Name = "cMenuStations";
            this.cMenuStations.Size = new System.Drawing.Size(125, 26);
            // 
            // stations导出列表ToolStripMenuItem1
            // 
            this.stations导出列表ToolStripMenuItem1.Name = "stations导出列表ToolStripMenuItem1";
            this.stations导出列表ToolStripMenuItem1.Size = new System.Drawing.Size(124, 22);
            this.stations导出列表ToolStripMenuItem1.Text = "导出列表";
            this.stations导出列表ToolStripMenuItem1.Click += new System.EventHandler(this.stations导出列表ToolStripMenuItem1_Click);
            // 
            // cMenuDates
            // 
            this.cMenuDates.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dates导出列表ToolStripMenuItem2});
            this.cMenuDates.Name = "cMenuDates";
            this.cMenuDates.Size = new System.Drawing.Size(125, 26);
            // 
            // dates导出列表ToolStripMenuItem2
            // 
            this.dates导出列表ToolStripMenuItem2.Name = "dates导出列表ToolStripMenuItem2";
            this.dates导出列表ToolStripMenuItem2.Size = new System.Drawing.Size(124, 22);
            this.dates导出列表ToolStripMenuItem2.Text = "导出列表";
            this.dates导出列表ToolStripMenuItem2.Click += new System.EventHandler(this.dates导出列表ToolStripMenuItem2_Click);
            // 
            // devices统计上报次数设备个数ToolStripMenuItem
            // 
            this.devices统计上报次数设备个数ToolStripMenuItem.Name = "devices统计上报次数设备个数ToolStripMenuItem";
            this.devices统计上报次数设备个数ToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
            this.devices统计上报次数设备个数ToolStripMenuItem.Text = "统计 [ 上报次数 - 设备个数  ]";
            this.devices统计上报次数设备个数ToolStripMenuItem.Click += new System.EventHandler(this.devices统计设备数上报次数ToolStripMenuItem_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 609);
            this.Controls.Add(this.rtbMsg);
            this.Controls.Add(this.lbPageCnt);
            this.Controls.Add(this.txtCurrPage);
            this.Controls.Add(this.btPageNext);
            this.Controls.Add(this.btPagePrev);
            this.Controls.Add(this.lbResultCnt);
            this.Controls.Add(this.grpDates);
            this.Controls.Add(this.grpStations);
            this.Controls.Add(this.btClearCurrent);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.grpDevices);
            this.Controls.Add(this.dgvLog);
            this.Name = "FormMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormMain_Load);
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
            ((System.ComponentModel.ISupportInitialize)(this.updownPagesize)).EndInit();
            this.cMenuDevices.ResumeLayout(false);
            this.cMenuStations.ResumeLayout(false);
            this.cMenuDates.ResumeLayout(false);
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
        private System.Data.DataColumn 日期;
        private System.Data.DataColumn 时间;
        private System.Data.DataColumn 版本号;
        private System.Data.DataColumn 帧序号;
        private System.Windows.Forms.Button btImport;
        private System.Windows.Forms.OpenFileDialog openFileDlg;
        private System.Windows.Forms.SaveFileDialog saveFileDlg;
        private System.Windows.Forms.Button btQuery;
        private System.Windows.Forms.Button btClearAll;
        private System.Windows.Forms.GroupBox grpDevices;
        private System.Windows.Forms.GroupBox grpStations;
        private System.Windows.Forms.GroupBox grpDates;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtStationId;
        private System.Windows.Forms.TextBox txtDeviceId;
        private System.Windows.Forms.TextBox txtDate;
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
        private System.Windows.Forms.Button btClearCurrent;
        private System.Windows.Forms.DataGridViewTextBoxColumn 序号;
        private System.Windows.Forms.DataGridViewTextBoxColumn 设备IDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 设备状态DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 设备电压DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 基站IDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 信号量DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 步数总计DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 时间DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 版本号DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 帧序号DataGridViewTextBoxColumn;
        private System.Windows.Forms.Label lbRecordCnt;
        private System.Windows.Forms.ComboBox cbxStat;
        private System.Windows.Forms.CheckBox chkSteps;
        private System.Windows.Forms.CheckBox chkStationId;
        private System.Windows.Forms.CheckBox chkStatus;
        private System.Windows.Forms.CheckBox chkVoltage;
        private System.Windows.Forms.CheckBox chkDeviceId;
        private System.Windows.Forms.CheckBox chkDate;
        private System.Windows.Forms.TextBox txtSteps;
        private System.Windows.Forms.TextBox txtVolt;
        private System.Windows.Forms.ComboBox cbxSteps;
        private System.Windows.Forms.ComboBox cbxVolt;
        private System.Windows.Forms.Button btQueryCountInfo;
        private System.Windows.Forms.CheckBox chkRemoveRepeat;
        private System.Data.DataColumn 上报次数;
        private System.Data.DataColumn 侦听设备数;
        private System.Windows.Forms.DataGridViewTextBoxColumn 序号DataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn 基站IDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn 序号DataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn 设备IDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Data.DataColumn 记录条数;
        private System.Windows.Forms.DataGridViewTextBoxColumn 序号DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 日期DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.TextBox txtVer;
        private System.Windows.Forms.ComboBox cbxVer;
        private System.Windows.Forms.CheckBox chkVer;
        private System.Windows.Forms.NumericUpDown updownPagesize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip cMenuDevices;
        private System.Windows.Forms.ToolStripMenuItem devices导出列表ToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip cMenuStations;
        private System.Windows.Forms.ToolStripMenuItem stations导出列表ToolStripMenuItem1;
        private System.Windows.Forms.ContextMenuStrip cMenuDates;
        private System.Windows.Forms.ToolStripMenuItem dates导出列表ToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem devices统计上报次数设备个数ToolStripMenuItem;
    }
}

