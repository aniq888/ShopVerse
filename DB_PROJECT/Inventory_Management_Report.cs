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
    public partial class Inventory_Management_Report : Form
    {
        public Inventory_Management_Report()
        {
            InitializeComponent();
        }

        private void LowStockAlertbutton_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=DESKTOP-RP0INUH\\SQLEXPRESS;Initial Catalog=SHOPVERSE;Integrated Security=True;Encrypt=False";

            string query = @"
    SELECT 
        p.Product_ID,
        p.Product_Name,
        p.Quantity
    FROM 
        Products p
    WHERE 
        p.Quantity < 10;"; 
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

        private void DeadStockbutton_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=DESKTOP-RP0INUH\\SQLEXPRESS;Initial Catalog=SHOPVERSE;Integrated Security=True;Encrypt=False";

            string query = @"

    SELECT 

        p.Product_ID,

        p.Product_Name

    FROM 

        Products p

    LEFT JOIN 

        OrderItem oi ON p.Product_ID = oi.Product_ID

    LEFT JOIN 

        Orders o ON oi.OrderID = o.OrderID

    WHERE 

        o.OrderDate < DATEADD(MONTH, -6, GETDATE()) OR o.OrderDate IS NULL

    GROUP BY 

        p.Product_ID, p.Product_Name;";
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

        private void StockTurnoverRatebutton_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=DESKTOP-RP0INUH\\SQLEXPRESS;Initial Catalog=SHOPVERSE;Integrated Security=True;Encrypt=False";
            string query=@"

    SELECT 

        p.Product_ID,

        p.Product_Name,

        SUM(oi.Quantity) AS Total_Units_Sold,

        AVG(p.Quantity) AS Average_Inventory,

        CASE 

            WHEN AVG(p.Quantity) = 0 THEN 0

            ELSE SUM(oi.Quantity) / AVG(p.Quantity)

        END AS Stock_Turnover_Rate

    FROM 

        Products p

    LEFT JOIN 

        OrderItem oi ON p.Product_ID = oi.Product_ID

    LEFT JOIN 

        Orders o ON oi.OrderID = o.OrderID

    GROUP BY 

        p.Product_ID, p.Product_Name;";
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

        private void MostReturnedItemsbutton_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=DESKTOP-RP0INUH\\SQLEXPRESS;Initial Catalog=SHOPVERSE;Integrated Security=True;Encrypt=False";
            string query = @"

    SELECT 

        p.Product_ID,

        p.Product_Name,

        COUNT(r.ReviewID) AS Total_Returns,

        AVG(r.Rating) AS Average_Rating

    FROM 

        Products p

    LEFT JOIN 

        Review r ON p.Product_ID = r.Product_ID

    GROUP BY 

        p.Product_ID, p.Product_Name

    HAVING 

        COUNT(r.ReviewID) > 5 OR AVG(r.Rating) < 3

    ORDER BY 

        Total_Returns DESC;";
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
