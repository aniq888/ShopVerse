using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace DB_PROJECT
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
            buttonLogin.Click += LoginFunc;
            BackToRegister.Click += goToRegister;
        }

        private void goToRegister(object sender, EventArgs e) { 
            frmregister register = new frmregister();
            register.Show();
            this.Hide();
        }

        private void LoginFunc(object sender, EventArgs e) {
            String username = textUserName.Text;
            String password = textpassword.Text;

            if (username == "" || password == "")
            {
                MessageBox.Show("Please enter username and password for logging in");
            }
            else {
                if (CustomerradioButton.Checked) {
                    CustomerLogin(username, password);
                }
            }
        }

        private void CustomerLogin(String username, String password) {
            try {
                SqlConnection conn = new SqlConnection("Data Source=DESKTOP-RP0INUH\\SQLEXPRESS;Initial Catalog=SHOPVERSE;Integrated Security=True;Encrypt=False;");
                conn.Open();
                SqlCommand cm;
                string query = "Select * from customer where username= @username;";

                cm = new SqlCommand(query, conn);
                cm.Parameters.AddWithValue("@username", username);

                SqlDataReader reader = cm.ExecuteReader();

                if (reader.HasRows)
                {
                    // If a result is returned, compare the input password with the stored password
                    reader.Read();
                    String storedPassword = reader["password"].ToString();

                    if (storedPassword == password)
                    {
                        HomePage home = new HomePage();
                        home.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Invalid password. Please try again.");
                    }
                }
                else
                {
                    MessageBox.Show("Username not found. Please check your username.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void checkShowPassword_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {

        }
    }
}
