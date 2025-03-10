namespace WindowsFormsApp1
{
    partial class Form2
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button EditBtn;
        private System.Windows.Forms.Label TitleLbl;
        private System.Windows.Forms.PictureBox StudentPic;
        private System.Windows.Forms.Button AddImageBtn;
        private System.Windows.Forms.Button ChangeImageBtn;
        private System.Windows.Forms.Label NameLbl, AgeLbl, AddressLbl, ContactLbl, EmailLbl, CourseLbl, YearLbl, GuardianLbl, GuardianContactLbl, HobbiesLbl, NicknameLbl;
        private System.Windows.Forms.TextBox NameTxt, AgeTxt, AddressTxt, ContactTxt, EmailTxt, GuardianTxt, GuardianContactTxt, HobbiesTxt, NicknameTxt;
        private System.Windows.Forms.ComboBox CourseCmb, YearCmb;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.EditBtn = new System.Windows.Forms.Button();
            this.TitleLbl = new System.Windows.Forms.Label();
            this.StudentPic = new System.Windows.Forms.PictureBox();
            this.AddImageBtn = new System.Windows.Forms.Button();
            this.ChangeImageBtn = new System.Windows.Forms.Button();
            this.NameTxt = new System.Windows.Forms.TextBox();
            this.AgeTxt = new System.Windows.Forms.TextBox();
            this.AddressTxt = new System.Windows.Forms.TextBox();
            this.ContactTxt = new System.Windows.Forms.TextBox();
            this.EmailTxt = new System.Windows.Forms.TextBox();
            this.CourseCmb = new System.Windows.Forms.ComboBox();
            this.YearCmb = new System.Windows.Forms.ComboBox();
            this.GuardianTxt = new System.Windows.Forms.TextBox();
            this.GuardianContactTxt = new System.Windows.Forms.TextBox();
            this.HobbiesTxt = new System.Windows.Forms.TextBox();
            this.NicknameTxt = new System.Windows.Forms.TextBox();

            // Title Label
            this.TitleLbl.Text = "Student Information";
            this.TitleLbl.Location = new System.Drawing.Point(20, 20);
            this.Controls.Add(this.TitleLbl);

            // Student Picture
            this.StudentPic.Location = new System.Drawing.Point(20, 50);
            this.StudentPic.Size = new System.Drawing.Size(100, 100);
            this.StudentPic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.StudentPic);

            // Buttons
            this.AddImageBtn.Text = "Add Image";
            this.AddImageBtn.Location = new System.Drawing.Point(130, 50);
            this.Controls.Add(this.AddImageBtn);

            this.ChangeImageBtn.Text = "Change Image";
            this.ChangeImageBtn.Location = new System.Drawing.Point(130, 80);
            this.Controls.Add(this.ChangeImageBtn);

            // Text Fields & Labels
            int yOffset = 160;
            string[] labelsText = { "Name:", "Age:", "Address:", "Contact:", "Email:", "Course:", "Year:", "Guardian:", "Guardian Contact:", "Hobbies:", "Nickname:" };
            System.Windows.Forms.Label[] labels = { NameLbl, AgeLbl, AddressLbl, ContactLbl, EmailLbl, CourseLbl, YearLbl, GuardianLbl, GuardianContactLbl, HobbiesLbl, NicknameLbl };
            System.Windows.Forms.Control[] inputs = { NameTxt, AgeTxt, AddressTxt, ContactTxt, EmailTxt, CourseCmb, YearCmb, GuardianTxt, GuardianContactTxt, HobbiesTxt, NicknameTxt };

            for (int i = 0; i < labels.Length; i++)
            {
                labels[i] = new System.Windows.Forms.Label();
                labels[i].Text = labelsText[i];
                labels[i].Location = new System.Drawing.Point(20, yOffset);
                this.Controls.Add(labels[i]);

                inputs[i].Location = new System.Drawing.Point(150, yOffset);
                inputs[i].Size = new System.Drawing.Size(200, 20);
                this.Controls.Add(inputs[i]);
                yOffset += 30;
            }

            // Edit Button
            this.EditBtn.Text = "Edit";
            this.EditBtn.Location = new System.Drawing.Point(150, yOffset);
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
            this.Controls.Add(this.EditBtn);

            // Form Properties
            this.ClientSize = new System.Drawing.Size(400, yOffset + 50);
            this.Name = "StudentPage";
            this.Text = "Student Details";
        }
    }
}