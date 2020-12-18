using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using Performaxx_User_Interface.Connection;
using Microsoft.VisualBasic;


namespace Performaxx_User_Interface
{
    public partial class CreateAccountForm : Form
    {

        public CreateAccountForm()
        {
            InitializeComponent();    
        }

        private void CreateAccountForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void createAccountButton_Click(object sender, EventArgs e)
        {
            string usernameRegularExpression = @"^[a-z,A-Z,\-,\s]{0,50}";
            string passwordRegularExpression = @"^(?=.*\d)(?=.*[A-Z])[A-Za-z\d]{0,30}$";

            string accountSQL = "SELECT Username FROM UserAccount Where username = '" + userNameTextBox.Text + "'";
            DataTable checkDuplicates = Performaxx_User_Interface.Connection.ServerConnection.executeSQL(accountSQL);

            if (checkDuplicates.Rows.Count > 0)
            {
                MessageBox.Show("The username already exists. Please try another username.", "Error: Exisiting Account", MessageBoxButtons.OK, MessageBoxIcon.Error);
                userNameTextBox.SelectAll();
                return;
            }

            if (!showMatch(userNameTextBox.Text, usernameRegularExpression) || !showMatch(passwordTextBox.Text, passwordRegularExpression) || string.IsNullOrEmpty(userNameTextBox.Text) ||
                string.IsNullOrEmpty(passwordTextBox.Text))
            {
                MessageBox.Show("Invalid username or password. Please follow the requirements.", "Error: Invalid Username/Password Entries", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (!passwordTextBox.Text.Equals(confirmPasswordTextBox.Text))
            {
                MessageBox.Show("Passwords do not match.", "Error: Invalid Password Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (administratorRadioButton.Checked == false && employeeRadioButton.Checked == false)
            {
                MessageBox.Show("Please select an account type.", "Error: Unselected Acccount Type", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else 
            {
                DialogResult result = MessageBox.Show("Do you want save record?", "Message: Record Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    string mySQL = string.Empty;
                    
                    mySQL += "INSERT INTO UserAccount (Username, Password, AccountType) ";
                    mySQL += "VALUES ('" + userNameTextBox.Text + "', '" + passwordTextBox.Text + "', " + "'Employee'" +")";

                    Performaxx_User_Interface.Connection.ServerConnection.executeSQL(mySQL);

                    MessageBox.Show("Your account has been created.", "Message: Account Creation", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LoginForm loginForm = new LoginForm();
                    loginForm.Show();
                    this.Hide();
                }
              
            }

        }

        private bool showMatch(string text, string expression)
        {
            Console.WriteLine("The Expression: " + expression);
            MatchCollection matchExpressionCollection = Regex.Matches(text, expression);

            foreach (Match expressionMatch in matchExpressionCollection)
            {
                return true;
            }

            return false;
        }

        private void returnToLoginScreenButton_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }

        private void viewAccountRequirementsButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Username Specifications: \n ~ Maximum of 50 characters. \n ~ Minimum of 2 characters.\n\n" +
                "Password Specifications: \n ~ Maximum of 30 characters. \n ~ At least one uppercase letter. \n" +
                " ~ At least one single digit.","Account Requirements", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void showPasswordsCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (showPasswordsCheckBox.Checked)
            {   
                passwordTextBox.PasswordChar = '\0';
                confirmPasswordTextBox.PasswordChar = '\0';
            }

            else
            {              
                passwordTextBox.PasswordChar = '●';
                confirmPasswordTextBox.PasswordChar = '●';
            }
        }


    }
}
