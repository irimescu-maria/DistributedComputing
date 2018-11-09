using StatisticalApp.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace StatisticalApp
{
    public partial class LoginForm : Form
    {
        private readonly AppDbContext _context;
        public User userLogged;

        public LoginForm()
        {
            InitializeComponent();
            _context = new AppDbContext();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            try
            {
                var user = _context.Users
                    .Single(u => u.Username == txtBox_Username.Text && u.Password == txtBox_Password.Text);

                userLogged = _context.Users.Single(u => u.Id == user.Id);

                if (user != null && userLogged.IsLogged == false)
                {
                    userLogged.IsLogged = true;
                    _context.SaveChanges();

                    this.Hide();
                    MessageBox.Show("Login successfully!");


                }
                else
                {
                    MessageBox.Show("User is already logged!");
                    txtBox_Username.Clear();
                    txtBox_Password.Clear();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Login failed!");
            }
        }

        private void btn_Cancel_Login_Click(object sender, EventArgs e)
        {
            this.Close();
            userLogged.IsLogged = false;
            _context.SaveChanges();
        }
    }
}
