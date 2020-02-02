namespace MAS_System_
{
    partial class Sensor
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
            this.tempLvlTxt = new System.Windows.Forms.TextBox();
            this.resetBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.smokeLvlTxt = new System.Windows.Forms.TextBox();
            this.humityTxt = new System.Windows.Forms.TextBox();
            this.tempThreshTxt = new System.Windows.Forms.TextBox();
            this.smokeThreshTxt = new System.Windows.Forms.TextBox();
            this.humityThreshTxt = new System.Windows.Forms.TextBox();
            this.tempBW = new System.ComponentModel.BackgroundWorker();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.logsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.smokeBW = new System.ComponentModel.BackgroundWorker();
            this.humBW = new System.ComponentModel.BackgroundWorker();
            this.thresholdToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.sensorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alarmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tempLvlTxt
            // 
            this.tempLvlTxt.Location = new System.Drawing.Point(69, 52);
            this.tempLvlTxt.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.tempLvlTxt.Name = "tempLvlTxt";
            this.tempLvlTxt.Size = new System.Drawing.Size(79, 20);
            this.tempLvlTxt.TabIndex = 0;
            // 
            // resetBtn
            // 
            this.resetBtn.Location = new System.Drawing.Point(69, 211);
            this.resetBtn.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(178, 22);
            this.resetBtn.TabIndex = 1;
            this.resetBtn.Text = "Reset";
            this.resetBtn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 52);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Temp Lvl";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 99);
            this.label2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Smoke Lvl";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 149);
            this.label3.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Humity Lvl";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(171, 52);
            this.label4.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Temp Thresh";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(171, 99);
            this.label5.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Smoke Thresh";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(171, 149);
            this.label6.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Humity Thresh";
            // 
            // smokeLvlTxt
            // 
            this.smokeLvlTxt.Location = new System.Drawing.Point(69, 99);
            this.smokeLvlTxt.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.smokeLvlTxt.Name = "smokeLvlTxt";
            this.smokeLvlTxt.Size = new System.Drawing.Size(79, 20);
            this.smokeLvlTxt.TabIndex = 8;
            // 
            // humityTxt
            // 
            this.humityTxt.Location = new System.Drawing.Point(69, 148);
            this.humityTxt.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.humityTxt.Name = "humityTxt";
            this.humityTxt.Size = new System.Drawing.Size(79, 20);
            this.humityTxt.TabIndex = 9;
            // 
            // tempThreshTxt
            // 
            this.tempThreshTxt.Location = new System.Drawing.Point(247, 52);
            this.tempThreshTxt.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.tempThreshTxt.Name = "tempThreshTxt";
            this.tempThreshTxt.Size = new System.Drawing.Size(75, 20);
            this.tempThreshTxt.TabIndex = 10;
            // 
            // smokeThreshTxt
            // 
            this.smokeThreshTxt.Location = new System.Drawing.Point(247, 96);
            this.smokeThreshTxt.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.smokeThreshTxt.Name = "smokeThreshTxt";
            this.smokeThreshTxt.Size = new System.Drawing.Size(75, 20);
            this.smokeThreshTxt.TabIndex = 11;
            // 
            // humityThreshTxt
            // 
            this.humityThreshTxt.Location = new System.Drawing.Point(244, 146);
            this.humityThreshTxt.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.humityThreshTxt.Name = "humityThreshTxt";
            this.humityThreshTxt.Size = new System.Drawing.Size(75, 20);
            this.humityThreshTxt.TabIndex = 12;
            // 
            // tempBW
            // 
            this.tempBW.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bw_DoWork);
            this.tempBW.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bw_ProgressChanged);
            this.tempBW.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bw_RunWorkerCompleted);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(48, 48);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logsToolStripMenuItem,
            this.logsToolStripMenuItem1,
            this.resetToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(2, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(378, 24);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // logsToolStripMenuItem
            // 
            this.logsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thresholdToolStripMenuItem,
            this.userToolStripMenuItem});
            this.logsToolStripMenuItem.Name = "logsToolStripMenuItem";
            this.logsToolStripMenuItem.Size = new System.Drawing.Size(39, 22);
            this.logsToolStripMenuItem.Text = "Edit";
            // 
            // smokeBW
            // 
            this.smokeBW.DoWork += new System.ComponentModel.DoWorkEventHandler(this.smokeBW_DoWork);
            this.smokeBW.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.smokeBW_ProgressChanged);
            this.smokeBW.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.smokeBW_RunWorkerCompleted);
            // 
            // humBW
            // 
            this.humBW.DoWork += new System.ComponentModel.DoWorkEventHandler(this.humBW_DoWork);
            this.humBW.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.humBW_ProgressChanged);
            this.humBW.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.humBW_RunWorkerCompleted);
            // 
            // thresholdToolStripMenuItem
            // 
            this.thresholdToolStripMenuItem.Name = "thresholdToolStripMenuItem";
            this.thresholdToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.thresholdToolStripMenuItem.Text = "Threshold";
            // 
            // userToolStripMenuItem
            // 
            this.userToolStripMenuItem.Name = "userToolStripMenuItem";
            this.userToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.userToolStripMenuItem.Text = "User";
            // 
            // logsToolStripMenuItem1
            // 
            this.logsToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sensorToolStripMenuItem,
            this.loginToolStripMenuItem,
            this.alarmToolStripMenuItem});
            this.logsToolStripMenuItem1.Name = "logsToolStripMenuItem1";
            this.logsToolStripMenuItem1.Size = new System.Drawing.Size(44, 22);
            this.logsToolStripMenuItem1.Text = "Logs";
            // 
            // sensorToolStripMenuItem
            // 
            this.sensorToolStripMenuItem.Name = "sensorToolStripMenuItem";
            this.sensorToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sensorToolStripMenuItem.Text = "Sensor";
            this.sensorToolStripMenuItem.Click += new System.EventHandler(this.sensorToolStripMenuItem_Click);
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.loginToolStripMenuItem.Text = "Login";
            this.loginToolStripMenuItem.Click += new System.EventHandler(this.loginToolStripMenuItem_Click);
            // 
            // alarmToolStripMenuItem
            // 
            this.alarmToolStripMenuItem.Name = "alarmToolStripMenuItem";
            this.alarmToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.alarmToolStripMenuItem.Text = "Alarm";
            this.alarmToolStripMenuItem.Click += new System.EventHandler(this.alarmToolStripMenuItem_Click);
            // 
            // resetToolStripMenuItem
            // 
            this.resetToolStripMenuItem.Name = "resetToolStripMenuItem";
            this.resetToolStripMenuItem.Size = new System.Drawing.Size(47, 22);
            this.resetToolStripMenuItem.Text = "Reset";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem1});
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(38, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem1.Text = "Exit";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.exitToolStripMenuItem1_Click);
            // 
            // Sensor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 269);
            this.Controls.Add(this.humityThreshTxt);
            this.Controls.Add(this.smokeThreshTxt);
            this.Controls.Add(this.tempThreshTxt);
            this.Controls.Add(this.humityTxt);
            this.Controls.Add(this.smokeLvlTxt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.resetBtn);
            this.Controls.Add(this.tempLvlTxt);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Name = "Sensor";
            this.Text = "Sensor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Sensor_FormClosing);
            this.Load += new System.EventHandler(this.Sensor_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tempLvlTxt;
        private System.Windows.Forms.Button resetBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox smokeLvlTxt;
        private System.Windows.Forms.TextBox humityTxt;
        private System.Windows.Forms.TextBox tempThreshTxt;
        private System.Windows.Forms.TextBox smokeThreshTxt;
        private System.Windows.Forms.TextBox humityThreshTxt;
        private System.ComponentModel.BackgroundWorker tempBW;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem logsToolStripMenuItem;
        private System.ComponentModel.BackgroundWorker smokeBW;
        private System.ComponentModel.BackgroundWorker humBW;
        private System.Windows.Forms.ToolStripMenuItem thresholdToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem sensorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alarmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
    }
}