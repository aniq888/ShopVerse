namespace DB_PROJECT
{
    partial class Revenue_by_Product_Category_Report
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.DELIVERYBUTTON = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.RevenuePerCategorybutton = new System.Windows.Forms.Button();
            this.PercentageContributionbutton = new System.Windows.Forms.Button();
            this.TrendingCategoriesbutton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.flowLayoutPanel1.Controls.Add(this.DELIVERYBUTTON);
            this.flowLayoutPanel1.Controls.Add(this.panel2);
            this.flowLayoutPanel1.Controls.Add(this.RevenuePerCategorybutton);
            this.flowLayoutPanel1.Controls.Add(this.PercentageContributionbutton);
            this.flowLayoutPanel1.Controls.Add(this.TrendingCategoriesbutton);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(286, 809);
            this.flowLayoutPanel1.TabIndex = 6;
            // 
            // DELIVERYBUTTON
            // 
            this.DELIVERYBUTTON.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(80)))), ((int)(((byte)(160)))));
            this.DELIVERYBUTTON.Dock = System.Windows.Forms.DockStyle.Right;
            this.DELIVERYBUTTON.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DELIVERYBUTTON.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DELIVERYBUTTON.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DELIVERYBUTTON.Location = new System.Drawing.Point(3, 3);
            this.DELIVERYBUTTON.Name = "DELIVERYBUTTON";
            this.DELIVERYBUTTON.Size = new System.Drawing.Size(188, 0);
            this.DELIVERYBUTTON.TabIndex = 6;
            this.DELIVERYBUTTON.Text = "DELIVERY ADDRESS";
            this.DELIVERYBUTTON.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(3, 9);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(283, 107);
            this.panel2.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DB_PROJECT.Properties.Resources.icons8_home_20;
            this.pictureBox1.Location = new System.Drawing.Point(3, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(54, 42);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(9, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 31);
            this.label1.TabIndex = 5;
            this.label1.Text = "Revenue By Category";
            // 
            // RevenuePerCategorybutton
            // 
            this.RevenuePerCategorybutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.RevenuePerCategorybutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.RevenuePerCategorybutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RevenuePerCategorybutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RevenuePerCategorybutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RevenuePerCategorybutton.ForeColor = System.Drawing.Color.White;
            this.RevenuePerCategorybutton.Location = new System.Drawing.Point(3, 122);
            this.RevenuePerCategorybutton.Name = "RevenuePerCategorybutton";
            this.RevenuePerCategorybutton.Size = new System.Drawing.Size(276, 46);
            this.RevenuePerCategorybutton.TabIndex = 7;
            this.RevenuePerCategorybutton.Text = "Revenue Per Category";
            this.RevenuePerCategorybutton.UseVisualStyleBackColor = false;
            this.RevenuePerCategorybutton.Click += new System.EventHandler(this.RevenuePerCategorybutton_Click);
            // 
            // PercentageContributionbutton
            // 
            this.PercentageContributionbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.PercentageContributionbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PercentageContributionbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PercentageContributionbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PercentageContributionbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PercentageContributionbutton.ForeColor = System.Drawing.Color.White;
            this.PercentageContributionbutton.Location = new System.Drawing.Point(3, 174);
            this.PercentageContributionbutton.Name = "PercentageContributionbutton";
            this.PercentageContributionbutton.Size = new System.Drawing.Size(276, 46);
            this.PercentageContributionbutton.TabIndex = 8;
            this.PercentageContributionbutton.Text = "Percentage Contribution";
            this.PercentageContributionbutton.UseVisualStyleBackColor = false;
            this.PercentageContributionbutton.Click += new System.EventHandler(this.PercentageContributionbutton_Click);
            // 
            // TrendingCategoriesbutton
            // 
            this.TrendingCategoriesbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.TrendingCategoriesbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.TrendingCategoriesbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TrendingCategoriesbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TrendingCategoriesbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TrendingCategoriesbutton.ForeColor = System.Drawing.Color.White;
            this.TrendingCategoriesbutton.Location = new System.Drawing.Point(3, 226);
            this.TrendingCategoriesbutton.Name = "TrendingCategoriesbutton";
            this.TrendingCategoriesbutton.Size = new System.Drawing.Size(276, 46);
            this.TrendingCategoriesbutton.TabIndex = 9;
            this.TrendingCategoriesbutton.Text = "Trending Categories";
            this.TrendingCategoriesbutton.UseVisualStyleBackColor = false;
            this.TrendingCategoriesbutton.Click += new System.EventHandler(this.TrendingCategoriesbutton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(544, 142);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(654, 526);
            this.dataGridView1.TabIndex = 7;
            // 
            // Revenue_by_Product_Category_Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1402, 809);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "Revenue_by_Product_Category_Report";
            this.Text = "Revenue_by_Product_Category_Report";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button DELIVERYBUTTON;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button RevenuePerCategorybutton;
        private System.Windows.Forms.Button PercentageContributionbutton;
        private System.Windows.Forms.Button TrendingCategoriesbutton;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}