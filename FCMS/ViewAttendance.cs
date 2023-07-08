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
    public partial class ViewAttendance : Form
    {
        private const string connectionString = "Data Source=DESKTOP-A95GOKV\\SQLEXPRESS01;Initial Catalog=FCMS;Integrated Security=True";
        public ViewAttendance()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void searchStd_Click(object sender, EventArgs e)
        {
            using System.Data.SqlClient.SqlConnection connection = new System.Data.SqlClient.SqlConnection(connectionString);
            {
                DateTime selectedDate = ViewdateTimePicker1.Value.Date;
                string query = "SELECT * FROM Attendance WHERE date = @Date";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Date", selectedDate);

                try
                {
                    connection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable attendanceTable = new DataTable();
                    adapter.Fill(attendanceTable);
                   viewAttendanceGridView.DataSource = attendanceTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }

        }

        private void viewAttendanceGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            Dashboard dash = new Dashboard();
            dash.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ViewdateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void DateLabel_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
