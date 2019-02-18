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
            this.序号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.设备IDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.设备状态DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.设备电压DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.基站IDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.信号量DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.步数总计DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.时间DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.版本号DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btImport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbLog)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvLog
            // 
            this.dgvLog.AllowUserToAddRows = false;
            this.dgvLog.AllowUserToDeleteRows = false;
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
            this.版本号DataGridViewTextBoxColumn});
            this.dgvLog.DataMember = "Table1";
            this.dgvLog.DataSource = this.dsLog;
            this.dgvLog.Location = new System.Drawing.Point(0, 68);
            this.dgvLog.Name = "dgvLog";
            this.dgvLog.RowHeadersVisible = false;
            this.dgvLog.RowTemplate.Height = 23;
            this.dgvLog.Size = new System.Drawing.Size(889, 411);
            this.dgvLog.TabIndex = 0;
            // 
            // dsLog
            // 
            this.dsLog.DataSetName = "NewDataSet";
            this.dsLog.Tables.AddRange(new System.Data.DataTable[] {
            this.tbLog});
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
            this.版本号});
            this.tbLog.TableName = "Table1";
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
            // btImport
            // 
            this.btImport.Location = new System.Drawing.Point(12, 12);
            this.btImport.Name = "btImport";
            this.btImport.Size = new System.Drawing.Size(100, 23);
            this.btImport.TabIndex = 1;
            this.btImport.Text = "导入日志文件";
            this.btImport.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 479);
            this.Controls.Add(this.btImport);
            this.Controls.Add(this.dgvLog);
            this.Name = "FormMain";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvLog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbLog)).EndInit();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.DataGridViewTextBoxColumn 序号;
        private System.Windows.Forms.DataGridViewTextBoxColumn 设备IDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 设备状态DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 设备电压DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 基站IDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 信号量DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 步数总计DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 时间DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 版本号DataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btImport;
    }
}

