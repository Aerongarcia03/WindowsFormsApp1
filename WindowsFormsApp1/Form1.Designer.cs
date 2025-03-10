namespace WindowsFormsApp1
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox UsernameTxt;
        private System.Windows.Forms.TextBox PasswordTxt;
        private System.Windows.Forms.Button LoginBtn;
        private System.Windows.Forms.Label UsernameLbl;
        private System.Windows.Forms.Label PasswordLbl;

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
            this.UsernameTxt = new System.Windows.Forms.TextBox();
            this.PasswordTxt = new System.Windows.Forms.TextBox();
            this.LoginBtn = new System.Windows.Forms.Button();
            this.UsernameLbl = new System.Windows.Forms.Label();
            this.PasswordLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();

            // UsernameTxt
            this.UsernameTxt.Location = new System.Drawing.Point(100, 30);
            this.UsernameTxt.Name = "UsernameTxt";
            this.UsernameTxt.Size = new System.Drawing.Size(150, 20);

            // PasswordTxt
            this.PasswordTxt.Location = new System.Drawing.Point(100, 70);
            this.PasswordTxt.Name = "PasswordTxt";
            this.PasswordTxt.Size = new System.Drawing.Size(150, 20);
            this.PasswordTxt.UseSystemPasswordChar = true;

            // LoginBtn
            this.LoginBtn.Location = new System.Drawing.Point(100, 110);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(75, 23);
            this.LoginBtn.Text = "Login";
            this.LoginBtn.UseVisualStyleBackColor = true;
            this.LoginBtn.Click += new System.EventHandler(this.LoginBtn_Click);

            // UsernameLbl
            this.UsernameLbl.AutoSize = true;
            this.UsernameLbl.Location = new System.Drawing.Point(30, 30);
            this.UsernameLbl.Name = "UsernameLbl";
            this.UsernameLbl.Text = "Username:";

            // PasswordLbl
            this.PasswordLbl.AutoSize = true;
            this.PasswordLbl.Location = new System.Drawing.Point(30, 70);
            this.PasswordLbl.Name = "PasswordLbl";
            this.PasswordLbl.Text = "Password:";

            // LoginPage
            this.ClientSize = new System.Drawing.Size(300, 200);
            this.Controls.Add(this.UsernameTxt);
            this.Controls.Add(this.PasswordTxt);
            this.Controls.Add(this.LoginBtn);
            this.Controls.Add(this.UsernameLbl);
            this.Controls.Add(this.PasswordLbl);
            this.Name = "LoginPage";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}