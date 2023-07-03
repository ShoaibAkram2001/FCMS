namespace FCMS
{
    partial class addStudent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addStudent));
            this.label2 = new System.Windows.Forms.Label();
            this.AgeBox = new System.Windows.Forms.TextBox();
            this.ClassBox = new System.Windows.Forms.TextBox();
            this.RollBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.AgeLabel = new System.Windows.Forms.Label();
            this.ClassLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.RollLabel = new System.Windows.Forms.Label();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.backBtn = new System.Windows.Forms.Button();
            this.addStdBtn = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(48, 461);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.label2.Size = new System.Drawing.Size(313, 74);
            this.label2.TabIndex = 1;
            this.label2.Text = "Faran College\r\n Management System";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // AgeBox
            // 
            this.AgeBox.BackColor = System.Drawing.SystemColors.Control;
            this.AgeBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AgeBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AgeBox.ForeColor = System.Drawing.Color.Black;
            this.AgeBox.Location = new System.Drawing.Point(91, 482);
            this.AgeBox.Multiline = true;
            this.AgeBox.Name = "AgeBox";
            this.AgeBox.Size = new System.Drawing.Size(687, 36);
            this.AgeBox.TabIndex = 7;
            this.AgeBox.TextChanged += new System.EventHandler(this.ConfirmBox_TextChanged);
            // 
            // ClassBox
            // 
            this.ClassBox.BackColor = System.Drawing.SystemColors.Control;
            this.ClassBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ClassBox.ForeColor = System.Drawing.Color.Black;
            this.ClassBox.Location = new System.Drawing.Point(91, 402);
            this.ClassBox.Multiline = true;
            this.ClassBox.Name = "ClassBox";
            this.ClassBox.Size = new System.Drawing.Size(687, 26);
            this.ClassBox.TabIndex = 6;
            this.ClassBox.TextChanged += new System.EventHandler(this.ClassBox_TextChanged);
            // 
            // RollBox
            // 
            this.RollBox.BackColor = System.Drawing.SystemColors.Control;
            this.RollBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RollBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RollBox.ForeColor = System.Drawing.Color.Black;
            this.RollBox.Location = new System.Drawing.Point(91, 307);
            this.RollBox.Multiline = true;
            this.RollBox.Name = "RollBox";
            this.RollBox.Size = new System.Drawing.Size(687, 37);
            this.RollBox.TabIndex = 5;
            this.RollBox.TextChanged += new System.EventHandler(this.RollBox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label3.Location = new System.Drawing.Point(403, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 23);
            this.label3.TabIndex = 3;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // AgeLabel
            // 
            this.AgeLabel.AutoSize = true;
            this.AgeLabel.BackColor = System.Drawing.SystemColors.Control;
            this.AgeLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AgeLabel.ForeColor = System.Drawing.Color.DodgerBlue;
            this.AgeLabel.Location = new System.Drawing.Point(91, 456);
            this.AgeLabel.Name = "AgeLabel";
            this.AgeLabel.Size = new System.Drawing.Size(51, 23);
            this.AgeLabel.TabIndex = 3;
            this.AgeLabel.Text = "Age";
            this.AgeLabel.Click += new System.EventHandler(this.AgeLabel_Click);
            // 
            // ClassLabel
            // 
            this.ClassLabel.AutoSize = true;
            this.ClassLabel.BackColor = System.Drawing.SystemColors.Control;
            this.ClassLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ClassLabel.ForeColor = System.Drawing.Color.DodgerBlue;
            this.ClassLabel.Location = new System.Drawing.Point(91, 376);
            this.ClassLabel.Name = "ClassLabel";
            this.ClassLabel.Size = new System.Drawing.Size(62, 23);
            this.ClassLabel.TabIndex = 3;
            this.ClassLabel.Text = "Class";
            this.ClassLabel.Click += new System.EventHandler(this.ClassLabel_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(0, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(499, 727);
            this.panel2.TabIndex = 3;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FCMS.Properties.Resources.FCMS1;
            this.pictureBox1.Location = new System.Drawing.Point(97, 173);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(225, 236);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // RollLabel
            // 
            this.RollLabel.AutoSize = true;
            this.RollLabel.BackColor = System.Drawing.SystemColors.Control;
            this.RollLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.RollLabel.ForeColor = System.Drawing.Color.DodgerBlue;
            this.RollLabel.Location = new System.Drawing.Point(91, 281);
            this.RollLabel.Name = "RollLabel";
            this.RollLabel.Size = new System.Drawing.Size(79, 23);
            this.RollLabel.TabIndex = 3;
            this.RollLabel.Text = "Roll No";
            this.RollLabel.Click += new System.EventHandler(this.RollLabel_Click);
            // 
            // NameBox
            // 
            this.NameBox.BackColor = System.Drawing.SystemColors.Control;
            this.NameBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NameBox.ForeColor = System.Drawing.Color.Black;
            this.NameBox.Location = new System.Drawing.Point(91, 228);
            this.NameBox.Multiline = true;
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(687, 24);
            this.NameBox.TabIndex = 2;
            this.NameBox.TextChanged += new System.EventHandler(this.NameBox_TextChanged);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel6.Location = new System.Drawing.Point(91, 517);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(687, 5);
            this.panel6.TabIndex = 1;
            this.panel6.Paint += new System.Windows.Forms.PaintEventHandler(this.panel6_Paint);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel5.Location = new System.Drawing.Point(91, 427);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(687, 5);
            this.panel5.TabIndex = 1;
            this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel4.Location = new System.Drawing.Point(91, 343);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(687, 5);
            this.panel4.TabIndex = 1;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel3.Location = new System.Drawing.Point(91, 258);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(687, 3);
            this.panel3.TabIndex = 1;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(287, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Student";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.BackColor = System.Drawing.SystemColors.Control;
            this.NameLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.NameLabel.ForeColor = System.Drawing.Color.DodgerBlue;
            this.NameLabel.Location = new System.Drawing.Point(91, 202);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(70, 23);
            this.NameLabel.TabIndex = 3;
            this.NameLabel.Text = "Name";
            this.NameLabel.Click += new System.EventHandler(this.NameLabel_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.backBtn);
            this.panel1.Controls.Add(this.addStdBtn);
            this.panel1.Controls.Add(this.AgeBox);
            this.panel1.Controls.Add(this.ClassBox);
            this.panel1.Controls.Add(this.RollBox);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.AgeLabel);
            this.panel1.Controls.Add(this.ClassLabel);
            this.panel1.Controls.Add(this.RollLabel);
            this.panel1.Controls.Add(this.NameLabel);
            this.panel1.Controls.Add(this.NameBox);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(502, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.panel1.Size = new System.Drawing.Size(804, 707);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // backBtn
            // 
            this.backBtn.BackColor = System.Drawing.Color.DodgerBlue;
            this.backBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.backBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backBtn.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.backBtn.Location = new System.Drawing.Point(63, 548);
            this.backBtn.Name = "backBtn";
            this.backBtn.Padding = new System.Windows.Forms.Padding(0, 11, 0, 11);
            this.backBtn.Size = new System.Drawing.Size(90, 68);
            this.backBtn.TabIndex = 10;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = false;
            this.backBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // addStdBtn
            // 
            this.addStdBtn.BackColor = System.Drawing.Color.DodgerBlue;
            this.addStdBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.addStdBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addStdBtn.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.addStdBtn.Location = new System.Drawing.Point(263, 622);
            this.addStdBtn.Name = "addStdBtn";
            this.addStdBtn.Padding = new System.Windows.Forms.Padding(0, 11, 0, 11);
            this.addStdBtn.Size = new System.Drawing.Size(331, 68);
            this.addStdBtn.TabIndex = 9;
            this.addStdBtn.Text = "Add Student";
            this.addStdBtn.UseVisualStyleBackColor = false;
            this.addStdBtn.Click += new System.EventHandler(this.addStdBtn_Click);
            // 
            // addStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1309, 703);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1327, 750);
            this.Name = "addStudent";
            this.Text = "addStudent";
            this.Load += new System.EventHandler(this.addStudent_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Label label2;
        private TextBox AgeBox;
        private TextBox ClassBox;
        private TextBox RollBox;
        private Label label3;
        private Label AgeLabel;
        private Label ClassLabel;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Label RollLabel;
        private TextBox NameBox;
        private Panel panel6;
        private Panel panel5;
        private Panel panel4;
        private Panel panel3;
        private Label label1;
        private Label NameLabel;
        private Panel panel1;
        private Button addStdBtn;
        private Button backBtn;
    }
}