using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DB_PROJECT
{
    public partial class CartForm : Form
    {
        private static List<Products> Cart = ProductsForm.getPublicCart();
        public CartForm()
        {
            InitializeComponent();
            BackButton.Click += goToProductsForm;
        }

        private void goToProductsForm(object sender, EventArgs e) { 
            ProductsForm productsForm = new ProductsForm();
            productsForm.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void Cart_Load(object sender, EventArgs e)
        {
            //MessageBox.Show(Cart.Count.ToString());
            DisplayProducts();
        }

        private void DisplayProducts()
        {
            flowLayoutPanelCart.Controls.Clear();
            flowLayoutPanelCart.AutoScroll = true;
            double currentSubTotal = 0.0;
            labelSubtotal.Text = "$0.00";

            foreach (var product in Cart)
            {
                Panel productPanel = new Panel
                {
                    Width = 800,
                    Height = 200,
                    BorderStyle = BorderStyle.FixedSingle,
                    Padding = new Padding(10)
                };

                // Create and set the image for the product
                PictureBox productImage = new PictureBox
                {
                    Width = 100,
                    Height = 100,
                    SizeMode = PictureBoxSizeMode.Zoom
                };

                try
                {
                    if (!string.IsNullOrEmpty(product.imageUrl)) // Ensure the URL is not null or empty
                    {
                        productImage.Load(product.imageUrl); // Load the image from the URL
                    }
                    else
                    {
                        MessageBox.Show("URL is Empty!"); // Use a default image if the URL is empty
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Failed to load image: {ex.Message}");
                }

                productPanel.Controls.Add(productImage);
                productImage.Location = new Point(10, 10);

                // Create label for product name
                Label nameLabel = new Label
                {
                    Text = "Name: " + product.name,
                    AutoSize = true,
                    Font = new Font("Arial", 10, FontStyle.Bold),
                    ForeColor = Color.DarkRed
                };
                productPanel.Controls.Add(nameLabel);
                nameLabel.Location = new Point(120, 10);

                // Create label for product price
                Label priceLabel = new Label
                {
                    Text = "Price: $" + product.price.ToString("F2"),
                    AutoSize = true,
                    Font = new Font("Arial", 9),
                    ForeColor = Color.DarkGreen
                };
                productPanel.Controls.Add(priceLabel);
                priceLabel.Location = new Point(120, 40);

                // Create label for product description
                Label descriptionLabel = new Label
                {
                    Text = "Description: " + product.description,
                    AutoSize = true,
                    MaximumSize = new Size(180, 50),
                    Font = new Font("Arial", 8),
                    ForeColor = Color.Gray,
                    TextAlign = ContentAlignment.MiddleLeft
                };
                productPanel.Controls.Add(descriptionLabel);
                descriptionLabel.Location = new Point(120, 70);

                // Create label for product quantity
                Label quantityLabel = new Label
                {
                    Text = "Quantity: " + product.quantity.ToString(),
                    AutoSize = true,
                    Font = new Font("Arial", 8),
                    ForeColor = Color.Blue
                };
                productPanel.Controls.Add(quantityLabel);
                quantityLabel.Location = new Point(120, 100);

                // Update subtotal
                currentSubTotal += product.price * product.quantity;
                labelSubtotal.Text = "Subtotal: $" + currentSubTotal.ToString("F2");

                // Create buttons for incrementing and decrementing the quantity
                Button incrementButton = new Button
                {
                    Text = "+",
                    Width = 50,
                    Height = 30,
                    BackColor = Color.LightGreen
                };
                incrementButton.Location = new Point(250, 100);
                incrementButton.Click += (sender, e) => IncrementQuantity(product, quantityLabel, currentSubTotal);

                Button decrementButton = new Button
                {
                    Text = "-",
                    Width = 50,
                    Height = 30,
                    BackColor = Color.LightCoral
                };
                decrementButton.Location = new Point(320, 100);
                decrementButton.Click += (sender, e) => DecrementQuantity(product, quantityLabel, currentSubTotal);

                // Add the buttons to the panel
                productPanel.Controls.Add(incrementButton);
                productPanel.Controls.Add(decrementButton);

                // Add the product panel to the flow layout panel
                flowLayoutPanelCart.Controls.Add(productPanel);
            }
        }

        // Method to load image from URL (you can implement as per your needs)
        //private Image LoadImageFromUrl(string imageUrl)
        //{
        //    try
        //    {
        //        return Image.FromFile(imageUrl); // Here assuming local file path; use appropriate method for URL
        //    }
        //    catch
        //    {
        //        return null; // Return a default image if loading fails
        //    }
        //}

        private void IncrementQuantity(Products product, Label quantityLabel, double currentSubTotal)
        {
            if (product.quantity < product.getCapacity())
            {
                product.quantity++;
                quantityLabel.Text = "Quantity: " + product.quantity.ToString();
                currentSubTotal += product.price;
                labelSubtotal.Text = "Subtotal: $" + currentSubTotal.ToString("F2");
            }
            else
            {
                MessageBox.Show("Maximum quantity reached for this product.");
            }
        }

        private void DecrementQuantity(Products product, Label quantityLabel, double currentSubTotal)
        {
            if (product.quantity > 0)
            {
                product.quantity--;
                quantityLabel.Text = "Quantity: " + product.quantity.ToString();
                currentSubTotal -= product.getPrice();
                labelSubtotal.Text = "Subtotal: $" + currentSubTotal.ToString("F2");

                if (product.quantity == 0)
                {
                    Cart.Remove(product);
                    DisplayProducts();
                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
