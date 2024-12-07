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
    public partial class Customer_Purchase_Behavior_Report : Form
    {
        public Customer_Purchase_Behavior_Report()
        {
            InitializeComponent();
        }

        private void Descriptionbutton_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=DESKTOP-RP0INUH\\SQLEXPRESS;Initial Catalog=SHOPVERSE;Integrated Security=True;Encrypt=False";

            string query = @"
    SELECT 
        c.customer_id,
        c.first_name,
        c.last_name,
        COUNT(o.OrderID) AS Purchase_Frequency,
        SUM(oi.Quantity * oi.Price) AS Total_Spend,
        AVG(oi.Quantity * oi.Price) AS Average_Spend
    FROM 
        customer c
    LEFT JOIN 
        Orders o ON c.customer_id = o.customer_id
    LEFT JOIN 
        OrderItem oi ON o.OrderID = oi.OrderID
    GROUP BY 
        c.customer_id, c.first_name, c.last_name
    ORDER BY 
        Total_Spend DESC;";
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

        private void MostActiveCustomersbutton_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=DESKTOP-RP0INUH\\SQLEXPRESS;Initial Catalog=SHOPVERSE;Integrated Security=True;Encrypt=False";
            string query = @"
    SELECT 
        c.customer_id,
        c.first_name,
        c.last_name,
        COUNT(o.OrderID) AS Total_Orders
    FROM 
        customer c
    LEFT JOIN 
        Orders o ON c.customer_id = o.customer_id
    GROUP BY 
        c.customer_id, c.first_name, c.last_name
    ORDER BY 
        Total_Orders DESC;";
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

        private void AvgSpendPerCustbutton_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=DESKTOP-RP0INUH\\SQLEXPRESS;Initial Catalog=SHOPVERSE;Integrated Security=True;Encrypt=False";

            string query = @"

    SELECT 

        c.customer_id,

        c.first_name,

        c.last_name,

        COUNT(o.OrderID) AS Total_Orders,

        SUM(oi.Quantity * oi.Price) AS Total_Spend,

        CASE 

            WHEN COUNT(o.OrderID) = 0 THEN 0

            ELSE SUM(oi.Quantity * oi.Price) / COUNT(o.OrderID)

        END AS Average_Spend

    FROM 

        customer c

    LEFT JOIN 

        Orders o ON c.customer_id = o.customer_id

    LEFT JOIN 

        OrderItem oi ON o.OrderID = oi.OrderID

    GROUP BY 

        c.customer_id, c.first_name, c.last_name

    ORDER BY 

        Average_Spend DESC;";
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

        private void RepeatPurchaseRatebutton_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=DESKTOP-RP0INUH\\SQLEXPRESS;Initial Catalog=SHOPVERSE;Integrated Security=True;Encrypt=False";

            string query = @"
    DECLARE @StartDate DATE = '2023-01-01'; -- Specify your start date
    DECLARE @EndDate DATE = '2023-12-31'; -- Specify your end date

    WITH CustomerOrderCounts AS (
        SELECT 
            c.customer_id,
            COUNT(o.OrderID) AS OrderCount
        FROM 
            customer c
        LEFT JOIN 
            Orders o ON c.customer_id = o.customer_id
        WHERE 
            o.OrderDate BETWEEN @StartDate AND @EndDate
        GROUP BY 
            c.customer_id
    )
    SELECT 
        (CAST(SUM(CASE WHEN OrderCount > 1 THEN 1 ELSE 0 END) AS FLOAT) / 
         COUNT(*)) * 100 AS Repeat_Purchase_Rate,
        COUNT(*) AS Total_Customers
    FROM 
        CustomerOrderCounts;";
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
