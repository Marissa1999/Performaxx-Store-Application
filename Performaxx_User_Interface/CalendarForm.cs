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

namespace Performaxx_User_Interface
{
    public partial class CalendarForm : Form
    {
        static string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\cstuser\Source\Repos\storeuserapplication\Performaxx_User_Interface\AccountDatabase.mdf;Integrated Security=True";
        SqlConnection connection = new SqlConnection(connectionString);
        SqlCommand command;
        SqlDataAdapter adapter;
        DataTable dataTable = new DataTable();
        string loggedUser;
        string backgroundColor;

        public CalendarForm(string username, string backgroundColor)
        {
            InitializeComponent();
            loggedUser = username;
            refreshEventTable();
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

        private void manageClientListButton_Click(object sender, EventArgs e)
        {
            ClientListForm clientListForm = new ClientListForm(loggedUser, backgroundColor);
            clientListForm.Show();
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

        private void returnToMainMenuButton_Click(object sender, EventArgs e)
        {
            MainMenuForm mainMenuForm = new MainMenuForm(loggedUser, backgroundColor);
            mainMenuForm.Show();
            this.Hide();
        }

        private void manageInventoryButton_Click(object sender, EventArgs e)
        {
            InventoryForm clientListForm = new InventoryForm(loggedUser, backgroundColor);
            clientListForm.Show();
            this.Hide();
        }

        private void userSettingsButton_Click(object sender, EventArgs e)
        {
            UserSettingsForm userSettingsForm = new UserSettingsForm(loggedUser, backgroundColor);
            userSettingsForm.Show();
            this.Hide();
        }

        private void CalendarForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        
        
        private void addEvent(string eventDate, string taskName, string description)
        {
            // Insert SQL statement
            string sql = "INSERT INTO Event(eventDate, taskName, description, userName)" +
                "VALUES(@EVENTDATE, @TASKNAME, @DESCRIPTION, @USERNAME)";
            command = new SqlCommand(sql, connection);

            command.Parameters.AddWithValue("@EVENTDATE", eventDate);
            command.Parameters.AddWithValue("@TASKNAME", taskName);
            command.Parameters.AddWithValue("@DESCRIPTION", description);
            command.Parameters.AddWithValue("@USERNAME", loggedUser);

            while (true)
            {
                try
                {
                    connection.Open();

                    if (command.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Event Successfully Inserted.");
                    }
                    connection.Close();

                    refreshEventTable();
                    break;
                }
                catch (Exception)
                {
                    connection.Close();
                }
            }
            
        }
        private void refreshEventTable()
        {
            eventsListView.Items.Clear();
            

            //SQL STMT
            string sql = "SELECT * FROM Event WHERE eventDate = '" + eventSelectionDateTimePicker.Value.ToString("yyyy-MM-dd") + "'";
            command = new SqlCommand(sql, connection);

            //OPEN Con, RETRIEVE, FILL LISTVIEW
            while (true)
            {
                try
                {
                    connection.Open();

                    adapter = new SqlDataAdapter(command);
                    adapter.Fill(dataTable);

                    // LOOP through data table
                    foreach (DataRow row in dataTable.Rows)
                    {
                        populateEventListView(row[0].ToString(), row[2].ToString(), row[3].ToString());
                    }

                    //CLEAR DT
                    dataTable.Rows.Clear();

                    int count = eventsListView.Items.Count;

                    if (count == 0)
                    {
                        eventsListView.Columns[1].Width = -2;
                        eventsListView.Columns[2].Width = -2;
                    }

                    else
                    {
                        eventsListView.Columns[1].Width = -1;
                        eventsListView.Columns[2].Width = -1;
                    }

                    break;
                }
                catch (Exception)
                {
                    connection.Close();
                }
            }
        }
        private void populateEventListView(string taskName, string description, string eventId)
        {
            string[] row = {taskName, description, eventId};          
           
            eventsListView.Items.Add(new ListViewItem(row));
        }


        private void addEventButton_Click(object sender, EventArgs e)
        {
            addEvent(eventDateTimePicker.Value.ToString("yyyy-MM-dd"), taskNameTextBox.Text, descriptionTextBox.Text);
            taskNameTextBox.Text = "";
            descriptionTextBox.Text = "";
        }

        private void eventSelectionDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            refreshEventTable();
        }

        private void updateEvent(string eventDate, string taskName, string description, int eventId)
        {
            string sql = "UPDATE Event SET EventDate='" + eventDate + "', TaskName='" + taskName +
                "', Description='" + description + "' WHERE EventId=" + eventId + "";
            command = new SqlCommand(sql, connection);

            // Open connection, update, retrieve listview
            while (true)
            {
                try
                {
                    connection.Open();

                    adapter = new SqlDataAdapter(command);
                    adapter.UpdateCommand = connection.CreateCommand();
                    adapter.UpdateCommand.CommandText = sql;

                    if (adapter.UpdateCommand.ExecuteNonQuery() > 0)
                    {
                        taskNameTextBox.Text = "";
                        descriptionTextBox.Text = "";
                        MessageBox.Show("Event Successfully Updated.");
                    }

                    connection.Close();

                    refreshEventTable();
                    break;
                }

                catch (Exception)
                {
                    connection.Close();
                }
            }
        }

        private void editEventButton_Click(object sender, EventArgs e)
        {
            int eventId = int.Parse(eventsListView.SelectedItems[0].SubItems[0].Text);
            string newEventDate = eventDateTimePicker.Value.ToString("yyyy-MM-dd");
            string newTaskName = taskNameTextBox.Text;
            string newDescription = descriptionTextBox.Text;

            updateEvent(newEventDate, newTaskName, newDescription, eventId);
        }

        private void deleteEvent(int eventId)
        {
            // SQL statement
            string sql = "DELETE FROM Event WHERE eventId=" + eventId + "";
            command = new SqlCommand(sql, connection);

            //Open connection, Execute delete, Close Con
            while (true)
            {
                try
                {
                    connection.Open();

                    adapter = new SqlDataAdapter(command);
                    adapter.DeleteCommand = connection.CreateCommand();
                    adapter.DeleteCommand.CommandText = sql;

                    //Prompt for confirmation
                    if (MessageBox.Show("Do you wish to delete this event?", "Message: Event Deletion Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                    {
                        if (command.ExecuteNonQuery() > 0)
                        {
                            taskNameTextBox.Text = "";
                            descriptionTextBox.Text = "";
                            MessageBox.Show("Event Successfully Deleted.");
                        }
                    }
                    connection.Close();

                    // Refresh
                    refreshEventTable();
                    break;
                }

                catch (Exception)
                {
                    connection.Close();
                }
            }
        }

        private void removeEventButton_Click(object sender, EventArgs e)
        {
            int eventId = int.Parse(eventsListView.SelectedItems[0].SubItems[0].Text);
            deleteEvent(eventId);
        }

        private void eventsListView_MouseClick(object sender, MouseEventArgs e)
        {
            taskNameTextBox.Text = eventsListView.SelectedItems[0].SubItems[1].Text;
            descriptionTextBox.Text = eventsListView.SelectedItems[0].SubItems[2].Text;            
        }
    }
}
