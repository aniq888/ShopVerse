namespace DB_PROJECT
{
    partial class Customer_Purchase_Behavior_Report
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
            this.Descriptionbutton = new System.Windows.Forms.Button();
            this.MostActiveCustomersbutton = new System.Windows.Forms.Button();
            this.AvgSpendPerCustbutton = new System.Windows.Forms.Button();
            this.RepeatPurchaseRatebutton = new System.Windows.Forms.Button();
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
            this.flowLayoutPanel1.Controls.Add(this.Descriptionbutton);
            this.flowLayoutPanel1.Controls.Add(this.MostActiveCustomersbutton);
            this.flowLayoutPanel1.Controls.Add(this.AvgSpendPerCustbutton);
            this.flowLayoutPanel1.Controls.Add(this.RepeatPurchaseRatebutton);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(248, 808);
            this.flowLayoutPanel1.TabIndex = 5;
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
            this.panel2.Size = new System.Drawing.Size(245, 107);
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
            this.label1.Size = new System.Drawing.Size(220, 31);
            this.label1.TabIndex = 5;
            this.label1.Text = "Purchase Behavior";
            // 
            // Descriptionbutton
            // 
            this.Descriptionbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.Descriptionbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Descriptionbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Descriptionbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Descriptionbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Descriptionbutton.ForeColor = System.Drawing.Color.White;
            this.Descriptionbutton.Location = new System.Drawing.Point(3, 122);
            this.Descriptionbutton.Name = "Descriptionbutton";
            this.Descriptionbutton.Size = new System.Drawing.Size(240, 46);
            this.Descriptionbutton.TabIndex = 7;
            this.Descriptionbutton.Text = "Description";
            this.Descriptionbutton.UseVisualStyleBackColor = false;
            this.Descriptionbutton.Click += new System.EventHandler(this.Descriptionbutton_Click);
            // 
            // MostActiveCustomersbutton
            // 
            this.MostActiveCustomersbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.MostActiveCustomersbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.MostActiveCustomersbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MostActiveCustomersbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MostActiveCustomersbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MostActiveCustomersbutton.ForeColor = System.Drawing.Color.White;
            this.MostActiveCustomersbutton.Location = new System.Drawing.Point(3, 174);
            this.MostActiveCustomersbutton.Name = "MostActiveCustomersbutton";
            this.MostActiveCustomersbutton.Size = new System.Drawing.Size(240, 91);
            this.MostActiveCustomersbutton.TabIndex = 8;
            this.MostActiveCustomersbutton.Text = "Most Active Customers";
            this.MostActiveCustomersbutton.UseVisualStyleBackColor = false;
            this.MostActiveCustomersbutton.Click += new System.EventHandler(this.MostActiveCustomersbutton_Click);
            // 
            // AvgSpendPerCustbutton
            // 
            this.AvgSpendPerCustbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.AvgSpendPerCustbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.AvgSpendPerCustbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AvgSpendPerCustbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AvgSpendPerCustbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AvgSpendPerCustbutton.ForeColor = System.Drawing.Color.White;
            this.AvgSpendPerCustbutton.Location = new System.Drawing.Point(3, 271);
            this.AvgSpendPerCustbutton.Name = "AvgSpendPerCustbutton";
            this.AvgSpendPerCustbutton.Size = new System.Drawing.Size(240, 98);
            this.AvgSpendPerCustbutton.TabIndex = 9;
            this.AvgSpendPerCustbutton.Text = "Average Spend Per Customer";
            this.AvgSpendPerCustbutton.UseVisualStyleBackColor = false;
            this.AvgSpendPerCustbutton.Click += new System.EventHandler(this.AvgSpendPerCustbutton_Click);
            // 
            // RepeatPurchaseRatebutton
            // 
            this.RepeatPurchaseRatebutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.RepeatPurchaseRatebutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.RepeatPurchaseRatebutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RepeatPurchaseRatebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RepeatPurchaseRatebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RepeatPurchaseRatebutton.ForeColor = System.Drawing.Color.White;
            this.RepeatPurchaseRatebutton.Location = new System.Drawing.Point(3, 375);
            this.RepeatPurchaseRatebutton.Name = "RepeatPurchaseRatebutton";
            this.RepeatPurchaseRatebutton.Size = new System.Drawing.Size(240, 123);
            this.RepeatPurchaseRatebutton.TabIndex = 10;
            this.RepeatPurchaseRatebutton.Text = "Repeat Purchase Rate";
            this.RepeatPurchaseRatebutton.UseVisualStyleBackColor = false;
            this.RepeatPurchaseRatebutton.Click += new System.EventHandler(this.RepeatPurchaseRatebutton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(456, 108);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(789, 582);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Customer_Purchase_Behavior_Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1446, 808);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "Customer_Purchase_Behavior_Report";
            this.Text = "Customer_Purchase_Behavior_Report";
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
        private System.Windows.Forms.Button Descriptionbutton;
        private System.Windows.Forms.Button MostActiveCustomersbutton;
        private System.Windows.Forms.Button AvgSpendPerCustbutton;
        private System.Windows.Forms.Button RepeatPurchaseRatebutton;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}