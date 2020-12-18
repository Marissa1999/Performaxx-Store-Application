using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Performaxx_User_Interface.Connection;

namespace Performaxx_User_Interface
{
    public partial class LoginForm : Form
    {
        protected string loggedUser = "";
        string backgroundColor = "";
        public LoginForm()
        {           
            InitializeComponent();   
            
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(userNameTextBox.Text) && (!string.IsNullOrEmpty(passwordTextBox.Text)))
            {
                string mySQL = string.Empty;

                mySQL += "SELECT * FROM UserAccount ";
                mySQL += "WHERE Username = '" + userNameTextBox.Text + "' ";
                mySQL += "AND Password = '" + passwordTextBox.Text + "' ";

                DataTable userData = ServerConnection.executeSQL(mySQL);
                

                if (userData.Rows.Count > 0)
                {
                    loggedUser = userNameTextBox.Text;
                    userNameTextBox.Clear();
                    passwordTextBox.Clear();

                    this.Hide();
                    Console.WriteLine(loggedUser);
                    MainMenuForm mainMenuForm = new MainMenuForm(loggedUser, backgroundColor);
                    mainMenuForm.Show();
                    this.userNameTextBox.Select();
                }

                else
                {
                    MessageBox.Show("The username or password is incorrect. Please try again.", "Error: Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    userNameTextBox.Focus();
                    userNameTextBox.SelectAll();

                }
            }

            else
            {
                MessageBox.Show("Please enter a username and password.", "Error: Empty Entries", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                userNameTextBox.Select();
            }

        }       

        private void createAccountButton_Click(object sender, EventArgs e)
        {
            CreateAccountForm createAccountForm = new CreateAccountForm();
            createAccountForm.Show();
            this.Hide();
        }

        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
