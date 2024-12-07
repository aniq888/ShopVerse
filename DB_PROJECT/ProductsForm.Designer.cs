namespace DB_PROJECT
{
    partial class ProductsForm
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
            this.flowLayoutPanelProducts = new System.Windows.Forms.FlowLayoutPanel();
            this.HomeButton = new System.Windows.Forms.Button();
            this.CartButton = new System.Windows.Forms.Button();
            this.WishListButton = new System.Windows.Forms.Button();
            this.BrowseButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // flowLayoutPanelProducts
            // 
            this.flowLayoutPanelProducts.Location = new System.Drawing.Point(12, 61);
            this.flowLayoutPanelProducts.Name = "flowLayoutPanelProducts";
            this.flowLayoutPanelProducts.Size = new System.Drawing.Size(776, 377);
            this.flowLayoutPanelProducts.TabIndex = 0;
            this.flowLayoutPanelProducts.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanelProducts_Paint);
            // 
            // HomeButton
            // 
            this.HomeButton.Location = new System.Drawing.Point(153, 12);
            this.HomeButton.Name = "HomeButton";
            this.HomeButton.Size = new System.Drawing.Size(75, 23);
            this.HomeButton.TabIndex = 1;
            this.HomeButton.Text = "Home";
            this.HomeButton.UseVisualStyleBackColor = true;
            // 
            // CartButton
            // 
            this.CartButton.Location = new System.Drawing.Point(279, 12);
            this.CartButton.Name = "CartButton";
            this.CartButton.Size = new System.Drawing.Size(75, 23);
            this.CartButton.TabIndex = 2;
            this.CartButton.Text = "Cart";
            this.CartButton.UseVisualStyleBackColor = true;
            // 
            // WishListButton
            // 
            this.WishListButton.Location = new System.Drawing.Point(421, 12);
            this.WishListButton.Name = "WishListButton";
            this.WishListButton.Size = new System.Drawing.Size(75, 23);
            this.WishListButton.TabIndex = 3;
            this.WishListButton.Text = "Wish List";
            this.WishListButton.UseVisualStyleBackColor = true;
            // 
            // BrowseButton
            // 
            this.BrowseButton.Location = new System.Drawing.Point(554, 12);
            this.BrowseButton.Name = "BrowseButton";
            this.BrowseButton.Size = new System.Drawing.Size(75, 23);
            this.BrowseButton.TabIndex = 4;
            this.BrowseButton.Text = "Browse";
            this.BrowseButton.UseVisualStyleBackColor = true;
            // 
            // Products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BrowseButton);
            this.Controls.Add(this.WishListButton);
            this.Controls.Add(this.CartButton);
            this.Controls.Add(this.HomeButton);
            this.Controls.Add(this.flowLayoutPanelProducts);
            this.Name = "Products";
            this.Text = "Products";
            this.Load += new System.EventHandler(this.Products_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelProducts;
        private System.Windows.Forms.Button HomeButton;
        private System.Windows.Forms.Button CartButton;
        private System.Windows.Forms.Button WishListButton;
        private System.Windows.Forms.Button BrowseButton;
    }
}