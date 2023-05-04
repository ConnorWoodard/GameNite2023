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
    public partial class Sign_In : Form
    {

        public static List<Account> account = new List<Account>()
        {

        };
        public Sign_In()
        {
            InitializeComponent();
            lblError.Visible = false;
            lblError2.Visible = false;
        }

        private void btnMakeAccount_Click(object sender, EventArgs e)
        {
            lblError.Visible=false;
            lblError2.Visible=false;
            string firstName = txtFirst.Text;
            string lastName = txtLast.Text;
            string email = txtEmail.Text;
            string password = txtPassword.Text;
            string confirmPassword = txtConfirmPassword.Text;
            if (firstName == "" || lastName == "" || email == "" || password == "")
            {
                lblError2.Visible = true;

            }
            else if (password != confirmPassword)
            {
                lblError.Visible = true;
            }
            else
            {
                Account addAccount = new Account(email, password);
                
                this.Close();
            }


        }
    }
}
