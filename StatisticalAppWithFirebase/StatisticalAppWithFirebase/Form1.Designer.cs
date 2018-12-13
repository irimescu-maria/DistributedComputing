namespace StatisticalAppWithFirebase
{
    partial class Form1
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
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage_Login = new MetroFramework.Controls.MetroTabPage();
            this.metroTabPage_Register = new MetroFramework.Controls.MetroTabPage();
            this.label_UserName = new MetroFramework.Controls.MetroLabel();
            this.label_Password = new MetroFramework.Controls.MetroLabel();
            this.label_Conf_Password = new MetroFramework.Controls.MetroLabel();
            this.textBox_Conf_Pass = new MetroFramework.Controls.MetroTextBox();
            this.textBox_Password = new MetroFramework.Controls.MetroTextBox();
            this.textBox_Username = new MetroFramework.Controls.MetroTextBox();
            this.button_Register = new MetroFramework.Controls.MetroButton();
            this.button_Cancel = new MetroFramework.Controls.MetroButton();
            this.label_User = new MetroFramework.Controls.MetroLabel();
            this.label_Password_Login = new MetroFramework.Controls.MetroLabel();
            this.txtBox_Pass_Login = new MetroFramework.Controls.MetroTextBox();
            this.txtBox_User_Login = new MetroFramework.Controls.MetroTextBox();
            this.button_Login = new MetroFramework.Controls.MetroButton();
            this.button_Cancel_Login = new MetroFramework.Controls.MetroButton();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage_Login.SuspendLayout();
            this.metroTabPage_Register.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.metroTabPage_Login);
            this.metroTabControl1.Controls.Add(this.metroTabPage_Register);
            this.metroTabControl1.Location = new System.Drawing.Point(12, 12);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(366, 426);
            this.metroTabControl1.TabIndex = 7;
            this.metroTabControl1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTabControl1.UseSelectable = true;
            // 
            // metroTabPage_Login
            // 
            this.metroTabPage_Login.Controls.Add(this.button_Cancel_Login);
            this.metroTabPage_Login.Controls.Add(this.button_Login);
            this.metroTabPage_Login.Controls.Add(this.txtBox_User_Login);
            this.metroTabPage_Login.Controls.Add(this.txtBox_Pass_Login);
            this.metroTabPage_Login.Controls.Add(this.label_Password_Login);
            this.metroTabPage_Login.Controls.Add(this.label_User);
            this.metroTabPage_Login.HorizontalScrollbarBarColor = true;
            this.metroTabPage_Login.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage_Login.HorizontalScrollbarSize = 10;
            this.metroTabPage_Login.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage_Login.Margin = new System.Windows.Forms.Padding(3, 3, 30, 3);
            this.metroTabPage_Login.Name = "metroTabPage_Login";
            this.metroTabPage_Login.Padding = new System.Windows.Forms.Padding(150, 0, 0, 0);
            this.metroTabPage_Login.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.metroTabPage_Login.Size = new System.Drawing.Size(358, 384);
            this.metroTabPage_Login.TabIndex = 0;
            this.metroTabPage_Login.Text = "Login";
            this.metroTabPage_Login.VerticalScrollbarBarColor = true;
            this.metroTabPage_Login.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage_Login.VerticalScrollbarSize = 10;
            // 
            // metroTabPage_Register
            // 
            this.metroTabPage_Register.Controls.Add(this.button_Cancel);
            this.metroTabPage_Register.Controls.Add(this.button_Register);
            this.metroTabPage_Register.Controls.Add(this.textBox_Username);
            this.metroTabPage_Register.Controls.Add(this.textBox_Password);
            this.metroTabPage_Register.Controls.Add(this.textBox_Conf_Pass);
            this.metroTabPage_Register.Controls.Add(this.label_Conf_Password);
            this.metroTabPage_Register.Controls.Add(this.label_Password);
            this.metroTabPage_Register.Controls.Add(this.label_UserName);
            this.metroTabPage_Register.HorizontalScrollbarBarColor = true;
            this.metroTabPage_Register.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage_Register.HorizontalScrollbarSize = 10;
            this.metroTabPage_Register.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage_Register.Name = "metroTabPage_Register";
            this.metroTabPage_Register.Size = new System.Drawing.Size(358, 384);
            this.metroTabPage_Register.TabIndex = 1;
            this.metroTabPage_Register.Text = "Register";
            this.metroTabPage_Register.VerticalScrollbarBarColor = true;
            this.metroTabPage_Register.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage_Register.VerticalScrollbarSize = 10;
            // 
            // label_UserName
            // 
            this.label_UserName.AutoSize = true;
            this.label_UserName.Location = new System.Drawing.Point(24, 103);
            this.label_UserName.Name = "label_UserName";
            this.label_UserName.Size = new System.Drawing.Size(72, 19);
            this.label_UserName.TabIndex = 2;
            this.label_UserName.Text = "User name";
            // 
            // label_Password
            // 
            this.label_Password.AutoSize = true;
            this.label_Password.Location = new System.Drawing.Point(24, 142);
            this.label_Password.Name = "label_Password";
            this.label_Password.Size = new System.Drawing.Size(63, 19);
            this.label_Password.TabIndex = 3;
            this.label_Password.Text = "Password";
            // 
            // label_Conf_Password
            // 
            this.label_Conf_Password.AutoSize = true;
            this.label_Conf_Password.Location = new System.Drawing.Point(24, 189);
            this.label_Conf_Password.Name = "label_Conf_Password";
            this.label_Conf_Password.Size = new System.Drawing.Size(115, 19);
            this.label_Conf_Password.TabIndex = 4;
            this.label_Conf_Password.Text = "Confirm Password";
            // 
            // textBox_Conf_Pass
            // 
            // 
            // 
            // 
            this.textBox_Conf_Pass.CustomButton.Image = null;
            this.textBox_Conf_Pass.CustomButton.Location = new System.Drawing.Point(127, 1);
            this.textBox_Conf_Pass.CustomButton.Name = "";
            this.textBox_Conf_Pass.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.textBox_Conf_Pass.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textBox_Conf_Pass.CustomButton.TabIndex = 1;
            this.textBox_Conf_Pass.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textBox_Conf_Pass.CustomButton.UseSelectable = true;
            this.textBox_Conf_Pass.CustomButton.Visible = false;
            this.textBox_Conf_Pass.Lines = new string[0];
            this.textBox_Conf_Pass.Location = new System.Drawing.Point(161, 184);
            this.textBox_Conf_Pass.MaxLength = 32767;
            this.textBox_Conf_Pass.Name = "textBox_Conf_Pass";
            this.textBox_Conf_Pass.PasswordChar = '\0';
            this.textBox_Conf_Pass.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBox_Conf_Pass.SelectedText = "";
            this.textBox_Conf_Pass.SelectionLength = 0;
            this.textBox_Conf_Pass.SelectionStart = 0;
            this.textBox_Conf_Pass.ShortcutsEnabled = true;
            this.textBox_Conf_Pass.Size = new System.Drawing.Size(149, 23);
            this.textBox_Conf_Pass.TabIndex = 5;
            this.textBox_Conf_Pass.UseSelectable = true;
            this.textBox_Conf_Pass.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textBox_Conf_Pass.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // textBox_Password
            // 
            // 
            // 
            // 
            this.textBox_Password.CustomButton.Image = null;
            this.textBox_Password.CustomButton.Location = new System.Drawing.Point(127, 1);
            this.textBox_Password.CustomButton.Name = "";
            this.textBox_Password.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.textBox_Password.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textBox_Password.CustomButton.TabIndex = 1;
            this.textBox_Password.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textBox_Password.CustomButton.UseSelectable = true;
            this.textBox_Password.CustomButton.Visible = false;
            this.textBox_Password.Lines = new string[0];
            this.textBox_Password.Location = new System.Drawing.Point(161, 137);
            this.textBox_Password.MaxLength = 32767;
            this.textBox_Password.Name = "textBox_Password";
            this.textBox_Password.PasswordChar = '\0';
            this.textBox_Password.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBox_Password.SelectedText = "";
            this.textBox_Password.SelectionLength = 0;
            this.textBox_Password.SelectionStart = 0;
            this.textBox_Password.ShortcutsEnabled = true;
            this.textBox_Password.Size = new System.Drawing.Size(149, 23);
            this.textBox_Password.TabIndex = 6;
            this.textBox_Password.UseSelectable = true;
            this.textBox_Password.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textBox_Password.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // textBox_Username
            // 
            // 
            // 
            // 
            this.textBox_Username.CustomButton.Image = null;
            this.textBox_Username.CustomButton.Location = new System.Drawing.Point(127, 1);
            this.textBox_Username.CustomButton.Name = "";
            this.textBox_Username.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.textBox_Username.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textBox_Username.CustomButton.TabIndex = 1;
            this.textBox_Username.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textBox_Username.CustomButton.UseSelectable = true;
            this.textBox_Username.CustomButton.Visible = false;
            this.textBox_Username.Lines = new string[0];
            this.textBox_Username.Location = new System.Drawing.Point(161, 98);
            this.textBox_Username.MaxLength = 32767;
            this.textBox_Username.Name = "textBox_Username";
            this.textBox_Username.PasswordChar = '\0';
            this.textBox_Username.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBox_Username.SelectedText = "";
            this.textBox_Username.SelectionLength = 0;
            this.textBox_Username.SelectionStart = 0;
            this.textBox_Username.ShortcutsEnabled = true;
            this.textBox_Username.Size = new System.Drawing.Size(149, 23);
            this.textBox_Username.TabIndex = 7;
            this.textBox_Username.UseSelectable = true;
            this.textBox_Username.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textBox_Username.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // button_Register
            // 
            this.button_Register.Location = new System.Drawing.Point(48, 274);
            this.button_Register.Name = "button_Register";
            this.button_Register.Size = new System.Drawing.Size(75, 23);
            this.button_Register.TabIndex = 8;
            this.button_Register.Text = "Register";
            this.button_Register.UseSelectable = true;
            this.button_Register.Click += new System.EventHandler(this.button_Register_Click);
            // 
            // button_Cancel
            // 
            this.button_Cancel.Location = new System.Drawing.Point(178, 273);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(75, 23);
            this.button_Cancel.TabIndex = 9;
            this.button_Cancel.Text = "Cancel";
            this.button_Cancel.UseSelectable = true;
            this.button_Cancel.Click += new System.EventHandler(this.button_Cancel_Click);
            // 
            // label_User
            // 
            this.label_User.AutoSize = true;
            this.label_User.Location = new System.Drawing.Point(47, 95);
            this.label_User.Name = "label_User";
            this.label_User.Size = new System.Drawing.Size(72, 19);
            this.label_User.TabIndex = 2;
            this.label_User.Text = "User name";
            // 
            // label_Password_Login
            // 
            this.label_Password_Login.AutoSize = true;
            this.label_Password_Login.Location = new System.Drawing.Point(47, 144);
            this.label_Password_Login.Name = "label_Password_Login";
            this.label_Password_Login.Size = new System.Drawing.Size(63, 19);
            this.label_Password_Login.TabIndex = 3;
            this.label_Password_Login.Text = "Password";
            // 
            // txtBox_Pass_Login
            // 
            // 
            // 
            // 
            this.txtBox_Pass_Login.CustomButton.Image = null;
            this.txtBox_Pass_Login.CustomButton.Location = new System.Drawing.Point(119, 1);
            this.txtBox_Pass_Login.CustomButton.Name = "";
            this.txtBox_Pass_Login.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtBox_Pass_Login.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtBox_Pass_Login.CustomButton.TabIndex = 1;
            this.txtBox_Pass_Login.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtBox_Pass_Login.CustomButton.UseSelectable = true;
            this.txtBox_Pass_Login.CustomButton.Visible = false;
            this.txtBox_Pass_Login.Lines = new string[0];
            this.txtBox_Pass_Login.Location = new System.Drawing.Point(154, 139);
            this.txtBox_Pass_Login.MaxLength = 32767;
            this.txtBox_Pass_Login.Name = "txtBox_Pass_Login";
            this.txtBox_Pass_Login.PasswordChar = '\0';
            this.txtBox_Pass_Login.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBox_Pass_Login.SelectedText = "";
            this.txtBox_Pass_Login.SelectionLength = 0;
            this.txtBox_Pass_Login.SelectionStart = 0;
            this.txtBox_Pass_Login.ShortcutsEnabled = true;
            this.txtBox_Pass_Login.Size = new System.Drawing.Size(141, 23);
            this.txtBox_Pass_Login.TabIndex = 4;
            this.txtBox_Pass_Login.UseSelectable = true;
            this.txtBox_Pass_Login.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtBox_Pass_Login.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtBox_User_Login
            // 
            // 
            // 
            // 
            this.txtBox_User_Login.CustomButton.Image = null;
            this.txtBox_User_Login.CustomButton.Location = new System.Drawing.Point(119, 1);
            this.txtBox_User_Login.CustomButton.Name = "";
            this.txtBox_User_Login.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtBox_User_Login.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtBox_User_Login.CustomButton.TabIndex = 1;
            this.txtBox_User_Login.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtBox_User_Login.CustomButton.UseSelectable = true;
            this.txtBox_User_Login.CustomButton.Visible = false;
            this.txtBox_User_Login.Lines = new string[0];
            this.txtBox_User_Login.Location = new System.Drawing.Point(154, 90);
            this.txtBox_User_Login.MaxLength = 32767;
            this.txtBox_User_Login.Name = "txtBox_User_Login";
            this.txtBox_User_Login.PasswordChar = '\0';
            this.txtBox_User_Login.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBox_User_Login.SelectedText = "";
            this.txtBox_User_Login.SelectionLength = 0;
            this.txtBox_User_Login.SelectionStart = 0;
            this.txtBox_User_Login.ShortcutsEnabled = true;
            this.txtBox_User_Login.Size = new System.Drawing.Size(141, 23);
            this.txtBox_User_Login.TabIndex = 5;
            this.txtBox_User_Login.UseSelectable = true;
            this.txtBox_User_Login.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtBox_User_Login.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // button_Login
            // 
            this.button_Login.Location = new System.Drawing.Point(79, 219);
            this.button_Login.Name = "button_Login";
            this.button_Login.Size = new System.Drawing.Size(75, 23);
            this.button_Login.TabIndex = 6;
            this.button_Login.Text = "Login";
            this.button_Login.UseSelectable = true;
            this.button_Login.Click += new System.EventHandler(this.button_Login_Click);
            // 
            // button_Cancel_Login
            // 
            this.button_Cancel_Login.Location = new System.Drawing.Point(190, 218);
            this.button_Cancel_Login.Name = "button_Cancel_Login";
            this.button_Cancel_Login.Size = new System.Drawing.Size(75, 23);
            this.button_Cancel_Login.TabIndex = 7;
            this.button_Cancel_Login.Text = "Cancel";
            this.button_Cancel_Login.UseSelectable = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 450);
            this.Controls.Add(this.metroTabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPage_Login.ResumeLayout(false);
            this.metroTabPage_Login.PerformLayout();
            this.metroTabPage_Register.ResumeLayout(false);
            this.metroTabPage_Register.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage metroTabPage_Login;
        private MetroFramework.Controls.MetroTabPage metroTabPage_Register;
        private MetroFramework.Controls.MetroButton button_Register;
        private MetroFramework.Controls.MetroTextBox textBox_Username;
        private MetroFramework.Controls.MetroTextBox textBox_Password;
        private MetroFramework.Controls.MetroTextBox textBox_Conf_Pass;
        private MetroFramework.Controls.MetroLabel label_Conf_Password;
        private MetroFramework.Controls.MetroLabel label_Password;
        private MetroFramework.Controls.MetroLabel label_UserName;
        private MetroFramework.Controls.MetroButton button_Cancel;
        private MetroFramework.Controls.MetroButton button_Cancel_Login;
        private MetroFramework.Controls.MetroButton button_Login;
        private MetroFramework.Controls.MetroTextBox txtBox_User_Login;
        private MetroFramework.Controls.MetroTextBox txtBox_Pass_Login;
        private MetroFramework.Controls.MetroLabel label_Password_Login;
        private MetroFramework.Controls.MetroLabel label_User;
    }
}

