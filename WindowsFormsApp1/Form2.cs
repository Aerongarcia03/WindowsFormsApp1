using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            this.Load += Form2_Load;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            LoadStudentData();
        }

        private void LoadStudentData()
        {
            // Set default student details
            NameTxt.Text = "Aeron James Garcia";
            AgeTxt.Text = "21";
            AddressTxt.Text = "Bongato East, Bayambang, Pangasinan";
            ContactTxt.Text = "09302218766";
            EmailTxt.Text = "aerongarcia033@gmail.com";

            // Populate ComboBoxes if empty
            if (CourseCmb.Items.Count == 0)
                CourseCmb.Items.AddRange(new object[] { "ABEL", "BSBA", "BSIT", "BPA" });

            if (YearCmb.Items.Count == 0)
                YearCmb.Items.AddRange(new object[] { "First", "Second", "Third", "Fourth" });

            // Set default selections
            CourseCmb.SelectedItem = "BSIT";
            YearCmb.SelectedItem = "Third";

            GuardianTxt.Text = "Arcelia Garcia";
            GuardianContactTxt.Text = "09776685694";
            HobbiesTxt.Text = "Watching";
            NicknameTxt.Text = "Aero";
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            using (Form3 editForm = new Form3(this))
            {
                editForm.ShowDialog();
            }
        }

        public void UpdateStudentData(
            string name, string age, string address, string contact, string email,
            string course, string year, string guardian, string guardianContact,
            string hobbies, string nickname)
        {
            // Ensure null safety
            NameTxt.Text = name ?? NameTxt.Text;
            AgeTxt.Text = age ?? AgeTxt.Text;
            AddressTxt.Text = address ?? AddressTxt.Text;
            ContactTxt.Text = contact ?? ContactTxt.Text;
            EmailTxt.Text = email ?? EmailTxt.Text;

            if (!string.IsNullOrEmpty(course) && CourseCmb.Items.Contains(course))
                CourseCmb.SelectedItem = course;

            if (!string.IsNullOrEmpty(year) && YearCmb.Items.Contains(year))
                YearCmb.SelectedItem = year;

            GuardianTxt.Text = guardian ?? GuardianTxt.Text;
            GuardianContactTxt.Text = guardianContact ?? GuardianContactTxt.Text;
            HobbiesTxt.Text = hobbies ?? HobbiesTxt.Text;
            NicknameTxt.Text = nickname ?? NicknameTxt.Text;
        }
    }
}
