using System.Configuration;

namespace StudentRegistrationApplication
{
    public partial class Form1 : Form
    {
        string fName, lName, mName;
        int day, month, year;
        bool isMale, isFemale;
        string gender, program;
        public Form1()
        {
            InitializeComponent();
        }
        public void finalResult(string lastName, string firstName, string middleName, int day, int month, int year)
        {
            MessageBox.Show($"Student name: {lastName} {firstName} {middleName}\nDate of birth: {month}/{day}/{year}");
        }

        public void finalResult(string lastName, string firstName, string middleName, string program)
        {
            MessageBox.Show($"Student name: {lastName} {firstName} {middleName}\nCourse: {program}");
        }

        public void finalResult(string lastName, string firstName, string middleName, string gender, int day, int month, int year)
        {
            MessageBox.Show($"Student name: {lastName} {firstName} {middleName}\nGender: {gender}\nDate of birth: {month}/{day}/{year}");
        }

        //button click
        public void setDefaults()
        {
            // Default Value for Day Combobox
            dayComboBox.Items.Insert(0, "-Day-");
            dayComboBox.SelectedIndex = 0;

            // Default Value for Month Combobox
            monthComboBox.Items.Insert(0, "-Month-");
            monthComboBox.SelectedIndex = 0;

            // Default Value for Year Combobox
            yearComboBox.Items.Insert(0, "-Year-");
            yearComboBox.SelectedIndex = 0;

        }

        public void populateDay()
        {
            for (int x = 1; x <= 31; x++) dayComboBox.Items.Add(x);
        }

        public void populateMonth()
        {
            for (int x = 1; x <= 12; x++) monthComboBox.Items.Add(x);
        }
        public void populateYear()
        {
            for (int x = 1900; x <= DateTime.Now.Year; x++) yearComboBox.Items.Add(x);
        }


        public void getInfo()
        {
            fName = fNameTextBox.Text;
            lName = lNameTextBox.Text;
            mName = mNameTextBox.Text;

            checkIfEmpty(fName);
            checkIfEmpty(lName);
            checkIfEmpty(mName);

            day = Int32.Parse(dayComboBox.Text);
            month = Int32.Parse(monthComboBox.Text);
            year = Int32.Parse(yearComboBox.Text);

            if (!int.TryParse(dayComboBox.SelectedItem?.ToString(), out day) ||
               !int.TryParse(monthComboBox.SelectedItem?.ToString(), out month) ||
               !int.TryParse(yearComboBox.SelectedItem?.ToString(), out year))
            {
                throw new Exception("Please select valid date.");
            }

            program = programComboBox.Text.Trim();
            gender = GetGender();

        }

        public void checkIfEmpty(string data)
        {
            if (data == null || data.Trim() == "") throw new Exception();
        }
        private string GetGender()
        {
            if (maleRadButton.Checked) { return "Male"; }
            if (femaleRadButton.Checked) { return "Female"; }
            throw new Exception("Please select a gender.");
        }
        public void resetField()
        {
            fNameTextBox.Text = string.Empty;
            lNameTextBox.Text = string.Empty;
            mNameTextBox.Text = string.Empty;

            maleRadButton.Checked = false;
            femaleRadButton.Checked = false;

            dayComboBox.Text = string.Empty;
            monthComboBox.Text = string.Empty;
            yearComboBox.Text = string.Empty;
            programComboBox.Text = string.Empty;
        }



        private void regStudentButton_Click(object sender, EventArgs e)
        {
            try
            {
                getInfo();
                finalResult(lName, fName, mName, day, month, year);
                resetField();
                finalResult(lName, fName, mName, program);
                resetField();
                finalResult(lName, fName, mName, gender, day, month, year);
                resetField();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            setDefaults();
            populateDay();
            populateMonth();
            populateYear();
        }
    }
}
