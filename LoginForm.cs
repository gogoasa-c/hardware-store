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

namespace hardware_store
{
    public partial class LoginForm : Form
    {
        public static Boolean userLogged = false;
        private string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=project;Integrated Security=True;";
        private Label welcomeLab;
        private Button button;

        public LoginForm(ref Label welcomeLabel, ref Button showStocksButton)
        {
            InitializeComponent();
            this.ControlBox = false;
            this.TopMost = true;
            this.welcomeLab = welcomeLabel;
            this.button = showStocksButton;
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string username = this.adminLogin.UsernameTextBox.Text;
            string password = this.adminLogin.PasswordTextBox.Text;

            if(password == string.Empty || username == string.Empty)
            {
                MessageBox.Show("Invalid Credentials!");
            }

            string query = "SELECT COUNT(*) FROM dbo.User_Info WHERE Username = @Username AND Password = @Password";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@Password", password);

                    connection.Open();
                    int count = (int)command.ExecuteScalar();
                    connection.Close();

                    if (count > 0)
                    {
                        userLogged = true;
                        this.welcomeLab.Text = "Welcome, " + username + "!";
                        MainForm.enableButton();
                        button.Enabled = true;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Invalid Credentials!");
                    }
                }
            }
        }
    }
}
