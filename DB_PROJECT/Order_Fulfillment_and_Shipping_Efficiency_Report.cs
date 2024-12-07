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
    public partial class Order_Fulfillment_and_Shipping_Efficiency_Report : Form
    {
        public Order_Fulfillment_and_Shipping_Efficiency_Report()
        {
            InitializeComponent();
        }

        private void TotalSalesbutton_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=DESKTOP-RP0INUH\\SQLEXPRESS;Initial Catalog=SHOPVERSE;Integrated Security=True;Encrypt=False";

            string query = @"
    SELECT 
        AVG(DATEDIFF(DAY, o.OrderDate, s.ShipmentDate)) AS AverageFulfillmentTime
    FROM 
        Orders o
    INNER JOIN 
        Shipment s ON o.ShipmentID = s.ShipmentID
    WHERE 
        s.ShipmentStatus = 'Shipped';
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

        private void ShippingDelaysbutton_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=DESKTOP-RP0INUH\\SQLEXPRESS;Initial Catalog=SHOPVERSE;Integrated Security=True;Encrypt=False";

            string query = @"
    SELECT 
        o.OrderID, 
        o.OrderDate, 
        s.ShipmentDate, 
        s.DeliveryDate
    FROM 
        Orders o
    INNER JOIN 
        Shipment s ON o.ShipmentID = s.ShipmentID
    WHERE 
        s.DeliveryDate > DATEADD(DAY, 7, s.ShipmentDate); -- Assuming 7 days as the estimated delivery time
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

        private void MostReliableShippingProvidersbutton_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=DESKTOP-RP0INUH\\SQLEXPRESS;Initial Catalog=SHOPVERSE;Integrated Security=True;Encrypt=False";

            string query = @"
    SELECT 
        s.LogisticsProvider,
        AVG(DATEDIFF(DAY, s.ShipmentDate, s.DeliveryDate)) AS AverageDeliveryTime,
        COUNT(CASE WHEN s.ShipmentStatus = 'Delivered' THEN 1 END) AS Deliveries
    FROM 
        Shipment s
    WHERE 
        s.ShipmentStatus = 'Delivered'
    GROUP BY 
        s.LogisticsProvider
    ORDER BY 
        AverageDeliveryTime ASC, Deliveries DESC;
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

        private void OrderCompletionRatebutton_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=DESKTOP-RP0INUH\\SQLEXPRESS;Initial Catalog=SHOPVERSE;Integrated Security=True;Encrypt=False";

            string query = @"
    SELECT 
        CAST(COUNT(CASE WHEN o.OrderStatus = 'Completed' THEN 1 END) AS FLOAT) 
        / COUNT(*) * 100 AS OrderCompletionRate
    FROM 
        Orders o;
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
