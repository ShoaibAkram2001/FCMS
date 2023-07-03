using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FCMS
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CollegeAddress_Click(object sender, EventArgs e)
        {

        }

        private void DashboardHead_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            MarkAttendance addStd = new MarkAttendance();
            addStd.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {
           UpdateStudent addStd = new UpdateStudent();
            addStd.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            addStudent addStd = new addStudent();
            addStd.Show();
            this.Hide();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void addStd_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void showStd_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Show_Click(object sender, EventArgs e)
        {
            ShowStudent addStd = new ShowStudent();
            addStd.Show();
            this.Hide();
        }

        private void DeleteStd_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Logout_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            Login addStd = new Login();
            addStd.Show();
            this.Hide();
        }

        private void panel6_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            MarkAttendance addStd = new MarkAttendance();
            addStd.Show();
            this.Hide();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            addStudent addStd = new addStudent();
            addStd.Show();
            this.Hide();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
           UpdateStudent addStd = new UpdateStudent();
            addStd.Show();
            this.Hide();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            ShowStudent addStd = new ShowStudent();
            addStd.Show();
            this.Hide();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
           deleteStudent addStd = new deleteStudent();
            addStd.Show();
            this.Hide();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            deleteStudent addStd = new deleteStudent();
            addStd.Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
          ViewAttendance addStd = new ViewAttendance();
            addStd.Show();
            this.Hide();
        }

        private void view_Click(object sender, EventArgs e)
        {
            ViewAttendance addStd = new ViewAttendance();
            addStd.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Login addStd = new Login();
            addStd.Show();
            this.Hide();
        }
    }
}
