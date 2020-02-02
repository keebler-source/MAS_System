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
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tempLvlTxt
            // 
            this.tempLvlTxt.Location = new System.Drawing.Point(220, 66);
            this.tempLvlTxt.Name = "tempLvlTxt";
            this.tempLvlTxt.Size = new System.Drawing.Size(240, 44);
            this.tempLvlTxt.TabIndex = 0;
            // 
            // resetBtn
            // 
            this.resetBtn.Location = new System.Drawing.Point(778, 543);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(202, 63);
            this.resetBtn.TabIndex = 1;
            this.resetBtn.Text = "Reset";
            this.resetBtn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "Temp Lvl";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 37);
            this.label2.TabIndex = 3;
            this.label2.Text = "Smoke Lvl";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 341);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 37);
            this.label3.TabIndex = 4;
            this.label3.Text = "Humity Lvl";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(543, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(208, 37);
            this.label4.TabIndex = 5;
            this.label4.Text = "Temp Thresh";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(543, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(225, 37);
            this.label5.TabIndex = 6;
            this.label5.Text = "Smoke Thresh";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(543, 341);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(225, 37);
            this.label6.TabIndex = 7;
            this.label6.Text = "Humity Thresh";
            // 
            // smokeLvlTxt
            // 
            this.smokeLvlTxt.Location = new System.Drawing.Point(220, 199);
            this.smokeLvlTxt.Name = "smokeLvlTxt";
            this.smokeLvlTxt.Size = new System.Drawing.Size(240, 44);
            this.smokeLvlTxt.TabIndex = 8;
            // 
            // humityTxt
            // 
            this.humityTxt.Location = new System.Drawing.Point(220, 338);
            this.humityTxt.Name = "humityTxt";
            this.humityTxt.Size = new System.Drawing.Size(240, 44);
            this.humityTxt.TabIndex = 9;
            // 
            // tempThreshTxt
            // 
            this.tempThreshTxt.Location = new System.Drawing.Point(783, 66);
            this.tempThreshTxt.Name = "tempThreshTxt";
            this.tempThreshTxt.Size = new System.Drawing.Size(228, 44);
            this.tempThreshTxt.TabIndex = 10;
            // 
            // smokeThreshTxt
            // 
            this.smokeThreshTxt.Location = new System.Drawing.Point(783, 192);
            this.smokeThreshTxt.Name = "smokeThreshTxt";
            this.smokeThreshTxt.Size = new System.Drawing.Size(228, 44);
            this.smokeThreshTxt.TabIndex = 11;
            // 
            // humityThreshTxt
            // 
            this.humityThreshTxt.Location = new System.Drawing.Point(774, 334);
            this.humityThreshTxt.Name = "humityThreshTxt";
            this.humityThreshTxt.Size = new System.Drawing.Size(228, 44);
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
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(48, 48);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1113, 56);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // logsToolStripMenuItem
            // 
            this.logsToolStripMenuItem.Name = "logsToolStripMenuItem";
            this.logsToolStripMenuItem.Size = new System.Drawing.Size(122, 52);
            this.logsToolStripMenuItem.Text = "Logs";
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
            // Sensor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1113, 676);
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
    }
}