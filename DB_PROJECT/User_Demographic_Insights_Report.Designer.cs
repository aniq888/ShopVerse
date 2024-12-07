namespace DB_PROJECT
{
    partial class User_Demographic_Insights_Report
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
            this.AgeDistributionbutton = new System.Windows.Forms.Button();
            this.GenderAnalysisbutton = new System.Windows.Forms.Button();
            this.LocationInsightsbutton1 = new System.Windows.Forms.Button();
            this.DemographicPreferencesbutton = new System.Windows.Forms.Button();
            this.LBIbutton2 = new System.Windows.Forms.Button();
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
            this.flowLayoutPanel1.Controls.Add(this.AgeDistributionbutton);
            this.flowLayoutPanel1.Controls.Add(this.GenderAnalysisbutton);
            this.flowLayoutPanel1.Controls.Add(this.LocationInsightsbutton1);
            this.flowLayoutPanel1.Controls.Add(this.LBIbutton2);
            this.flowLayoutPanel1.Controls.Add(this.DemographicPreferencesbutton);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(277, 813);
            this.flowLayoutPanel1.TabIndex = 7;
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
            this.panel2.Size = new System.Drawing.Size(285, 107);
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
            this.label1.Size = new System.Drawing.Size(269, 31);
            this.label1.TabIndex = 5;
            this.label1.Text = "User DemoGraphic Ins.";
            // 
            // AgeDistributionbutton
            // 
            this.AgeDistributionbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.AgeDistributionbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.AgeDistributionbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AgeDistributionbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AgeDistributionbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AgeDistributionbutton.ForeColor = System.Drawing.Color.White;
            this.AgeDistributionbutton.Location = new System.Drawing.Point(3, 122);
            this.AgeDistributionbutton.Name = "AgeDistributionbutton";
            this.AgeDistributionbutton.Size = new System.Drawing.Size(272, 55);
            this.AgeDistributionbutton.TabIndex = 8;
            this.AgeDistributionbutton.Text = "Age Distribution";
            this.AgeDistributionbutton.UseVisualStyleBackColor = false;
            this.AgeDistributionbutton.Click += new System.EventHandler(this.AgeDistributionbutton_Click);
            // 
            // GenderAnalysisbutton
            // 
            this.GenderAnalysisbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.GenderAnalysisbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.GenderAnalysisbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GenderAnalysisbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GenderAnalysisbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenderAnalysisbutton.ForeColor = System.Drawing.Color.White;
            this.GenderAnalysisbutton.Location = new System.Drawing.Point(3, 183);
            this.GenderAnalysisbutton.Name = "GenderAnalysisbutton";
            this.GenderAnalysisbutton.Size = new System.Drawing.Size(272, 60);
            this.GenderAnalysisbutton.TabIndex = 9;
            this.GenderAnalysisbutton.Text = "Gender Analysis";
            this.GenderAnalysisbutton.UseVisualStyleBackColor = false;
            this.GenderAnalysisbutton.Click += new System.EventHandler(this.GenderAnalysisbutton_Click);
            // 
            // LocationInsightsbutton1
            // 
            this.LocationInsightsbutton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.LocationInsightsbutton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.LocationInsightsbutton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LocationInsightsbutton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LocationInsightsbutton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LocationInsightsbutton1.ForeColor = System.Drawing.Color.White;
            this.LocationInsightsbutton1.Location = new System.Drawing.Point(3, 249);
            this.LocationInsightsbutton1.Name = "LocationInsightsbutton1";
            this.LocationInsightsbutton1.Size = new System.Drawing.Size(272, 59);
            this.LocationInsightsbutton1.TabIndex = 10;
            this.LocationInsightsbutton1.Text = "Location-Based Insights(sales)";
            this.LocationInsightsbutton1.UseVisualStyleBackColor = false;
            this.LocationInsightsbutton1.Click += new System.EventHandler(this.LocationInsightsbutton_Click);
            // 
            // DemographicPreferencesbutton
            // 
            this.DemographicPreferencesbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.DemographicPreferencesbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.DemographicPreferencesbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DemographicPreferencesbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DemographicPreferencesbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DemographicPreferencesbutton.ForeColor = System.Drawing.Color.White;
            this.DemographicPreferencesbutton.Location = new System.Drawing.Point(3, 379);
            this.DemographicPreferencesbutton.Name = "DemographicPreferencesbutton";
            this.DemographicPreferencesbutton.Size = new System.Drawing.Size(272, 59);
            this.DemographicPreferencesbutton.TabIndex = 11;
            this.DemographicPreferencesbutton.Text = "Demographic Preferences";
            this.DemographicPreferencesbutton.UseVisualStyleBackColor = false;
            this.DemographicPreferencesbutton.Click += new System.EventHandler(this.DemographicPreferencesbutton_Click);
            // 
            // LBIbutton2
            // 
            this.LBIbutton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.LBIbutton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.LBIbutton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LBIbutton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LBIbutton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBIbutton2.ForeColor = System.Drawing.Color.White;
            this.LBIbutton2.Location = new System.Drawing.Point(3, 314);
            this.LBIbutton2.Name = "LBIbutton2";
            this.LBIbutton2.Size = new System.Drawing.Size(272, 59);
            this.LBIbutton2.TabIndex = 12;
            this.LBIbutton2.Text = "Location-Based Insights(user-activity)";
            this.LBIbutton2.UseVisualStyleBackColor = false;
            this.LBIbutton2.Click += new System.EventHandler(this.LBIbutton2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(498, 153);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(684, 525);
            this.dataGridView1.TabIndex = 8;
            // 
            // User_Demographic_Insights_Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1402, 813);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "User_Demographic_Insights_Report";
            this.Text = "User_Demographic_Insights_Report";
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
        private System.Windows.Forms.Button AgeDistributionbutton;
        private System.Windows.Forms.Button GenderAnalysisbutton;
        private System.Windows.Forms.Button LocationInsightsbutton1;
        private System.Windows.Forms.Button DemographicPreferencesbutton;
        private System.Windows.Forms.Button LBIbutton2;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}