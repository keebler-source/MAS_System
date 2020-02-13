namespace MAS_System_
{
    partial class sensorLog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.logToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sensorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sensorToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.sensorLogsTableAdapter1 = new MAS_System_.MAS_TEAM_3_477DataSetTableAdapters.sensorLogsTableAdapter();
            this.sensorLogsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mAS_TEAM_3_477DataSet = new MAS_System_.MAS_TEAM_3_477DataSet();
            this.alarmLogBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.alarmLogTableAdapter = new MAS_System_.MAS_TEAM_3_477DataSetTableAdapters.alarmLogTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sensorNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sensorValueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.humiditySensorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.humiditySensorTableAdapter = new MAS_System_.MAS_TEAM_3_477DataSetTableAdapters.humiditySensorTableAdapter();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.smokeSensorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.smokeSensorTableAdapter = new MAS_System_.MAS_TEAM_3_477DataSetTableAdapters.smokeSensorTableAdapter();
            this.sensorNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sensorValueDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateTimeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.tempSensorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tempSensorTableAdapter = new MAS_System_.MAS_TEAM_3_477DataSetTableAdapters.tempSensorTableAdapter();
            this.sensorNameDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sensorValueDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateTimeDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sensorLogsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mAS_TEAM_3_477DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alarmLogBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.humiditySensorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.smokeSensorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tempSensorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(48, 48);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logToolStripMenuItem,
            this.sensorToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1709, 35);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // logToolStripMenuItem
            // 
            this.logToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alramToolStripMenuItem,
            this.loginToolStripMenuItem});
            this.logToolStripMenuItem.Name = "logToolStripMenuItem";
            this.logToolStripMenuItem.Size = new System.Drawing.Size(58, 29);
            this.logToolStripMenuItem.Text = "Log";
            // 
            // alramToolStripMenuItem
            // 
            this.alramToolStripMenuItem.Name = "alramToolStripMenuItem";
            this.alramToolStripMenuItem.Size = new System.Drawing.Size(161, 34);
            this.alramToolStripMenuItem.Text = "Alram";
            this.alramToolStripMenuItem.Click += new System.EventHandler(this.alramToolStripMenuItem_Click);
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(161, 34);
            this.loginToolStripMenuItem.Text = "Login";
            this.loginToolStripMenuItem.Click += new System.EventHandler(this.loginToolStripMenuItem_Click);
            // 
            // sensorToolStripMenuItem
            // 
            this.sensorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sensorToolStripMenuItem1});
            this.sensorToolStripMenuItem.Name = "sensorToolStripMenuItem";
            this.sensorToolStripMenuItem.Size = new System.Drawing.Size(82, 29);
            this.sensorToolStripMenuItem.Text = "Sensor";
            // 
            // sensorToolStripMenuItem1
            // 
            this.sensorToolStripMenuItem1.Name = "sensorToolStripMenuItem1";
            this.sensorToolStripMenuItem1.Size = new System.Drawing.Size(168, 34);
            this.sensorToolStripMenuItem1.Text = "Sensor";
            this.sensorToolStripMenuItem1.Click += new System.EventHandler(this.sensorToolStripMenuItem1_Click);
            // 
            // sensorLogsTableAdapter1
            // 
            this.sensorLogsTableAdapter1.ClearBeforeFill = true;
            // 
            // sensorLogsBindingSource
            // 
            this.sensorLogsBindingSource.DataMember = "sensorLogs";
            this.sensorLogsBindingSource.DataSource = this.mAS_TEAM_3_477DataSet;
            // 
            // mAS_TEAM_3_477DataSet
            // 
            this.mAS_TEAM_3_477DataSet.DataSetName = "MAS_TEAM_3_477DataSet";
            this.mAS_TEAM_3_477DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // alarmLogBindingSource
            // 
            this.alarmLogBindingSource.DataMember = "alarmLog";
            this.alarmLogBindingSource.DataSource = this.mAS_TEAM_3_477DataSet;
            // 
            // alarmLogTableAdapter
            // 
            this.alarmLogTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sensorNameDataGridViewTextBoxColumn,
            this.sensorValueDataGridViewTextBoxColumn,
            this.dateTimeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.humiditySensorBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(18, 58);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(515, 622);
            this.dataGridView1.TabIndex = 1;
            // 
            // sensorNameDataGridViewTextBoxColumn
            // 
            this.sensorNameDataGridViewTextBoxColumn.DataPropertyName = "sensorName";
            this.sensorNameDataGridViewTextBoxColumn.HeaderText = "sensorName";
            this.sensorNameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.sensorNameDataGridViewTextBoxColumn.Name = "sensorNameDataGridViewTextBoxColumn";
            this.sensorNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.sensorNameDataGridViewTextBoxColumn.Width = 150;
            // 
            // sensorValueDataGridViewTextBoxColumn
            // 
            this.sensorValueDataGridViewTextBoxColumn.DataPropertyName = "sensorValue";
            this.sensorValueDataGridViewTextBoxColumn.HeaderText = "sensorValue";
            this.sensorValueDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.sensorValueDataGridViewTextBoxColumn.Name = "sensorValueDataGridViewTextBoxColumn";
            this.sensorValueDataGridViewTextBoxColumn.ReadOnly = true;
            this.sensorValueDataGridViewTextBoxColumn.Width = 150;
            // 
            // dateTimeDataGridViewTextBoxColumn
            // 
            this.dateTimeDataGridViewTextBoxColumn.DataPropertyName = "dateTime";
            this.dateTimeDataGridViewTextBoxColumn.HeaderText = "dateTime";
            this.dateTimeDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.dateTimeDataGridViewTextBoxColumn.Name = "dateTimeDataGridViewTextBoxColumn";
            this.dateTimeDataGridViewTextBoxColumn.ReadOnly = true;
            this.dateTimeDataGridViewTextBoxColumn.Width = 150;
            // 
            // humiditySensorBindingSource
            // 
            this.humiditySensorBindingSource.DataMember = "humiditySensor";
            this.humiditySensorBindingSource.DataSource = this.mAS_TEAM_3_477DataSet;
            // 
            // humiditySensorTableAdapter
            // 
            this.humiditySensorTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sensorNameDataGridViewTextBoxColumn1,
            this.sensorValueDataGridViewTextBoxColumn1,
            this.dateTimeDataGridViewTextBoxColumn1});
            this.dataGridView2.DataSource = this.smokeSensorBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(530, 58);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 62;
            this.dataGridView2.RowTemplate.Height = 28;
            this.dataGridView2.Size = new System.Drawing.Size(533, 622);
            this.dataGridView2.TabIndex = 2;
            // 
            // smokeSensorBindingSource
            // 
            this.smokeSensorBindingSource.DataMember = "smokeSensor";
            this.smokeSensorBindingSource.DataSource = this.mAS_TEAM_3_477DataSet;
            // 
            // smokeSensorTableAdapter
            // 
            this.smokeSensorTableAdapter.ClearBeforeFill = true;
            // 
            // sensorNameDataGridViewTextBoxColumn1
            // 
            this.sensorNameDataGridViewTextBoxColumn1.DataPropertyName = "sensorName";
            this.sensorNameDataGridViewTextBoxColumn1.HeaderText = "sensorName";
            this.sensorNameDataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.sensorNameDataGridViewTextBoxColumn1.Name = "sensorNameDataGridViewTextBoxColumn1";
            this.sensorNameDataGridViewTextBoxColumn1.Width = 150;
            // 
            // sensorValueDataGridViewTextBoxColumn1
            // 
            this.sensorValueDataGridViewTextBoxColumn1.DataPropertyName = "sensorValue";
            this.sensorValueDataGridViewTextBoxColumn1.HeaderText = "sensorValue";
            this.sensorValueDataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.sensorValueDataGridViewTextBoxColumn1.Name = "sensorValueDataGridViewTextBoxColumn1";
            this.sensorValueDataGridViewTextBoxColumn1.Width = 150;
            // 
            // dateTimeDataGridViewTextBoxColumn1
            // 
            this.dateTimeDataGridViewTextBoxColumn1.DataPropertyName = "dateTime";
            this.dateTimeDataGridViewTextBoxColumn1.HeaderText = "dateTime";
            this.dateTimeDataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dateTimeDataGridViewTextBoxColumn1.Name = "dateTimeDataGridViewTextBoxColumn1";
            this.dateTimeDataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sensorNameDataGridViewTextBoxColumn2,
            this.sensorValueDataGridViewTextBoxColumn2,
            this.dateTimeDataGridViewTextBoxColumn2});
            this.dataGridView3.DataSource = this.tempSensorBindingSource;
            this.dataGridView3.Location = new System.Drawing.Point(1069, 58);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.RowHeadersWidth = 62;
            this.dataGridView3.RowTemplate.Height = 28;
            this.dataGridView3.Size = new System.Drawing.Size(521, 622);
            this.dataGridView3.TabIndex = 3;
            // 
            // tempSensorBindingSource
            // 
            this.tempSensorBindingSource.DataMember = "tempSensor";
            this.tempSensorBindingSource.DataSource = this.mAS_TEAM_3_477DataSet;
            // 
            // tempSensorTableAdapter
            // 
            this.tempSensorTableAdapter.ClearBeforeFill = true;
            // 
            // sensorNameDataGridViewTextBoxColumn2
            // 
            this.sensorNameDataGridViewTextBoxColumn2.DataPropertyName = "sensorName";
            this.sensorNameDataGridViewTextBoxColumn2.HeaderText = "sensorName";
            this.sensorNameDataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.sensorNameDataGridViewTextBoxColumn2.Name = "sensorNameDataGridViewTextBoxColumn2";
            this.sensorNameDataGridViewTextBoxColumn2.ReadOnly = true;
            this.sensorNameDataGridViewTextBoxColumn2.Width = 150;
            // 
            // sensorValueDataGridViewTextBoxColumn2
            // 
            this.sensorValueDataGridViewTextBoxColumn2.DataPropertyName = "sensorValue";
            this.sensorValueDataGridViewTextBoxColumn2.HeaderText = "sensorValue";
            this.sensorValueDataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.sensorValueDataGridViewTextBoxColumn2.Name = "sensorValueDataGridViewTextBoxColumn2";
            this.sensorValueDataGridViewTextBoxColumn2.ReadOnly = true;
            this.sensorValueDataGridViewTextBoxColumn2.Width = 150;
            // 
            // dateTimeDataGridViewTextBoxColumn2
            // 
            this.dateTimeDataGridViewTextBoxColumn2.DataPropertyName = "dateTime";
            this.dateTimeDataGridViewTextBoxColumn2.HeaderText = "dateTime";
            this.dateTimeDataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.dateTimeDataGridViewTextBoxColumn2.Name = "dateTimeDataGridViewTextBoxColumn2";
            this.dateTimeDataGridViewTextBoxColumn2.ReadOnly = true;
            this.dateTimeDataGridViewTextBoxColumn2.Width = 150;
            // 
            // sensorLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1709, 692);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "sensorLog";
            this.Text = "sensorLog";
            this.Load += new System.EventHandler(this.sensorLog_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sensorLogsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mAS_TEAM_3_477DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alarmLogBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.humiditySensorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.smokeSensorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tempSensorBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem logToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alramToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sensorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sensorToolStripMenuItem1;
        private MAS_TEAM_3_477DataSetTableAdapters.sensorLogsTableAdapter sensorLogsTableAdapter1;
        private System.Windows.Forms.BindingSource sensorLogsBindingSource;
        private MAS_TEAM_3_477DataSet mAS_TEAM_3_477DataSet;
        private System.Windows.Forms.BindingSource alarmLogBindingSource;
        private MAS_TEAM_3_477DataSetTableAdapters.alarmLogTableAdapter alarmLogTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource humiditySensorBindingSource;
        private MAS_TEAM_3_477DataSetTableAdapters.humiditySensorTableAdapter humiditySensorTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn sensorNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sensorValueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource smokeSensorBindingSource;
        private MAS_TEAM_3_477DataSetTableAdapters.smokeSensorTableAdapter smokeSensorTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn sensorNameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn sensorValueDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateTimeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.BindingSource tempSensorBindingSource;
        private MAS_TEAM_3_477DataSetTableAdapters.tempSensorTableAdapter tempSensorTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn sensorNameDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn sensorValueDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateTimeDataGridViewTextBoxColumn2;
    }
}