using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DB_PROJECT
{
    public partial class Sales_Performance_Report : Form
    {
        public Sales_Performance_Report()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void TotalSalesbutton_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=DESKTOP-RP0INUH\\SQLEXPRESS;Initial Catalog=SHOPVERSE;Integrated Security=True;Encrypt=False";
            string startDate = "2023-01-01"; // Example start date
            string endDate = "2023-12-31";   // Example end date

            string query = $@"
SELECT 
    o.OrderID,
    o.OrderDate,
    o.OrderStatus,
    oi.OrderItemID,
    oi.Quantity,
    oi.Price,
    (oi.Quantity * oi.Price) AS ItemTotal,
    SUM(oi.Quantity * oi.Price) OVER() AS TotalSales
FROM 
    Orders o
INNER JOIN 
    OrderItem oi ON o.OrderID = oi.OrderID
WHERE 
    o.OrderDate BETWEEN '{startDate}' AND '{endDate}'
    AND o.OrderStatus = 'Completed';";


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

        private void AverageOrderValuebutton_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=DESKTOP-RP0INUH\\SQLEXPRESS;Initial Catalog=SHOPVERSE;Integrated Security=True;Encrypt=False";
            string startDate = "2023-01-01"; // Example start date
            string endDate = "2023-12-31";   // Example end date

            string query = $@"
SELECT 
    SUM(oi.Quantity * oi.Price) AS TotalSales,
    COUNT(DISTINCT o.OrderID) AS NumberOfOrders,
    CASE 
        WHEN COUNT(DISTINCT o.OrderID) = 0 THEN 0
        ELSE SUM(oi.Quantity * oi.Price) / COUNT(DISTINCT o.OrderID)
    END AS AverageOrderValue
FROM 
    Orders o
INNER JOIN 
    OrderItem oi ON o.OrderID = oi.OrderID
WHERE 
    o.OrderDate BETWEEN '{startDate}' AND '{endDate}'
    AND o.OrderStatus = 'Completed';";
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

        private void BestSellingProductsbutton_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=DESKTOP-RP0INUH\\SQLEXPRESS;Initial Catalog=SHOPVERSE;Integrated Security=True;Encrypt=False";

            string query = @"
SELECT 
    p.Product_ID,
    p.Product_Name,
    SUM(oi.Quantity) AS TotalQuantitySold
FROM 
    Products p
INNER JOIN 
    OrderItem oi ON p.Product_ID = oi.Product_ID
INNER JOIN 
    Orders o ON oi.OrderID = o.OrderID
WHERE 
    o.OrderStatus = 'Completed'
GROUP BY 
    p.Product_ID, p.Product_Name
ORDER BY 
    TotalQuantitySold DESC;";
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

        private void TopCategoriesbutton_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=DESKTOP-RP0INUH\\SQLEXPRESS;Initial Catalog=SHOPVERSE;Integrated Security=True;Encrypt=False";

            string query = @"

    SELECT 

        c.Name AS Category_Name,

        SUM(oi.Quantity * oi.Price) AS Total_Sales

    FROM 

        OrderItem oi

    JOIN 

        Orders o ON oi.OrderID = o.OrderID

    JOIN 

        Products p ON oi.Product_ID = p.Product_ID

    JOIN 

        Category c ON p.Category_ID = c.Category_ID

    WHERE 

        o.OrderStatus = 'Completed'  -- Only consider completed orders for sales analysis

    GROUP BY 

        c.Name

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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
