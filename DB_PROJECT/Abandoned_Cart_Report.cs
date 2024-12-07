using System;
using System.Collections;
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
    public partial class Abandoned_Cart_Report : Form
    {
        public Abandoned_Cart_Report()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void NumberofAbandonedCartsbutton_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=DESKTOP-RP0INUH\\SQLEXPRESS;Initial Catalog=SHOPVERSE;Integrated Security=True;Encrypt=False";
            string startDate = "2023-01-01"; // Example start date
            string endDate = "2023-12-31";   // Example end date

            string query = $@"
SELECT 
    COUNT(*) AS AbandonedCartCount
FROM 
    Cart
WHERE 
    Status = 'Abandoned'
    AND LastUpdatedDate BETWEEN '{startDate}' AND '{endDate}';";

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
        
        

        private void AvgValuebutton_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=DESKTOP-RP0INUH\\SQLEXPRESS;Initial Catalog=SHOPVERSE;Integrated Security=True;Encrypt=False";

            string query = @"
    SELECT 
        AVG(CartValue) AS AverageAbandonedCartValue
    FROM (
        SELECT 
            c.CartID, 
            SUM(ci.Quantity * ci.Price) AS CartValue
        FROM 
            Cart c
        INNER JOIN 
            CartItem ci ON c.CartID = ci.CartID
        WHERE 
            c.Status = 'Abandoned'
        GROUP BY 
            c.CartID
    ) AbandonedCarts;
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

        private void ProductAnalysisbutton_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=DESKTOP-RP0INUH\\SQLEXPRESS;Initial Catalog=SHOPVERSE;Integrated Security=True;Encrypt=False";

            string query = @"
    SELECT 
        p.Product_Name, 
        COUNT(ci.Product_ID) AS TimesLeftInCart
    FROM 
        Cart c
    INNER JOIN 
        CartItem ci ON c.CartID = ci.CartID
    INNER JOIN 
        Products p ON ci.Product_ID = p.Product_ID
    WHERE 
        c.Status = 'Abandoned'
    GROUP BY 
        p.Product_ID, p.Product_Name
    ORDER BY 
        TimesLeftInCart DESC;
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

        private void AbandonmentReasonsbutton_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=DESKTOP-RP0INUH\\SQLEXPRESS;Initial Catalog=SHOPVERSE;Integrated Security=True;Encrypt=False";

            string query = @"
    SELECT 
        Reason, 
        COUNT(*) AS Occurrences
    FROM 
        CartFeedback
    GROUP BY 
        Reason
    ORDER BY 
        Occurrences DESC;
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
