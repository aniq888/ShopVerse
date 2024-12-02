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
            this.textFirstName = new System.Windows.Forms.TextBox();
            this.textpassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textconfirmpassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.checkShowPassword = new System.Windows.Forms.CheckBox();
            this.buttonRegister = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.BackToLogin = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.LastNametextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.EmailtextBox = new System.Windows.Forms.TextBox();
            this.AddresstextBox = new System.Windows.Forms.TextBox();
            this.SellerradioButton = new System.Windows.Forms.RadioButton();
            this.CustomerradioButton = new System.Windows.Forms.RadioButton();
            this.AdminradioButton = new System.Windows.Forms.RadioButton();
            this.ShipperradioButton = new System.Windows.Forms.RadioButton();
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
            this.label2.Location = new System.Drawing.Point(213, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "First Name";
            // 
            // textFirstName
            // 
            this.textFirstName.BackColor = System.Drawing.Color.LightGray;
            this.textFirstName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textFirstName.ForeColor = System.Drawing.Color.Transparent;
            this.textFirstName.Location = new System.Drawing.Point(217, 172);
            this.textFirstName.Multiline = true;
            this.textFirstName.Name = "textFirstName";
            this.textFirstName.Size = new System.Drawing.Size(200, 20);
            this.textFirstName.TabIndex = 2;
            // 
            // textpassword
            // 
            this.textpassword.BackColor = System.Drawing.Color.LightGray;
            this.textpassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textpassword.ForeColor = System.Drawing.Color.Transparent;
            this.textpassword.Location = new System.Drawing.Point(217, 360);
            this.textpassword.Multiline = true;
            this.textpassword.Name = "textpassword";
            this.textpassword.Size = new System.Drawing.Size(200, 20);
            this.textpassword.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(213, 336);
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
            this.textconfirmpassword.Location = new System.Drawing.Point(217, 407);
            this.textconfirmpassword.Multiline = true;
            this.textconfirmpassword.Name = "textconfirmpassword";
            this.textconfirmpassword.Size = new System.Drawing.Size(200, 20);
            this.textconfirmpassword.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(213, 383);
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
            this.checkShowPassword.Location = new System.Drawing.Point(274, 433);
            this.checkShowPassword.Name = "checkShowPassword";
            this.checkShowPassword.Size = new System.Drawing.Size(143, 25);
            this.checkShowPassword.TabIndex = 7;
            this.checkShowPassword.Text = "Show Password";
            this.checkShowPassword.UseVisualStyleBackColor = true;
            this.checkShowPassword.CheckedChanged += new System.EventHandler(this.checkShowPassword_CheckedChanged);
            // 
            // buttonRegister
            // 
            this.buttonRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.buttonRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRegister.ForeColor = System.Drawing.Color.White;
            this.buttonRegister.Location = new System.Drawing.Point(237, 516);
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
            this.label5.Location = new System.Drawing.Point(213, 559);
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
            this.BackToLogin.Location = new System.Drawing.Point(247, 580);
            this.BackToLogin.Name = "BackToLogin";
            this.BackToLogin.Size = new System.Drawing.Size(127, 21);
            this.BackToLogin.TabIndex = 10;
            this.BackToLogin.Text = "BACK TO LOGIN";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(213, 195);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 21);
            this.label6.TabIndex = 11;
            this.label6.Text = "Last Name";
            // 
            // LastNametextBox
            // 
            this.LastNametextBox.BackColor = System.Drawing.Color.LightGray;
            this.LastNametextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LastNametextBox.ForeColor = System.Drawing.Color.Transparent;
            this.LastNametextBox.Location = new System.Drawing.Point(217, 219);
            this.LastNametextBox.Multiline = true;
            this.LastNametextBox.Name = "LastNametextBox";
            this.LastNametextBox.Size = new System.Drawing.Size(200, 20);
            this.LastNametextBox.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(215, 289);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 21);
            this.label7.TabIndex = 14;
            this.label7.Text = "Address";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(213, 242);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 21);
            this.label8.TabIndex = 15;
            this.label8.Text = "Email";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // EmailtextBox
            // 
            this.EmailtextBox.BackColor = System.Drawing.Color.LightGray;
            this.EmailtextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EmailtextBox.ForeColor = System.Drawing.Color.Transparent;
            this.EmailtextBox.Location = new System.Drawing.Point(217, 266);
            this.EmailtextBox.Multiline = true;
            this.EmailtextBox.Name = "EmailtextBox";
            this.EmailtextBox.Size = new System.Drawing.Size(200, 20);
            this.EmailtextBox.TabIndex = 16;
            // 
            // AddresstextBox
            // 
            this.AddresstextBox.BackColor = System.Drawing.Color.LightGray;
            this.AddresstextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AddresstextBox.ForeColor = System.Drawing.Color.Transparent;
            this.AddresstextBox.Location = new System.Drawing.Point(217, 313);
            this.AddresstextBox.Multiline = true;
            this.AddresstextBox.Name = "AddresstextBox";
            this.AddresstextBox.Size = new System.Drawing.Size(200, 20);
            this.AddresstextBox.TabIndex = 17;
            // 
            // SellerradioButton
            // 
            this.SellerradioButton.AutoSize = true;
            this.SellerradioButton.Location = new System.Drawing.Point(175, 468);
            this.SellerradioButton.Name = "SellerradioButton";
            this.SellerradioButton.Size = new System.Drawing.Size(60, 21);
            this.SellerradioButton.TabIndex = 18;
            this.SellerradioButton.TabStop = true;
            this.SellerradioButton.Text = "Seller";
            this.SellerradioButton.UseVisualStyleBackColor = true;
            // 
            // CustomerradioButton
            // 
            this.CustomerradioButton.AutoSize = true;
            this.CustomerradioButton.Location = new System.Drawing.Point(237, 468);
            this.CustomerradioButton.Name = "CustomerradioButton";
            this.CustomerradioButton.Size = new System.Drawing.Size(85, 21);
            this.CustomerradioButton.TabIndex = 19;
            this.CustomerradioButton.TabStop = true;
            this.CustomerradioButton.Text = "Customer";
            this.CustomerradioButton.UseVisualStyleBackColor = true;
            // 
            // AdminradioButton
            // 
            this.AdminradioButton.AutoSize = true;
            this.AdminradioButton.Location = new System.Drawing.Point(339, 468);
            this.AdminradioButton.Name = "AdminradioButton";
            this.AdminradioButton.Size = new System.Drawing.Size(67, 21);
            this.AdminradioButton.TabIndex = 20;
            this.AdminradioButton.TabStop = true;
            this.AdminradioButton.Text = "Admin";
            this.AdminradioButton.UseVisualStyleBackColor = true;
            // 
            // ShipperradioButton
            // 
            this.ShipperradioButton.AutoSize = true;
            this.ShipperradioButton.Location = new System.Drawing.Point(423, 468);
            this.ShipperradioButton.Name = "ShipperradioButton";
            this.ShipperradioButton.Size = new System.Drawing.Size(73, 21);
            this.ShipperradioButton.TabIndex = 21;
            this.ShipperradioButton.TabStop = true;
            this.ShipperradioButton.Text = "Shipper";
            this.ShipperradioButton.UseVisualStyleBackColor = true;
            // 
            // frmregister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(634, 634);
            this.Controls.Add(this.ShipperradioButton);
            this.Controls.Add(this.AdminradioButton);
            this.Controls.Add(this.CustomerradioButton);
            this.Controls.Add(this.SellerradioButton);
            this.Controls.Add(this.AddresstextBox);
            this.Controls.Add(this.EmailtextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.LastNametextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.BackToLogin);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonRegister);
            this.Controls.Add(this.checkShowPassword);
            this.Controls.Add(this.textconfirmpassword);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textpassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textFirstName);
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
        private System.Windows.Forms.TextBox textFirstName;
        private System.Windows.Forms.TextBox textpassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textconfirmpassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkShowPassword;
        private System.Windows.Forms.Button buttonRegister;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label BackToLogin;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox LastNametextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox EmailtextBox;
        private System.Windows.Forms.TextBox AddresstextBox;
        private System.Windows.Forms.RadioButton SellerradioButton;
        private System.Windows.Forms.RadioButton CustomerradioButton;
        private System.Windows.Forms.RadioButton AdminradioButton;
        private System.Windows.Forms.RadioButton ShipperradioButton;
    }
}

