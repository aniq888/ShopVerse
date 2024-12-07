namespace DB_PROJECT
{
    partial class Abandoned_Cart_Report
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
            this.NumberofAbandonedCartsbutton = new System.Windows.Forms.Button();
            this.AvgValuebutton = new System.Windows.Forms.Button();
            this.ProductAnalysisbutton = new System.Windows.Forms.Button();
            this.AbandonmentReasonsbutton = new System.Windows.Forms.Button();
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
            this.flowLayoutPanel1.Controls.Add(this.NumberofAbandonedCartsbutton);
            this.flowLayoutPanel1.Controls.Add(this.AvgValuebutton);
            this.flowLayoutPanel1.Controls.Add(this.ProductAnalysisbutton);
            this.flowLayoutPanel1.Controls.Add(this.AbandonmentReasonsbutton);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(289, 815);
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
            this.panel2.Size = new System.Drawing.Size(364, 107);
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
            this.label1.Size = new System.Drawing.Size(192, 31);
            this.label1.TabIndex = 5;
            this.label1.Text = "Abandoned Cart";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // NumberofAbandonedCartsbutton
            // 
            this.NumberofAbandonedCartsbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.NumberofAbandonedCartsbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.NumberofAbandonedCartsbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NumberofAbandonedCartsbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NumberofAbandonedCartsbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumberofAbandonedCartsbutton.ForeColor = System.Drawing.Color.White;
            this.NumberofAbandonedCartsbutton.Location = new System.Drawing.Point(3, 122);
            this.NumberofAbandonedCartsbutton.Name = "NumberofAbandonedCartsbutton";
            this.NumberofAbandonedCartsbutton.Size = new System.Drawing.Size(280, 46);
            this.NumberofAbandonedCartsbutton.TabIndex = 7;
            this.NumberofAbandonedCartsbutton.Text = "Number of Abandoned Carts";
            this.NumberofAbandonedCartsbutton.UseVisualStyleBackColor = false;
            this.NumberofAbandonedCartsbutton.Click += new System.EventHandler(this.NumberofAbandonedCartsbutton_Click);
            // 
            // AvgValuebutton
            // 
            this.AvgValuebutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.AvgValuebutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.AvgValuebutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AvgValuebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AvgValuebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AvgValuebutton.ForeColor = System.Drawing.Color.White;
            this.AvgValuebutton.Location = new System.Drawing.Point(3, 174);
            this.AvgValuebutton.Name = "AvgValuebutton";
            this.AvgValuebutton.Size = new System.Drawing.Size(280, 66);
            this.AvgValuebutton.TabIndex = 8;
            this.AvgValuebutton.Text = "Average Value of Abandoned Carts";
            this.AvgValuebutton.UseVisualStyleBackColor = false;
            this.AvgValuebutton.Click += new System.EventHandler(this.AvgValuebutton_Click);
            // 
            // ProductAnalysisbutton
            // 
            this.ProductAnalysisbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.ProductAnalysisbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ProductAnalysisbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ProductAnalysisbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ProductAnalysisbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductAnalysisbutton.ForeColor = System.Drawing.Color.White;
            this.ProductAnalysisbutton.Location = new System.Drawing.Point(3, 246);
            this.ProductAnalysisbutton.Name = "ProductAnalysisbutton";
            this.ProductAnalysisbutton.Size = new System.Drawing.Size(280, 46);
            this.ProductAnalysisbutton.TabIndex = 9;
            this.ProductAnalysisbutton.Text = "Product Analysis";
            this.ProductAnalysisbutton.UseVisualStyleBackColor = false;
            this.ProductAnalysisbutton.Click += new System.EventHandler(this.ProductAnalysisbutton_Click);
            // 
            // AbandonmentReasonsbutton
            // 
            this.AbandonmentReasonsbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.AbandonmentReasonsbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.AbandonmentReasonsbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AbandonmentReasonsbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AbandonmentReasonsbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AbandonmentReasonsbutton.ForeColor = System.Drawing.Color.White;
            this.AbandonmentReasonsbutton.Location = new System.Drawing.Point(3, 298);
            this.AbandonmentReasonsbutton.Name = "AbandonmentReasonsbutton";
            this.AbandonmentReasonsbutton.Size = new System.Drawing.Size(280, 46);
            this.AbandonmentReasonsbutton.TabIndex = 10;
            this.AbandonmentReasonsbutton.Text = "Cart Abandonment Reasons";
            this.AbandonmentReasonsbutton.UseVisualStyleBackColor = false;
            this.AbandonmentReasonsbutton.Click += new System.EventHandler(this.AbandonmentReasonsbutton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(532, 122);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(666, 583);
            this.dataGridView1.TabIndex = 7;
            // 
            // Abandoned_Cart_Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1403, 815);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "Abandoned_Cart_Report";
            this.Text = "Abandoned_Cart_Report";
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
        private System.Windows.Forms.Button NumberofAbandonedCartsbutton;
        private System.Windows.Forms.Button AvgValuebutton;
        private System.Windows.Forms.Button ProductAnalysisbutton;
        private System.Windows.Forms.Button AbandonmentReasonsbutton;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}