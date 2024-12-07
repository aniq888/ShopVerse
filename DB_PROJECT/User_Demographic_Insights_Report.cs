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
    public partial class User_Demographic_Insights_Report : Form
    {
        public User_Demographic_Insights_Report()
        {
            InitializeComponent();
        }

        private void AgeDistributionbutton_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=DESKTOP-RP0INUH\\SQLEXPRESS;Initial Catalog=SHOPVERSE;Integrated Security=True;Encrypt=False";

            string query = @"
SELECT 
    CASE 
        WHEN DATEDIFF(YEAR, DateOfBirth, GETDATE()) < 18 THEN 'Under 18'
        WHEN DATEDIFF(YEAR, DateOfBirth, GETDATE()) BETWEEN 18 AND 24 THEN '18-24'
        WHEN DATEDIFF(YEAR, DateOfBirth, GETDATE()) BETWEEN 25 AND 34 THEN '25-34'
        WHEN DATEDIFF(YEAR, DateOfBirth, GETDATE()) BETWEEN 35 AND 44 THEN '35-44'
        WHEN DATEDIFF(YEAR, DateOfBirth, GETDATE()) BETWEEN 45 AND 54 THEN '45-54'
        ELSE '55+'
    END AS AgeGroup,
    COUNT(*) AS UserCount
FROM 
    Customer
GROUP BY 
    CASE 
        WHEN DATEDIFF(YEAR, DateOfBirth, GETDATE()) < 18 THEN 'Under 18'
        WHEN DATEDIFF(YEAR, DateOfBirth, GETDATE()) BETWEEN 18 AND 24 THEN '18-24'
        WHEN DATEDIFF(YEAR, DateOfBirth, GETDATE()) BETWEEN 25 AND 34 THEN '25-34'
        WHEN DATEDIFF(YEAR, DateOfBirth, GETDATE()) BETWEEN 35 AND 44 THEN '35-44'
        WHEN DATEDIFF(YEAR, DateOfBirth, GETDATE()) BETWEEN 45 AND 54 THEN '45-54'
        ELSE '55+'
    END
ORDER BY AgeGroup;
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

        private void GenderAnalysisbutton_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=DESKTOP-RP0INUH\\SQLEXPRESS;Initial Catalog=SHOPVERSE;Integrated Security=True;Encrypt=False";

            string query = @"
SELECT 
    Gender,
    COUNT(*) * 100.0 / (SELECT COUNT(*) FROM Customer) AS Percentage
FROM 
    Customer
GROUP BY 
    Gender;
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

        private void LocationInsightsbutton_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=DESKTOP-RP0INUH\\SQLEXPRESS;Initial Catalog=SHOPVERSE;Integrated Security=True;Encrypt=False";

            string query = @"
SELECT 
    c.Country,
    c.State,
    c.City,
    SUM(oi.Quantity * oi.Price) AS TotalSales
FROM 
    Orders o
INNER JOIN 
    Customer c ON o.Customer_ID = c.Customer_ID
INNER JOIN 
    OrderItem oi ON o.OrderID = oi.OrderID
WHERE 
    o.OrderStatus = 'Completed'
GROUP BY 
    c.Country, c.State, c.City
ORDER BY 
    TotalSales DESC;
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

        private void DemographicPreferencesbutton_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=DESKTOP-RP0INUH\\SQLEXPRESS;Initial Catalog=SHOPVERSE;Integrated Security=True;Encrypt=False";

            string query = @"
SELECT 
    c.Country,
    c.State,
    c.City,
    c.Gender,
    pc.Category_ID,
    cat.Name AS CategoryName,
    COUNT(oi.Product_ID) AS ProductCount,
    SUM(oi.Quantity * oi.Price) AS TotalSales
FROM 
    Orders o
INNER JOIN 
    Customer c ON o.Customer_ID = c.Customer_ID
INNER JOIN 
    OrderItem oi ON o.OrderID = oi.OrderID
INNER JOIN 
    Products p ON oi.Product_ID = p.Product_ID
INNER JOIN 
    ProductCategory pc ON p.Product_ID = pc.Product_ID
INNER JOIN 
    Category cat ON pc.Category_ID = cat.Category_ID
WHERE 
    o.OrderStatus = 'Completed'
GROUP BY 
    c.Country, c.State, c.City, c.Gender, pc.Category_ID, cat.Name
ORDER BY 
    TotalSales DESC;
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

        private void LBIbutton2_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=DESKTOP-RP0INUH\\SQLEXPRESS;Initial Catalog=SHOPVERSE;Integrated Security=True;Encrypt=False";

            string query = @"
SELECT 
    Country,
    State,
    City,
    COUNT(*) AS UserCount
FROM 
    Customer
GROUP BY 
    Country, State, City
ORDER BY 
    Country, State, City;
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
