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

namespace FCMS
{
    public partial class UpdateStudent : Form
    {
        private const string connectionString = "Data Source=DESKTOP-A95GOKV\\SQLEXPRESS01;Initial Catalog=FCMS;Integrated Security=True";
        public UpdateStudent()
        {
            InitializeComponent();
        }

        private void namebox_TextChanged(object sender, EventArgs e)
        {

        }

        private void rollbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void classbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void agebox_TextChanged(object sender, EventArgs e)
        {

        }

        private void MobileLabel_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void namebox_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void rollbox_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void classbox_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void agebox_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            Dashboard dash = new Dashboard();
            dash.Show();
            this.Hide();
        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

         
            string rollNo = rollupdate.Text.ToString();
;
            string updatedClass = classupdate.Text.ToString();
            string updatedName =nameupdate.Text.ToString();

      

            if (string.IsNullOrEmpty(rollNo) || string.IsNullOrEmpty(updatedClass) || string.IsNullOrEmpty(ageupdate.Text.ToString()) || string.IsNullOrEmpty(Name))
            {
                MessageBox.Show("Please enter All fields.","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int updatedAge = int.Parse(ageupdate.Text.ToString());



            // SQL query to update student record based on roll number
            string query = "UPDATE student SET name = @UpdatedName,class = @UpdatedClass, age = @UpdatedAge WHERE rollno = @RollNo";

            using System.Data.SqlClient.SqlConnection connection = new System.Data.SqlClient.SqlConnection(connectionString);
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@UpdatedName", updatedName);
                command.Parameters.AddWithValue("@UpdatedClass", updatedClass);
                command.Parameters.AddWithValue("@UpdatedAge", updatedAge);
                command.Parameters.AddWithValue("@RollNo", rollNo);

                connection.Open();
                int rowsAffected = command.ExecuteNonQuery();
                connection.Close();

                if (rowsAffected > 0)
                {

                    nameupdate.Text = string.Empty;
                    rollupdate.Text = string.Empty;
                    classupdate.Text = string.Empty;
                    ageupdate.Text = string.Empty;
                    //Console.WriteLine("Student record updated successfully!");
                    MessageBox.Show("Student record updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    //Console.WriteLine("No matching student record found for the provided roll number.");
                    MessageBox.Show("No matching student record found for the provided roll number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
