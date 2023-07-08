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
    public partial class View_Students : Form
    {
        private const string connectionString = "Data Source=DESKTOP-A95GOKV\\SQLEXPRESS01;Initial Catalog=FCMS;Integrated Security=True";
        public View_Students()
        {
            InitializeComponent();
        }

        private void SearchStudentGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        void BindGridView()
        {

            using System.Data.SqlClient.SqlConnection connection = new System.Data.SqlClient.SqlConnection(connectionString);
            {
                connection.Open();

                String query = "Select * from student";

                using (SqlDataAdapter com = new SqlDataAdapter(query, connection))
                {
                    DataTable dt = new DataTable();
                    com.Fill(dt);
                   viewStudentGridView.DataSource = dt;
                   viewStudentGridView.AllowUserToAddRows = false;
                }
            }
        }

        private void View_Students_Load(object sender, EventArgs e)
        {
            BindGridView();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            Dashboard dash = new Dashboard();
            this.Hide();
            dash.Show();
        }
    }
}
