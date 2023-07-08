using MySql.Data.MySqlClient;
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
    public partial class MarkAttendance : Form
    {
        private const string connectionString = "Data Source=DESKTOP-A95GOKV\\SQLEXPRESS01;Initial Catalog=FCMS;Integrated Security=True";
        public MarkAttendance()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void RollAttendance_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void DateLabel_Click(object sender, EventArgs e)
        {

        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            Dashboard dash = new Dashboard();
            dash.Show();
            this.Hide();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private bool isRollNoAlreadyTaken(String rollNo)
        {
            bool isTaken = false;
            try
            {

                using System.Data.SqlClient.SqlConnection connection = new System.Data.SqlClient.SqlConnection(connectionString);
                {
                    // Check if roll number already exists
                    string checkQuery = "SELECT COUNT(*) FROM student WHERE rollno = @RollNo";
                    SqlCommand checkCommand = new SqlCommand(checkQuery, connection);
                    checkCommand.Parameters.AddWithValue("@RollNo", rollNo);

                    connection.Open();
                    int count = (int)checkCommand.ExecuteScalar();

                    isTaken = (count > 0);



                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

            return isTaken;
        }
        private void button1_Click(object sender, EventArgs e)
        {

            using System.Data.SqlClient.SqlConnection connection = new System.Data.SqlClient.SqlConnection(connectionString);
            {
                DateTime selectedDate = dateTimePicker1.Value.Date;
                String rollNo = RollAttendanceBox.Text.ToString();
                String attendanceStatus = comboBox1.Text.ToString();

                
                if (string.IsNullOrEmpty(rollNo) || string.IsNullOrEmpty(attendanceStatus) || string.IsNullOrEmpty(selectedDate.ToString()))
                {
                    MessageBox.Show("Please enter All fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                
                if (!isRollNoAlreadyTaken(rollNo))
                {
                    MessageBox.Show("Roll No not exist . Please choose a different Roll No.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;

                }



                string query = "INSERT INTO Attendance (rollno, date, AttendanceStatus) VALUES (@StudentID, @Date, @AttendanceStatus)";
                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@StudentID", rollNo);
                command.Parameters.AddWithValue("@Date", selectedDate);
                command.Parameters.AddWithValue("@AttendanceStatus", attendanceStatus);

                connection.Open();

                int rowsAffected = command.ExecuteNonQuery();
                connection.Close();

                if (rowsAffected > 0)
                {

                    RollAttendanceBox.Text = string.Empty;
                    dateTimePicker1.Text = string.Empty;
                    comboBox1.Text = string.Empty;
         
                    // Console.WriteLine("Student record added successfully!");
                    MessageBox.Show("Student Attendance has been marked successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // Console.WriteLine("Failed to add student record.");
                    MessageBox.Show("Failed to mark student attendance.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
