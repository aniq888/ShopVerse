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
    public partial class Revenue_by_Product_Category_Report : Form
    {
        public Revenue_by_Product_Category_Report()
        {
            InitializeComponent();
        }

        private void RevenuePerCategorybutton_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=DESKTOP-RP0INUH\\SQLEXPRESS;Initial Catalog=SHOPVERSE;Integrated Security=True;Encrypt=False";

            string query = @"

    SELECT 

        pc.Category_ID,

        SUM(oi.Price * oi.Quantity) AS Total_Revenue

    FROM 

        OrderItem oi

    JOIN 

        Orders o ON oi.OrderID = o.OrderID

    JOIN 

        ProductCategory pc ON oi.Product_ID = pc.Product_ID

    GROUP BY 

        pc.Category_ID;";
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

        private void PercentageContributionbutton_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=DESKTOP-RP0INUH\\SQLEXPRESS;Initial Catalog=SHOPVERSE;Integrated Security=True;Encrypt=False";

            string query = @"

    WITH CategoryRevenue AS (

        SELECT 

            pc.Category_ID,

            SUM(oi.Price * oi.Quantity) AS Total_Revenue

        FROM 

            OrderItem oi

        JOIN 

            Orders o ON oi.OrderID = o.OrderID

        JOIN 

            ProductCategory pc ON oi.Product_ID = pc.Product_ID

        GROUP BY 

            pc.Category_ID

    ),

    TotalRevenue AS (

        SELECT 

            SUM(Total_Revenue) AS Overall_Revenue

        FROM 

            CategoryRevenue

    )

    SELECT 

        cr.Category_ID,

        cr.Total_Revenue,

        (cr.Total_Revenue / tr.Overall_Revenue) * 100 AS Percentage_Contribution

    FROM 

        CategoryRevenue cr, TotalRevenue tr;";
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

        private void TrendingCategoriesbutton_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=DESKTOP-RP0INUH\\SQLEXPRESS;Initial Catalog=SHOPVERSE;Integrated Security=True;Encrypt=False";

            string query = @"

    SELECT 

        pc.Category_ID,

        SUM(oi.Price * oi.Quantity) AS Total_Revenue

    FROM 

        OrderItem oi

    JOIN 

        Orders o ON oi.OrderID = o.OrderID

    JOIN 

        ProductCategory pc ON oi.Product_ID = pc.Product_ID

    GROUP BY 

        pc.Category_ID;";
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
