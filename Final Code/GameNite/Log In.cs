using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameNite
{
    public partial class Log_In : Form
    {
        Sign_In sign_In = new Sign_In();
        public Log_In()
        {
            InitializeComponent();
            
        }


        private void btnLogIn_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string password = txtPassword.Text;
            if (email == "" || password == "")
            {
                lblError.Visible = true;
                lblError.Text = "Invalid Email/Password";
                
            }
            for (int i = 0; i < Sign_In.account.Count; i++)
            {
                
                if (email != Sign_In.account[i].Email || password != Sign_In.account[i].Password)
                {
                    lblError.Visible = true;
                    break;
                }
                else
                {
                    this.Close();
                }
            }
            
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            sign_In.Show();
        }


    }
}
