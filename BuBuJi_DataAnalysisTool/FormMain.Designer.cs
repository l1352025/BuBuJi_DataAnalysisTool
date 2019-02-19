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
            this.btImport = new System.Windows.Forms.Button();
            this.openFileDlg = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDlg = new System.Windows.Forms.SaveFileDialog();
            this.btQuery = new System.Windows.Forms.Button();
            this.btClearAll = new System.Windows.Forms.Button();
            this.帧序号 = new System.Data.DataColumn();
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
            this.grpDevices = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lbResultCnt = new System.Windows.Forms.Label();
            this.btPagePrev = new System.Windows.Forms.Button();
            this.btPageNext = new System.Windows.Forms.Button();
            this.txtCurrPageNum = new System.Windows.Forms.TextBox();
            this.lbPageCnt = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.rtbMsg = new System.Windows.Forms.RichTextBox();
            this.tbDevices = new System.Data.DataTable();
            this.tbStations = new System.Data.DataTable();
            this.tbDates = new System.Data.DataTable();
            this.deviceId = new System.Data.DataColumn();
            this.stationId = new System.Data.DataColumn();
            this.date = new System.Data.DataColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbLog)).BeginInit();
            this.grpDevices.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbDevices)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbStations)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbDates)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
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
            this.dgvLog.Location = new System.Drawing.Point(207, 68);
            this.dgvLog.Name = "dgvLog";
            this.dgvLog.RowHeadersVisible = false;
            this.dgvLog.RowTemplate.Height = 23;
            this.dgvLog.Size = new System.Drawing.Size(682, 399);
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
            this.id.ColumnName = "id";
            this.id.DataType = typeof(int);
            // 
            // 设备ID
            // 
            this.设备ID.ColumnName = "设备ID";
            // 
            // 设备状态
            // 
            this.设备状态.ColumnName = "设备状态";
            // 
            // 设备电压
            // 
            this.设备电压.ColumnName = "设备电压";
            // 
            // 基站ID
            // 
            this.基站ID.ColumnName = "基站ID";
            // 
            // 信号量
            // 
            this.信号量.ColumnName = "信号量";
            // 
            // 步数总计
            // 
            this.步数总计.ColumnName = "步数总计";
            // 
            // 时间
            // 
            this.时间.ColumnName = "时间";
            // 
            // 版本号
            // 
            this.版本号.ColumnName = "版本号";
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
            this.btQuery.Location = new System.Drawing.Point(709, 17);
            this.btQuery.Name = "btQuery";
            this.btQuery.Size = new System.Drawing.Size(58, 23);
            this.btQuery.TabIndex = 1;
            this.btQuery.Text = "查询";
            this.btQuery.UseVisualStyleBackColor = true;
            this.btQuery.Click += new System.EventHandler(this.btQuery_Click);
            // 
            // btClearAll
            // 
            this.btClearAll.Location = new System.Drawing.Point(804, 17);
            this.btClearAll.Name = "btClearAll";
            this.btClearAll.Size = new System.Drawing.Size(76, 23);
            this.btClearAll.TabIndex = 1;
            this.btClearAll.Text = "删除数据库";
            this.btClearAll.UseVisualStyleBackColor = true;
            this.btClearAll.Click += new System.EventHandler(this.btClearAll_Click);
            // 
            // 帧序号
            // 
            this.帧序号.ColumnName = "帧序号";
            // 
            // 序号
            // 
            this.序号.HeaderText = "序号";
            this.序号.Name = "序号";
            this.序号.Width = 50;
            // 
            // 设备IDDataGridViewTextBoxColumn
            // 
            this.设备IDDataGridViewTextBoxColumn.DataPropertyName = "设备ID";
            this.设备IDDataGridViewTextBoxColumn.HeaderText = "设备ID";
            this.设备IDDataGridViewTextBoxColumn.Name = "设备IDDataGridViewTextBoxColumn";
            this.设备IDDataGridViewTextBoxColumn.Width = 80;
            // 
            // 设备状态DataGridViewTextBoxColumn
            // 
            this.设备状态DataGridViewTextBoxColumn.DataPropertyName = "设备状态";
            this.设备状态DataGridViewTextBoxColumn.HeaderText = "设备状态";
            this.设备状态DataGridViewTextBoxColumn.Name = "设备状态DataGridViewTextBoxColumn";
            this.设备状态DataGridViewTextBoxColumn.Width = 60;
            // 
            // 设备电压DataGridViewTextBoxColumn
            // 
            this.设备电压DataGridViewTextBoxColumn.DataPropertyName = "设备电压";
            this.设备电压DataGridViewTextBoxColumn.HeaderText = "设备电压";
            this.设备电压DataGridViewTextBoxColumn.Name = "设备电压DataGridViewTextBoxColumn";
            this.设备电压DataGridViewTextBoxColumn.Width = 60;
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
            this.信号量DataGridViewTextBoxColumn.Width = 50;
            // 
            // 步数总计DataGridViewTextBoxColumn
            // 
            this.步数总计DataGridViewTextBoxColumn.DataPropertyName = "步数总计";
            this.步数总计DataGridViewTextBoxColumn.HeaderText = "步数总计";
            this.步数总计DataGridViewTextBoxColumn.Name = "步数总计DataGridViewTextBoxColumn";
            this.步数总计DataGridViewTextBoxColumn.Width = 60;
            // 
            // 时间DataGridViewTextBoxColumn
            // 
            this.时间DataGridViewTextBoxColumn.DataPropertyName = "时间";
            this.时间DataGridViewTextBoxColumn.HeaderText = "时间";
            this.时间DataGridViewTextBoxColumn.Name = "时间DataGridViewTextBoxColumn";
            this.时间DataGridViewTextBoxColumn.Width = 120;
            // 
            // 版本号DataGridViewTextBoxColumn
            // 
            this.版本号DataGridViewTextBoxColumn.DataPropertyName = "版本号";
            this.版本号DataGridViewTextBoxColumn.HeaderText = "版本号";
            this.版本号DataGridViewTextBoxColumn.Name = "版本号DataGridViewTextBoxColumn";
            this.版本号DataGridViewTextBoxColumn.Width = 50;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "帧序号";
            this.dataGridViewTextBoxColumn1.HeaderText = "帧序号";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 50;
            // 
            // grpDevices
            // 
            this.grpDevices.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.grpDevices.Controls.Add(this.dataGridView1);
            this.grpDevices.Location = new System.Drawing.Point(6, 393);
            this.grpDevices.Name = "grpDevices";
            this.grpDevices.Size = new System.Drawing.Size(195, 210);
            this.grpDevices.TabIndex = 2;
            this.grpDevices.TabStop = false;
            this.grpDevices.Text = "设备列表 【**】";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView2);
            this.groupBox1.Location = new System.Drawing.Point(6, 207);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(195, 183);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "基站列表 【**】";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView3);
            this.groupBox2.Location = new System.Drawing.Point(6, 68);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(195, 133);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "统计天数 【**】";
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
            this.groupBox3.Location = new System.Drawing.Point(0, -6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(889, 68);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // lbResultCnt
            // 
            this.lbResultCnt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbResultCnt.AutoSize = true;
            this.lbResultCnt.Location = new System.Drawing.Point(205, 479);
            this.lbResultCnt.Name = "lbResultCnt";
            this.lbResultCnt.Size = new System.Drawing.Size(191, 12);
            this.lbResultCnt.TabIndex = 3;
            this.lbResultCnt.Text = "当前结果：总数 ** 条， 共 ** 页";
            // 
            // btPagePrev
            // 
            this.btPagePrev.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btPagePrev.Font = new System.Drawing.Font("宋体", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btPagePrev.Location = new System.Drawing.Point(478, 476);
            this.btPagePrev.Name = "btPagePrev";
            this.btPagePrev.Size = new System.Drawing.Size(53, 18);
            this.btPagePrev.TabIndex = 4;
            this.btPagePrev.Text = "上一页";
            this.btPagePrev.UseVisualStyleBackColor = true;
            // 
            // btPageNext
            // 
            this.btPageNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btPageNext.Font = new System.Drawing.Font("宋体", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btPageNext.Location = new System.Drawing.Point(655, 476);
            this.btPageNext.Name = "btPageNext";
            this.btPageNext.Size = new System.Drawing.Size(53, 18);
            this.btPageNext.TabIndex = 4;
            this.btPageNext.Text = "下一页";
            this.btPageNext.UseVisualStyleBackColor = true;
            // 
            // txtCurrPageNum
            // 
            this.txtCurrPageNum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtCurrPageNum.Location = new System.Drawing.Point(548, 473);
            this.txtCurrPageNum.Name = "txtCurrPageNum";
            this.txtCurrPageNum.Size = new System.Drawing.Size(45, 21);
            this.txtCurrPageNum.TabIndex = 5;
            // 
            // lbPageCnt
            // 
            this.lbPageCnt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbPageCnt.AutoSize = true;
            this.lbPageCnt.Location = new System.Drawing.Point(599, 479);
            this.lbPageCnt.Name = "lbPageCnt";
            this.lbPageCnt.Size = new System.Drawing.Size(35, 12);
            this.lbPageCnt.TabIndex = 6;
            this.lbPageCnt.Text = "/ ***";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(201, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "日期";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(236, 17);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 21);
            this.textBox1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(352, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "设备ID";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(399, 17);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 21);
            this.textBox2.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(521, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "基站ID";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(568, 17);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 21);
            this.textBox3.TabIndex = 3;
            // 
            // rtbMsg
            // 
            this.rtbMsg.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbMsg.Location = new System.Drawing.Point(207, 501);
            this.rtbMsg.Name = "rtbMsg";
            this.rtbMsg.Size = new System.Drawing.Size(682, 102);
            this.rtbMsg.TabIndex = 7;
            this.rtbMsg.Text = "";
            // 
            // tbDevices
            // 
            this.tbDevices.Columns.AddRange(new System.Data.DataColumn[] {
            this.deviceId});
            this.tbDevices.TableName = "tblDevices";
            // 
            // tbStations
            // 
            this.tbStations.Columns.AddRange(new System.Data.DataColumn[] {
            this.stationId});
            this.tbStations.TableName = "tblStations";
            // 
            // tbDates
            // 
            this.tbDates.Columns.AddRange(new System.Data.DataColumn[] {
            this.date});
            this.tbDates.TableName = "tblDates";
            // 
            // deviceId
            // 
            this.deviceId.ColumnName = "deviceId";
            this.deviceId.DataType = typeof(int);
            // 
            // stationId
            // 
            this.stationId.ColumnName = "stationId";
            this.stationId.DataType = typeof(int);
            // 
            // date
            // 
            this.date.ColumnName = "date";
            this.date.DataType = typeof(System.DateTime);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 20);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(195, 190);
            this.dataGridView1.TabIndex = 0;
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(0, 20);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 23;
            this.dataGridView2.Size = new System.Drawing.Size(195, 157);
            this.dataGridView2.TabIndex = 0;
            // 
            // dataGridView3
            // 
            this.dataGridView3.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(0, 20);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowTemplate.Height = 23;
            this.dataGridView3.Size = new System.Drawing.Size(195, 107);
            this.dataGridView3.TabIndex = 0;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 609);
            this.Controls.Add(this.rtbMsg);
            this.Controls.Add(this.lbPageCnt);
            this.Controls.Add(this.txtCurrPageNum);
            this.Controls.Add(this.btPageNext);
            this.Controls.Add(this.btPagePrev);
            this.Controls.Add(this.lbResultCnt);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.grpDevices);
            this.Controls.Add(this.dgvLog);
            this.Name = "FormMain";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvLog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbLog)).EndInit();
            this.grpDevices.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbDevices)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbStations)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbDates)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
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
        private System.Data.DataColumn 帧序号;
        private System.Windows.Forms.Button btQuery;
        private System.Windows.Forms.Button btClearAll;
        private System.Windows.Forms.GroupBox grpDevices;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
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
        private System.Windows.Forms.TextBox txtCurrPageNum;
        private System.Windows.Forms.Label lbPageCnt;
        private System.Windows.Forms.RichTextBox rtbMsg;
        private System.Data.DataTable tbDevices;
        private System.Data.DataColumn deviceId;
        private System.Data.DataTable tbStations;
        private System.Data.DataColumn stationId;
        private System.Data.DataTable tbDates;
        private System.Data.DataColumn date;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView3;
    }
}

