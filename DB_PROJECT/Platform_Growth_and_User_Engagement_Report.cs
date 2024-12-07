using System;
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
    public partial class Platform_Growth_and_User_Engagement_Report : Form
    {
        public Platform_Growth_and_User_Engagement_Report()
        {
            InitializeComponent();
        }

        private void NewUserRegistrationsbutton_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=DESKTOP-RP0INUH\\SQLEXPRESS;Initial Catalog=SHOPVERSE;Integrated Security=True;Encrypt=False";
            string startDate = "2023-01-01"; // Example start date
            string endDate = "2023-12-31";   // Example end date

            string query = $@"
SELECT 
    COUNT(*) AS NewUserRegistrations
FROM 
    Customer
WHERE 
    CreatedDate BETWEEN '{startDate}' AND '{endDate}';
";
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

        private void UserEngagementMetricsbutton_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=DESKTOP-RP0INUH\\SQLEXPRESS;Initial Catalog=SHOPVERSE;Integrated Security=True;Encrypt=False";
            string startDate = "2023-01-01"; // Example start date
            string endDate = "2023-12-31";   // Example end date

            string query = $@"
SELECT 
    Customer_ID,
    COUNT(*) AS LoginCount
FROM 
    Logins
WHERE 
    LoginDate BETWEEN '{startDate}' AND '{endDate}'
GROUP BY 
    Customer_ID
ORDER BY 
    LoginCount DESC;
";
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

        private void ChurnRatebutton_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=DESKTOP-RP0INUH\\SQLEXPRESS;Initial Catalog=SHOPVERSE;Integrated Security=True;Encrypt=False";

            string query = @"
SELECT 
    (CAST(SUM(CASE WHEN OrderCount = 1 THEN 1 ELSE 0 END) AS FLOAT) / COUNT(*)) * 100 AS ChurnRate
FROM (
    SELECT 
        Customer_ID,
        COUNT(OrderID) AS OrderCount
    FROM 
        Orders
    GROUP BY 
        Customer_ID
) AS CustomerOrders;
";
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

        private void ActiveUserRatiobutton_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=DESKTOP-RP0INUH\\SQLEXPRESS;Initial Catalog=SHOPVERSE;Integrated Security=True;Encrypt=False";

            string query = @"
SELECT 
    (CAST(ActiveUsers AS FLOAT) / TotalUsers) * 100 AS ActiveUserRatio
FROM (
    SELECT 
        (SELECT COUNT(DISTINCT Customer_ID) FROM Orders) AS ActiveUsers,
        (SELECT COUNT(*) FROM Customer) AS TotalUsers
) AS UserStats;
";
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
