using System;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Login
{
    class Login
    {
        //declaring properties
        public string Username { get; set; }
        public string Userpassword { get; set; }

        //init
        public Login(string user, string pass)
        {
            this.Username = user;
            this.Userpassword = pass;
        }
        //Validation
        private bool StringValidator(string input)
        {
            string pattern = "[^a-zA-Z]";
        }
    }
}
    