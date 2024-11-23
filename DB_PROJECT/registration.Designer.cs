namespace DB_PROJECT
{
    partial class frmregister
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textUserName = new System.Windows.Forms.TextBox();
            this.textpassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textconfirmpassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.checkShowPassword = new System.Windows.Forms.CheckBox();
            this.buttonRegister = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.BackToLogin = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.label1.Location = new System.Drawing.Point(222, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Get Started";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(213, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "User Name";
            // 
            // textUserName
            // 
            this.textUserName.BackColor = System.Drawing.Color.LightGray;
            this.textUserName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textUserName.ForeColor = System.Drawing.Color.Transparent;
            this.textUserName.Location = new System.Drawing.Point(217, 172);
            this.textUserName.Multiline = true;
            this.textUserName.Name = "textUserName";
            this.textUserName.Size = new System.Drawing.Size(200, 20);
            this.textUserName.TabIndex = 2;
            // 
            // textpassword
            // 
            this.textpassword.BackColor = System.Drawing.Color.LightGray;
            this.textpassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textpassword.ForeColor = System.Drawing.Color.Transparent;
            this.textpassword.Location = new System.Drawing.Point(217, 240);
            this.textpassword.Multiline = true;
            this.textpassword.Name = "textpassword";
            this.textpassword.Size = new System.Drawing.Size(200, 20);
            this.textpassword.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(213, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Password";
            // 
            // textconfirmpassword
            // 
            this.textconfirmpassword.BackColor = System.Drawing.Color.LightGray;
            this.textconfirmpassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textconfirmpassword.ForeColor = System.Drawing.Color.Transparent;
            this.textconfirmpassword.Location = new System.Drawing.Point(217, 311);
            this.textconfirmpassword.Multiline = true;
            this.textconfirmpassword.Name = "textconfirmpassword";
            this.textconfirmpassword.Size = new System.Drawing.Size(200, 20);
            this.textconfirmpassword.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(213, 272);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 21);
            this.label4.TabIndex = 5;
            this.label4.Text = "Confirm Password";
            // 
            // checkShowPassword
            // 
            this.checkShowPassword.AutoSize = true;
            this.checkShowPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkShowPassword.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkShowPassword.Location = new System.Drawing.Point(274, 346);
            this.checkShowPassword.Name = "checkShowPassword";
            this.checkShowPassword.Size = new System.Drawing.Size(143, 25);
            this.checkShowPassword.TabIndex = 7;
            this.checkShowPassword.Text = "Show Password";
            this.checkShowPassword.UseVisualStyleBackColor = true;
            // 
            // buttonRegister
            // 
            this.buttonRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.buttonRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRegister.ForeColor = System.Drawing.Color.White;
            this.buttonRegister.Location = new System.Drawing.Point(237, 410);
            this.buttonRegister.Name = "buttonRegister";
            this.buttonRegister.Size = new System.Drawing.Size(150, 40);
            this.buttonRegister.TabIndex = 8;
            this.buttonRegister.Text = "Register";
            this.buttonRegister.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(213, 470);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(200, 21);
            this.label5.TabIndex = 9;
            this.label5.Text = "Already have an Account";
            // 
            // BackToLogin
            // 
            this.BackToLogin.AutoSize = true;
            this.BackToLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BackToLogin.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackToLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.BackToLogin.Location = new System.Drawing.Point(248, 503);
            this.BackToLogin.Name = "BackToLogin";
            this.BackToLogin.Size = new System.Drawing.Size(127, 21);
            this.BackToLogin.TabIndex = 10;
            this.BackToLogin.Text = "BACK TO LOGIN";
            // 
            // frmregister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(634, 634);
            this.Controls.Add(this.BackToLogin);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonRegister);
            this.Controls.Add(this.checkShowPassword);
            this.Controls.Add(this.textconfirmpassword);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textpassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textUserName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.LightGray;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmregister";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textUserName;
        private System.Windows.Forms.TextBox textpassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textconfirmpassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkShowPassword;
        private System.Windows.Forms.Button buttonRegister;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label BackToLogin;
    }
}

