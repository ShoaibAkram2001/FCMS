namespace FCMS
{
    partial class ViewAttendance
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewAttendance));
            this.label1 = new System.Windows.Forms.Label();
            this.searchStd = new System.Windows.Forms.Button();
            this.backBtn = new System.Windows.Forms.Button();
            this.viewAttendanceGridView = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ViewdateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.DateLabel = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.viewAttendanceGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(343, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "View Attendance";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // searchStd
            // 
            this.searchStd.BackColor = System.Drawing.Color.DodgerBlue;
            this.searchStd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.searchStd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchStd.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.searchStd.Location = new System.Drawing.Point(667, 122);
            this.searchStd.Name = "searchStd";
            this.searchStd.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.searchStd.Size = new System.Drawing.Size(226, 49);
            this.searchStd.TabIndex = 9;
            this.searchStd.Text = "View Attendance";
            this.searchStd.UseVisualStyleBackColor = false;
            this.searchStd.Click += new System.EventHandler(this.searchStd_Click);
            // 
            // backBtn
            // 
            this.backBtn.BackColor = System.Drawing.Color.DodgerBlue;
            this.backBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.backBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backBtn.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.backBtn.Location = new System.Drawing.Point(946, 122);
            this.backBtn.Name = "backBtn";
            this.backBtn.Padding = new System.Windows.Forms.Padding(0, 11, 0, 11);
            this.backBtn.Size = new System.Drawing.Size(68, 49);
            this.backBtn.TabIndex = 11;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = false;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // viewAttendanceGridView
            // 
            this.viewAttendanceGridView.BackgroundColor = System.Drawing.Color.White;
            this.viewAttendanceGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.viewAttendanceGridView.GridColor = System.Drawing.SystemColors.Control;
            this.viewAttendanceGridView.Location = new System.Drawing.Point(171, 231);
            this.viewAttendanceGridView.Name = "viewAttendanceGridView";
            this.viewAttendanceGridView.RowHeadersWidth = 51;
            this.viewAttendanceGridView.RowTemplate.Height = 29;
            this.viewAttendanceGridView.Size = new System.Drawing.Size(559, 427);
            this.viewAttendanceGridView.TabIndex = 12;
            this.viewAttendanceGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.viewAttendanceGridView_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.ViewdateTimePicker1);
            this.panel1.Controls.Add(this.DateLabel);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.viewAttendanceGridView);
            this.panel1.Controls.Add(this.backBtn);
            this.panel1.Controls.Add(this.searchStd);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(2, 10);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(5);
            this.panel1.Size = new System.Drawing.Size(1044, 683);
            this.panel1.TabIndex = 8;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // ViewdateTimePicker1
            // 
            this.ViewdateTimePicker1.CalendarFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ViewdateTimePicker1.CalendarForeColor = System.Drawing.Color.Black;
            this.ViewdateTimePicker1.CalendarMonthBackground = System.Drawing.SystemColors.Control;
            this.ViewdateTimePicker1.CalendarTitleBackColor = System.Drawing.SystemColors.Control;
            this.ViewdateTimePicker1.CalendarTitleForeColor = System.Drawing.SystemColors.Control;
            this.ViewdateTimePicker1.CalendarTrailingForeColor = System.Drawing.SystemColors.Control;
            this.ViewdateTimePicker1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ViewdateTimePicker1.Location = new System.Drawing.Point(112, 132);
            this.ViewdateTimePicker1.Name = "ViewdateTimePicker1";
            this.ViewdateTimePicker1.Size = new System.Drawing.Size(549, 32);
            this.ViewdateTimePicker1.TabIndex = 15;
            this.ViewdateTimePicker1.ValueChanged += new System.EventHandler(this.ViewdateTimePicker1_ValueChanged);
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.BackColor = System.Drawing.SystemColors.Control;
            this.DateLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DateLabel.ForeColor = System.Drawing.Color.DodgerBlue;
            this.DateLabel.Location = new System.Drawing.Point(112, 106);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(56, 23);
            this.DateLabel.TabIndex = 14;
            this.DateLabel.Text = "Date";
            this.DateLabel.Click += new System.EventHandler(this.DateLabel_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel5.Location = new System.Drawing.Point(112, 157);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(549, 4);
            this.panel5.TabIndex = 13;
            this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
            // 
            // ViewAttendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1046, 694);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1064, 741);
            this.Name = "ViewAttendance";
            this.Text = "ViewAttendance";
            ((System.ComponentModel.ISupportInitialize)(this.viewAttendanceGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Label label1;
        private Button searchStd;
        private Button backBtn;
        private DataGridView viewAttendanceGridView;
        private Panel panel1;
        private DateTimePicker ViewdateTimePicker1;
        private Label DateLabel;
        private Panel panel5;
    }
}