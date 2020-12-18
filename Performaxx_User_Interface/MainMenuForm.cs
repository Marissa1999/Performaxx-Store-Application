using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Performaxx_User_Interface
{
    public partial class MainMenuForm : Form
    {
        protected string loggedUser = "";
        string backgroundColor = "";
        public MainMenuForm(string username, string backgroundColor)
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
        }      

        private void manageInventoryButton_Click(object sender, EventArgs e)
        {       
            InventoryForm inventoryForm = new InventoryForm(loggedUser, backgroundColor);
            inventoryForm.Show();
            this.Hide();
        }

        private void manageClientListButton_Click(object sender, EventArgs e)
        {
            ClientListForm clientListForm = new ClientListForm(loggedUser, backgroundColor);
            clientListForm.Show();
            this.Hide();
        }

        private void manageCalendarEventsButton_Click(object sender, EventArgs e)
        {
            CalendarForm calendarForm = new CalendarForm(loggedUser, backgroundColor);
            calendarForm.Show();
            this.Hide();
        }

        private void userSettingsButton_Click(object sender, EventArgs e)
        {
            UserSettingsForm userSettingsForm = new UserSettingsForm(loggedUser, backgroundColor);
            userSettingsForm.Show();
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

        private void MainMenuForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
