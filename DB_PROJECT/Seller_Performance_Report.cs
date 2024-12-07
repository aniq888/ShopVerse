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
    public partial class Seller_Performance_Report : Form
    {
        public Seller_Performance_Report()
        {
            InitializeComponent();
        }

        private void TotalSalesperSellerbutton_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=DESKTOP-RP0INUH\\SQLEXPRESS;Initial Catalog=SHOPVERSE;Integrated Security=True;Encrypt=False";

            string query = @"

    SELECT 

        s.SellerID,

        s.StoreName,

        SUM(oi.Price * oi.Quantity) AS Total_Sales

    FROM 

        Seller s

    JOIN 

        Products p ON s.SellerID = p.SellerID  -- Assuming Products table has SellerID

    JOIN 

        OrderItem oi ON p.Product_ID = oi.Product_ID

    JOIN 

        Orders o ON oi.OrderID = o.OrderID

    GROUP BY 

        s.SellerID, s.StoreName

    ORDER BY 

        Total_Sales DESC;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);

                    dataGridView1.DataSource = dataTable; // Bind data to DataGridView
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void AverageProductRatingbutton_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=DESKTOP-RP0INUH\\SQLEXPRESS;Initial Catalog=SHOPVERSE;Integrated Security=True;Encrypt=False";

            string query = @"

    SELECT 

        s.SellerID,

        s.StoreName,

        SUM(oi.Price * oi.Quantity) AS Total_Sales

    FROM 

        Seller s

    JOIN 

        Products p ON s.SellerID = p.SellerID  

    JOIN 

        OrderItem oi ON p.Product_ID = oi.Product_ID

    JOIN 

        Orders o ON oi.OrderID = o.OrderID

    GROUP BY 

        s.SellerID, s.StoreName

    ORDER BY 

        Total_Sales DESC;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);

                    dataGridView1.DataSource = dataTable; // Bind data to DataGridView
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void ReturnandRefundRatebutton_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=DESKTOP-RP0INUH\\SQLEXPRESS;Initial Catalog=SHOPVERSE;Integrated Security=True;Encrypt=False";

            string query = @"

    SELECT 

        COUNT(CASE WHEN o.OrderStatus IN ('Cancelled') THEN 1 END) * 100.0 / COUNT(*) AS Return_Refund_Rate

    FROM 

        Orders o;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);

                    dataGridView1.DataSource = dataTable; // Bind data to DataGridView
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
    }
}
