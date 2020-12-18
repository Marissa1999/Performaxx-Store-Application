using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Performaxx_User_Interface
{
    public partial class UserSettingsForm : Form
    {
        string loggedUser;
        string usernameRegularExpression = @"^[a-z,A-Z,\-,\s]{0,50}";
        string passwordRegularExpression = @"^(?=.*\d)(?=.*[A-Z])[A-Za-z\d]{0,30}$";
        string backgroundColor = "";

        public UserSettingsForm(string username, string backgroundColor)
        {
            InitializeComponent();
            loggedUser = username;
            this.backgroundColor = backgroundColor;

            switch (backgroundColor)
            {
                case "orange":
                    this.BackgroundImage = Properties.Resources.PerformaxxFrame;

                    break;

                case "red":
                    this.BackgroundImage = Properties.Resources.PerformaxxFrameRed;
                    break;

                case "blue":
                    this.BackgroundImage = Properties.Resources.PerformaxxFrameBlue;
                    break;

                default:
                    this.BackgroundImage = Properties.Resources.PerformaxxFrame;
                    break;
            }
            this.DoubleBuffered = true;
        
        }
    

        private void manageClientListButton_Click(object sender, EventArgs e)
        {
            ClientListForm clientListForm = new ClientListForm(loggedUser, backgroundColor);
            clientListForm.Show();
            this.Hide();
        }

        private void manageInventoryButton_Click(object sender, EventArgs e)
        {
            InventoryForm inventoryForm = new InventoryForm(loggedUser, backgroundColor);
            inventoryForm.Show();
            this.Hide();
        }

        private void returnToMainMenuButton_Click(object sender, EventArgs e)
        {
            MainMenuForm mainMenuForm = new MainMenuForm(loggedUser, backgroundColor);
            mainMenuForm.Show();
            this.Hide();
        }

        private void manageCalendarEventsButton_Click(object sender, EventArgs e)
        {
            CalendarForm calendarForm = new CalendarForm(loggedUser, backgroundColor);
            calendarForm.Show();
            this.Hide();
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to logout?", "Message: Logout Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                LoginForm loginForm = new LoginForm();
                loginForm.Show();
                this.Hide();
            }
        }

        private void UserSettingsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void modifyUserInformationButton_Click(object sender, EventArgs e)
        {
            userInformationPanel.Visible = true;
            usernamePanel.Visible = false;
            passwordPanel.Visible = false;
            notificationPanel.Visible = false;
            themePanel.Visible = false;
        }

        private void changeUsernameButton_Click(object sender, EventArgs e)
        {
            userInformationPanel.Visible = true;
            usernamePanel.Visible = true;
            passwordPanel.Visible = false;
            notificationPanel.Visible = false;
            themePanel.Visible = false;
        }

        private void changePasswordButton_Click(object sender, EventArgs e)
        {
            userInformationPanel.Visible = false;
            usernamePanel.Visible = false;
            passwordPanel.Visible = true;
            notificationPanel.Visible = false;
            themePanel.Visible = false;
        }

        private void modifyNotificationsButton_Click(object sender, EventArgs e)
        {
            userInformationPanel.Visible = false;
            usernamePanel.Visible = false;
            passwordPanel.Visible = false;
            notificationPanel.Visible = true;
            themePanel.Visible = false;
        }

        private void changeThemeButton_Click(object sender, EventArgs e)
        {
            userInformationPanel.Visible = false;
            usernamePanel.Visible = false;
            passwordPanel.Visible = false;
            notificationPanel.Visible = false;
            themePanel.Visible = true;
        }

        private void saveUsernameChangesButton_Click(object sender, EventArgs e)
        {
            string accountSQL = "SELECT Username FROM UserAccount Where username = '" + currentUsernameTextBox.Text + "'";
            DataTable checkDuplicates = Performaxx_User_Interface.Connection.ServerConnection.executeSQL(accountSQL);

            if (checkDuplicates.Rows.Count > 0)
            {

                if (!showMatch(newUsernameTextBox.Text, usernameRegularExpression) || string.IsNullOrEmpty(newUsernameTextBox.Text))
                {
                    MessageBox.Show("Invalid username input. Please follow the requirements.", "Error: Invalid Username", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                else
                {
                    if (confirmUsernameTextBox.Text.Equals(newUsernameTextBox.Text))
                    {
                        DialogResult result = MessageBox.Show("Do you want save the changes?", "Message: Change Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                        if (result == DialogResult.Yes)
                        {
                            string mySQL = string.Empty;

                            mySQL += "UPDATE UserAccount SET Username='" + newUsernameTextBox.Text + "' WHERE Username = '" + currentUsernameTextBox.Text + "'";


                            Performaxx_User_Interface.Connection.ServerConnection.executeSQL(mySQL);

                            MessageBox.Show("Your username has been changed.", "Message: Username Change", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            loggedUser = newUsernameTextBox.Text;
                        }
                    }

                    else
                    {
                        MessageBox.Show("Invalid username confirmation. Please assure that your username is typed correctly.", "Error: Invalid Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }

            else
            {
                MessageBox.Show("The username does not exists. Please try another username.", "Error: Unexisiting Account", MessageBoxButtons.OK, MessageBoxIcon.Error);
                currentUsernameTextBox.SelectAll();
                return;
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

        private void savePasswordChangesButton_Click(object sender, EventArgs e)
        {
            string accountSQL = "SELECT Username FROM UserAccount Where username = '" + loggedUser + "'";
            DataTable checkDuplicates = Performaxx_User_Interface.Connection.ServerConnection.executeSQL(accountSQL);

            if (checkDuplicates.Rows.Count > 0)
            {
                if (!showMatch(newPasswordTextBox.Text, passwordRegularExpression) || string.IsNullOrEmpty(newPasswordTextBox.Text))
                {
                    MessageBox.Show("Invalid password input. Please follow the requirements.", "Error: Invalid Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                else
                {
                    if (confirmPasswordTextBox.Text.Equals(newPasswordTextBox.Text))
                    {
                        DialogResult result = MessageBox.Show("Do you want save the changes?", "Message: Change Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                        if (result == DialogResult.Yes)
                        {
                            string mySQL = string.Empty;

                            mySQL += "UPDATE UserAccount SET Password='" + newPasswordTextBox.Text + "' WHERE Username = '" + loggedUser + "'";


                            Performaxx_User_Interface.Connection.ServerConnection.executeSQL(mySQL);

                            MessageBox.Show("Your password has been changed.", "Username Change", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            
                        }
                    }

                    else
                    {
                        MessageBox.Show("Invalid username confirmation. Please reassure that your username is typed correctly.", "Error: Invalid Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }

            else
            {
                MessageBox.Show("The username does not exists. Please insert another username.", "Error: Unexisiting Username", MessageBoxButtons.OK, MessageBoxIcon.Error);
                currentUsernameTextBox.SelectAll();
                return;
            }
        }

        private void saveThemeChanges_Click(object sender, EventArgs e)
        {
            switch (backgroundThemeComboBox.SelectedItem)
            {
                case "Orange":
                    this.BackgroundImage = Properties.Resources.PerformaxxFrame;
                    backgroundColor = "orange";
                    break;

                case "Red":
                    this.BackgroundImage = Properties.Resources.PerformaxxFrameRed;
                    backgroundColor = "red";

                    break;

                case "Blue":
                    this.BackgroundImage = Properties.Resources.PerformaxxFrameBlue;
                    backgroundColor = "blue";
                    break;

            }
        }
    }
}
