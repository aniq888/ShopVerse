namespace DB_PROJECT
{
    partial class WishList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WishList));
            this.panel1 = new System.Windows.Forms.Panel();
            this.shopverselabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.separator3 = new Controls.Separator();
            this.WishListlabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.CheckAvailabilitybutton = new System.Windows.Forms.Button();
            this.RemoveItembutton = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.SearchpictureBox = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SearchpictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.panel1.Controls.Add(this.shopverselabel);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.Snow;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1426, 112);
            this.panel1.TabIndex = 2;
            // 
            // shopverselabel
            // 
            this.shopverselabel.AutoSize = true;
            this.shopverselabel.Font = new System.Drawing.Font("Perpetua Titling MT", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shopverselabel.Location = new System.Drawing.Point(166, 42);
            this.shopverselabel.Name = "shopverselabel";
            this.shopverselabel.Size = new System.Drawing.Size(221, 38);
            this.shopverselabel.TabIndex = 4;
            this.shopverselabel.Text = "SHOP VERSE";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.richTextBox1);
            this.panel2.Controls.Add(this.SearchpictureBox);
            this.panel2.Location = new System.Drawing.Point(634, 42);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(324, 47);
            this.panel2.TabIndex = 3;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.ForeColor = System.Drawing.Color.MediumPurple;
            this.richTextBox1.Location = new System.Drawing.Point(0, 0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(261, 47);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "Find More Products";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.label2.Location = new System.Drawing.Point(186, 235);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1069, 16);
            this.label2.TabIndex = 19;
            this.label2.Text = resources.GetString("label2.Text");
            // 
            // separator3
            // 
            this.separator3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.separator3.Color = System.Drawing.Color.Empty;
            this.separator3.Direction = null;
            this.separator3.DisabledColor = System.Drawing.Color.Empty;
            this.separator3.Location = new System.Drawing.Point(99, 251);
            this.separator3.Name = "separator3";
            this.separator3.Size = new System.Drawing.Size(1229, 10);
            this.separator3.TabIndex = 18;
            this.separator3.Text = "separator2";
            this.separator3.Thickness = 0;
            // 
            // WishListlabel
            // 
            this.WishListlabel.AutoSize = true;
            this.WishListlabel.Font = new System.Drawing.Font("Perpetua Titling MT", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WishListlabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.WishListlabel.Location = new System.Drawing.Point(167, 179);
            this.WishListlabel.Name = "WishListlabel";
            this.WishListlabel.Size = new System.Drawing.Size(188, 38);
            this.WishListlabel.TabIndex = 17;
            this.WishListlabel.Text = "Wish List";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DB_PROJECT.Properties.Resources.icons8_wishlist_58;
            this.pictureBox1.Location = new System.Drawing.Point(361, 168);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 64);
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // CheckAvailabilitybutton
            // 
            this.CheckAvailabilitybutton.BackgroundImage = global::DB_PROJECT.Properties.Resources.images;
            this.CheckAvailabilitybutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CheckAvailabilitybutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckAvailabilitybutton.ForeColor = System.Drawing.Color.White;
            this.CheckAvailabilitybutton.Location = new System.Drawing.Point(350, 526);
            this.CheckAvailabilitybutton.Name = "CheckAvailabilitybutton";
            this.CheckAvailabilitybutton.Size = new System.Drawing.Size(313, 46);
            this.CheckAvailabilitybutton.TabIndex = 22;
            this.CheckAvailabilitybutton.Text = "CHECK AVAILABILITY";
            this.CheckAvailabilitybutton.UseVisualStyleBackColor = true;
            // 
            // RemoveItembutton
            // 
            this.RemoveItembutton.BackgroundImage = global::DB_PROJECT.Properties.Resources.images;
            this.RemoveItembutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RemoveItembutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveItembutton.ForeColor = System.Drawing.Color.White;
            this.RemoveItembutton.Location = new System.Drawing.Point(779, 526);
            this.RemoveItembutton.Name = "RemoveItembutton";
            this.RemoveItembutton.Size = new System.Drawing.Size(313, 46);
            this.RemoveItembutton.TabIndex = 21;
            this.RemoveItembutton.Text = "REMOVE ITEM";
            this.RemoveItembutton.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::DB_PROJECT.Properties.Resources.Screenshot_2024_11_24_012736;
            this.pictureBox2.Location = new System.Drawing.Point(144, 267);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1075, 193);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 20;
            this.pictureBox2.TabStop = false;
            // 
            // SearchpictureBox
            // 
            this.SearchpictureBox.Image = global::DB_PROJECT.Properties.Resources.icons8_search_50;
            this.SearchpictureBox.Location = new System.Drawing.Point(267, 0);
            this.SearchpictureBox.Name = "SearchpictureBox";
            this.SearchpictureBox.Size = new System.Drawing.Size(57, 47);
            this.SearchpictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.SearchpictureBox.TabIndex = 2;
            this.SearchpictureBox.TabStop = false;
            // 
            // WishList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1426, 638);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.CheckAvailabilitybutton);
            this.Controls.Add(this.RemoveItembutton);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.separator3);
            this.Controls.Add(this.WishListlabel);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "WishList";
            this.Text = "WishList";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SearchpictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label shopverselabel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.PictureBox SearchpictureBox;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private Controls.Separator separator3;
        private System.Windows.Forms.Label WishListlabel;
        private System.Windows.Forms.Button RemoveItembutton;
        private System.Windows.Forms.Button CheckAvailabilitybutton;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}