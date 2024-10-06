namespace StudentRegistrationApplication
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            lNameTextBox = new TextBox();
            fNameTextBox = new TextBox();
            mNameTextBox = new TextBox();
            dayComboBox = new ComboBox();
            yearComboBox = new ComboBox();
            programComboBox = new ComboBox();
            label7 = new Label();
            maleRadButton = new RadioButton();
            femaleRadButton = new RadioButton();
            regStudentButton = new Button();
            monthComboBox = new ComboBox();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label1.Location = new Point(12, 21);
            label1.Name = "label1";
            label1.Size = new Size(314, 32);
            label1.TabIndex = 0;
            label1.Text = "Student Registration Form";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 60);
            label2.Name = "label2";
            label2.Size = new Size(86, 20);
            label2.TabIndex = 1;
            label2.Text = "Last name *";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 113);
            label3.Name = "label3";
            label3.Size = new Size(87, 20);
            label3.TabIndex = 2;
            label3.Text = "First name *";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(26, 166);
            label4.Name = "label4";
            label4.Size = new Size(107, 20);
            label4.TabIndex = 3;
            label4.Text = "Middle name *";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(26, 219);
            label5.Name = "label5";
            label5.Size = new Size(57, 20);
            label5.TabIndex = 4;
            label5.Text = "Gender";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(26, 244);
            label6.Name = "label6";
            label6.Size = new Size(104, 20);
            label6.TabIndex = 5;
            label6.Text = "Date of birth *";
            // 
            // lNameTextBox
            // 
            lNameTextBox.Location = new Point(26, 83);
            lNameTextBox.Name = "lNameTextBox";
            lNameTextBox.Size = new Size(172, 27);
            lNameTextBox.TabIndex = 6;
            // 
            // fNameTextBox
            // 
            fNameTextBox.Location = new Point(26, 136);
            fNameTextBox.Name = "fNameTextBox";
            fNameTextBox.Size = new Size(172, 27);
            fNameTextBox.TabIndex = 7;
            // 
            // mNameTextBox
            // 
            mNameTextBox.Location = new Point(26, 189);
            mNameTextBox.Name = "mNameTextBox";
            mNameTextBox.Size = new Size(172, 27);
            mNameTextBox.TabIndex = 8;
            // 
            // dayComboBox
            // 
            dayComboBox.FormattingEnabled = true;
            dayComboBox.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31" });
            dayComboBox.Location = new Point(26, 267);
            dayComboBox.Name = "dayComboBox";
            dayComboBox.Size = new Size(77, 28);
            dayComboBox.TabIndex = 9;
            dayComboBox.Text = "-Day-";
            // 
            // yearComboBox
            // 
            yearComboBox.FormattingEnabled = true;
            yearComboBox.Items.AddRange(new object[] { "1975", "1976", "1977", "1978", "1979", "1980", "1981", "1982", "1983", "1984", "1985", "1986", "1987", "1988", "1989", "1990", "1991", "1992", "1993", "1994", "1995", "1996", "1997", "1998", "1999", "2000", "2001", "2002", "2003", "2004", "2005", "2006", "2007", "2008", "2009", "2010", "2011", "2012", "2013", "2014", "2015", "2016", "2017", "2018", "2019", "2020", "2021", "2022", "2023", "2024" });
            yearComboBox.Location = new Point(192, 267);
            yearComboBox.Name = "yearComboBox";
            yearComboBox.Size = new Size(77, 28);
            yearComboBox.TabIndex = 11;
            yearComboBox.Text = "-Year-";
            // 
            // programComboBox
            // 
            programComboBox.FormattingEnabled = true;
            programComboBox.Items.AddRange(new object[] { "Bachelor of Science in Information Technology (BSIT)", "Bachelor of Science in Computer Science (BSCS)", "Bachelor of Science in Business Administration (BSBA)", "Bachelor of Science in Accountancy (BSA)", "Bachelor of Science in Hospitality Management (BSHM)", "Bachelor of Science in Tourism Management (BSTM)", "Bachelor of Science in Computer Engineering (BSCpE)", "Bachelor of Science in Communication (BSC)", "Bachelor of Science in Entrepreneurship (BSE)", "Bachelor of Science in Multimedia Arts (BSMA)", "Bachelor of Science in Retail Technology and Consumer Science" });
            programComboBox.Location = new Point(26, 321);
            programComboBox.Name = "programComboBox";
            programComboBox.Size = new Size(210, 28);
            programComboBox.TabIndex = 12;
            programComboBox.Text = "-Select preferred program-";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(26, 298);
            label7.Name = "label7";
            label7.Size = new Size(135, 20);
            label7.TabIndex = 13;
            label7.Text = "Program to apply *";
            // 
            // maleRadButton
            // 
            maleRadButton.AutoSize = true;
            maleRadButton.Location = new Point(89, 217);
            maleRadButton.Name = "maleRadButton";
            maleRadButton.Size = new Size(63, 24);
            maleRadButton.TabIndex = 14;
            maleRadButton.TabStop = true;
            maleRadButton.Text = "Male";
            maleRadButton.UseVisualStyleBackColor = true;
            // 
            // femaleRadButton
            // 
            femaleRadButton.AutoSize = true;
            femaleRadButton.Location = new Point(158, 217);
            femaleRadButton.Name = "femaleRadButton";
            femaleRadButton.Size = new Size(78, 24);
            femaleRadButton.TabIndex = 15;
            femaleRadButton.TabStop = true;
            femaleRadButton.Text = "Female";
            femaleRadButton.UseVisualStyleBackColor = true;
            // 
            // regStudentButton
            // 
            regStudentButton.BackColor = Color.Firebrick;
            regStudentButton.ForeColor = SystemColors.ButtonFace;
            regStudentButton.Location = new Point(25, 355);
            regStudentButton.Name = "regStudentButton";
            regStudentButton.Size = new Size(148, 36);
            regStudentButton.TabIndex = 16;
            regStudentButton.Text = "Register Student";
            regStudentButton.UseVisualStyleBackColor = false;
            regStudentButton.Click += regStudentButton_Click;
            // 
            // monthComboBox
            // 
            monthComboBox.FormattingEnabled = true;
            monthComboBox.Location = new Point(109, 267);
            monthComboBox.Name = "monthComboBox";
            monthComboBox.Size = new Size(77, 28);
            monthComboBox.TabIndex = 17;
            monthComboBox.Text = "-Month-";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(329, 77);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(306, 232);
            pictureBox1.TabIndex = 18;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ButtonShadow;
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(432, 315);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 19;
            button1.Text = "Browse";
            button1.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(693, 409);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Controls.Add(monthComboBox);
            Controls.Add(regStudentButton);
            Controls.Add(femaleRadButton);
            Controls.Add(maleRadButton);
            Controls.Add(label7);
            Controls.Add(programComboBox);
            Controls.Add(yearComboBox);
            Controls.Add(dayComboBox);
            Controls.Add(mNameTextBox);
            Controls.Add(fNameTextBox);
            Controls.Add(lNameTextBox);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox lNameTextBox;
        private TextBox fNameTextBox;
        private TextBox mNameTextBox;
        private ComboBox dayComboBox;
        private ComboBox yearComboBox;
        private ComboBox programComboBox;
        private Label label7;
        private RadioButton maleRadButton;
        private RadioButton femaleRadButton;
        private Button regStudentButton;
        private ComboBox monthComboBox;
        private PictureBox pictureBox1;
        private Button button1;
    }
}
