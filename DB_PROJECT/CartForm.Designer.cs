namespace DB_PROJECT
{
    partial class CartForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.shopverselabel = new System.Windows.Forms.Label();
            this.CARTlabel = new System.Windows.Forms.Label();
            this.separator3 = new Controls.Separator();
            this.button1 = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.flowLayoutPanelCart = new System.Windows.Forms.FlowLayoutPanel();
            this.labelSubtotal = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.panel1.Controls.Add(this.BackButton);
            this.panel1.Controls.Add(this.shopverselabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.Snow;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1386, 112);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // shopverselabel
            // 
            this.shopverselabel.AutoSize = true;
            this.shopverselabel.Font = new System.Drawing.Font("Perpetua Titling MT", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shopverselabel.Location = new System.Drawing.Point(569, 34);
            this.shopverselabel.Name = "shopverselabel";
            this.shopverselabel.Size = new System.Drawing.Size(221, 38);
            this.shopverselabel.TabIndex = 4;
            this.shopverselabel.Text = "SHOP VERSE";
            // 
            // CARTlabel
            // 
            this.CARTlabel.AutoSize = true;
            this.CARTlabel.Font = new System.Drawing.Font("Perpetua Titling MT", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CARTlabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.CARTlabel.Location = new System.Drawing.Point(139, 129);
            this.CARTlabel.Name = "CARTlabel";
            this.CARTlabel.Size = new System.Drawing.Size(112, 38);
            this.CARTlabel.TabIndex = 5;
            this.CARTlabel.Text = "CART";
            this.CARTlabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // separator3
            // 
            this.separator3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.separator3.Color = System.Drawing.Color.Empty;
            this.separator3.Direction = null;
            this.separator3.DisabledColor = System.Drawing.Color.Empty;
            this.separator3.Location = new System.Drawing.Point(71, 201);
            this.separator3.Name = "separator3";
            this.separator3.Size = new System.Drawing.Size(1229, 10);
            this.separator3.TabIndex = 7;
            this.separator3.Text = "separator2";
            this.separator3.Thickness = 0;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::DB_PROJECT.Properties.Resources.images;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(730, 527);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(313, 46);
            this.button1.TabIndex = 12;
            this.button1.Text = "PROCEED TO CHECKOUT";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // BackButton
            // 
            this.BackButton.ForeColor = System.Drawing.Color.Black;
            this.BackButton.Location = new System.Drawing.Point(97, 34);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(75, 23);
            this.BackButton.TabIndex = 5;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanelCart
            // 
            this.flowLayoutPanelCart.Location = new System.Drawing.Point(71, 217);
            this.flowLayoutPanelCart.Name = "flowLayoutPanelCart";
            this.flowLayoutPanelCart.Size = new System.Drawing.Size(1229, 304);
            this.flowLayoutPanelCart.TabIndex = 14;
            // 
            // labelSubtotal
            // 
            this.labelSubtotal.AutoSize = true;
            this.labelSubtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSubtotal.Location = new System.Drawing.Point(1116, 544);
            this.labelSubtotal.Name = "labelSubtotal";
            this.labelSubtotal.Size = new System.Drawing.Size(0, 20);
            this.labelSubtotal.TabIndex = 15;
            this.labelSubtotal.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // CartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1386, 638);
            this.Controls.Add(this.labelSubtotal);
            this.Controls.Add(this.flowLayoutPanelCart);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.separator3);
            this.Controls.Add(this.CARTlabel);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CartForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Cart_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label shopverselabel;
        private System.Windows.Forms.Label CARTlabel;
        private Controls.Separator separator3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelCart;
        private System.Windows.Forms.Label labelSubtotal;
    }
}