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
    public partial class ShowStudent : Form
    {
        private const string connectionString = "Data Source=DESKTOP-A95GOKV\\SQLEXPRESS01;Initial Catalog=FCMS;Integrated Security=True";
        public ShowStudent()
        {
            InitializeComponent();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            Dashboard dash = new Dashboard();
            dash.Show();
            this.Hide();
        }



        private void searchStdBtn_Click(object sender, EventArgs e)
        {

            string rollNo = rollshow.Text.ToString();
            Console.WriteLine("Show student clicked");

            if (string.IsNullOrEmpty(rollNo))
            {
                MessageBox.Show("Please Enter Roll No.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string query = "SELECT * FROM student WHERE rollno = @RollNo";

            try
            {
                using System.Data.SqlClient.SqlConnection connection = new System.Data.SqlClient.SqlConnection(connectionString);
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@RollNo", rollNo);

                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        string name = reader["Name"].ToString();
                        string studentClass = reader["Class"].ToString();
                        int age = Convert.ToInt32(reader["Age"]);


                        String message = "Name :" + name + "\n"
                             + "Roll No :" + rollNo + "\n"
                             + "Class :" + studentClass + "\n"
                             + "Age :" + age + "\n";
                        
      
                         MessageBox.Show(message,
                             "Successfully Search", MessageBoxButtons.OK,
                             MessageBoxIcon.Information);

                        /*Console.WriteLine("Student Details:");
                        Console.WriteLine("Name: " + name);
                        Console.WriteLine("Roll No: " + rollNo);
                        Console.WriteLine("Class: " + studentClass);
                        Console.WriteLine("Age: " + age);*/
                    }
                    else
                    {
                        MessageBox.Show("No matching student record found for the provided roll number.",
                            "Error", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);

                        //Console.WriteLine("No matching student record found for the provided roll number.");
                    }

                    reader.Close();
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while searching for the student record: " + ex.Message);
            }

        }
    }
}
