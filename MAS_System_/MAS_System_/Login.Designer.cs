namespace MAS_System_
{
    partial class Login
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
            this.userNameLbl = new System.Windows.Forms.Label();
            this.passwrdLbl = new System.Windows.Forms.Label();
            this.passwrdTxt = new System.Windows.Forms.TextBox();
            this.userNameTxt = new System.Windows.Forms.TextBox();
            this.loginBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // userNameLbl
            // 
            this.userNameLbl.AutoSize = true;
            this.userNameLbl.Location = new System.Drawing.Point(48, 49);
            this.userNameLbl.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.userNameLbl.Name = "userNameLbl";
            this.userNameLbl.Size = new System.Drawing.Size(57, 13);
            this.userNameLbl.TabIndex = 0;
            this.userNameLbl.Text = "UserName";
            // 
            // passwrdLbl
            // 
            this.passwrdLbl.AutoSize = true;
            this.passwrdLbl.Location = new System.Drawing.Point(48, 141);
            this.passwrdLbl.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.passwrdLbl.Name = "passwrdLbl";
            this.passwrdLbl.Size = new System.Drawing.Size(53, 13);
            this.passwrdLbl.TabIndex = 1;
            this.passwrdLbl.Text = "Password";
            // 
            // passwrdTxt
            // 
            this.passwrdTxt.Location = new System.Drawing.Point(48, 161);
            this.passwrdTxt.Margin = new System.Windows.Forms.Padding(1);
            this.passwrdTxt.Name = "passwrdTxt";
            this.passwrdTxt.Size = new System.Drawing.Size(85, 20);
            this.passwrdTxt.TabIndex = 2;
            // 
            // userNameTxt
            // 
            this.userNameTxt.Location = new System.Drawing.Point(48, 73);
            this.userNameTxt.Margin = new System.Windows.Forms.Padding(1);
            this.userNameTxt.Name = "userNameTxt";
            this.userNameTxt.Size = new System.Drawing.Size(85, 20);
            this.userNameTxt.TabIndex = 3;
            // 
            // loginBtn
            // 
            this.loginBtn.Location = new System.Drawing.Point(48, 212);
            this.loginBtn.Margin = new System.Windows.Forms.Padding(1);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(72, 32);
            this.loginBtn.TabIndex = 4;
            this.loginBtn.Text = "Login";
            this.loginBtn.UseVisualStyleBackColor = true;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 275);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.userNameTxt);
            this.Controls.Add(this.passwrdTxt);
            this.Controls.Add(this.passwrdLbl);
            this.Controls.Add(this.userNameLbl);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label userNameLbl;
        private System.Windows.Forms.Label passwrdLbl;
        private System.Windows.Forms.TextBox passwrdTxt;
        private System.Windows.Forms.TextBox userNameTxt;
        private System.Windows.Forms.Button loginBtn;
    }
}

