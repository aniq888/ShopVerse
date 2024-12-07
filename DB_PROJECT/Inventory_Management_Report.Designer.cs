namespace DB_PROJECT
{
    partial class Inventory_Management_Report
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
            this.LowStockAlertbutton = new System.Windows.Forms.Button();
            this.DeadStockbutton = new System.Windows.Forms.Button();
            this.StockTurnoverRatebutton = new System.Windows.Forms.Button();
            this.MostReturnedItemsbutton = new System.Windows.Forms.Button();
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
            this.flowLayoutPanel1.Controls.Add(this.LowStockAlertbutton);
            this.flowLayoutPanel1.Controls.Add(this.DeadStockbutton);
            this.flowLayoutPanel1.Controls.Add(this.StockTurnoverRatebutton);
            this.flowLayoutPanel1.Controls.Add(this.MostReturnedItemsbutton);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(286, 815);
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
            this.label1.Size = new System.Drawing.Size(267, 31);
            this.label1.TabIndex = 5;
            this.label1.Text = "Inventory Management";
            // 
            // LowStockAlertbutton
            // 
            this.LowStockAlertbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.LowStockAlertbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.LowStockAlertbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LowStockAlertbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LowStockAlertbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LowStockAlertbutton.ForeColor = System.Drawing.Color.White;
            this.LowStockAlertbutton.Location = new System.Drawing.Point(3, 122);
            this.LowStockAlertbutton.Name = "LowStockAlertbutton";
            this.LowStockAlertbutton.Size = new System.Drawing.Size(276, 46);
            this.LowStockAlertbutton.TabIndex = 7;
            this.LowStockAlertbutton.Text = "Low Stock Alert";
            this.LowStockAlertbutton.UseVisualStyleBackColor = false;
            this.LowStockAlertbutton.Click += new System.EventHandler(this.LowStockAlertbutton_Click);
            // 
            // DeadStockbutton
            // 
            this.DeadStockbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.DeadStockbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.DeadStockbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeadStockbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeadStockbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeadStockbutton.ForeColor = System.Drawing.Color.White;
            this.DeadStockbutton.Location = new System.Drawing.Point(3, 174);
            this.DeadStockbutton.Name = "DeadStockbutton";
            this.DeadStockbutton.Size = new System.Drawing.Size(276, 46);
            this.DeadStockbutton.TabIndex = 8;
            this.DeadStockbutton.Text = "Dead Stock";
            this.DeadStockbutton.UseVisualStyleBackColor = false;
            this.DeadStockbutton.Click += new System.EventHandler(this.DeadStockbutton_Click);
            // 
            // StockTurnoverRatebutton
            // 
            this.StockTurnoverRatebutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.StockTurnoverRatebutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.StockTurnoverRatebutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.StockTurnoverRatebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StockTurnoverRatebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StockTurnoverRatebutton.ForeColor = System.Drawing.Color.White;
            this.StockTurnoverRatebutton.Location = new System.Drawing.Point(3, 226);
            this.StockTurnoverRatebutton.Name = "StockTurnoverRatebutton";
            this.StockTurnoverRatebutton.Size = new System.Drawing.Size(276, 46);
            this.StockTurnoverRatebutton.TabIndex = 9;
            this.StockTurnoverRatebutton.Text = "Stock Turnover Rate";
            this.StockTurnoverRatebutton.UseVisualStyleBackColor = false;
            this.StockTurnoverRatebutton.Click += new System.EventHandler(this.StockTurnoverRatebutton_Click);
            // 
            // MostReturnedItemsbutton
            // 
            this.MostReturnedItemsbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.MostReturnedItemsbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.MostReturnedItemsbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MostReturnedItemsbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MostReturnedItemsbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MostReturnedItemsbutton.ForeColor = System.Drawing.Color.White;
            this.MostReturnedItemsbutton.Location = new System.Drawing.Point(3, 278);
            this.MostReturnedItemsbutton.Name = "MostReturnedItemsbutton";
            this.MostReturnedItemsbutton.Size = new System.Drawing.Size(276, 46);
            this.MostReturnedItemsbutton.TabIndex = 10;
            this.MostReturnedItemsbutton.Text = "Most Returned Items";
            this.MostReturnedItemsbutton.UseVisualStyleBackColor = false;
            this.MostReturnedItemsbutton.Click += new System.EventHandler(this.MostReturnedItemsbutton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(505, 122);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(676, 585);
            this.dataGridView1.TabIndex = 6;
            // 
            // Inventory_Management_Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1405, 815);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "Inventory_Management_Report";
            this.Text = "Inventory_Management_Report";
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
        private System.Windows.Forms.Button LowStockAlertbutton;
        private System.Windows.Forms.Button DeadStockbutton;
        private System.Windows.Forms.Button StockTurnoverRatebutton;
        private System.Windows.Forms.Button MostReturnedItemsbutton;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}