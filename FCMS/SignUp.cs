
using System;
using System.Data.SqlClient;

namespace FCMS
{
    public partial class SignUp : Form
    {
        private const string connectionString = "Data Source=DESKTOP-A95GOKV\\SQLEXPRESS01;Initial Catalog=FCMS;Integrated Security=True";


        // Create a SqlConnectionStringBuilder instance
       

        

        public SignUp()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
          
         
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void ConfirmBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void MobileBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void UsernameLabel_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
          
            if (string.IsNullOrEmpty(usernameBox.Text))
            {
                MessageBox.Show("Please enter a username", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(PasswordBox.Text))
            {
                MessageBox.Show("Please enter a password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(MobileBox.Text)||MobileBox.Text.Length!=11)
            {
                MessageBox.Show("Please enter 11 digit long mobile number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(ConfirmBox.Text))
            {
                MessageBox.Show("Please enter the confirm password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (PasswordBox.Text != ConfirmBox.Text)
            {
                MessageBox.Show("Passwords do not match", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    using System.Data.SqlClient.SqlConnection connection = new System.Data.SqlClient.SqlConnection(connectionString);
                    {
                        connection.Open();

                         string insertQuery = "INSERT INTO Login(username, password, mobileno) VALUES (@Username, @Password, @MobileNo)";

                         SqlCommand command = new SqlCommand(insertQuery,
                                                             connection);
                         command.Parameters.AddWithValue("@Username", usernameBox.Text);
                         command.Parameters.AddWithValue("@Password", PasswordBox.Text);
                         command.Parameters.AddWithValue("@MobileNo", MobileBox.Text);

                        int rowsAffected = command.ExecuteNonQuery();
                        
                        Console.WriteLine(rowsAffected);
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Signup successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            // Clear the form fields after successful signup
                            usernameBox.Text = string.Empty;
                            PasswordBox.Text = string.Empty;
                            MobileBox.Text = string.Empty;
                            ConfirmBox.Text = string.Empty;
                        }
                        else
                        {
                            MessageBox.Show("Signup failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (ArgumentException ex)
                {
                   
               
                    MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


               Login loginForm = new Login();
                loginForm.Show();
                this.Hide();
            }
           

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void MobileLabel_Click(object sender, EventArgs e)
        {

        }

        private void PasswordLabel_Click(object sender, EventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void SignUpLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login loginForm = new Login();

            this.Hide();
            loginForm.Show();

        }
    }
}