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
    public partial class addStudent : Form
    {
        private const string connectionString = "Data Source=DESKTOP-A95GOKV\\SQLEXPRESS01;Initial Catalog=FCMS;Integrated Security=True";
        public addStudent()
        {
            InitializeComponent();
        }

        private void NameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void RollBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ClassBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ConfirmBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void AgeLabel_Click(object sender, EventArgs e)
        {

        }

        private void ClassLabel_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void RollLabel_Click(object sender, EventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void NameLabel_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void addStdBtn_Click(object sender, EventArgs e)
        {

            string Name = NameBox.Text.ToString();


            string RollNo = RollBox.Text.ToString();

            string StudentClass = ClassBox.Text.ToString();

            if (string.IsNullOrEmpty(RollNo) || string.IsNullOrEmpty(StudentClass) || string.IsNullOrEmpty(AgeBox.Text.ToString()) || string.IsNullOrEmpty(Name))
            {
                MessageBox.Show("Please enter All fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int Age = int.Parse(AgeBox.Text.ToString());


            string query = "INSERT INTO student (name, rollno, class, age) VALUES (@Name, @Rollno, @Class, @Age)";

            using System.Data.SqlClient.SqlConnection connection = new System.Data.SqlClient.SqlConnection(connectionString);
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Name", Name);
                command.Parameters.AddWithValue("@Rollno", RollNo);
                command.Parameters.AddWithValue("@Class", StudentClass);
                command.Parameters.AddWithValue("@Age", Age);

                connection.Open();
                int rowsAffected = command.ExecuteNonQuery();
                connection.Close();

                if (rowsAffected > 0)
                {

                  NameBox.Text = string.Empty;
                    RollBox.Text = string.Empty;
                    ClassBox.Text = string.Empty;
                    AgeBox.Text = string.Empty;
                    // Console.WriteLine("Student record added successfully!");
                    MessageBox.Show("Student record added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                   // Console.WriteLine("Failed to add student record.");
                    MessageBox.Show("Failed to add student record.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }



        }

        private void addStudent_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dashboard dash = new Dashboard();
            dash.Show();
            this.Hide();
        }
    }
}
