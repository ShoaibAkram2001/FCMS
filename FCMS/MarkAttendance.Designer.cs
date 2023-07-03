namespace FCMS
{
    partial class MarkAttendance
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MarkAttendance));
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.RollAttendanceBox = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.MarkAttendanceLabel = new System.Windows.Forms.Label();
            this.RollAttendance = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.backBtn = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.AttendanceStatusLabel = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.submitAttendBtn = new System.Windows.Forms.Button();
            this.DateLabel = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(35, 453);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(5);
            this.label2.Size = new System.Drawing.Size(309, 74);
            this.label2.TabIndex = 1;
            this.label2.Text = "Faran College\r\n Management System";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label3.Location = new System.Drawing.Point(323, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 20);
            this.label3.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(2, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(399, 692);
            this.panel2.TabIndex = 3;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FCMS.Properties.Resources.FCMS1;
            this.pictureBox1.Location = new System.Drawing.Point(61, 160);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(230, 225);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // RollAttendanceBox
            // 
            this.RollAttendanceBox.BackColor = System.Drawing.SystemColors.Control;
            this.RollAttendanceBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RollAttendanceBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RollAttendanceBox.ForeColor = System.Drawing.Color.Black;
            this.RollAttendanceBox.Location = new System.Drawing.Point(73, 217);
            this.RollAttendanceBox.Multiline = true;
            this.RollAttendanceBox.Name = "RollAttendanceBox";
            this.RollAttendanceBox.Size = new System.Drawing.Size(549, 23);
            this.RollAttendanceBox.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel3.Location = new System.Drawing.Point(73, 246);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(549, 3);
            this.panel3.TabIndex = 1;
            // 
            // MarkAttendanceLabel
            // 
            this.MarkAttendanceLabel.AutoSize = true;
            this.MarkAttendanceLabel.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.MarkAttendanceLabel.ForeColor = System.Drawing.Color.DodgerBlue;
            this.MarkAttendanceLabel.Location = new System.Drawing.Point(188, 72);
            this.MarkAttendanceLabel.Name = "MarkAttendanceLabel";
            this.MarkAttendanceLabel.Size = new System.Drawing.Size(244, 32);
            this.MarkAttendanceLabel.TabIndex = 0;
            this.MarkAttendanceLabel.Text = "Mark Attendance";
            // 
            // RollAttendance
            // 
            this.RollAttendance.AutoSize = true;
            this.RollAttendance.BackColor = System.Drawing.SystemColors.Control;
            this.RollAttendance.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.RollAttendance.ForeColor = System.Drawing.Color.DodgerBlue;
            this.RollAttendance.Location = new System.Drawing.Point(73, 191);
            this.RollAttendance.Name = "RollAttendance";
            this.RollAttendance.Size = new System.Drawing.Size(79, 23);
            this.RollAttendance.TabIndex = 3;
            this.RollAttendance.Text = "Roll No";
            this.RollAttendance.Click += new System.EventHandler(this.RollAttendance_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Controls.Add(this.backBtn);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.AttendanceStatusLabel);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.submitAttendBtn);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.DateLabel);
            this.panel1.Controls.Add(this.RollAttendance);
            this.panel1.Controls.Add(this.RollAttendanceBox);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.MarkAttendanceLabel);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(399, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(5);
            this.panel1.Size = new System.Drawing.Size(644, 692);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // backBtn
            // 
            this.backBtn.BackColor = System.Drawing.Color.DodgerBlue;
            this.backBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.backBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backBtn.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.backBtn.Location = new System.Drawing.Point(73, 490);
            this.backBtn.Name = "backBtn";
            this.backBtn.Padding = new System.Windows.Forms.Padding(0, 11, 0, 11);
            this.backBtn.Size = new System.Drawing.Size(89, 68);
            this.backBtn.TabIndex = 16;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = false;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.SystemColors.Control;
            this.comboBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.comboBox1.ForeColor = System.Drawing.Color.Black;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "P",
            "A"});
            this.comboBox1.Location = new System.Drawing.Point(73, 419);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(549, 31);
            this.comboBox1.TabIndex = 15;
            this.comboBox1.Text = "P";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(323, 409);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 13;
            // 
            // AttendanceStatusLabel
            // 
            this.AttendanceStatusLabel.AutoSize = true;
            this.AttendanceStatusLabel.BackColor = System.Drawing.SystemColors.Control;
            this.AttendanceStatusLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AttendanceStatusLabel.ForeColor = System.Drawing.Color.DodgerBlue;
            this.AttendanceStatusLabel.Location = new System.Drawing.Point(69, 386);
            this.AttendanceStatusLabel.Name = "AttendanceStatusLabel";
            this.AttendanceStatusLabel.Size = new System.Drawing.Size(254, 23);
            this.AttendanceStatusLabel.TabIndex = 14;
            this.AttendanceStatusLabel.Text = "Select Attendance Status";
            this.AttendanceStatusLabel.Click += new System.EventHandler(this.label4_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel4.Location = new System.Drawing.Point(73, 450);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(549, 3);
            this.panel4.TabIndex = 11;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dateTimePicker1.CalendarForeColor = System.Drawing.Color.Black;
            this.dateTimePicker1.CalendarMonthBackground = System.Drawing.SystemColors.Control;
            this.dateTimePicker1.CalendarTitleBackColor = System.Drawing.SystemColors.Control;
            this.dateTimePicker1.CalendarTitleForeColor = System.Drawing.SystemColors.Control;
            this.dateTimePicker1.CalendarTrailingForeColor = System.Drawing.SystemColors.Control;
            this.dateTimePicker1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimePicker1.Location = new System.Drawing.Point(73, 313);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(549, 32);
            this.dateTimePicker1.TabIndex = 10;
            // 
            // submitAttendBtn
            // 
            this.submitAttendBtn.BackColor = System.Drawing.Color.DodgerBlue;
            this.submitAttendBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.submitAttendBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.submitAttendBtn.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.submitAttendBtn.Location = new System.Drawing.Point(230, 576);
            this.submitAttendBtn.Name = "submitAttendBtn";
            this.submitAttendBtn.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.submitAttendBtn.Size = new System.Drawing.Size(265, 65);
            this.submitAttendBtn.TabIndex = 9;
            this.submitAttendBtn.Text = "Submit";
            this.submitAttendBtn.UseVisualStyleBackColor = false;
            this.submitAttendBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.BackColor = System.Drawing.SystemColors.Control;
            this.DateLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DateLabel.ForeColor = System.Drawing.Color.DodgerBlue;
            this.DateLabel.Location = new System.Drawing.Point(73, 287);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(56, 23);
            this.DateLabel.TabIndex = 3;
            this.DateLabel.Text = "Date";
            this.DateLabel.Click += new System.EventHandler(this.DateLabel_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel5.Location = new System.Drawing.Point(73, 338);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(549, 4);
            this.panel5.TabIndex = 1;
            // 
            // MarkAttendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1046, 694);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1195, 741);
            this.Name = "MarkAttendance";
            this.Text = "Attendance";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Label label2;
        private Label label3;
        private Panel panel2;
        private PictureBox pictureBox1;
        private TextBox RollAttendanceBox;
        private Panel panel3;
        private Label MarkAttendanceLabel;
        private Label RollAttendance;
        private Panel panel1;
        private Button submitAttendBtn;
        private Label DateLabel;
        private Panel panel5;
        private DateTimePicker dateTimePicker1;
        private Label label1;
        private Label AttendanceStatusLabel;
        private Panel panel4;
        private ComboBox comboBox1;
        private Button backBtn;
    }
}