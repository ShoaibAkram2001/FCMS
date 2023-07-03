namespace FCMS
{
    partial class ShowStudent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShowStudent));
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.rollshow = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.backBtn = new System.Windows.Forms.Button();
            this.searchStd = new System.Windows.Forms.Button();
            this.SearchStudentGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SearchStudentGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.BackColor = System.Drawing.SystemColors.Control;
            this.UsernameLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.UsernameLabel.ForeColor = System.Drawing.Color.DodgerBlue;
            this.UsernameLabel.Location = new System.Drawing.Point(61, 180);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(79, 23);
            this.UsernameLabel.TabIndex = 3;
            this.UsernameLabel.Text = "Roll No";
            // 
            // rollshow
            // 
            this.rollshow.BackColor = System.Drawing.SystemColors.Control;
            this.rollshow.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rollshow.ForeColor = System.Drawing.Color.Black;
            this.rollshow.Location = new System.Drawing.Point(61, 206);
            this.rollshow.Multiline = true;
            this.rollshow.Name = "rollshow";
            this.rollshow.Size = new System.Drawing.Size(549, 23);
            this.rollshow.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel3.Location = new System.Drawing.Point(61, 235);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(549, 3);
            this.panel3.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FCMS.Properties.Resources.FCMS1;
            this.pictureBox1.Location = new System.Drawing.Point(77, 165);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(230, 225);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(213, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Show Student";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panel2.Location = new System.Drawing.Point(-1, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(407, 692);
            this.panel2.TabIndex = 7;
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
            this.label3.Location = new System.Drawing.Point(321, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 23);
            this.label3.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.SearchStudentGridView);
            this.panel1.Controls.Add(this.backBtn);
            this.panel1.Controls.Add(this.searchStd);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.UsernameLabel);
            this.panel1.Controls.Add(this.rollshow);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(403, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(5);
            this.panel1.Size = new System.Drawing.Size(644, 692);
            this.panel1.TabIndex = 6;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // backBtn
            // 
            this.backBtn.BackColor = System.Drawing.Color.DodgerBlue;
            this.backBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.backBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backBtn.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.backBtn.Location = new System.Drawing.Point(61, 272);
            this.backBtn.Name = "backBtn";
            this.backBtn.Padding = new System.Windows.Forms.Padding(0, 11, 0, 11);
            this.backBtn.Size = new System.Drawing.Size(68, 49);
            this.backBtn.TabIndex = 11;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = false;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // searchStd
            // 
            this.searchStd.BackColor = System.Drawing.Color.DodgerBlue;
            this.searchStd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.searchStd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchStd.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.searchStd.Location = new System.Drawing.Point(204, 325);
            this.searchStd.Name = "searchStd";
            this.searchStd.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.searchStd.Size = new System.Drawing.Size(197, 55);
            this.searchStd.TabIndex = 9;
            this.searchStd.Text = "Search Student";
            this.searchStd.UseVisualStyleBackColor = false;
            this.searchStd.Click += new System.EventHandler(this.searchStdBtn_Click);
            // 
            // SearchStudentGridView
            // 
            this.SearchStudentGridView.BackgroundColor = System.Drawing.Color.White;
            this.SearchStudentGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SearchStudentGridView.GridColor = System.Drawing.SystemColors.Control;
            this.SearchStudentGridView.Location = new System.Drawing.Point(95, 453);
            this.SearchStudentGridView.Name = "SearchStudentGridView";
            this.SearchStudentGridView.RowHeadersWidth = 51;
            this.SearchStudentGridView.RowTemplate.Height = 29;
            this.SearchStudentGridView.Size = new System.Drawing.Size(452, 216);
            this.SearchStudentGridView.TabIndex = 12;
            // 
            // ShowStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1046, 694);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1064, 741);
            this.Name = "ShowStudent";
            this.Text = "ShowStudent";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SearchStudentGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Label UsernameLabel;
        private TextBox rollshow;
        private Panel panel3;
        private PictureBox pictureBox1;
        private Label label1;
        private Panel panel2;
        private Label label2;
        private Label label3;
        private Panel panel1;
        private Button searchStd;
        private Button backBtn;
        private DataGridView SearchStudentGridView;
    }
}