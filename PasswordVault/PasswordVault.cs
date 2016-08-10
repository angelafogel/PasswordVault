using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Text.RegularExpressions;
using System.Data.SqlClient;
using System.Net.Mail;

namespace PasswordVaultNS
{
    public class PasswordVault
    {
        private string _username;
        private string _password;
        private string _emailAddress;
        private string _passwordHint;
        private bool isEnabled = false;

        public const string localDbString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Angela\Source\Repos\shu-cs604\passwordvault\PasswordVault\VaultDB.mdf;Integrated Security=True";
       
        public PasswordVault()
        {
        }

        public PasswordVault(string username, string password, string emailAddress, string passwordHint)
        {
            _username = username;
            _password = password;
            _emailAddress = emailAddress;
            _passwordHint = passwordHint;
        }

        public bool ValidateUserName(string username)
        {
            if (_username.ToUpper() == username.ToUpper())
            {
                return true;
            }
            return false;
        }
        
        public bool ValidateComplexUserName(string username)
        {
            bool isWhiteSpace = String.IsNullOrWhiteSpace(username);

            if (isWhiteSpace == false && username.Length > 1)
            {
                return true;
            }
            return false;
        }

        public bool ValidatePassword(string password)
        {
            if (_password == password)
            {
                return true;
            }
            return false;
        }

        public bool ValidateComplexPassword(string password)
        {
            if (password.Length >= 8 &&
                password.Count(c => char.IsDigit(c)) >= 1 &&
                password.Count(c => char.IsUpper(c)) >= 1 &&
                password.Count(c => char.IsLower(c)) >= 1)
            {
                return true;
            }
            return false;
        }

        public bool ValidateEmailAddress(string email)
        {
            if (_emailAddress == email)
            {
                return true;
            }
            return false;
        }

        public bool ValidateComplexEmailAddress(string email)
        {
            //source: http://haacked.com/archive/2007/08/21/i-knew-how-to-validate-an-email-address-until-i.aspx/
            string pattern = @"^(?!\.)(""([^""\r\\]|\\[""\r\\])*""|"
                + @"([-a-z0-9!#$%&'*+/=?^_`{|}~]|(?<!\.)\.)*)(?<!\.)"
                + @"@[a-z0-9][\w\.-]*[a-z0-9]\.[a-z][a-z\.]*[a-z]$";

            Regex regex = new Regex(pattern, RegexOptions.IgnoreCase);
            return regex.IsMatch(email);
        }

        public bool ValidateUserNameAndPassword(string username, string password)
        {
            if (_username.ToUpper() == username.ToUpper() && _password == password)
            {
                return true;
            }
            return false;
        }

        public bool ValidatePasswordHint(string passwordHint)
        {
            if (_passwordHint == passwordHint)
            {
                return true;
            }
            return false;
        }

        public bool ValidateComplexPasswordHint(string passwordHint)
        {
            bool isWhiteSpace = String.IsNullOrWhiteSpace(passwordHint);

            if (isWhiteSpace == false && passwordHint.Length > 0)
            {
                return true;
            }
            return false;
        }

        public bool SendEmailNewAccount(EmailNotification emailObject)
        {
            emailObject.SendEmail();
            return true;
        }

        public bool SendEmailForgotPassword(EmailNotification emailObject)
        {
            emailObject.SendEmail();
            return true;
        }


        public bool CreateNewAccountService()
        {
            bool successful = false;

            if (ValidateComplexUserName(_username) && 
                ValidateComplexPassword(_password) &&
                ValidateComplexEmailAddress(_emailAddress) &&
                ValidateComplexPasswordHint(_passwordHint))
            {
                successful = InsertNewAccountToLocalDB(localDbString);
            }
            return successful;
        }

        public bool AccountSignInService(string username, string password)
        {
            string result = "";
            bool successful = false;

            if (ValidateComplexUserName(username) &&
                ValidateComplexPassword(password))
            {
                result = RetrieveAccountInfoFromLocalDb(username, localDbString);
                if (result == password)
                {
                    successful = true;
                }
            }
            return successful;
        }
        
        public bool ForgotPasswordService(string email)
        {
            string result;

            if (ValidateComplexEmailAddress(email))
            {
                result = RetrievePasswordHintFromLocalDb(email, localDbString);
                return true;
            }
            return false;
        }

        private bool InsertNewAccountToLocalDB(string connectionString)
        {
            string queryString = "INSERT INTO dbo.[UserTable] (MasterPassword, PasswordHint, UserEmail, UserName) VALUES (@MasterPassword, @PasswordHint, @UserEmail, @UserName);";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString);
                command.Connection = connection;
                command.Parameters.AddWithValue("@MasterPassword", _password);
                command.Parameters.AddWithValue("@PasswordHint", _passwordHint);
                command.Parameters.AddWithValue("@UserEmail", _emailAddress);
                command.Parameters.AddWithValue("@UserName", _username);
                connection.Open();

                command.ExecuteNonQuery();

                return true;
            }
        }

        private string RetrieveAccountInfoFromLocalDb(string username, string connectionString)
        {
            string result = "";
            string queryString = "SELECT * FROM dbo.[UserTable] WHERE UserName = @UserName;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString);
                command.Connection = connection;
                command.Parameters.AddWithValue("@UserName", username);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        result = reader.GetString(reader.GetOrdinal("MasterPassword"));
                    }
                }
                reader.Close();

                return result;
            }
        }

        private string RetrievePasswordHintFromLocalDb(string email, string connectionString)
        {
            string result = "";
            string queryString = "SELECT * FROM dbo.[UserTable] WHERE UserEmail = @UserEmail;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString);
                command.Connection = connection;
                command.Parameters.AddWithValue("@UserEmail", email);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        result = reader.GetString(reader.GetOrdinal("PasswordHint"));
                    }

                }

                Console.WriteLine(result);

                reader.Close();

                return result;
            }
        }

        [STAThread]
        public static void Main()
        {
            /// Running the Form1 application
            /// 
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmSignIn());
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
