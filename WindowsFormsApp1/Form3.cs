using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form3 : Form
    {
        private readonly Form2 studentPage;

        public Form3(Form2 studentPage)
        {
            InitializeComponent();
            this.studentPage = studentPage ?? throw new ArgumentNullException(nameof(studentPage));
            LoadDropdowns();
        }

        private void LoadDropdowns()
        {
            if (CourseCmb.Items.Count == 0)
                CourseCmb.Items.AddRange(new object[] { "ABEL", "BSBA", "BSIT", "BPA" });

            if (YearCmb.Items.Count == 0)
                YearCmb.Items.AddRange(new object[] { "First", "Second", "Third", "Fourth" });
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            // Validate required fields
            if (string.IsNullOrWhiteSpace(NameTxt.Text) ||
                string.IsNullOrWhiteSpace(AgeTxt.Text) ||
                string.IsNullOrWhiteSpace(AddressTxt.Text) ||
                string.IsNullOrWhiteSpace(ContactTxt.Text) ||
                string.IsNullOrWhiteSpace(EmailTxt.Text) ||
                CourseCmb.SelectedIndex == -1 ||
                YearCmb.SelectedIndex == -1 ||
                string.IsNullOrWhiteSpace(GuardianTxt.Text) ||
                string.IsNullOrWhiteSpace(GuardianContactTxt.Text))
            {
                MessageBox.Show("All required fields must be filled!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validate numeric fields
            if (!IsValidNumber(AgeTxt.Text, out int age) || age <= 0)
            {
                MessageBox.Show("Invalid age! Please enter a valid number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!IsValidNumber(ContactTxt.Text, out _) || !IsValidNumber(GuardianContactTxt.Text, out _))
            {
                MessageBox.Show("Contact numbers must be numeric and valid!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Update student data in Form2
            studentPage.UpdateStudentData(
                NameTxt.Text, AgeTxt.Text, AddressTxt.Text, ContactTxt.Text, EmailTxt.Text,
                CourseCmb.SelectedItem?.ToString(), YearCmb.SelectedItem?.ToString(),
                GuardianTxt.Text, GuardianContactTxt.Text, HobbiesTxt.Text, NicknameTxt.Text
            );

            MessageBox.Show("Profile updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Close the form properly
            using (this) { this.Close(); }
        }

        private bool IsValidNumber(string input, out int number)
        {
            return int.TryParse(input, out number) && number > 0;
        }
    }
}
