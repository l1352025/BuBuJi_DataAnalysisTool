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
            this.tbStations = new System.Data.DataTable();
            this.tblStations_id = new System.Data.DataColumn();
            this.tblStations_stationId = new System.Data.DataColumn();
            this.tbDates = new System.Data.DataTable();
            this.tblDates_id = new System.Data.DataColumn();
            this.tblDates_date = new System.Data.DataColumn();
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
            this.txtSteps = new System.Windows.Forms.TextBox();
            this.txtVolt = new System.Windows.Forms.TextBox();
            this.cbxSteps = new System.Windows.Forms.ComboBox();
            this.cbxVolt = new System.Windows.Forms.ComboBox();
            this.cbxStat = new System.Windows.Forms.ComboBox();
            this.chkSteps = new System.Windows.Forms.CheckBox();
            this.chkStationId = new System.Windows.Forms.CheckBox();
            this.chkStatus = new System.Windows.Forms.CheckBox();
            this.chkVoltage = new System.Windows.Forms.CheckBox();
            this.chkDeviceId = new System.Windows.Forms.CheckBox();
            this.chkDate = new System.Windows.Forms.CheckBox();
            this.txtStationId = new System.Windows.Forms.TextBox();
            this.lbRecordCnt = new System.Windows.Forms.Label();
            this.txtDeviceId = new System.Windows.Forms.TextBox();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.btQueryCountInfo = new System.Windows.Forms.Button();
            this.lbResultCnt = new System.Windows.Forms.Label();
            this.btPagePrev = new System.Windows.Forms.Button();
            this.btPageNext = new System.Windows.Forms.Button();
            this.txtCurrPage = new System.Windows.Forms.TextBox();
            this.lbPageCnt = new System.Windows.Forms.Label();
            this.rtbMsg = new System.Windows.Forms.RichTextBox();
            this.btClearCurrent = new System.Windows.Forms.Button();
            this.chkRemoveRepeat = new System.Windows.Forms.CheckBox();
            this.chkFsn = new System.Windows.Forms.CheckBox();
            this.txtFsn = new System.Windows.Forms.TextBox();
            this.上报次数 = new System.Data.DataColumn();
            this.侦听设备数 = new System.Data.DataColumn();
            this.序号DataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.基站IDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.序号DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.日期DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.序号DataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.设备IDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.dgvLog.Location = new System.Drawing.Point(319, 89);
            this.dgvLog.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvLog.Name = "dgvLog";
            this.dgvLog.ReadOnly = true;
            this.dgvLog.RowHeadersVisible = false;
            this.dgvLog.RowHeadersWidth = 60;
            this.dgvLog.RowTemplate.Height = 23;
            this.dgvLog.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLog.Size = new System.Drawing.Size(973, 495);
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
            this.btQuery.Location = new System.Drawing.Point(913, 19);
            this.btQuery.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btQuery.Name = "btQuery";
            this.btQuery.Size = new System.Drawing.Size(77, 26);
            this.btQuery.TabIndex = 1;
            this.btQuery.Text = "查询";
            this.btQuery.UseVisualStyleBackColor = true;
            this.btQuery.Click += new System.EventHandler(this.btQuery_Click);
            // 
            // btClearAll
            // 
            this.btClearAll.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btClearAll.Location = new System.Drawing.Point(1127, 54);
            this.btClearAll.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btClearAll.Name = "btClearAll";
            this.btClearAll.Size = new System.Drawing.Size(107, 24);
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
            this.grpDevices.Location = new System.Drawing.Point(8, 470);
            this.grpDevices.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpDevices.Name = "grpDevices";
            this.grpDevices.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpDevices.Size = new System.Drawing.Size(303, 288);
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
            this.dgvDevice.Location = new System.Drawing.Point(4, 22);
            this.dgvDevice.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvDevice.Name = "dgvDevice";
            this.dgvDevice.RowHeadersVisible = false;
            this.dgvDevice.RowTemplate.Height = 23;
            this.dgvDevice.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDevice.Size = new System.Drawing.Size(295, 262);
            this.dgvDevice.TabIndex = 0;
            this.dgvDevice.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDevice_CellClick);
            // 
            // grpStations
            // 
            this.grpStations.Controls.Add(this.dgvStation);
            this.grpStations.Location = new System.Drawing.Point(8, 233);
            this.grpStations.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpStations.Name = "grpStations";
            this.grpStations.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpStations.Size = new System.Drawing.Size(303, 229);
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
            this.dgvStation.Location = new System.Drawing.Point(4, 22);
            this.dgvStation.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvStation.Name = "dgvStation";
            this.dgvStation.RowHeadersVisible = false;
            this.dgvStation.RowTemplate.Height = 23;
            this.dgvStation.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStation.Size = new System.Drawing.Size(295, 203);
            this.dgvStation.TabIndex = 0;
            this.dgvStation.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStation_CellClick);
            // 
            // grpDates
            // 
            this.grpDates.Controls.Add(this.dgvDate);
            this.grpDates.Location = new System.Drawing.Point(8, 89);
            this.grpDates.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpDates.Name = "grpDates";
            this.grpDates.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpDates.Size = new System.Drawing.Size(303, 136);
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
            this.dgvDate.ColumnHeadersVisible = false;
            this.dgvDate.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.序号DataGridViewTextBoxColumn,
            this.日期DataGridViewTextBoxColumn});
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
            this.dgvDate.Location = new System.Drawing.Point(4, 22);
            this.dgvDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvDate.Name = "dgvDate";
            this.dgvDate.RowHeadersVisible = false;
            this.dgvDate.RowTemplate.Height = 23;
            this.dgvDate.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDate.Size = new System.Drawing.Size(295, 110);
            this.dgvDate.TabIndex = 0;
            this.dgvDate.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDate_CellClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.groupBox3.Controls.Add(this.txtFsn);
            this.groupBox3.Controls.Add(this.txtSteps);
            this.groupBox3.Controls.Add(this.txtVolt);
            this.groupBox3.Controls.Add(this.cbxSteps);
            this.groupBox3.Controls.Add(this.cbxVolt);
            this.groupBox3.Controls.Add(this.cbxStat);
            this.groupBox3.Controls.Add(this.chkRemoveRepeat);
            this.groupBox3.Controls.Add(this.chkSteps);
            this.groupBox3.Controls.Add(this.chkStationId);
            this.groupBox3.Controls.Add(this.chkStatus);
            this.groupBox3.Controls.Add(this.chkVoltage);
            this.groupBox3.Controls.Add(this.chkDeviceId);
            this.groupBox3.Controls.Add(this.chkFsn);
            this.groupBox3.Controls.Add(this.chkDate);
            this.groupBox3.Controls.Add(this.txtStationId);
            this.groupBox3.Controls.Add(this.lbRecordCnt);
            this.groupBox3.Controls.Add(this.txtDeviceId);
            this.groupBox3.Controls.Add(this.txtDate);
            this.groupBox3.Controls.Add(this.btImport);
            this.groupBox3.Controls.Add(this.btQueryCountInfo);
            this.groupBox3.Controls.Add(this.btQuery);
            this.groupBox3.Controls.Add(this.btClearAll);
            this.groupBox3.Location = new System.Drawing.Point(0, -8);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Size = new System.Drawing.Size(1292, 89);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // txtSteps
            // 
            this.txtSteps.Location = new System.Drawing.Point(719, 56);
            this.txtSteps.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSteps.Name = "txtSteps";
            this.txtSteps.Size = new System.Drawing.Size(75, 25);
            this.txtSteps.TabIndex = 9;
            // 
            // txtVolt
            // 
            this.txtVolt.Location = new System.Drawing.Point(500, 55);
            this.txtVolt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtVolt.Name = "txtVolt";
            this.txtVolt.Size = new System.Drawing.Size(48, 25);
            this.txtVolt.TabIndex = 9;
            // 
            // cbxSteps
            // 
            this.cbxSteps.FormattingEnabled = true;
            this.cbxSteps.Items.AddRange(new object[] {
            "等于",
            "大于",
            "小于"});
            this.cbxSteps.Location = new System.Drawing.Point(647, 58);
            this.cbxSteps.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbxSteps.Name = "cbxSteps";
            this.cbxSteps.Size = new System.Drawing.Size(64, 23);
            this.cbxSteps.TabIndex = 8;
            // 
            // cbxVolt
            // 
            this.cbxVolt.FormattingEnabled = true;
            this.cbxVolt.Items.AddRange(new object[] {
            "等于",
            "大于",
            "小于"});
            this.cbxVolt.Location = new System.Drawing.Point(427, 56);
            this.cbxVolt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbxVolt.Name = "cbxVolt";
            this.cbxVolt.Size = new System.Drawing.Size(64, 23);
            this.cbxVolt.TabIndex = 8;
            // 
            // cbxStat
            // 
            this.cbxStat.FormattingEnabled = true;
            this.cbxStat.Items.AddRange(new object[] {
            "正常",
            "损坏",
            "其他"});
            this.cbxStat.Location = new System.Drawing.Point(271, 58);
            this.cbxStat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbxStat.Name = "cbxStat";
            this.cbxStat.Size = new System.Drawing.Size(61, 23);
            this.cbxStat.TabIndex = 8;
            // 
            // chkSteps
            // 
            this.chkSteps.AutoSize = true;
            this.chkSteps.ForeColor = System.Drawing.SystemColors.Window;
            this.chkSteps.Location = new System.Drawing.Point(584, 62);
            this.chkSteps.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkSteps.Name = "chkSteps";
            this.chkSteps.Size = new System.Drawing.Size(59, 19);
            this.chkSteps.TabIndex = 7;
            this.chkSteps.Text = "步数";
            this.chkSteps.UseVisualStyleBackColor = true;
            // 
            // chkStationId
            // 
            this.chkStationId.AutoSize = true;
            this.chkStationId.ForeColor = System.Drawing.SystemColors.Window;
            this.chkStationId.Location = new System.Drawing.Point(663, 25);
            this.chkStationId.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkStationId.Name = "chkStationId";
            this.chkStationId.Size = new System.Drawing.Size(75, 19);
            this.chkStationId.TabIndex = 7;
            this.chkStationId.Text = "基站ID";
            this.chkStationId.UseVisualStyleBackColor = true;
            // 
            // chkStatus
            // 
            this.chkStatus.AutoSize = true;
            this.chkStatus.ForeColor = System.Drawing.SystemColors.Window;
            this.chkStatus.Location = new System.Drawing.Point(209, 62);
            this.chkStatus.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkStatus.Name = "chkStatus";
            this.chkStatus.Size = new System.Drawing.Size(59, 19);
            this.chkStatus.TabIndex = 7;
            this.chkStatus.Text = "状态";
            this.chkStatus.UseVisualStyleBackColor = true;
            // 
            // chkVoltage
            // 
            this.chkVoltage.AutoSize = true;
            this.chkVoltage.ForeColor = System.Drawing.SystemColors.Window;
            this.chkVoltage.Location = new System.Drawing.Point(367, 62);
            this.chkVoltage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkVoltage.Name = "chkVoltage";
            this.chkVoltage.Size = new System.Drawing.Size(59, 19);
            this.chkVoltage.TabIndex = 7;
            this.chkVoltage.Text = "电压";
            this.chkVoltage.UseVisualStyleBackColor = true;
            // 
            // chkDeviceId
            // 
            this.chkDeviceId.AutoSize = true;
            this.chkDeviceId.ForeColor = System.Drawing.SystemColors.Window;
            this.chkDeviceId.Location = new System.Drawing.Point(431, 25);
            this.chkDeviceId.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkDeviceId.Name = "chkDeviceId";
            this.chkDeviceId.Size = new System.Drawing.Size(75, 19);
            this.chkDeviceId.TabIndex = 7;
            this.chkDeviceId.Text = "设备ID";
            this.chkDeviceId.UseVisualStyleBackColor = true;
            // 
            // chkDate
            // 
            this.chkDate.AutoSize = true;
            this.chkDate.ForeColor = System.Drawing.SystemColors.Window;
            this.chkDate.Location = new System.Drawing.Point(243, 25);
            this.chkDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkDate.Name = "chkDate";
            this.chkDate.Size = new System.Drawing.Size(59, 19);
            this.chkDate.TabIndex = 7;
            this.chkDate.Text = "日期";
            this.chkDate.UseVisualStyleBackColor = true;
            // 
            // txtStationId
            // 
            this.txtStationId.Location = new System.Drawing.Point(751, 19);
            this.txtStationId.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtStationId.Name = "txtStationId";
            this.txtStationId.Size = new System.Drawing.Size(121, 25);
            this.txtStationId.TabIndex = 3;
            // 
            // lbRecordCnt
            // 
            this.lbRecordCnt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbRecordCnt.AutoSize = true;
            this.lbRecordCnt.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbRecordCnt.ForeColor = System.Drawing.SystemColors.Window;
            this.lbRecordCnt.Location = new System.Drawing.Point(1148, 20);
            this.lbRecordCnt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbRecordCnt.Name = "lbRecordCnt";
            this.lbRecordCnt.Size = new System.Drawing.Size(67, 30);
            this.lbRecordCnt.TabIndex = 6;
            this.lbRecordCnt.Text = "记录总数\r\n *** 条";
            this.lbRecordCnt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtDeviceId
            // 
            this.txtDeviceId.Location = new System.Drawing.Point(519, 19);
            this.txtDeviceId.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDeviceId.Name = "txtDeviceId";
            this.txtDeviceId.Size = new System.Drawing.Size(120, 25);
            this.txtDeviceId.TabIndex = 3;
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(315, 21);
            this.txtDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(92, 25);
            this.txtDate.TabIndex = 3;
            // 
            // btQueryCountInfo
            // 
            this.btQueryCountInfo.Location = new System.Drawing.Point(999, 18);
            this.btQueryCountInfo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btQueryCountInfo.Name = "btQueryCountInfo";
            this.btQueryCountInfo.Size = new System.Drawing.Size(77, 29);
            this.btQueryCountInfo.TabIndex = 1;
            this.btQueryCountInfo.Text = "统计";
            this.btQueryCountInfo.UseVisualStyleBackColor = true;
            this.btQueryCountInfo.Click += new System.EventHandler(this.btQueryCountInfo_Click);
            // 
            // lbResultCnt
            // 
            this.lbResultCnt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbResultCnt.AutoSize = true;
            this.lbResultCnt.Location = new System.Drawing.Point(316, 599);
            this.lbResultCnt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbResultCnt.Name = "lbResultCnt";
            this.lbResultCnt.Size = new System.Drawing.Size(184, 15);
            this.lbResultCnt.TabIndex = 3;
            this.lbResultCnt.Text = "当前结果： ** 条  ** 页";
            // 
            // btPagePrev
            // 
            this.btPagePrev.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btPagePrev.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btPagePrev.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btPagePrev.Location = new System.Drawing.Point(595, 592);
            this.btPagePrev.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btPagePrev.Name = "btPagePrev";
            this.btPagePrev.Size = new System.Drawing.Size(71, 30);
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
            this.btPageNext.Location = new System.Drawing.Point(786, 592);
            this.btPageNext.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btPageNext.Name = "btPageNext";
            this.btPageNext.Size = new System.Drawing.Size(71, 30);
            this.btPageNext.TabIndex = 4;
            this.btPageNext.Text = "下一页";
            this.btPageNext.UseVisualStyleBackColor = false;
            this.btPageNext.Click += new System.EventHandler(this.btPageNext_Click);
            // 
            // txtCurrPage
            // 
            this.txtCurrPage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtCurrPage.Location = new System.Drawing.Point(679, 594);
            this.txtCurrPage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCurrPage.Name = "txtCurrPage";
            this.txtCurrPage.Size = new System.Drawing.Size(49, 25);
            this.txtCurrPage.TabIndex = 5;
            // 
            // lbPageCnt
            // 
            this.lbPageCnt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbPageCnt.AutoSize = true;
            this.lbPageCnt.Location = new System.Drawing.Point(731, 602);
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
            this.rtbMsg.Location = new System.Drawing.Point(319, 626);
            this.rtbMsg.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rtbMsg.Name = "rtbMsg";
            this.rtbMsg.Size = new System.Drawing.Size(972, 126);
            this.rtbMsg.TabIndex = 7;
            this.rtbMsg.Text = "";
            // 
            // btClearCurrent
            // 
            this.btClearCurrent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btClearCurrent.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btClearCurrent.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btClearCurrent.Location = new System.Drawing.Point(894, 592);
            this.btClearCurrent.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btClearCurrent.Name = "btClearCurrent";
            this.btClearCurrent.Size = new System.Drawing.Size(124, 30);
            this.btClearCurrent.TabIndex = 1;
            this.btClearCurrent.Text = "清除当前记录";
            this.btClearCurrent.UseVisualStyleBackColor = false;
            this.btClearCurrent.Click += new System.EventHandler(this.btClearCurrent_Click);
            // 
            // chkRemoveRepeat
            // 
            this.chkRemoveRepeat.AutoSize = true;
            this.chkRemoveRepeat.Checked = true;
            this.chkRemoveRepeat.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkRemoveRepeat.ForeColor = System.Drawing.SystemColors.Window;
            this.chkRemoveRepeat.Location = new System.Drawing.Point(957, 59);
            this.chkRemoveRepeat.Margin = new System.Windows.Forms.Padding(4);
            this.chkRemoveRepeat.Name = "chkRemoveRepeat";
            this.chkRemoveRepeat.Size = new System.Drawing.Size(119, 19);
            this.chkRemoveRepeat.TabIndex = 7;
            this.chkRemoveRepeat.Text = "去掉重复计数";
            this.chkRemoveRepeat.UseVisualStyleBackColor = true;
            // 
            // chkFsn
            // 
            this.chkFsn.AutoSize = true;
            this.chkFsn.ForeColor = System.Drawing.SystemColors.Window;
            this.chkFsn.Location = new System.Drawing.Point(823, 60);
            this.chkFsn.Margin = new System.Windows.Forms.Padding(4);
            this.chkFsn.Name = "chkFsn";
            this.chkFsn.Size = new System.Drawing.Size(74, 19);
            this.chkFsn.TabIndex = 7;
            this.chkFsn.Text = "帧序号";
            this.chkFsn.UseVisualStyleBackColor = true;
            // 
            // txtFsn
            // 
            this.txtFsn.Location = new System.Drawing.Point(894, 56);
            this.txtFsn.Margin = new System.Windows.Forms.Padding(4);
            this.txtFsn.Name = "txtFsn";
            this.txtFsn.Size = new System.Drawing.Size(45, 25);
            this.txtFsn.TabIndex = 9;
            // 
            // 上报次数
            // 
            this.上报次数.ColumnName = "上报次数";
            this.上报次数.DataType = typeof(int);
            // 
            // 侦听设备数
            // 
            this.侦听设备数.ColumnName = "侦听设备数";
            this.侦听设备数.DataType = typeof(int);
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
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1292, 761);
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
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private System.Windows.Forms.TextBox txtFsn;
        private System.Windows.Forms.CheckBox chkFsn;
        private System.Data.DataColumn 上报次数;
        private System.Data.DataColumn 侦听设备数;
        private System.Windows.Forms.DataGridViewTextBoxColumn 序号DataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn 基站IDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn 序号DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 日期DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 序号DataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn 设备IDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}

