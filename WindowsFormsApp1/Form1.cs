using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private int loginAttempts = 0;
        private readonly string MockUsername = "admin123";
        private readonly string MockPassword = "pass123";
        private const int MaxAttempts = 5;

        public Form1()
        {
            InitializeComponent();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            if (IsInputValid())
            {
                if (AuthenticateUser(UsernameTxt.Text, PasswordTxt.Text))
                {
                    MessageBox.Show("Login Successful!", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    OpenStudentForm();
                }
                else
                {
                    HandleFailedLogin();
                }
            }
        }

        private bool IsInputValid()
        {
            if (string.IsNullOrWhiteSpace(UsernameTxt.Text) || string.IsNullOrWhiteSpace(PasswordTxt.Text))
            {
                MessageBox.Show("Please enter both Username and Password!", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private bool AuthenticateUser(string username, string password)
        {
            return username == MockUsername && password == MockPassword;
        }

        private void HandleFailedLogin()
        {
            loginAttempts++;

            if (loginAttempts >= MaxAttempts)
            {
                MessageBox.Show("Too many failed attempts! Login disabled.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                LoginBtn.Enabled = false; // Disable login button after max attempts
            }
            else
            {
                MessageBox.Show($"Incorrect username or password. Attempts left: {MaxAttempts - loginAttempts}",
                                "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void OpenStudentForm()
        {
            Form2 studentForm = new Form2();
            studentForm.Show();
            this.Hide();
        }
    }
}
