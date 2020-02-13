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
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sensorLogsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mAS_TEAM_3_477DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alarmLogBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(48, 48);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logToolStripMenuItem,
            this.sensorToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(19, 6, 0, 6);
            this.menuStrip1.Size = new System.Drawing.Size(2533, 69);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // logToolStripMenuItem
            // 
            this.logToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alramToolStripMenuItem,
            this.loginToolStripMenuItem});
            this.logToolStripMenuItem.Name = "logToolStripMenuItem";
            this.logToolStripMenuItem.Size = new System.Drawing.Size(107, 52);
            this.logToolStripMenuItem.Text = "Log";
            // 
            // alramToolStripMenuItem
            // 
            this.alramToolStripMenuItem.Name = "alramToolStripMenuItem";
            this.alramToolStripMenuItem.Size = new System.Drawing.Size(312, 66);
            this.alramToolStripMenuItem.Text = "Alram";
            this.alramToolStripMenuItem.Click += new System.EventHandler(this.alramToolStripMenuItem_Click);
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(312, 66);
            this.loginToolStripMenuItem.Text = "Login";
            this.loginToolStripMenuItem.Click += new System.EventHandler(this.loginToolStripMenuItem_Click);
            // 
            // sensorToolStripMenuItem
            // 
            this.sensorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sensorToolStripMenuItem1});
            this.sensorToolStripMenuItem.Name = "sensorToolStripMenuItem";
            this.sensorToolStripMenuItem.Size = new System.Drawing.Size(155, 52);
            this.sensorToolStripMenuItem.Text = "Sensor";
            // 
            // sensorToolStripMenuItem1
            // 
            this.sensorToolStripMenuItem1.Name = "sensorToolStripMenuItem1";
            this.sensorToolStripMenuItem1.Size = new System.Drawing.Size(325, 66);
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
            // sensorLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2533, 1281);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.Name = "sensorLog";
            this.Text = "sensorLog";
            this.Load += new System.EventHandler(this.sensorLog_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sensorLogsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mAS_TEAM_3_477DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alarmLogBindingSource)).EndInit();
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
    }
}