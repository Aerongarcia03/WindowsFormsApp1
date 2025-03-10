namespace WindowsFormsApp1
{
    partial class Form3
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Label TitleLbl;
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
            this.SaveBtn = new System.Windows.Forms.Button();
            this.TitleLbl = new System.Windows.Forms.Label();

            this.NameLbl = new System.Windows.Forms.Label();
            this.AgeLbl = new System.Windows.Forms.Label();
            this.AddressLbl = new System.Windows.Forms.Label();
            this.ContactLbl = new System.Windows.Forms.Label();
            this.EmailLbl = new System.Windows.Forms.Label();
            this.CourseLbl = new System.Windows.Forms.Label();
            this.YearLbl = new System.Windows.Forms.Label();
            this.GuardianLbl = new System.Windows.Forms.Label();
            this.GuardianContactLbl = new System.Windows.Forms.Label();
            this.HobbiesLbl = new System.Windows.Forms.Label();
            this.NicknameLbl = new System.Windows.Forms.Label();

            this.NameTxt = new System.Windows.Forms.TextBox();
            this.AgeTxt = new System.Windows.Forms.TextBox();
            this.AddressTxt = new System.Windows.Forms.TextBox();
            this.ContactTxt = new System.Windows.Forms.TextBox();
            this.EmailTxt = new System.Windows.Forms.TextBox();
            this.GuardianTxt = new System.Windows.Forms.TextBox();
            this.GuardianContactTxt = new System.Windows.Forms.TextBox();
            this.HobbiesTxt = new System.Windows.Forms.TextBox();
            this.NicknameTxt = new System.Windows.Forms.TextBox();

            this.CourseCmb = new System.Windows.Forms.ComboBox();
            this.YearCmb = new System.Windows.Forms.ComboBox();

            // Labels & Inputs Positioning
            int yOffset = 60;
            string[] labelsText = { "Name:", "Age:", "Address:", "Contact:", "Email:", "Course:", "Year:", "Guardian:", "Guardian Contact:", "Hobbies:", "Nickname:" };
            System.Windows.Forms.Label[] labels = { NameLbl, AgeLbl, AddressLbl, ContactLbl, EmailLbl, CourseLbl, YearLbl, GuardianLbl, GuardianContactLbl, HobbiesLbl, NicknameLbl };
            System.Windows.Forms.Control[] inputs = { NameTxt, AgeTxt, AddressTxt, ContactTxt, EmailTxt, CourseCmb, YearCmb, GuardianTxt, GuardianContactTxt, HobbiesTxt, NicknameTxt };

            for (int i = 0; i < labels.Length; i++)
            {
                labels[i].Text = labelsText[i];
                labels[i].Location = new System.Drawing.Point(20, yOffset);
                this.Controls.Add(labels[i]);

                inputs[i].Location = new System.Drawing.Point(150, yOffset);
                inputs[i].Size = new System.Drawing.Size(200, 20);
                this.Controls.Add(inputs[i]);
                yOffset += 30;
            }

            // Save Button
            this.SaveBtn.Text = "Save";
            this.SaveBtn.Location = new System.Drawing.Point(150, yOffset);
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            this.Controls.Add(this.SaveBtn);

            // Form Properties
            this.ClientSize = new System.Drawing.Size(400, yOffset + 50);
            this.Name = "EditPage";
            this.Text = "Edit Student Details";
        }
    }
}