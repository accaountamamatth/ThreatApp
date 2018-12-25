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
using System.Data.SqlClient;

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

       
            string user = GetUserByUsername(usernamebox.Text);
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
       
        private void newuserButton_Click(object sender, EventArgs e)
        {
            var connectionString = "Data Source = EVOPC18\\PMSMART; Initial Catalog = NORTHWND; User ID = test; Password = test";
            var sql = "UPDATE Username UPDATE PASSWORD";

            try
            {
                using(var connection = new SqlConnection(connectionString))
                {
                    using(var command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.Add("@Password", SqlDbType.NVarChar).Value = passwordbox.Text;
                        command.Parameters.Add("@Username", SqlDbType.NVarChar).Value = usernamebox.Text;
                        connection.Open();
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show($"Failed to Update! Error Message: {e.Message}");
            }


            HashSalt hashSalt = GenerateSaltedHash(passwordbox.Text);

            

        }
    }
}
