namespace StatisticalApp
{
    partial class LoginForm
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
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.LoginPage = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.label_Username = new MetroFramework.Controls.MetroLabel();
            this.label_Password = new MetroFramework.Controls.MetroLabel();
            this.txtBox_Username = new MetroFramework.Controls.MetroTextBox();
            this.txtBox_Password = new MetroFramework.Controls.MetroTextBox();
            this.btn_Login = new MetroFramework.Controls.MetroButton();
            this.btn_Cancel_Login = new MetroFramework.Controls.MetroButton();
            this.label_Username_Register = new MetroFramework.Controls.MetroLabel();
            this.label_Password_Register = new MetroFramework.Controls.MetroLabel();
            this.label_Confirm_Password_Register = new MetroFramework.Controls.MetroLabel();
            this.txtBox_Username_Register = new MetroFramework.Controls.MetroTextBox();
            this.txtBox_Password_Register = new MetroFramework.Controls.MetroTextBox();
            this.txtBox_Confirm_Password_Register = new MetroFramework.Controls.MetroTextBox();
            this.btn_Register = new MetroFramework.Controls.MetroButton();
            this.btn_Cancel_Register = new MetroFramework.Controls.MetroButton();
            this.metroPanel1.SuspendLayout();
            this.LoginPage.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.metroTabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.LoginPage);
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(0, 0);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(345, 378);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // LoginPage
            // 
            this.LoginPage.Controls.Add(this.metroTabPage1);
            this.LoginPage.Controls.Add(this.metroTabPage2);
            this.LoginPage.ItemSize = new System.Drawing.Size(70, 31);
            this.LoginPage.Location = new System.Drawing.Point(3, 51);
            this.LoginPage.Name = "LoginPage";
            this.LoginPage.SelectedIndex = 0;
            this.LoginPage.Size = new System.Drawing.Size(339, 315);
            this.LoginPage.TabIndex = 10;
            this.LoginPage.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.LoginPage.UseStyleColors = true;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.metroTabPage1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.metroTabPage1.Controls.Add(this.btn_Cancel_Login);
            this.metroTabPage1.Controls.Add(this.btn_Login);
            this.metroTabPage1.Controls.Add(this.txtBox_Password);
            this.metroTabPage1.Controls.Add(this.txtBox_Username);
            this.metroTabPage1.Controls.Add(this.label_Password);
            this.metroTabPage1.Controls.Add(this.label_Username);
            this.metroTabPage1.CustomBackground = true;
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 35);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(331, 276);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Login";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.btn_Cancel_Register);
            this.metroTabPage2.Controls.Add(this.btn_Register);
            this.metroTabPage2.Controls.Add(this.txtBox_Confirm_Password_Register);
            this.metroTabPage2.Controls.Add(this.txtBox_Password_Register);
            this.metroTabPage2.Controls.Add(this.txtBox_Username_Register);
            this.metroTabPage2.Controls.Add(this.label_Confirm_Password_Register);
            this.metroTabPage2.Controls.Add(this.label_Password_Register);
            this.metroTabPage2.Controls.Add(this.label_Username_Register);
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 35);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(331, 276);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "Register";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            // 
            // label_Username
            // 
            this.label_Username.AutoSize = true;
            this.label_Username.Location = new System.Drawing.Point(5, 72);
            this.label_Username.Name = "label_Username";
            this.label_Username.Size = new System.Drawing.Size(68, 19);
            this.label_Username.TabIndex = 2;
            this.label_Username.Text = "Username";
            // 
            // label_Password
            // 
            this.label_Password.AutoSize = true;
            this.label_Password.Location = new System.Drawing.Point(5, 120);
            this.label_Password.Name = "label_Password";
            this.label_Password.Size = new System.Drawing.Size(64, 19);
            this.label_Password.TabIndex = 3;
            this.label_Password.Text = "Password";
            // 
            // txtBox_Username
            // 
            this.txtBox_Username.Location = new System.Drawing.Point(103, 72);
            this.txtBox_Username.Name = "txtBox_Username";
            this.txtBox_Username.Size = new System.Drawing.Size(147, 23);
            this.txtBox_Username.TabIndex = 4;
            // 
            // txtBox_Password
            // 
            this.txtBox_Password.Location = new System.Drawing.Point(103, 120);
            this.txtBox_Password.Name = "txtBox_Password";
            this.txtBox_Password.PasswordChar = '*';
            this.txtBox_Password.Size = new System.Drawing.Size(147, 23);
            this.txtBox_Password.TabIndex = 5;
            // 
            // btn_Login
            // 
            this.btn_Login.Location = new System.Drawing.Point(37, 210);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(75, 23);
            this.btn_Login.TabIndex = 6;
            this.btn_Login.Text = "Login";
            // 
            // btn_Cancel_Login
            // 
            this.btn_Cancel_Login.Location = new System.Drawing.Point(143, 210);
            this.btn_Cancel_Login.Name = "btn_Cancel_Login";
            this.btn_Cancel_Login.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancel_Login.TabIndex = 7;
            this.btn_Cancel_Login.Text = "Cancel";
            // 
            // label_Username_Register
            // 
            this.label_Username_Register.AutoSize = true;
            this.label_Username_Register.Location = new System.Drawing.Point(25, 63);
            this.label_Username_Register.Name = "label_Username_Register";
            this.label_Username_Register.Size = new System.Drawing.Size(68, 19);
            this.label_Username_Register.TabIndex = 2;
            this.label_Username_Register.Text = "Username";
            // 
            // label_Password_Register
            // 
            this.label_Password_Register.AutoSize = true;
            this.label_Password_Register.Location = new System.Drawing.Point(25, 103);
            this.label_Password_Register.Name = "label_Password_Register";
            this.label_Password_Register.Size = new System.Drawing.Size(64, 19);
            this.label_Password_Register.TabIndex = 3;
            this.label_Password_Register.Text = "Password";
            // 
            // label_Confirm_Password_Register
            // 
            this.label_Confirm_Password_Register.AutoSize = true;
            this.label_Confirm_Password_Register.Location = new System.Drawing.Point(25, 138);
            this.label_Confirm_Password_Register.Name = "label_Confirm_Password_Register";
            this.label_Confirm_Password_Register.Size = new System.Drawing.Size(116, 19);
            this.label_Confirm_Password_Register.TabIndex = 4;
            this.label_Confirm_Password_Register.Text = "Confirm Password";
            // 
            // txtBox_Username_Register
            // 
            this.txtBox_Username_Register.Location = new System.Drawing.Point(162, 59);
            this.txtBox_Username_Register.Name = "txtBox_Username_Register";
            this.txtBox_Username_Register.Size = new System.Drawing.Size(155, 23);
            this.txtBox_Username_Register.TabIndex = 5;
            // 
            // txtBox_Password_Register
            // 
            this.txtBox_Password_Register.Location = new System.Drawing.Point(162, 99);
            this.txtBox_Password_Register.Name = "txtBox_Password_Register";
            this.txtBox_Password_Register.PasswordChar = '*';
            this.txtBox_Password_Register.Size = new System.Drawing.Size(155, 23);
            this.txtBox_Password_Register.TabIndex = 6;
            // 
            // txtBox_Confirm_Password_Register
            // 
            this.txtBox_Confirm_Password_Register.Location = new System.Drawing.Point(162, 134);
            this.txtBox_Confirm_Password_Register.Name = "txtBox_Confirm_Password_Register";
            this.txtBox_Confirm_Password_Register.PasswordChar = '*';
            this.txtBox_Confirm_Password_Register.Size = new System.Drawing.Size(155, 23);
            this.txtBox_Confirm_Password_Register.TabIndex = 7;
            // 
            // btn_Register
            // 
            this.btn_Register.Location = new System.Drawing.Point(48, 215);
            this.btn_Register.Name = "btn_Register";
            this.btn_Register.Size = new System.Drawing.Size(75, 23);
            this.btn_Register.TabIndex = 8;
            this.btn_Register.Text = "Register";
            // 
            // btn_Cancel_Register
            // 
            this.btn_Cancel_Register.Location = new System.Drawing.Point(162, 215);
            this.btn_Cancel_Register.Name = "btn_Cancel_Register";
            this.btn_Cancel_Register.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancel_Register.TabIndex = 9;
            this.btn_Cancel_Register.Text = "Cancel";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 378);
            this.Controls.Add(this.metroPanel1);
            this.Name = "LoginForm";
            this.Text = "Form1";
            this.metroPanel1.ResumeLayout(false);
            this.LoginPage.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.metroTabPage1.PerformLayout();
            this.metroTabPage2.ResumeLayout(false);
            this.metroTabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroTabControl LoginPage;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private MetroFramework.Controls.MetroTextBox txtBox_Password;
        private MetroFramework.Controls.MetroTextBox txtBox_Username;
        private MetroFramework.Controls.MetroLabel label_Password;
        private MetroFramework.Controls.MetroLabel label_Username;
        private MetroFramework.Controls.MetroButton btn_Cancel_Login;
        private MetroFramework.Controls.MetroButton btn_Login;
        private MetroFramework.Controls.MetroButton btn_Cancel_Register;
        private MetroFramework.Controls.MetroButton btn_Register;
        private MetroFramework.Controls.MetroTextBox txtBox_Confirm_Password_Register;
        private MetroFramework.Controls.MetroTextBox txtBox_Password_Register;
        private MetroFramework.Controls.MetroTextBox txtBox_Username_Register;
        private MetroFramework.Controls.MetroLabel label_Confirm_Password_Register;
        private MetroFramework.Controls.MetroLabel label_Password_Register;
        private MetroFramework.Controls.MetroLabel label_Username_Register;
    }
}

