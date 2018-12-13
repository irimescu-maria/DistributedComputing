using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using StatisticalAppWithFirebase.Model;
using System;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace StatisticalAppWithFirebase
{
    public partial class Form1 : Form
    {
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "zECpgWh19r3fR1b6WCnCd1auXP3mr9cToZAPnRzL",
            BasePath = "https://fir-statisticalapp.firebaseio.com/"
        };

        IFirebaseClient client;

        public Form1()
        {
            InitializeComponent();

            client = new FireSharp.FirebaseClient(config);
         
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (client != null)
            {
                MessageBox.Show("Connection established!");
            }
        }

        private async void button_Register_Click(object sender, EventArgs e)
        {
            var user = new User
            {
                Id = Guid.NewGuid(),
                Username = textBox_Username.Text,
                Password = encryption(textBox_Password.Text),
                ConfirmPassword = encryption(textBox_Conf_Pass.Text),
                IsLogged = true
            };
            
            SetResponse response = await client.SetTaskAsync("User/"+Guid.NewGuid(), user);
            User result = response.ResultAs<User>();

            this.Close();
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void button_Login_Click(object sender, EventArgs e)
        {
            User user = new User();
            FirebaseResponse response = await client.GetTaskAsync("User/");
            User obj = response.ResultAs<User>();

           // User user = new User();
            var login = new User
            {
                Username = encryption(textBox_Password.Text),
                Password = txtBox_Pass_Login.Text
            };

            if(login.Username == obj.Username && login.Password == obj.Password)
            {
                MessageBox.Show("Login successfully!"); 
            }
        }

        //Encrypt the password using md5
        public string encryption(String password)
        {
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            byte[] encrypt;
            UTF8Encoding encode = new UTF8Encoding();
            //encrypt the given password string into Encrypted data  
            encrypt = md5.ComputeHash(encode.GetBytes(password));
            StringBuilder encryptdata = new StringBuilder();
            //Create a new string by using the encrypted data  
            for (int i = 0; i < encrypt.Length; i++)
            {
                encryptdata.Append(encrypt[i].ToString());
            }
            return encryptdata.ToString();
        }

      
    }
}
