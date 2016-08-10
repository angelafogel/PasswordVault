using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PasswordVaultNS
{
    public partial class frmCreateAccount : Form
    {
        public frmCreateAccount()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            string email = txtEmail.Text;
            string passwordHint = txtPasswordHint.Text;
            PasswordVault pv = new PasswordVault(username, password, email, passwordHint);

            if (pv.CreateNewAccountService())
            {
                MessageBox.Show("Your account has been created. You should receive a confirmation in email shortly.", "Notifcation");
            }
            else
            {
                MessageBox.Show("There is a error with the information you provided.", "Error");
            }            
        }

    }
}
