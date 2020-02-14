namespace MAS_System_
{
    partial class loginLog
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
            this.logsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sensorToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.alarmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sensorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.senorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginLogTableAdapter1 = new MAS_System_.MAS_TEAM_3_477DataSetTableAdapters.loginLogTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.loginLogBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mASTEAM3477DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mAS_TEAM_3_477DataSet = new MAS_System_.MAS_TEAM_3_477DataSet();
            this.usernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginLogBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mASTEAM3477DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mAS_TEAM_3_477DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(48, 48);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logsToolStripMenuItem,
            this.sensorToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(911, 35);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // logsToolStripMenuItem
            // 
            this.logsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sensorToolStripMenuItem1,
            this.alarmToolStripMenuItem});
            this.logsToolStripMenuItem.Name = "logsToolStripMenuItem";
            this.logsToolStripMenuItem.Size = new System.Drawing.Size(66, 29);
            this.logsToolStripMenuItem.Text = "Logs";
            // 
            // sensorToolStripMenuItem1
            // 
            this.sensorToolStripMenuItem1.Name = "sensorToolStripMenuItem1";
            this.sensorToolStripMenuItem1.Size = new System.Drawing.Size(168, 34);
            this.sensorToolStripMenuItem1.Text = "Sensor";
            this.sensorToolStripMenuItem1.Click += new System.EventHandler(this.sensorToolStripMenuItem1_Click);
            // 
            // alarmToolStripMenuItem
            // 
            this.alarmToolStripMenuItem.Name = "alarmToolStripMenuItem";
            this.alarmToolStripMenuItem.Size = new System.Drawing.Size(168, 34);
            this.alarmToolStripMenuItem.Text = "Alarm";
            this.alarmToolStripMenuItem.Click += new System.EventHandler(this.alarmToolStripMenuItem_Click);
            // 
            // sensorToolStripMenuItem
            // 
            this.sensorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.senorToolStripMenuItem});
            this.sensorToolStripMenuItem.Name = "sensorToolStripMenuItem";
            this.sensorToolStripMenuItem.Size = new System.Drawing.Size(82, 29);
            this.sensorToolStripMenuItem.Text = "Sensor";
            // 
            // senorToolStripMenuItem
            // 
            this.senorToolStripMenuItem.Name = "senorToolStripMenuItem";
            this.senorToolStripMenuItem.Size = new System.Drawing.Size(160, 34);
            this.senorToolStripMenuItem.Text = "Senor";
            this.senorToolStripMenuItem.Click += new System.EventHandler(this.senorToolStripMenuItem_Click);
            // 
            // loginLogTableAdapter1
            // 
            this.loginLogTableAdapter1.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.usernameDataGridViewTextBoxColumn,
            this.dateTimeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.loginLogBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(13, 42);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 123;
            this.dataGridView1.RowTemplate.Height = 46;
            this.dataGridView1.Size = new System.Drawing.Size(724, 398);
            this.dataGridView1.TabIndex = 1;
            // 
            // loginLogBindingSource
            // 
            this.loginLogBindingSource.DataMember = "loginLog";
            this.loginLogBindingSource.DataSource = this.mASTEAM3477DataSetBindingSource;
            // 
            // mASTEAM3477DataSetBindingSource
            // 
            this.mASTEAM3477DataSetBindingSource.DataSource = this.mAS_TEAM_3_477DataSet;
            this.mASTEAM3477DataSetBindingSource.Position = 0;
            // 
            // mAS_TEAM_3_477DataSet
            // 
            this.mAS_TEAM_3_477DataSet.DataSetName = "MAS_TEAM_3_477DataSet";
            this.mAS_TEAM_3_477DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usernameDataGridViewTextBoxColumn
            // 
            this.usernameDataGridViewTextBoxColumn.DataPropertyName = "User Name";
            this.usernameDataGridViewTextBoxColumn.HeaderText = "username";
            this.usernameDataGridViewTextBoxColumn.MinimumWidth = 15;
            this.usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            this.usernameDataGridViewTextBoxColumn.ReadOnly = true;
            this.usernameDataGridViewTextBoxColumn.Width = 300;
            // 
            // dateTimeDataGridViewTextBoxColumn
            // 
            this.dateTimeDataGridViewTextBoxColumn.DataPropertyName = "Date / Time";
            this.dateTimeDataGridViewTextBoxColumn.HeaderText = "dateTime";
            this.dateTimeDataGridViewTextBoxColumn.MinimumWidth = 15;
            this.dateTimeDataGridViewTextBoxColumn.Name = "dateTimeDataGridViewTextBoxColumn";
            this.dateTimeDataGridViewTextBoxColumn.ReadOnly = true;
            this.dateTimeDataGridViewTextBoxColumn.Width = 300;
            // 
            // loginLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 568);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "loginLog";
            this.Text = "loginLog";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginLogBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mASTEAM3477DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mAS_TEAM_3_477DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem logsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sensorToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem alarmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sensorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem senorToolStripMenuItem;
        private MAS_TEAM_3_477DataSetTableAdapters.loginLogTableAdapter loginLogTableAdapter1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource loginLogBindingSource;
        private System.Windows.Forms.BindingSource mASTEAM3477DataSetBindingSource;
        private MAS_TEAM_3_477DataSet mAS_TEAM_3_477DataSet;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateTimeDataGridViewTextBoxColumn;
    }
}