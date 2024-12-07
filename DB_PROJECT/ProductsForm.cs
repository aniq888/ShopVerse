using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DB_PROJECT
{
    public partial class ProductsForm : Form
    {
        private static List<Products> Cart = new List<Products>();
        public static List<Products> getPublicCart() {
            return Cart;
        }

        public void setPublicCart(List<Products> Cart){
            ProductsForm.Cart = Cart;
        }
        public ProductsForm()
        {
            InitializeComponent();
            CartButton.Click += goToCart;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void goToCart(object sender, EventArgs e) { 
            CartForm cartPage = new CartForm();
            cartPage.Show();
            this.Hide();
        }

        private void Products_Load(object sender, EventArgs e)
        {
            Panel containerPanel = new Panel();
            containerPanel.Dock = DockStyle.Fill;
            containerPanel.Padding = new Padding(0, 100, 0, 0);

            flowLayoutPanelProducts.Dock = DockStyle.Fill;
            flowLayoutPanelProducts.AutoScroll = true;
            containerPanel.Controls.Add(flowLayoutPanelProducts);

            this.Controls.Add(containerPanel);
            LoadProducts();
        }

        private void LoadProducts()
        {
            string connectionString = "Data Source=MOIZ-PC\\ROOT;Initial Catalog=shopverse;Integrated Security=True;Encrypt=False";

            string query = "SELECT TOP 10 product_name, category_name, retail_price, discounted_price, image, description, " +
                           "product_rating, overall_rating, brand, category_id, product_id, quantity FROM Products";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        flowLayoutPanelProducts.Controls.Clear();

                        while (reader.Read())
                        {
                            Products product = new Products();
                            product.setProduct_id(int.Parse(reader["product_id"].ToString()));
                            product.setName(reader["product_name"].ToString());
                            product.setPrice(int.Parse(reader["discounted_price"].ToString()));
                            product.setDescription(reader["description"].ToString());
                            product.setCapacity(int.Parse(reader["quantity"].ToString()));
                            string productId = reader["product_id"].ToString();
                            Panel productPanel = new Panel
                            {
                                Width = 1000,
                                Height = 250,
                                Padding = new Padding(20),
                                BorderStyle = BorderStyle.FixedSingle
                            };

                            PictureBox pictureBox = new PictureBox
                            {
                                Width = 100,
                                Height = 100,
                                SizeMode = PictureBoxSizeMode.Zoom
                            };

                            string images = reader["image"].ToString();
                            if (!string.IsNullOrEmpty(images) && images.StartsWith("[") && images.EndsWith("]"))
                            {
                                images = images.Substring(1, images.Length - 2);
                                string[] imageUrls = images.Split(',');
                                if (imageUrls.Length > 0)
                                {
                                    string imageUrl = imageUrls[0].Trim('\"');
                                    try
                                    {
                                        pictureBox.Load(imageUrl); // Load image from URL
                                        product.setImageUrl(imageUrl);
                                    }
                                    catch
                                    {
                                        MessageBox.Show("Failed to load image from URL: " + imageUrl);
                                    }
                                }
                            }
                            else
                            {
                                MessageBox.Show("Invalid image format.");
                            }

                            Label nameLabel = new Label
                            {
                                Text = "Name: " + reader["product_name"].ToString(),
                                AutoSize = true,
                                Font = new Font("Arial", 10, FontStyle.Bold),
                                ForeColor = Color.DarkRed
                            };

                            Label priceLabel = new Label
                            {
                                Text = "Price: $" + reader["retail_price"].ToString(),
                                AutoSize = true,
                                Font = new Font("Arial", 9),
                                ForeColor = Color.DarkGreen
                            };

                            Label descriptionLabel = new Label
                            {
                                Text = "Description: " + reader["description"].ToString(),
                                AutoSize = true,
                                MaximumSize = new Size(180, 50),
                                Font = new Font("Arial", 8),
                                ForeColor = Color.Gray
                            };

                            productPanel.Controls.Add(pictureBox);
                            pictureBox.Location = new Point(10, 10);

                            productPanel.Controls.Add(nameLabel);
                            nameLabel.Location = new Point(120, 10);

                            productPanel.Controls.Add(priceLabel);
                            priceLabel.Location = new Point(120, 40);

                            productPanel.Controls.Add(descriptionLabel);
                            descriptionLabel.Location = new Point(120, 70);

                            Button addToCartButton = new Button
                            {
                                Text = "Add to Cart",
                                Width = 120,
                                Height = 30,
                                BackColor = Color.LightGreen,
                                Font = new Font("Arial", 9),
                            };
                            addToCartButton.Location = new Point(120, 150);
                            addToCartButton.Click += (s, e) => AddToCart(product); // Pass product ID

                            Button addToWishListButton = new Button
                            {
                                Text = "Add to Wish List",
                                Width = 120,
                                Height = 30,
                                BackColor = Color.LightBlue,
                                Font = new Font("Arial", 9),
                            };
                            addToWishListButton.Location = new Point(250, 150);
                            addToWishListButton.Click += (s, e) => AddToWishList(product); // Pass product ID

                            productPanel.Controls.Add(addToCartButton);
                            productPanel.Controls.Add(addToWishListButton);

                            flowLayoutPanelProducts.Controls.Add(productPanel);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading products: " + ex.Message);
                }
            }
        }

        private void AddToCart(Products product)
        {
            Cart.Add(product);
        }

        private void AddToWishList(Products product)
        {

        }

        private void flowLayoutPanelProducts_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}