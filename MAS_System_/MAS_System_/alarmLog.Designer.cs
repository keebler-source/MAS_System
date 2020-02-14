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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.mAS_TEAM_3_477DataSet = new MAS_System_.MAS_TEAM_3_477DataSet();
            this.alarmLogBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.alarmLogTableAdapter = new MAS_System_.MAS_TEAM_3_477DataSetTableAdapters.alarmLogTableAdapter();
            this.sensorNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sensorVauleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thresholdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mAS_TEAM_3_477DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alarmLogBindingSource)).BeginInit();
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
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(664, 35);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // logToolStripMenuItem
            // 
            this.logToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loginToolStripMenuItem,
            this.sensorToolStripMenuItem});
            this.logToolStripMenuItem.Name = "logToolStripMenuItem";
            this.logToolStripMenuItem.Size = new System.Drawing.Size(58, 29);
            this.logToolStripMenuItem.Text = "Log";
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(168, 34);
            this.loginToolStripMenuItem.Text = "Login";
            this.loginToolStripMenuItem.Click += new System.EventHandler(this.loginToolStripMenuItem_Click);
            // 
            // sensorToolStripMenuItem
            // 
            this.sensorToolStripMenuItem.Name = "sensorToolStripMenuItem";
            this.sensorToolStripMenuItem.Size = new System.Drawing.Size(168, 34);
            this.sensorToolStripMenuItem.Text = "Sensor";
            this.sensorToolStripMenuItem.Click += new System.EventHandler(this.sensorToolStripMenuItem_Click);
            // 
            // sensorToolStripMenuItem1
            // 
            this.sensorToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sensorToolStripMenuItem2});
            this.sensorToolStripMenuItem1.Name = "sensorToolStripMenuItem1";
            this.sensorToolStripMenuItem1.Size = new System.Drawing.Size(82, 29);
            this.sensorToolStripMenuItem1.Text = "Sensor";
            // 
            // sensorToolStripMenuItem2
            // 
            this.sensorToolStripMenuItem2.Name = "sensorToolStripMenuItem2";
            this.sensorToolStripMenuItem2.Size = new System.Drawing.Size(168, 34);
            this.sensorToolStripMenuItem2.Text = "Sensor";
            this.sensorToolStripMenuItem2.Click += new System.EventHandler(this.sensorToolStripMenuItem2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sensorNameDataGridViewTextBoxColumn,
            this.sensorVauleDataGridViewTextBoxColumn,
            this.thresholdDataGridViewTextBoxColumn,
            this.dateTimeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.alarmLogBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 38);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(664, 651);
            this.dataGridView1.TabIndex = 1;
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
            // sensorNameDataGridViewTextBoxColumn
            // 
            this.sensorNameDataGridViewTextBoxColumn.DataPropertyName = "sensorName";
            this.sensorNameDataGridViewTextBoxColumn.HeaderText = "Sensor";
            this.sensorNameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.sensorNameDataGridViewTextBoxColumn.Name = "sensorNameDataGridViewTextBoxColumn";
            this.sensorNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.sensorNameDataGridViewTextBoxColumn.Width = 150;
            // 
            // sensorVauleDataGridViewTextBoxColumn
            // 
            this.sensorVauleDataGridViewTextBoxColumn.DataPropertyName = "sensorVaule";
            this.sensorVauleDataGridViewTextBoxColumn.HeaderText = "sensorVaule";
            this.sensorVauleDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.sensorVauleDataGridViewTextBoxColumn.Name = "sensorVauleDataGridViewTextBoxColumn";
            this.sensorVauleDataGridViewTextBoxColumn.ReadOnly = true;
            this.sensorVauleDataGridViewTextBoxColumn.Width = 150;
            // 
            // thresholdDataGridViewTextBoxColumn
            // 
            this.thresholdDataGridViewTextBoxColumn.DataPropertyName = "threshold";
            this.thresholdDataGridViewTextBoxColumn.HeaderText = "threshold";
            this.thresholdDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.thresholdDataGridViewTextBoxColumn.Name = "thresholdDataGridViewTextBoxColumn";
            this.thresholdDataGridViewTextBoxColumn.ReadOnly = true;
            this.thresholdDataGridViewTextBoxColumn.Width = 150;
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
            // alarmLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 692);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "alarmLog";
            this.Text = "alarmLog";
            this.Load += new System.EventHandler(this.alarmLog_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mAS_TEAM_3_477DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alarmLogBindingSource)).EndInit();
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
        private System.Windows.Forms.DataGridView dataGridView1;
        private MAS_TEAM_3_477DataSet mAS_TEAM_3_477DataSet;
        private System.Windows.Forms.BindingSource alarmLogBindingSource;
        private MAS_TEAM_3_477DataSetTableAdapters.alarmLogTableAdapter alarmLogTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn sensorNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sensorVauleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn thresholdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateTimeDataGridViewTextBoxColumn;
    }
}