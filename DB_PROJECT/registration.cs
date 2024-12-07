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
    public partial class frmregister : Form
    {
        public frmregister()
        {
            InitializeComponent();
            buttonRegister.Click += RegisterFunc; // No parentheses here
            BackToLogin.Click += goToLogin;
        }

        private void goToLogin(object sender, EventArgs e) {
            login loginpage = new login();
            loginpage.Show();
            this.Hide();
        }

        private void RegisterFunc(object sender, EventArgs e)
        {
            //MessageBox.Show("Register button clicked!");
            String firstName = textFirstName.Text;
            String lastName = LastNametextBox.Text;
            String email = EmailtextBox.Text;
            String address = AddresstextBox.Text;
            String password = textpassword.Text;
            String confirmPass = textconfirmpassword.Text;

            if(firstName == "" || lastName == "" || email == "" || address == "" || password == "" || confirmPass == ""){
                MessageBox.Show("Plaese Enter text in all the fields!");
            }
            if (CustomerradioButton.Checked) {
                CustomerRegister(firstName, lastName, email, address, password, confirmPass);
            }
        }

        private void CustomerRegister(String firstName, String lastName, String email, String address, String password, String confirmPass) {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-RP0INUH\\SQLEXPRESS;Initial Catalog=SHOPVERSE;Integrated Security=True;Encrypt=False;");
            conn.Open();
            SqlCommand cm;
            string query = "INSERT INTO customer (first_name, last_name, email, address, password) " +
               "VALUES (@FirstName, @LastName, @Email, @Address, @Password)";

            cm = new SqlCommand(query, conn);
            cm.Parameters.AddWithValue("@FirstName", firstName);
            cm.Parameters.AddWithValue("@LastName", lastName);
            cm.Parameters.AddWithValue("@", email);
            cm.Parameters.AddWithValue("@Address", address);
            cm.Parameters.AddWithValue("@Password", password);

            cm.ExecuteNonQuery();
            cm.Dispose();
            conn.Close();
            
            login loginpage = new login();
            loginpage.Show();
            this.Hide();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkShowPassword_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
