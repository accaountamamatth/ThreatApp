using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        static int attempt = 3;
        public Form1()
        {
            InitializeComponent();
        }
       
        private void loginButton_Click(object sender, EventArgs e)
        {
            User user = GetUserByUsername(usernamebox.Text);
            bool isPasswordMatched = VerifyPassword(passwordbox.Text, user.Hash, user.Salt)
            
            if (isPasswordMatched)
            {
                //Login Successful
                //Open Up Threat Intel Window
            }
            else
            {
                //Login Failed
                //Thow Message Box
                MessageBox.Show("Failed Username or Password");
            }
        }
    }
}
