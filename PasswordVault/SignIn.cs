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
    public partial class frmSignIn : Form
    {
        public frmSignIn()
        {
            InitializeComponent();
        }

        private void btnCreateAnAccount_Click(object sender, EventArgs e)
        {
            frmCreateAccount frmCA = new frmCreateAccount();
            frmCA.ShowDialog();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            PasswordVault pv = new PasswordVault();

            //if (username == "user" && password == "pass")
            if (pv.AccountSignInService(username, password))
            {
                Vault form1 = new Vault();
                form1.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("The username or password is incorrect.", "Error");
            }

            txtUsername.Text = "";
            txtPassword.Text = "";
        }

        private void lblForgotPassword_Click(object sender, EventArgs e)
        {
            frmForgotPassword frmPF = new frmForgotPassword();
            frmPF.ShowDialog();
        }

        private void frmSignIn_Load(object sender, EventArgs e)
        {
            
        }
    }
}
