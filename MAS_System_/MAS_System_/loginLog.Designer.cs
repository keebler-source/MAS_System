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
            this.loginLogBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.loginLogBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.loginLogBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.mAS_TEAM_3_477DataSet = new MAS_System_.MAS_TEAM_3_477DataSet();
            this.loginLogTableAdapter1 = new MAS_System_.MAS_TEAM_3_477DataSetTableAdapters.loginLogTableAdapter();
            this.mASTEAM3477DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.mAS_TEAM_3_477DataSet1 = new MAS_System_.MAS_TEAM_3_477DataSet();
            this.thresholdBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.thresholdTableAdapter = new MAS_System_.MAS_TEAM_3_477DataSetTableAdapters.thresholdTableAdapter();
            this.loginLogBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loginLogBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginLogBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginLogBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mAS_TEAM_3_477DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mASTEAM3477DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mAS_TEAM_3_477DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thresholdBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginLogBindingSource3)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(48, 48);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logsToolStripMenuItem,
            this.sensorToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(19, 6, 0, 6);
            this.menuStrip1.Size = new System.Drawing.Size(1923, 72);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // logsToolStripMenuItem
            // 
            this.logsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sensorToolStripMenuItem1,
            this.alarmToolStripMenuItem});
            this.logsToolStripMenuItem.Name = "logsToolStripMenuItem";
            this.logsToolStripMenuItem.Size = new System.Drawing.Size(122, 52);
            this.logsToolStripMenuItem.Text = "Logs";
            // 
            // sensorToolStripMenuItem1
            // 
            this.sensorToolStripMenuItem1.Name = "sensorToolStripMenuItem1";
            this.sensorToolStripMenuItem1.Size = new System.Drawing.Size(325, 66);
            this.sensorToolStripMenuItem1.Text = "Sensor";
            this.sensorToolStripMenuItem1.Click += new System.EventHandler(this.sensorToolStripMenuItem1_Click);
            // 
            // alarmToolStripMenuItem
            // 
            this.alarmToolStripMenuItem.Name = "alarmToolStripMenuItem";
            this.alarmToolStripMenuItem.Size = new System.Drawing.Size(325, 66);
            this.alarmToolStripMenuItem.Text = "Alarm";
            this.alarmToolStripMenuItem.Click += new System.EventHandler(this.alarmToolStripMenuItem_Click);
            // 
            // sensorToolStripMenuItem
            // 
            this.sensorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.senorToolStripMenuItem});
            this.sensorToolStripMenuItem.Name = "sensorToolStripMenuItem";
            this.sensorToolStripMenuItem.Size = new System.Drawing.Size(155, 52);
            this.sensorToolStripMenuItem.Text = "Sensor";
            // 
            // senorToolStripMenuItem
            // 
            this.senorToolStripMenuItem.Name = "senorToolStripMenuItem";
            this.senorToolStripMenuItem.Size = new System.Drawing.Size(310, 66);
            this.senorToolStripMenuItem.Text = "Senor";
            this.senorToolStripMenuItem.Click += new System.EventHandler(this.senorToolStripMenuItem_Click);
            // 
            // loginLogBindingSource
            // 
            this.loginLogBindingSource.DataMember = "loginLog";
            this.loginLogBindingSource.DataSource = this.mASTEAM3477DataSetBindingSource;
            // 
            // loginLogBindingSource1
            // 
            this.loginLogBindingSource1.DataMember = "loginLog";
            this.loginLogBindingSource1.DataSource = this.mASTEAM3477DataSetBindingSource;
            // 
            // loginLogBindingSource2
            // 
            this.loginLogBindingSource2.DataMember = "loginLog";
            this.loginLogBindingSource2.DataSource = this.mAS_TEAM_3_477DataSet;
            // 
            // mAS_TEAM_3_477DataSet
            // 
            this.mAS_TEAM_3_477DataSet.DataSetName = "MAS_TEAM_3_477DataSet";
            this.mAS_TEAM_3_477DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // loginLogTableAdapter1
            // 
            this.loginLogTableAdapter1.ClearBeforeFill = true;
            // 
            // mASTEAM3477DataSetBindingSource
            // 
            this.mASTEAM3477DataSetBindingSource.DataSource = this.mAS_TEAM_3_477DataSet;
            this.mASTEAM3477DataSetBindingSource.Position = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.username,
            this.dateTime});
            this.dataGridView1.DataSource = this.loginLogBindingSource3;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(0, 72);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 123;
            this.dataGridView1.RowTemplate.Height = 46;
            this.dataGridView1.Size = new System.Drawing.Size(1923, 736);
            this.dataGridView1.TabIndex = 1;
            // 
            // mAS_TEAM_3_477DataSet1
            // 
            this.mAS_TEAM_3_477DataSet1.DataSetName = "MAS_TEAM_3_477DataSet";
            this.mAS_TEAM_3_477DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // thresholdBindingSource
            // 
            this.thresholdBindingSource.DataMember = "threshold";
            this.thresholdBindingSource.DataSource = this.mAS_TEAM_3_477DataSet1;
            // 
            // thresholdTableAdapter
            // 
            this.thresholdTableAdapter.ClearBeforeFill = true;
            // 
            // loginLogBindingSource3
            // 
            this.loginLogBindingSource3.DataMember = "loginLog";
            this.loginLogBindingSource3.DataSource = this.mAS_TEAM_3_477DataSet1;
            // 
            // username
            // 
            this.username.DataPropertyName = "username";
            this.username.HeaderText = "User Name";
            this.username.MinimumWidth = 15;
            this.username.Name = "username";
            this.username.ReadOnly = true;
            this.username.Width = 300;
            // 
            // dateTime
            // 
            this.dateTime.DataPropertyName = "dateTime";
            this.dateTime.HeaderText = "Data";
            this.dateTime.MinimumWidth = 15;
            this.dateTime.Name = "dateTime";
            this.dateTime.ReadOnly = true;
            this.dateTime.Width = 300;
            // 
            // loginLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1923, 1051);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(11, 9, 11, 9);
            this.Name = "loginLog";
            this.Text = "loginLog";
            this.Load += new System.EventHandler(this.loginLog_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loginLogBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginLogBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginLogBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mAS_TEAM_3_477DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mASTEAM3477DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mAS_TEAM_3_477DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thresholdBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginLogBindingSource3)).EndInit();
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
        private System.Windows.Forms.BindingSource loginLogBindingSource;
        private System.Windows.Forms.BindingSource mASTEAM3477DataSetBindingSource;
        private MAS_TEAM_3_477DataSet mAS_TEAM_3_477DataSet;
        private System.Windows.Forms.BindingSource loginLogBindingSource1;
        private System.Windows.Forms.BindingSource loginLogBindingSource2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MAS_TEAM_3_477DataSet mAS_TEAM_3_477DataSet1;
        private System.Windows.Forms.BindingSource thresholdBindingSource;
        private MAS_TEAM_3_477DataSetTableAdapters.thresholdTableAdapter thresholdTableAdapter;
        private System.Windows.Forms.BindingSource loginLogBindingSource3;
        private System.Windows.Forms.DataGridViewTextBoxColumn username;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateTime;
    }
}