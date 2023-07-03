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
    public partial class deleteStudent : Form
    {
        private const string connectionString = "Data Source=DESKTOP-A95GOKV\\SQLEXPRESS01;Initial Catalog=FCMS;Integrated Security=True";
        public deleteStudent()
        {
            InitializeComponent();
        }

        private void deleteStdBtn_Click(object sender, EventArgs e)
        {
            string rollNo = rolldelete.Text.ToString();

            if (string.IsNullOrEmpty(rollNo))
            {
                MessageBox.Show("Please Enter Roll No.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
           

            // SQL query to delete student record based on roll number
            string query = "DELETE FROM student WHERE rollno = @RollNo";

            using System.Data.SqlClient.SqlConnection connection = new System.Data.SqlClient.SqlConnection(connectionString); 
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@RollNo", rollNo);

                connection.Open();
                int rowsAffected = command.ExecuteNonQuery();
                connection.Close();

                if (rowsAffected > 0)
                {

                    rolldelete.Text = String.Empty;
                    MessageBox.Show("Student record deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
              //  Console.WriteLine("Student record deleted successfully!");
                }
                else
                {
                    MessageBox.Show("No matching student record found for the provided roll number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //Console.WriteLine("No matching student record found for the provided roll number.");
                }
            }
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            Dashboard dash = new Dashboard();
            dash.Show();
            this.Hide();
        }
    }
}
