
using MySql.Data.MySqlClient;
using System;
using System.Data.SqlClient;

namespace FCMS
{
    public partial class Login : Form
    {
        private const string connectionString = "Data Source=DESKTOP-A95GOKV\\SQLEXPRESS01;Initial Catalog=FCMS;Integrated Security=True";
        public Login()
        {
            InitializeComponent();
        }
        
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PasswordBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void SignUpLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignUp signup = new SignUp();
            signup.Show();
            this.Hide();

        }

        

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            string username = LoginUsernameBox.Text;
            string password = PasswordLoginBox.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both username and password.");
                return;
            }

            try
            {
                using System.Data.SqlClient.SqlConnection connection = new System.Data.SqlClient.SqlConnection(connectionString);
                {
                    connection.Open();
                    string query = "SELECT COUNT(*) FROM Login WHERE username = @Username AND password = @Password";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Username", username);
                        command.Parameters.AddWithValue("@Password", password);

                        object result = command.ExecuteScalar();
                        int count = Convert.ToInt32(result);


                        if (count > 0)
                        {
                            MessageBox.Show("Login successful!");
                            // Perform any additional actions or navigate to another form
                            connection.Close();

                            this.Hide();
                            Dashboard dashForm = new Dashboard();
                            dashForm.Show();
                        }
                        else
                        {
                            MessageBox.Show("Invalid username or password.");
                            connection.Close();
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void usernameBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
