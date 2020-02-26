namespace MAS_System_
{
    partial class alarmLog
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
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sensorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sensorToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.sensorToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.mAS_TEAM_3_477DataSet = new MAS_System_.MAS_TEAM_3_477DataSet();
            this.tableAdapterManager = new MAS_System_.MAS_TEAM_3_477DataSetTableAdapters.TableAdapterManager();
            this.alarmLogsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.alarmLogsTableAdapter = new MAS_System_.MAS_TEAM_3_477DataSetTableAdapters.alarmLogsTableAdapter();
            this.alarmLogsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mAS_TEAM_3_477DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alarmLogsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alarmLogsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logToolStripMenuItem,
            this.sensorToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(19, 6, 0, 6);
            this.menuStrip1.Size = new System.Drawing.Size(1849, 64);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // logToolStripMenuItem
            // 
            this.logToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loginToolStripMenuItem,
            this.sensorToolStripMenuItem});
            this.logToolStripMenuItem.Name = "logToolStripMenuItem";
            this.logToolStripMenuItem.Size = new System.Drawing.Size(107, 52);
            this.logToolStripMenuItem.Text = "Log";
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(325, 66);
            this.loginToolStripMenuItem.Text = "Login";
            this.loginToolStripMenuItem.Click += new System.EventHandler(this.loginToolStripMenuItem_Click);
            // 
            // sensorToolStripMenuItem
            // 
            this.sensorToolStripMenuItem.Name = "sensorToolStripMenuItem";
            this.sensorToolStripMenuItem.Size = new System.Drawing.Size(325, 66);
            this.sensorToolStripMenuItem.Text = "Sensor";
            this.sensorToolStripMenuItem.Click += new System.EventHandler(this.sensorToolStripMenuItem_Click);
            // 
            // sensorToolStripMenuItem1
            // 
            this.sensorToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sensorToolStripMenuItem2});
            this.sensorToolStripMenuItem1.Name = "sensorToolStripMenuItem1";
            this.sensorToolStripMenuItem1.Size = new System.Drawing.Size(155, 52);
            this.sensorToolStripMenuItem1.Text = "Sensor";
            // 
            // sensorToolStripMenuItem2
            // 
            this.sensorToolStripMenuItem2.Name = "sensorToolStripMenuItem2";
            this.sensorToolStripMenuItem2.Size = new System.Drawing.Size(325, 66);
            this.sensorToolStripMenuItem2.Text = "Sensor";
            this.sensorToolStripMenuItem2.Click += new System.EventHandler(this.sensorToolStripMenuItem2_Click);
            // 
            // mAS_TEAM_3_477DataSet
            // 
            this.mAS_TEAM_3_477DataSet.DataSetName = "MAS_TEAM_3_477DataSet";
            this.mAS_TEAM_3_477DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.alarmLogsTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.humiditySensorTableAdapter = null;
            this.tableAdapterManager.loginLogTableAdapter = null;
            this.tableAdapterManager.sensorLogsTableAdapter = null;
            this.tableAdapterManager.smokeSensorTableAdapter = null;
            this.tableAdapterManager.tempSensorTableAdapter = null;
            this.tableAdapterManager.thresholdTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = MAS_System_.MAS_TEAM_3_477DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.usersTableAdapter = null;
            // 
            // alarmLogsBindingSource
            // 
            this.alarmLogsBindingSource.DataMember = "alarmLogs";
            this.alarmLogsBindingSource.DataSource = this.mAS_TEAM_3_477DataSet;
            // 
            // alarmLogsTableAdapter
            // 
            this.alarmLogsTableAdapter.ClearBeforeFill = true;
            // 
            // alarmLogsDataGridView
            // 
            this.alarmLogsDataGridView.AllowUserToAddRows = false;
            this.alarmLogsDataGridView.AllowUserToDeleteRows = false;
            this.alarmLogsDataGridView.AutoGenerateColumns = false;
            this.alarmLogsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.alarmLogsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.alarmLogsDataGridView.DataSource = this.alarmLogsBindingSource;
            this.alarmLogsDataGridView.Location = new System.Drawing.Point(21, 78);
            this.alarmLogsDataGridView.Name = "alarmLogsDataGridView";
            this.alarmLogsDataGridView.ReadOnly = true;
            this.alarmLogsDataGridView.RowHeadersWidth = 123;
            this.alarmLogsDataGridView.RowTemplate.Height = 46;
            this.alarmLogsDataGridView.Size = new System.Drawing.Size(1633, 736);
            this.alarmLogsDataGridView.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "sensorName";
            this.dataGridViewTextBoxColumn2.HeaderText = "Sensor";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 15;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 300;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "sensorVaule";
            this.dataGridViewTextBoxColumn3.HeaderText = "Vaule";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 15;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 300;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "threshold";
            this.dataGridViewTextBoxColumn4.HeaderText = "Threshold";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 15;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 300;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "dateTime";
            this.dataGridViewTextBoxColumn5.HeaderText = "Date & Time";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 15;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 300;
            // 
            // alarmLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1849, 1280);
            this.Controls.Add(this.alarmLogsDataGridView);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.Name = "alarmLog";
            this.Text = "alarmLog";
            this.Load += new System.EventHandler(this.alarmLog_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mAS_TEAM_3_477DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alarmLogsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alarmLogsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem logToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sensorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sensorToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem sensorToolStripMenuItem2;
        private MAS_TEAM_3_477DataSet mAS_TEAM_3_477DataSet;
        private MAS_TEAM_3_477DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource alarmLogsBindingSource;
        private MAS_TEAM_3_477DataSetTableAdapters.alarmLogsTableAdapter alarmLogsTableAdapter;
        private System.Windows.Forms.DataGridView alarmLogsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}