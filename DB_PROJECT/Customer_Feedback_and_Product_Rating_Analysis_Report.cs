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
    public partial class Customer_Feedback_and_Product_Rating_Analysis_Report : Form
    {
        public Customer_Feedback_and_Product_Rating_Analysis_Report()
        {
            InitializeComponent();
        }

        private void AverageRatingbyProductbutton_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=DESKTOP-RP0INUH\\SQLEXPRESS;Initial Catalog=SHOPVERSE;Integrated Security=True;Encrypt=False";

            string query = @"

    SELECT 

        p.Product_ID,

        p.Product_Name,

        AVG(r.Rating) AS Average_Rating

    FROM 

        Products p

    LEFT JOIN 

        Review r ON p.Product_ID = r.Product_ID

    GROUP BY 

        p.Product_ID, p.Product_Name

    ORDER BY 

        Average_Rating DESC;";
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

        private void ProductSentimentAnalysisbutton_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=DESKTOP-RP0INUH\\SQLEXPRESS;Initial Catalog=SHOPVERSE;Integrated Security=True;Encrypt=False";

            string query = @"

    SELECT 

        p.Product_ID,

        p.Product_Name,

        CASE 

            WHEN r.Comment LIKE '%excellent%' THEN 'Positive'

            WHEN r.Comment LIKE '%good%' THEN 'Positive'

            WHEN r.Comment LIKE '%bad%' THEN 'Negative'

            WHEN r.Comment LIKE '%poor quality%' THEN 'Negative'

            ELSE 'Neutral'

        END AS Sentiment,

        COUNT(*) AS Review_Count

    FROM 

        Products p

    LEFT JOIN 

        Review r ON p.Product_ID = r.Product_ID

    GROUP BY 

        p.Product_ID, p.Product_Name, 

        CASE 

            WHEN r.Comment LIKE '%excellent%' THEN 'Positive'

            WHEN r.Comment LIKE '%good%' THEN 'Positive'

            WHEN r.Comment LIKE '%bad%' THEN 'Negative'

            WHEN r.Comment LIKE '%poor quality%' THEN 'Negative'

            ELSE 'Neutral'

        END

    ORDER BY 

        p.Product_ID;";
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

        private void TopRatedProductsbutton_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=DESKTOP-RP0INUH\\SQLEXPRESS;Initial Catalog=SHOPVERSE;Integrated Security=True;Encrypt=False";

            string query = @"

    SELECT 
top 10
        p.Product_ID,

        p.Product_Name,

        AVG(r.Rating) AS Average_Rating

    FROM 

        Products p

    JOIN 

        Review r ON p.Product_ID = r.Product_ID

    GROUP BY 

        p.Product_ID, p.Product_Name

    HAVING 

        AVG(r.Rating) IS NOT NULL

    ORDER BY 

        Average_Rating DESC

    ;";
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
