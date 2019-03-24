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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.dgvLog = new System.Windows.Forms.DataGridView();
            this.设备IDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.设备状态DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.设备电压DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.基站IDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.信号量DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.步数总计DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.时间DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.版本号DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.帧序号DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cMenuLogs = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.导出本页ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.导出所有ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.选择当前行设备IDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.选择当前行基站IDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.选择当前行日期ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dsLog = new System.Data.DataSet();
            this.tbLog = new System.Data.DataTable();
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
            this.tblDevices_deviceId = new System.Data.DataColumn();
            this.上报次数 = new System.Data.DataColumn();
            this.tbStations = new System.Data.DataTable();
            this.tblStations_stationId = new System.Data.DataColumn();
            this.设备个数 = new System.Data.DataColumn();
            this.tbDates = new System.Data.DataTable();
            this.tblDates_date = new System.Data.DataColumn();
            this.记录条数 = new System.Data.DataColumn();
            this.tbDoc = new System.Data.DataTable();
            this.tblDoc_deviceId = new System.Data.DataColumn();
            this.tblDoc_AllRptCnt = new System.Data.DataColumn();
            this.tblDoc_RptDay1 = new System.Data.DataColumn();
            this.tblDoc_RptDay2 = new System.Data.DataColumn();
            this.tblDoc_RptDay3 = new System.Data.DataColumn();
            this.tblDoc_Day4 = new System.Data.DataColumn();
            this.tblDoc_Day5 = new System.Data.DataColumn();
            this.tblDoc_StepStatus = new System.Data.DataColumn();
            this.btImport = new System.Windows.Forms.Button();
            this.openFileDlg = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDlg = new System.Windows.Forms.SaveFileDialog();
            this.btQuery = new System.Windows.Forms.Button();
            this.btClearAll = new System.Windows.Forms.Button();
            this.grpDevices = new System.Windows.Forms.GroupBox();
            this.dgvDevice = new System.Windows.Forms.DataGridView();
            this.设备IDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cMenuDevices = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.devices导出列表ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.devices统计上报次数设备个数ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grpStations = new System.Windows.Forms.GroupBox();
            this.dgvStation = new System.Windows.Forms.DataGridView();
            this.基站IDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cMenuStations = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.stations导出列表ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.grpDates = new System.Windows.Forms.GroupBox();
            this.dgvDate = new System.Windows.Forms.DataGridView();
            this.日期DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cMenuDates = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.dates导出列表ToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.dates删除记录ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.updownPagesize = new System.Windows.Forms.NumericUpDown();
            this.txtSteps = new System.Windows.Forms.TextBox();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.txtDeviceId = new System.Windows.Forms.TextBox();
            this.txtStationId = new System.Windows.Forms.TextBox();
            this.txtVer = new System.Windows.Forms.TextBox();
            this.txtVolt = new System.Windows.Forms.TextBox();
            this.cbxVer = new System.Windows.Forms.ComboBox();
            this.cbxSteps = new System.Windows.Forms.ComboBox();
            this.cbxVolt = new System.Windows.Forms.ComboBox();
            this.cbxStat = new System.Windows.Forms.ComboBox();
            this.chkRmSameDev = new System.Windows.Forms.CheckBox();
            this.chkRmSameReport = new System.Windows.Forms.CheckBox();
            this.chkSteps = new System.Windows.Forms.CheckBox();
            this.chkStationId = new System.Windows.Forms.CheckBox();
            this.chkVer = new System.Windows.Forms.CheckBox();
            this.chkStatus = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chkVoltage = new System.Windows.Forms.CheckBox();
            this.btCountMainInfo = new System.Windows.Forms.Button();
            this.chkDeviceId = new System.Windows.Forms.CheckBox();
            this.chkDate = new System.Windows.Forms.CheckBox();
            this.lbRecordCnt = new System.Windows.Forms.Label();
            this.lbResultCnt = new System.Windows.Forms.Label();
            this.btPagePrev = new System.Windows.Forms.Button();
            this.btPageNext = new System.Windows.Forms.Button();
            this.txtCurrPage = new System.Windows.Forms.TextBox();
            this.lbPageCnt = new System.Windows.Forms.Label();
            this.rtbMsg = new System.Windows.Forms.RichTextBox();
            this.btClearCurrent = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.rbtRptCnt = new System.Windows.Forms.RadioButton();
            this.rbtVbatMax = new System.Windows.Forms.RadioButton();
            this.rbtVbatMin = new System.Windows.Forms.RadioButton();
            this.btClearDocView = new System.Windows.Forms.Button();
            this.lbCurrDocCnt = new System.Windows.Forms.Label();
            this.btCountDocInfo = new System.Windows.Forms.Button();
            this.btDocImport = new System.Windows.Forms.Button();
            this.dgvDoc = new System.Windows.Forms.DataGridView();
            this.设备IDDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.总上报次数DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.第1天上报DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.第2天上报DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.第3天上报DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.第4天上报DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.第5天上报DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.步数状态DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cMenuDocs = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.导出列表ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.选择当前行设备IDToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.导入档案ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.删除档案ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLog)).BeginInit();
            this.cMenuLogs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsLog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbLog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbDevices)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbStations)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbDates)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbDoc)).BeginInit();
            this.grpDevices.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDevice)).BeginInit();
            this.cMenuDevices.SuspendLayout();
            this.grpStations.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStation)).BeginInit();
            this.cMenuStations.SuspendLayout();
            this.grpDates.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDate)).BeginInit();
            this.cMenuDates.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updownPagesize)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoc)).BeginInit();
            this.cMenuDocs.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvLog
            // 
            this.dgvLog.AllowUserToAddRows = false;
            this.dgvLog.AllowUserToDeleteRows = false;
            this.dgvLog.AllowUserToOrderColumns = true;
            this.dgvLog.AllowUserToResizeRows = false;
            this.dgvLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.设备IDDataGridViewTextBoxColumn,
            this.设备状态DataGridViewTextBoxColumn,
            this.设备电压DataGridViewTextBoxColumn,
            this.基站IDDataGridViewTextBoxColumn,
            this.信号量DataGridViewTextBoxColumn,
            this.步数总计DataGridViewTextBoxColumn,
            this.时间DataGridViewTextBoxColumn,
            this.版本号DataGridViewTextBoxColumn,
            this.帧序号DataGridViewTextBoxColumn});
            this.dgvLog.ContextMenuStrip = this.cMenuLogs;
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
            this.dgvLog.Location = new System.Drawing.Point(0, 0);
            this.dgvLog.Margin = new System.Windows.Forms.Padding(0);
            this.dgvLog.Name = "dgvLog";
            this.dgvLog.ReadOnly = true;
            this.dgvLog.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvLog.RowHeadersWidth = 70;
            this.dgvLog.RowTemplate.Height = 23;
            this.dgvLog.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvLog.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLog.Size = new System.Drawing.Size(988, 474);
            this.dgvLog.TabIndex = 0;
            this.dgvLog.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvLog_CellFormatting);
            this.dgvLog.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgv_RowsAdded);
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
            // cMenuLogs
            // 
            this.cMenuLogs.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cMenuLogs.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.导出本页ToolStripMenuItem,
            this.导出所有ToolStripMenuItem,
            this.选择当前行设备IDToolStripMenuItem,
            this.选择当前行基站IDToolStripMenuItem,
            this.选择当前行日期ToolStripMenuItem});
            this.cMenuLogs.Name = "cMenuLogs";
            this.cMenuLogs.Size = new System.Drawing.Size(205, 124);
            this.cMenuLogs.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.cMenuLog_ItemClicked);
            // 
            // 导出本页ToolStripMenuItem
            // 
            this.导出本页ToolStripMenuItem.Name = "导出本页ToolStripMenuItem";
            this.导出本页ToolStripMenuItem.Size = new System.Drawing.Size(204, 24);
            this.导出本页ToolStripMenuItem.Text = "导出本页";
            // 
            // 导出所有ToolStripMenuItem
            // 
            this.导出所有ToolStripMenuItem.Name = "导出所有ToolStripMenuItem";
            this.导出所有ToolStripMenuItem.Size = new System.Drawing.Size(204, 24);
            this.导出所有ToolStripMenuItem.Text = "导出所有";
            // 
            // 选择当前行设备IDToolStripMenuItem
            // 
            this.选择当前行设备IDToolStripMenuItem.Name = "选择当前行设备IDToolStripMenuItem";
            this.选择当前行设备IDToolStripMenuItem.Size = new System.Drawing.Size(204, 24);
            this.选择当前行设备IDToolStripMenuItem.Text = "选择当前行-设备ID";
            // 
            // 选择当前行基站IDToolStripMenuItem
            // 
            this.选择当前行基站IDToolStripMenuItem.Name = "选择当前行基站IDToolStripMenuItem";
            this.选择当前行基站IDToolStripMenuItem.Size = new System.Drawing.Size(204, 24);
            this.选择当前行基站IDToolStripMenuItem.Text = "选择当前行-基站ID";
            // 
            // 选择当前行日期ToolStripMenuItem
            // 
            this.选择当前行日期ToolStripMenuItem.Name = "选择当前行日期ToolStripMenuItem";
            this.选择当前行日期ToolStripMenuItem.Size = new System.Drawing.Size(204, 24);
            this.选择当前行日期ToolStripMenuItem.Text = "选择当前行-日期";
            // 
            // dsLog
            // 
            this.dsLog.DataSetName = "NewDataSet";
            this.dsLog.Tables.AddRange(new System.Data.DataTable[] {
            this.tbLog,
            this.tbDevices,
            this.tbStations,
            this.tbDates,
            this.tbDoc});
            // 
            // tbLog
            // 
            this.tbLog.Columns.AddRange(new System.Data.DataColumn[] {
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
            this.tblDevices_deviceId,
            this.上报次数});
            this.tbDevices.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Constraint2", new string[] {
                        "设备ID"}, false)});
            this.tbDevices.TableName = "tblDevices";
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
            this.tblStations_stationId,
            this.设备个数});
            this.tbStations.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Constraint2", new string[] {
                        "基站ID"}, false)});
            this.tbStations.TableName = "tblStations";
            // 
            // tblStations_stationId
            // 
            this.tblStations_stationId.ColumnName = "基站ID";
            this.tblStations_stationId.DataType = typeof(long);
            // 
            // 设备个数
            // 
            this.设备个数.ColumnName = "设备个数";
            this.设备个数.DataType = typeof(int);
            // 
            // tbDates
            // 
            this.tbDates.Columns.AddRange(new System.Data.DataColumn[] {
            this.tblDates_date,
            this.记录条数});
            this.tbDates.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Constraint2", new string[] {
                        "日期"}, false)});
            this.tbDates.TableName = "tblDates";
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
            // tbDoc
            // 
            this.tbDoc.Columns.AddRange(new System.Data.DataColumn[] {
            this.tblDoc_deviceId,
            this.tblDoc_AllRptCnt,
            this.tblDoc_RptDay1,
            this.tblDoc_RptDay2,
            this.tblDoc_RptDay3,
            this.tblDoc_Day4,
            this.tblDoc_Day5,
            this.tblDoc_StepStatus});
            this.tbDoc.TableName = "tblDoc";
            // 
            // tblDoc_deviceId
            // 
            this.tblDoc_deviceId.ColumnName = "设备ID";
            this.tblDoc_deviceId.DataType = typeof(long);
            // 
            // tblDoc_AllRptCnt
            // 
            this.tblDoc_AllRptCnt.ColumnName = "总上报次数";
            this.tblDoc_AllRptCnt.DataType = typeof(decimal);
            // 
            // tblDoc_RptDay1
            // 
            this.tblDoc_RptDay1.ColumnName = "第1天上报";
            // 
            // tblDoc_RptDay2
            // 
            this.tblDoc_RptDay2.ColumnName = "第2天上报";
            // 
            // tblDoc_RptDay3
            // 
            this.tblDoc_RptDay3.ColumnName = "第3天上报";
            // 
            // tblDoc_Day4
            // 
            this.tblDoc_Day4.ColumnName = "第4天上报";
            // 
            // tblDoc_Day5
            // 
            this.tblDoc_Day5.ColumnName = "第5天上报";
            // 
            // tblDoc_StepStatus
            // 
            this.tblDoc_StepStatus.ColumnName = "步数状态";
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
            this.btQuery.Location = new System.Drawing.Point(1185, 22);
            this.btQuery.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btQuery.Name = "btQuery";
            this.btQuery.Size = new System.Drawing.Size(135, 29);
            this.btQuery.TabIndex = 1;
            this.btQuery.Text = "查询";
            this.btQuery.UseVisualStyleBackColor = true;
            this.btQuery.Click += new System.EventHandler(this.btQuery_Click);
            // 
            // btClearAll
            // 
            this.btClearAll.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btClearAll.Location = new System.Drawing.Point(197, 54);
            this.btClearAll.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btClearAll.Name = "btClearAll";
            this.btClearAll.Size = new System.Drawing.Size(131, 24);
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
            this.grpDevices.Size = new System.Drawing.Size(320, 293);
            this.grpDevices.TabIndex = 2;
            this.grpDevices.TabStop = false;
            this.grpDevices.Text = "上报的设备【**】";
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
            this.dgvDevice.Location = new System.Drawing.Point(4, 22);
            this.dgvDevice.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvDevice.Name = "dgvDevice";
            this.dgvDevice.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvDevice.RowHeadersWidth = 65;
            this.dgvDevice.RowTemplate.Height = 23;
            this.dgvDevice.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDevice.Size = new System.Drawing.Size(312, 267);
            this.dgvDevice.TabIndex = 0;
            this.dgvDevice.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDevice_CellClick);
            this.dgvDevice.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgv_RowsAdded);
            // 
            // 设备IDDataGridViewTextBoxColumn1
            // 
            this.设备IDDataGridViewTextBoxColumn1.DataPropertyName = "设备ID";
            this.设备IDDataGridViewTextBoxColumn1.HeaderText = "设备ID";
            this.设备IDDataGridViewTextBoxColumn1.Name = "设备IDDataGridViewTextBoxColumn1";
            this.设备IDDataGridViewTextBoxColumn1.Width = 90;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "上报次数";
            this.dataGridViewTextBoxColumn2.HeaderText = "上报次数";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 60;
            // 
            // cMenuDevices
            // 
            this.cMenuDevices.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cMenuDevices.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.devices导出列表ToolStripMenuItem,
            this.devices统计上报次数设备个数ToolStripMenuItem});
            this.cMenuDevices.Name = "cMenuDevices";
            this.cMenuDevices.Size = new System.Drawing.Size(269, 52);
            // 
            // devices导出列表ToolStripMenuItem
            // 
            this.devices导出列表ToolStripMenuItem.Name = "devices导出列表ToolStripMenuItem";
            this.devices导出列表ToolStripMenuItem.Size = new System.Drawing.Size(268, 24);
            this.devices导出列表ToolStripMenuItem.Text = "导出列表";
            this.devices导出列表ToolStripMenuItem.Click += new System.EventHandler(this.devices导出列表ToolStripMenuItem_Click);
            // 
            // devices统计上报次数设备个数ToolStripMenuItem
            // 
            this.devices统计上报次数设备个数ToolStripMenuItem.Name = "devices统计上报次数设备个数ToolStripMenuItem";
            this.devices统计上报次数设备个数ToolStripMenuItem.Size = new System.Drawing.Size(268, 24);
            this.devices统计上报次数设备个数ToolStripMenuItem.Text = "统计 [ 上报次数 - 设备个数  ]";
            this.devices统计上报次数设备个数ToolStripMenuItem.Click += new System.EventHandler(this.devices统计设备数上报次数ToolStripMenuItem_Click);
            // 
            // grpStations
            // 
            this.grpStations.Controls.Add(this.dgvStation);
            this.grpStations.Location = new System.Drawing.Point(8, 232);
            this.grpStations.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpStations.Name = "grpStations";
            this.grpStations.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpStations.Size = new System.Drawing.Size(320, 229);
            this.grpStations.TabIndex = 2;
            this.grpStations.TabStop = false;
            this.grpStations.Text = "接收的基站【**】";
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
            this.dgvStation.Location = new System.Drawing.Point(4, 22);
            this.dgvStation.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvStation.Name = "dgvStation";
            this.dgvStation.RowHeadersWidth = 65;
            this.dgvStation.RowTemplate.Height = 23;
            this.dgvStation.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStation.Size = new System.Drawing.Size(312, 203);
            this.dgvStation.TabIndex = 0;
            this.dgvStation.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStation_CellClick);
            this.dgvStation.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgv_RowsAdded);
            // 
            // 基站IDDataGridViewTextBoxColumn1
            // 
            this.基站IDDataGridViewTextBoxColumn1.DataPropertyName = "基站ID";
            this.基站IDDataGridViewTextBoxColumn1.HeaderText = "基站ID";
            this.基站IDDataGridViewTextBoxColumn1.Name = "基站IDDataGridViewTextBoxColumn1";
            this.基站IDDataGridViewTextBoxColumn1.Width = 90;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "设备个数";
            this.dataGridViewTextBoxColumn1.HeaderText = "设备个数";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 60;
            // 
            // cMenuStations
            // 
            this.cMenuStations.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cMenuStations.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stations导出列表ToolStripMenuItem1});
            this.cMenuStations.Name = "cMenuStations";
            this.cMenuStations.Size = new System.Drawing.Size(139, 28);
            // 
            // stations导出列表ToolStripMenuItem1
            // 
            this.stations导出列表ToolStripMenuItem1.Name = "stations导出列表ToolStripMenuItem1";
            this.stations导出列表ToolStripMenuItem1.Size = new System.Drawing.Size(138, 24);
            this.stations导出列表ToolStripMenuItem1.Text = "导出列表";
            this.stations导出列表ToolStripMenuItem1.Click += new System.EventHandler(this.stations导出列表ToolStripMenuItem1_Click);
            // 
            // grpDates
            // 
            this.grpDates.Controls.Add(this.dgvDate);
            this.grpDates.Location = new System.Drawing.Point(8, 89);
            this.grpDates.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpDates.Name = "grpDates";
            this.grpDates.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpDates.Size = new System.Drawing.Size(320, 136);
            this.grpDates.TabIndex = 2;
            this.grpDates.TabStop = false;
            this.grpDates.Text = "记录的天数【**】";
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
            this.dgvDate.Location = new System.Drawing.Point(4, 22);
            this.dgvDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvDate.Name = "dgvDate";
            this.dgvDate.RowHeadersWidth = 65;
            this.dgvDate.RowTemplate.Height = 23;
            this.dgvDate.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDate.Size = new System.Drawing.Size(312, 110);
            this.dgvDate.TabIndex = 0;
            this.dgvDate.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDate_CellClick);
            this.dgvDate.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgv_RowsAdded);
            // 
            // 日期DataGridViewTextBoxColumn
            // 
            this.日期DataGridViewTextBoxColumn.DataPropertyName = "日期";
            this.日期DataGridViewTextBoxColumn.HeaderText = "日期";
            this.日期DataGridViewTextBoxColumn.Name = "日期DataGridViewTextBoxColumn";
            this.日期DataGridViewTextBoxColumn.Width = 90;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "记录条数";
            this.dataGridViewTextBoxColumn3.HeaderText = "记录条数";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 60;
            // 
            // cMenuDates
            // 
            this.cMenuDates.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cMenuDates.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dates导出列表ToolStripMenuItem2,
            this.dates删除记录ToolStripMenuItem});
            this.cMenuDates.Name = "cMenuDates";
            this.cMenuDates.Size = new System.Drawing.Size(139, 52);
            // 
            // dates导出列表ToolStripMenuItem2
            // 
            this.dates导出列表ToolStripMenuItem2.Name = "dates导出列表ToolStripMenuItem2";
            this.dates导出列表ToolStripMenuItem2.Size = new System.Drawing.Size(138, 24);
            this.dates导出列表ToolStripMenuItem2.Text = "导出列表";
            this.dates导出列表ToolStripMenuItem2.Click += new System.EventHandler(this.dates导出列表ToolStripMenuItem2_Click);
            // 
            // dates删除记录ToolStripMenuItem
            // 
            this.dates删除记录ToolStripMenuItem.Name = "dates删除记录ToolStripMenuItem";
            this.dates删除记录ToolStripMenuItem.Size = new System.Drawing.Size(138, 24);
            this.dates删除记录ToolStripMenuItem.Text = "删除记录";
            this.dates删除记录ToolStripMenuItem.Click += new System.EventHandler(this.dates删除记录ToolStripMenuItem_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.groupBox3.Controls.Add(this.updownPagesize);
            this.groupBox3.Controls.Add(this.txtSteps);
            this.groupBox3.Controls.Add(this.txtDate);
            this.groupBox3.Controls.Add(this.txtDeviceId);
            this.groupBox3.Controls.Add(this.txtStationId);
            this.groupBox3.Controls.Add(this.txtVer);
            this.groupBox3.Controls.Add(this.txtVolt);
            this.groupBox3.Controls.Add(this.cbxVer);
            this.groupBox3.Controls.Add(this.cbxSteps);
            this.groupBox3.Controls.Add(this.cbxVolt);
            this.groupBox3.Controls.Add(this.cbxStat);
            this.groupBox3.Controls.Add(this.chkRmSameDev);
            this.groupBox3.Controls.Add(this.chkRmSameReport);
            this.groupBox3.Controls.Add(this.chkSteps);
            this.groupBox3.Controls.Add(this.chkStationId);
            this.groupBox3.Controls.Add(this.chkVer);
            this.groupBox3.Controls.Add(this.chkStatus);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.chkVoltage);
            this.groupBox3.Controls.Add(this.btCountMainInfo);
            this.groupBox3.Controls.Add(this.chkDeviceId);
            this.groupBox3.Controls.Add(this.chkDate);
            this.groupBox3.Controls.Add(this.lbRecordCnt);
            this.groupBox3.Controls.Add(this.btImport);
            this.groupBox3.Controls.Add(this.btQuery);
            this.groupBox3.Controls.Add(this.btClearAll);
            this.groupBox3.Location = new System.Drawing.Point(0, -8);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Size = new System.Drawing.Size(1336, 89);
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
            this.updownPagesize.Location = new System.Drawing.Point(1252, 55);
            this.updownPagesize.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.updownPagesize.Size = new System.Drawing.Size(67, 25);
            this.updownPagesize.TabIndex = 10;
            this.updownPagesize.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // txtSteps
            // 
            this.txtSteps.Location = new System.Drawing.Point(847, 55);
            this.txtSteps.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSteps.Name = "txtSteps";
            this.txtSteps.Size = new System.Drawing.Size(75, 25);
            this.txtSteps.TabIndex = 9;
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(541, 19);
            this.txtDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(89, 25);
            this.txtDate.TabIndex = 9;
            // 
            // txtDeviceId
            // 
            this.txtDeviceId.Location = new System.Drawing.Point(728, 19);
            this.txtDeviceId.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDeviceId.Name = "txtDeviceId";
            this.txtDeviceId.Size = new System.Drawing.Size(111, 25);
            this.txtDeviceId.TabIndex = 9;
            // 
            // txtStationId
            // 
            this.txtStationId.Location = new System.Drawing.Point(948, 19);
            this.txtStationId.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtStationId.Name = "txtStationId";
            this.txtStationId.Size = new System.Drawing.Size(104, 25);
            this.txtStationId.TabIndex = 9;
            // 
            // txtVer
            // 
            this.txtVer.Location = new System.Drawing.Point(1081, 55);
            this.txtVer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtVer.Name = "txtVer";
            this.txtVer.Size = new System.Drawing.Size(48, 25);
            this.txtVer.TabIndex = 9;
            // 
            // txtVolt
            // 
            this.txtVolt.Location = new System.Drawing.Point(639, 54);
            this.txtVolt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtVolt.Name = "txtVolt";
            this.txtVolt.Size = new System.Drawing.Size(48, 25);
            this.txtVolt.TabIndex = 9;
            // 
            // cbxVer
            // 
            this.cbxVer.FormattingEnabled = true;
            this.cbxVer.Items.AddRange(new object[] {
            "等于",
            "大于",
            "小于"});
            this.cbxVer.Location = new System.Drawing.Point(1009, 56);
            this.cbxVer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbxVer.Name = "cbxVer";
            this.cbxVer.Size = new System.Drawing.Size(64, 23);
            this.cbxVer.TabIndex = 8;
            // 
            // cbxSteps
            // 
            this.cbxSteps.FormattingEnabled = true;
            this.cbxSteps.Items.AddRange(new object[] {
            "等于",
            "大于",
            "小于"});
            this.cbxSteps.Location = new System.Drawing.Point(775, 56);
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
            this.cbxVolt.Location = new System.Drawing.Point(567, 55);
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
            this.cbxStat.Location = new System.Drawing.Point(416, 54);
            this.cbxStat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbxStat.Name = "cbxStat";
            this.cbxStat.Size = new System.Drawing.Size(61, 23);
            this.cbxStat.TabIndex = 8;
            // 
            // chkRmSameDev
            // 
            this.chkRmSameDev.AutoSize = true;
            this.chkRmSameDev.Font = new System.Drawing.Font("宋体", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.chkRmSameDev.ForeColor = System.Drawing.SystemColors.Window;
            this.chkRmSameDev.Location = new System.Drawing.Point(1065, 24);
            this.chkRmSameDev.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkRmSameDev.Name = "chkRmSameDev";
            this.chkRmSameDev.Size = new System.Drawing.Size(107, 17);
            this.chkRmSameDev.TabIndex = 7;
            this.chkRmSameDev.Text = "去掉重复设备";
            this.chkRmSameDev.UseVisualStyleBackColor = true;
            // 
            // chkRmSameReport
            // 
            this.chkRmSameReport.AutoSize = true;
            this.chkRmSameReport.Checked = true;
            this.chkRmSameReport.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkRmSameReport.Font = new System.Drawing.Font("宋体", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.chkRmSameReport.ForeColor = System.Drawing.SystemColors.Window;
            this.chkRmSameReport.Location = new System.Drawing.Point(356, 22);
            this.chkRmSameReport.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkRmSameReport.Name = "chkRmSameReport";
            this.chkRmSameReport.Size = new System.Drawing.Size(107, 17);
            this.chkRmSameReport.TabIndex = 7;
            this.chkRmSameReport.Text = "去掉重复上报";
            this.chkRmSameReport.UseVisualStyleBackColor = true;
            // 
            // chkSteps
            // 
            this.chkSteps.AutoSize = true;
            this.chkSteps.ForeColor = System.Drawing.SystemColors.Window;
            this.chkSteps.Location = new System.Drawing.Point(715, 59);
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
            this.chkStationId.Location = new System.Drawing.Point(872, 22);
            this.chkStationId.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkStationId.Name = "chkStationId";
            this.chkStationId.Size = new System.Drawing.Size(75, 19);
            this.chkStationId.TabIndex = 7;
            this.chkStationId.Text = "基站ID";
            this.chkStationId.UseVisualStyleBackColor = true;
            // 
            // chkVer
            // 
            this.chkVer.AutoSize = true;
            this.chkVer.ForeColor = System.Drawing.SystemColors.Window;
            this.chkVer.Location = new System.Drawing.Point(948, 60);
            this.chkVer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkVer.Name = "chkVer";
            this.chkVer.Size = new System.Drawing.Size(59, 19);
            this.chkVer.TabIndex = 7;
            this.chkVer.Text = "版本";
            this.chkVer.UseVisualStyleBackColor = true;
            // 
            // chkStatus
            // 
            this.chkStatus.AutoSize = true;
            this.chkStatus.ForeColor = System.Drawing.SystemColors.Window;
            this.chkStatus.Location = new System.Drawing.Point(356, 56);
            this.chkStatus.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkStatus.Name = "chkStatus";
            this.chkStatus.Size = new System.Drawing.Size(59, 19);
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
            this.label1.Location = new System.Drawing.Point(1183, 61);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "每页显示";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // chkVoltage
            // 
            this.chkVoltage.AutoSize = true;
            this.chkVoltage.ForeColor = System.Drawing.SystemColors.Window;
            this.chkVoltage.Location = new System.Drawing.Point(505, 59);
            this.chkVoltage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkVoltage.Name = "chkVoltage";
            this.chkVoltage.Size = new System.Drawing.Size(59, 19);
            this.chkVoltage.TabIndex = 7;
            this.chkVoltage.Text = "电压";
            this.chkVoltage.UseVisualStyleBackColor = true;
            // 
            // btCountMainInfo
            // 
            this.btCountMainInfo.Location = new System.Drawing.Point(197, 18);
            this.btCountMainInfo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btCountMainInfo.Name = "btCountMainInfo";
            this.btCountMainInfo.Size = new System.Drawing.Size(131, 28);
            this.btCountMainInfo.TabIndex = 1;
            this.btCountMainInfo.Text = "统计概要信息";
            this.btCountMainInfo.UseVisualStyleBackColor = true;
            this.btCountMainInfo.Click += new System.EventHandler(this.btQueryCountInfo_Click);
            // 
            // chkDeviceId
            // 
            this.chkDeviceId.AutoSize = true;
            this.chkDeviceId.ForeColor = System.Drawing.SystemColors.Window;
            this.chkDeviceId.Location = new System.Drawing.Point(653, 24);
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
            this.chkDate.Location = new System.Drawing.Point(483, 21);
            this.chkDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkDate.Name = "chkDate";
            this.chkDate.Size = new System.Drawing.Size(59, 19);
            this.chkDate.TabIndex = 7;
            this.chkDate.Text = "日期";
            this.chkDate.UseVisualStyleBackColor = true;
            // 
            // lbRecordCnt
            // 
            this.lbRecordCnt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbRecordCnt.AutoSize = true;
            this.lbRecordCnt.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbRecordCnt.ForeColor = System.Drawing.SystemColors.Window;
            this.lbRecordCnt.Location = new System.Drawing.Point(16, 59);
            this.lbRecordCnt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbRecordCnt.Name = "lbRecordCnt";
            this.lbRecordCnt.Size = new System.Drawing.Size(122, 15);
            this.lbRecordCnt.TabIndex = 6;
            this.lbRecordCnt.Text = "记录总数 *** 条";
            this.lbRecordCnt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbResultCnt
            // 
            this.lbResultCnt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbResultCnt.AutoSize = true;
            this.lbResultCnt.Location = new System.Drawing.Point(4, 485);
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
            this.btPagePrev.Location = new System.Drawing.Point(279, 478);
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
            this.btPageNext.Location = new System.Drawing.Point(471, 478);
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
            this.txtCurrPage.Location = new System.Drawing.Point(363, 479);
            this.txtCurrPage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCurrPage.Name = "txtCurrPage";
            this.txtCurrPage.Size = new System.Drawing.Size(49, 25);
            this.txtCurrPage.TabIndex = 5;
            this.txtCurrPage.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCurrPage_KeyPress);
            // 
            // lbPageCnt
            // 
            this.lbPageCnt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbPageCnt.AutoSize = true;
            this.lbPageCnt.Location = new System.Drawing.Point(416, 484);
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
            this.rtbMsg.Location = new System.Drawing.Point(352, 630);
            this.rtbMsg.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rtbMsg.Name = "rtbMsg";
            this.rtbMsg.Size = new System.Drawing.Size(977, 126);
            this.rtbMsg.TabIndex = 7;
            this.rtbMsg.Text = "";
            // 
            // btClearCurrent
            // 
            this.btClearCurrent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btClearCurrent.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btClearCurrent.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btClearCurrent.Location = new System.Drawing.Point(577, 478);
            this.btClearCurrent.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btClearCurrent.Name = "btClearCurrent";
            this.btClearCurrent.Size = new System.Drawing.Size(124, 30);
            this.btClearCurrent.TabIndex = 1;
            this.btClearCurrent.Text = "清除当前记录";
            this.btClearCurrent.UseVisualStyleBackColor = false;
            this.btClearCurrent.Click += new System.EventHandler(this.btClearCurrent_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(347, 82);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(0, 0);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(989, 544);
            this.tabControl1.TabIndex = 9;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgvLog);
            this.tabPage1.Controls.Add(this.lbResultCnt);
            this.tabPage1.Controls.Add(this.btClearCurrent);
            this.tabPage1.Controls.Add(this.btPagePrev);
            this.tabPage1.Controls.Add(this.btPageNext);
            this.tabPage1.Controls.Add(this.txtCurrPage);
            this.tabPage1.Controls.Add(this.lbPageCnt);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(0);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(981, 515);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "查询结果";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.rbtRptCnt);
            this.tabPage2.Controls.Add(this.rbtVbatMax);
            this.tabPage2.Controls.Add(this.rbtVbatMin);
            this.tabPage2.Controls.Add(this.btClearDocView);
            this.tabPage2.Controls.Add(this.lbCurrDocCnt);
            this.tabPage2.Controls.Add(this.btCountDocInfo);
            this.tabPage2.Controls.Add(this.btDocImport);
            this.tabPage2.Controls.Add(this.dgvDoc);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Size = new System.Drawing.Size(981, 515);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "设备档案信息";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // rbtRptCnt
            // 
            this.rbtRptCnt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.rbtRptCnt.AutoSize = true;
            this.rbtRptCnt.Location = new System.Drawing.Point(596, 482);
            this.rbtRptCnt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbtRptCnt.Name = "rbtRptCnt";
            this.rbtRptCnt.Size = new System.Drawing.Size(88, 19);
            this.rbtRptCnt.TabIndex = 6;
            this.rbtRptCnt.Text = "上报次数";
            this.rbtRptCnt.UseVisualStyleBackColor = true;
            // 
            // rbtVbatMax
            // 
            this.rbtVbatMax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.rbtVbatMax.AutoSize = true;
            this.rbtVbatMax.Location = new System.Drawing.Point(499, 482);
            this.rbtVbatMax.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbtVbatMax.Name = "rbtVbatMax";
            this.rbtVbatMax.Size = new System.Drawing.Size(88, 19);
            this.rbtVbatMax.TabIndex = 6;
            this.rbtVbatMax.Text = "最高电压";
            this.rbtVbatMax.UseVisualStyleBackColor = true;
            // 
            // rbtVbatMin
            // 
            this.rbtVbatMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.rbtVbatMin.AutoSize = true;
            this.rbtVbatMin.Checked = true;
            this.rbtVbatMin.Location = new System.Drawing.Point(401, 481);
            this.rbtVbatMin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbtVbatMin.Name = "rbtVbatMin";
            this.rbtVbatMin.Size = new System.Drawing.Size(88, 19);
            this.rbtVbatMin.TabIndex = 6;
            this.rbtVbatMin.TabStop = true;
            this.rbtVbatMin.Text = "最低电压";
            this.rbtVbatMin.UseVisualStyleBackColor = true;
            // 
            // btClearDocView
            // 
            this.btClearDocView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btClearDocView.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btClearDocView.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btClearDocView.Location = new System.Drawing.Point(808, 479);
            this.btClearDocView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btClearDocView.Name = "btClearDocView";
            this.btClearDocView.Size = new System.Drawing.Size(124, 30);
            this.btClearDocView.TabIndex = 5;
            this.btClearDocView.Text = "清除当前记录";
            this.btClearDocView.UseVisualStyleBackColor = false;
            this.btClearDocView.Click += new System.EventHandler(this.btClearDocView_Click);
            // 
            // lbCurrDocCnt
            // 
            this.lbCurrDocCnt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbCurrDocCnt.AutoSize = true;
            this.lbCurrDocCnt.Location = new System.Drawing.Point(4, 486);
            this.lbCurrDocCnt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCurrDocCnt.Name = "lbCurrDocCnt";
            this.lbCurrDocCnt.Size = new System.Drawing.Size(237, 15);
            this.lbCurrDocCnt.TabIndex = 4;
            this.lbCurrDocCnt.Text = "当前档案： ** 个  未上报 ** 个";
            // 
            // btCountDocInfo
            // 
            this.btCountDocInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btCountDocInfo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btCountDocInfo.Location = new System.Drawing.Point(699, 479);
            this.btCountDocInfo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btCountDocInfo.Name = "btCountDocInfo";
            this.btCountDocInfo.Size = new System.Drawing.Size(89, 30);
            this.btCountDocInfo.TabIndex = 1;
            this.btCountDocInfo.Text = "统计";
            this.btCountDocInfo.UseVisualStyleBackColor = false;
            this.btCountDocInfo.Click += new System.EventHandler(this.btCountDocInfo_Click);
            // 
            // btDocImport
            // 
            this.btDocImport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btDocImport.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btDocImport.Location = new System.Drawing.Point(288, 478);
            this.btDocImport.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btDocImport.Name = "btDocImport";
            this.btDocImport.Size = new System.Drawing.Size(93, 30);
            this.btDocImport.TabIndex = 1;
            this.btDocImport.Text = "导入档案";
            this.btDocImport.UseVisualStyleBackColor = false;
            this.btDocImport.Click += new System.EventHandler(this.btDocImport_Click);
            // 
            // dgvDoc
            // 
            this.dgvDoc.AllowUserToAddRows = false;
            this.dgvDoc.AllowUserToDeleteRows = false;
            this.dgvDoc.AllowUserToResizeRows = false;
            this.dgvDoc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDoc.AutoGenerateColumns = false;
            this.dgvDoc.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDoc.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvDoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvDoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.设备IDDataGridViewTextBoxColumn2,
            this.总上报次数DataGridViewTextBoxColumn,
            this.第1天上报DataGridViewTextBoxColumn,
            this.第2天上报DataGridViewTextBoxColumn,
            this.第3天上报DataGridViewTextBoxColumn,
            this.第4天上报DataGridViewTextBoxColumn,
            this.第5天上报DataGridViewTextBoxColumn,
            this.步数状态DataGridViewTextBoxColumn});
            this.dgvDoc.ContextMenuStrip = this.cMenuDocs;
            this.dgvDoc.DataMember = "tblDoc";
            this.dgvDoc.DataSource = this.dsLog;
            this.dgvDoc.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvDoc.Location = new System.Drawing.Point(0, 0);
            this.dgvDoc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvDoc.Name = "dgvDoc";
            this.dgvDoc.RowHeadersWidth = 60;
            this.dgvDoc.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvDoc.RowTemplate.Height = 23;
            this.dgvDoc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDoc.Size = new System.Drawing.Size(979, 474);
            this.dgvDoc.TabIndex = 0;
            this.dgvDoc.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvDoc_CellFormatting);
            this.dgvDoc.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgv_RowsAdded);
            // 
            // 设备IDDataGridViewTextBoxColumn2
            // 
            this.设备IDDataGridViewTextBoxColumn2.DataPropertyName = "设备ID";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.设备IDDataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle9;
            this.设备IDDataGridViewTextBoxColumn2.HeaderText = "设备ID";
            this.设备IDDataGridViewTextBoxColumn2.Name = "设备IDDataGridViewTextBoxColumn2";
            this.设备IDDataGridViewTextBoxColumn2.Width = 90;
            // 
            // 总上报次数DataGridViewTextBoxColumn
            // 
            this.总上报次数DataGridViewTextBoxColumn.DataPropertyName = "总上报次数";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.总上报次数DataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle10;
            this.总上报次数DataGridViewTextBoxColumn.HeaderText = "总上报次数";
            this.总上报次数DataGridViewTextBoxColumn.Name = "总上报次数DataGridViewTextBoxColumn";
            this.总上报次数DataGridViewTextBoxColumn.Width = 85;
            // 
            // 第1天上报DataGridViewTextBoxColumn
            // 
            this.第1天上报DataGridViewTextBoxColumn.DataPropertyName = "第1天上报";
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.第1天上报DataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle11;
            this.第1天上报DataGridViewTextBoxColumn.HeaderText = "第1天上报";
            this.第1天上报DataGridViewTextBoxColumn.Name = "第1天上报DataGridViewTextBoxColumn";
            this.第1天上报DataGridViewTextBoxColumn.Width = 85;
            // 
            // 第2天上报DataGridViewTextBoxColumn
            // 
            this.第2天上报DataGridViewTextBoxColumn.DataPropertyName = "第2天上报";
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.第2天上报DataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle12;
            this.第2天上报DataGridViewTextBoxColumn.HeaderText = "第2天上报";
            this.第2天上报DataGridViewTextBoxColumn.Name = "第2天上报DataGridViewTextBoxColumn";
            this.第2天上报DataGridViewTextBoxColumn.Width = 85;
            // 
            // 第3天上报DataGridViewTextBoxColumn
            // 
            this.第3天上报DataGridViewTextBoxColumn.DataPropertyName = "第3天上报";
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.第3天上报DataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle13;
            this.第3天上报DataGridViewTextBoxColumn.HeaderText = "第3天上报";
            this.第3天上报DataGridViewTextBoxColumn.Name = "第3天上报DataGridViewTextBoxColumn";
            this.第3天上报DataGridViewTextBoxColumn.Width = 85;
            // 
            // 第4天上报DataGridViewTextBoxColumn
            // 
            this.第4天上报DataGridViewTextBoxColumn.DataPropertyName = "第4天上报";
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.第4天上报DataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle14;
            this.第4天上报DataGridViewTextBoxColumn.HeaderText = "第4天上报";
            this.第4天上报DataGridViewTextBoxColumn.Name = "第4天上报DataGridViewTextBoxColumn";
            this.第4天上报DataGridViewTextBoxColumn.Width = 85;
            // 
            // 第5天上报DataGridViewTextBoxColumn
            // 
            this.第5天上报DataGridViewTextBoxColumn.DataPropertyName = "第5天上报";
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.第5天上报DataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle15;
            this.第5天上报DataGridViewTextBoxColumn.HeaderText = "第5天上报";
            this.第5天上报DataGridViewTextBoxColumn.Name = "第5天上报DataGridViewTextBoxColumn";
            this.第5天上报DataGridViewTextBoxColumn.Width = 85;
            // 
            // 步数状态DataGridViewTextBoxColumn
            // 
            this.步数状态DataGridViewTextBoxColumn.DataPropertyName = "步数状态";
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.步数状态DataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle16;
            this.步数状态DataGridViewTextBoxColumn.HeaderText = "步数状态";
            this.步数状态DataGridViewTextBoxColumn.Name = "步数状态DataGridViewTextBoxColumn";
            this.步数状态DataGridViewTextBoxColumn.Width = 150;
            // 
            // cMenuDocs
            // 
            this.cMenuDocs.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cMenuDocs.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.导出列表ToolStripMenuItem,
            this.选择当前行设备IDToolStripMenuItem1,
            this.导入档案ToolStripMenuItem1,
            this.删除档案ToolStripMenuItem1});
            this.cMenuDocs.Name = "cMenuDocs";
            this.cMenuDocs.Size = new System.Drawing.Size(205, 100);
            this.cMenuDocs.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.cMenuDocs_ItemClicked);
            // 
            // 导出列表ToolStripMenuItem
            // 
            this.导出列表ToolStripMenuItem.Name = "导出列表ToolStripMenuItem";
            this.导出列表ToolStripMenuItem.Size = new System.Drawing.Size(204, 24);
            this.导出列表ToolStripMenuItem.Text = "导出列表";
            // 
            // 选择当前行设备IDToolStripMenuItem1
            // 
            this.选择当前行设备IDToolStripMenuItem1.Name = "选择当前行设备IDToolStripMenuItem1";
            this.选择当前行设备IDToolStripMenuItem1.Size = new System.Drawing.Size(204, 24);
            this.选择当前行设备IDToolStripMenuItem1.Text = "选择当前行-设备ID";
            // 
            // 导入档案ToolStripMenuItem1
            // 
            this.导入档案ToolStripMenuItem1.Name = "导入档案ToolStripMenuItem1";
            this.导入档案ToolStripMenuItem1.Size = new System.Drawing.Size(204, 24);
            this.导入档案ToolStripMenuItem1.Text = "导入档案";
            // 
            // 删除档案ToolStripMenuItem1
            // 
            this.删除档案ToolStripMenuItem1.Name = "删除档案ToolStripMenuItem1";
            this.删除档案ToolStripMenuItem1.Size = new System.Drawing.Size(204, 24);
            this.删除档案ToolStripMenuItem1.Text = "删除档案";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1336, 761);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.rtbMsg);
            this.Controls.Add(this.grpDates);
            this.Controls.Add(this.grpStations);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.grpDevices);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLog)).EndInit();
            this.cMenuLogs.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dsLog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbLog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbDevices)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbStations)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbDates)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbDoc)).EndInit();
            this.grpDevices.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDevice)).EndInit();
            this.cMenuDevices.ResumeLayout(false);
            this.grpStations.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStation)).EndInit();
            this.cMenuStations.ResumeLayout(false);
            this.grpDates.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDate)).EndInit();
            this.cMenuDates.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updownPagesize)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoc)).EndInit();
            this.cMenuDocs.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLog;
        private System.Data.DataSet dsLog;
        private System.Data.DataTable tbLog;
        private System.Data.DataColumn 设备ID;
        private System.Data.DataColumn 设备状态;
        private System.Data.DataColumn 设备电压;
        private System.Data.DataColumn 基站ID;
        private System.Data.DataColumn 信号量;
        private System.Data.DataColumn 步数总计;
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
        private System.Data.DataColumn tblDevices_deviceId;
        private System.Data.DataColumn tblStations_stationId;
        private System.Data.DataColumn tblDates_date;
        private System.Windows.Forms.Button btClearCurrent;
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
        private System.Windows.Forms.Button btCountMainInfo;
        private System.Windows.Forms.CheckBox chkRmSameReport;
        private System.Data.DataColumn 上报次数;
        private System.Data.DataColumn 设备个数;
        private System.Data.DataColumn 记录条数;
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
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.TextBox txtDeviceId;
        private System.Windows.Forms.TextBox txtStationId;
        private System.Windows.Forms.CheckBox chkRmSameDev;
        private System.Windows.Forms.ContextMenuStrip cMenuLogs;
        private System.Windows.Forms.ToolStripMenuItem 导出本页ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 导出所有ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 选择当前行设备IDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 选择当前行基站IDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 选择当前行日期ToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridViewTextBoxColumn 设备IDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 设备状态DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 设备电压DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 基站IDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 信号量DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 步数总计DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 时间DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 版本号DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 帧序号DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 设备IDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn 日期DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn 基站IDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.Label lbCurrDocCnt;
        private System.Windows.Forms.Button btDocImport;
        private System.Windows.Forms.DataGridView dgvDoc;
        private System.Data.DataTable tbDoc;
        private System.Data.DataColumn tblDoc_deviceId;
        private System.Data.DataColumn tblDoc_AllRptCnt;
        private System.Data.DataColumn tblDoc_RptDay1;
        private System.Data.DataColumn tblDoc_RptDay2;
        private System.Data.DataColumn tblDoc_RptDay3;
        private System.Data.DataColumn tblDoc_Day4;
        private System.Data.DataColumn tblDoc_Day5;
        private System.Data.DataColumn tblDoc_StepStatus;
        private System.Windows.Forms.Button btClearDocView;
        private System.Windows.Forms.ContextMenuStrip cMenuDocs;
        private System.Windows.Forms.ToolStripMenuItem 导出列表ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 选择当前行设备IDToolStripMenuItem1;
        private System.Windows.Forms.DataGridViewTextBoxColumn 设备IDDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn 总上报次数DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 第1天上报DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 第2天上报DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 第3天上报DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 第4天上报DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 第5天上报DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 步数状态DataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStripMenuItem dates删除记录ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 导入档案ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 删除档案ToolStripMenuItem1;
        private System.Windows.Forms.RadioButton rbtVbatMax;
        private System.Windows.Forms.RadioButton rbtVbatMin;
        private System.Windows.Forms.Button btCountDocInfo;
        private System.Windows.Forms.RadioButton rbtRptCnt;
    }
}

