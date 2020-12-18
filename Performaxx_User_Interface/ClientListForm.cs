using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using DGVPrinterHelper;

namespace Performaxx_User_Interface
{
    public partial class ClientListForm : Form
    {
        static string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\cstuser\Source\Repos\storeuserapplication\Performaxx_User_Interface\AccountDatabase.mdf;Integrated Security=True";
        SqlConnection connection = new SqlConnection(connectionString);
        SqlCommand command;
        SqlDataAdapter adapter;
        DataTable dataTable = new DataTable();
        string loggedUser;
        string backgroundColor;
        public ClientListForm(string username, string backgroundColor)
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

        private void populateClientListView(string clientId, string name, string address, string city, string postalCode, string email, string phoneNumber, string comments)
        {
            string[] row = { clientId, name, address, city, postalCode, email, phoneNumber, comments };
     
            clientListView.Items.Add(new ListViewItem(row));
        }

        // Inserting clients
        private void addClient(string name, string address, string city, string postalCode, string email, string phoneNumber, string comments)
        {
            // Insert SQL statement
            string sql = "INSERT INTO Clients(name, address, city, postalCode, email, phoneNumber, comments)" +
                "VALUES(@NAME, @ADDRESS, @CITY, @POSTALCODE, @EMAIL, @PHONENUMBER, @COMMENTS)";
            command = new SqlCommand(sql, connection);

            command.Parameters.AddWithValue("@NAME", name);
            command.Parameters.AddWithValue("@ADDRESS", address);
            command.Parameters.AddWithValue("@CITY", city);
            command.Parameters.AddWithValue("@POSTALCODE", postalCode);
            command.Parameters.AddWithValue("@EMAIL", email);
            command.Parameters.AddWithValue("@PHONENUMBER", phoneNumber);
            command.Parameters.AddWithValue("@COMMENTS", comments);
             
            while (true)
            {
                try
                {
                    connection.Open();

                    if (command.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Client Successfully Inserted.");
                    }
                    connection.Close();

                    retrieveClientTable();
                    break;
                }
                catch (Exception)
                {
                    connection.Close();
                }
            }
        }

        // Selecting clients
        private void retrieveClientTable()
        {
            clientListView.Items.Clear();

            //SQL STMT
            string sqlQuery = "SELECT * FROM Clients";
            command = new SqlCommand(sqlQuery, connection);

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
                        populateClientListView(row[0].ToString(), row[1].ToString(), row[2].ToString(), row[3].ToString(), row[4].ToString(), row[5].ToString(), row[6].ToString(), row[7].ToString());
                    }

                    //CLEAR DT
                    dataTable.Rows.Clear();

                    int count = clientListView.Items.Count;

                    if (count == 0)
                    {
                        clientListView.Columns[1].Width = -2;
                        clientListView.Columns[2].Width = -2;
                        clientListView.Columns[3].Width = -2;
                        clientListView.Columns[4].Width = -2;
                        clientListView.Columns[5].Width = -2;
                        clientListView.Columns[6].Width = -2;
                        clientListView.Columns[7].Width = -2;
                    }

                    else
                    {
                        clientListView.Columns[1].Width = -1;
                        clientListView.Columns[2].Width = -1;
                        clientListView.Columns[3].Width = -1;
                        clientListView.Columns[4].Width = -2;
                        clientListView.Columns[5].Width = -1;
                        clientListView.Columns[6].Width = -2;
                        clientListView.Columns[7].Width = -1;
                    }

                    break;
                }

                catch (Exception)
                {
                    connection.Close();
                }
            }
        }

        private void updateClient(int clientId, string name, string address, string city, string postalCode, string email, string phoneNumber, string comments)
        {
            string sql = "UPDATE Clients SET Name='" + name + "', Address='" + address +
                "', City='" + city + "', PostalCode='" + postalCode + "', Email='" + email +
                "', PhoneNumber='" + phoneNumber + "', Comments='" + comments + "' WHERE ClientId=" + clientId + "";
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
                        nameTextBox.Text = "";
                        addressTextBox.Text = "";
                        cityTextBox.Text = "";
                        postalCodeTextBox.Text = "";
                        emailTextBox.Text = "";
                        phoneNumberTextBox.Text = "";
                        commentsTextBox.Text = "";
                        searchClientTextBox.Text = "";
                        MessageBox.Show("Client Successfully Updated.");
                    }

                    connection.Close();

                    retrieveClientTable();
                    break;
                }

                catch (Exception)
                {
                    connection.Close();
                }
            }            
        }

        private void deleteClient(int clientId)
        {
            
            // SQL statement
            string sql = "DELETE FROM Clients WHERE ClientId=" + clientId + "";
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
                    if (MessageBox.Show("Do you wish to delete this client?", "Message: Client Deletion Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                    {
                        if (command.ExecuteNonQuery() > 0)
                        {
                            nameTextBox.Text = "";
                            addressTextBox.Text = "";
                            cityTextBox.Text = "";
                            postalCodeTextBox.Text = "";
                            emailTextBox.Text = "";
                            phoneNumberTextBox.Text = "";
                            commentsTextBox.Text = "";
                            searchClientTextBox.Text = "";
                            MessageBox.Show("Client Successfully Deleted.");
                        }
                    }
                    connection.Close();

                    // Refresh
                    retrieveClientTable();
                    break;
                }
                catch (Exception)
                {
                    connection.Close();
                }
            }                       
        }

        private void clientListView_MouseClick(object sender, MouseEventArgs e)
        {
            nameTextBox.Text = clientListView.SelectedItems[0].SubItems[1].Text;
            addressTextBox.Text = clientListView.SelectedItems[0].SubItems[2].Text;
            cityTextBox.Text = clientListView.SelectedItems[0].SubItems[3].Text;
            postalCodeTextBox.Text = clientListView.SelectedItems[0].SubItems[4].Text;
            emailTextBox.Text = clientListView.SelectedItems[0].SubItems[5].Text;
            phoneNumberTextBox.Text = clientListView.SelectedItems[0].SubItems[6].Text;
            commentsTextBox.Text = clientListView.SelectedItems[0].SubItems[7].Text;                
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (Regex.IsMatch(nameTextBox.Text, @"^[a-z,A-Z,\-,\s]{2,40}"))
            {
                if (nameTextBox.Text.Length <= 40 && addressTextBox.Text.Length <= 30 && cityTextBox.Text.Length <= 40 && postalCodeTextBox.Text.Length <= 7 && emailTextBox.Text.Length <= 40
                    && phoneNumberTextBox.Text.Length <= 12 && commentsTextBox.Text.Length <= 100)
                {
                    if (Regex.IsMatch(addressTextBox.Text, @"^[A-Za-z0-9]+(?:\s[A-Za-z0-9'_-]+)+$") && Regex.IsMatch(cityTextBox.Text, @"^[a-zA-Z]+(?:[\s-][a-zA-Z]+)*$") &&
                        Regex.IsMatch(postalCodeTextBox.Text, @"[ABCEGHJKLMNPRSTVXY][0-9][ABCEGHJKLMNPRSTVWXYZ] ?[0-9][ABCEGHJKLMNPRSTVWXYZ][0-9]") && Regex.IsMatch(emailTextBox.Text, @"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$") &&
                        Regex.IsMatch(phoneNumberTextBox.Text, @"^(?:\([2-9]\d{2}\)\ ?|[2-9]\d{2}(?:\-?|\ ?))[2-9]\d{2}[- ]?\d{4}$") && !string.IsNullOrEmpty(commentsTextBox.Text))
                    {
                        addClient(nameTextBox.Text, addressTextBox.Text, cityTextBox.Text,
                            postalCodeTextBox.Text, emailTextBox.Text, phoneNumberTextBox.Text,
                            commentsTextBox.Text);

                        nameTextBox.Text = "";
                        addressTextBox.Text = "";
                        cityTextBox.Text = "";
                        postalCodeTextBox.Text = "";
                        emailTextBox.Text = "";
                        phoneNumberTextBox.Text = "";
                        commentsTextBox.Text = "";
                        searchClientTextBox.Text = "";
                    }
                    else if (!Regex.IsMatch(addressTextBox.Text, @"^[A-Za-z0-9]+(?:\s[A-Za-z0-9'_-]+)+$"))
                    {
                        MessageBox.Show("The address must follow the following format: \nEx: 821 Saint-Croix", "Error: Incorrect Address Format", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (!Regex.IsMatch(cityTextBox.Text, @"^[a-zA-Z]+(?:[\s-][a-zA-Z]+)*$"))
                    {
                        MessageBox.Show("The city must be formated as follows: \nEx: Saint-Laurent", "Error: Incorrect City Format", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (!Regex.IsMatch(postalCodeTextBox.Text, @"[ABCEGHJKLMNPRSTVXY][0-9][ABCEGHJKLMNPRSTVWXYZ] ?[0-9][ABCEGHJKLMNPRSTVWXYZ][0-9]"))
                    {
                        MessageBox.Show("The postal code must be formated as follows: \nEx: H4L 1H3", "Error: Incorrect Postal Code Format", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (!Regex.IsMatch(emailTextBox.Text, @"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$"))
                    {
                        MessageBox.Show("The email must be formated as follows: \nEx: example@gmail.com", "Error: Incorrect Email Format", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }     
                    else if (!Regex.IsMatch(phoneNumberTextBox.Text, @"^(?:\([2-9]\d{2}\)\ ?|[2-9]\d{2}(?:\-?|\ ?))[2-9]\d{2}[- ]?\d{4}$"))
                    {
                        MessageBox.Show("The phone number must be formated as follows: \nEx: 514-313-6866, (514) 686-7777, 5146687777, 554-5556666, 555687-5465", "Error: Incorrect Phone Number Format", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (string.IsNullOrEmpty(commentsTextBox.Text))
                    {
                        MessageBox.Show("The client comment entry should not be empty.", "Error: Empty Comment Entry", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                else
                {
                    MessageBox.Show("In order to add a client, the maximum number of characters for each entry include the following: \n\n ~ Name: 40 \n ~ Address: 30 \n ~ City: 40 \n ~ Postal Code: 7 " +
                        "\n ~ Email: 40 \n ~ Phone Number: 12 \n ~ Comments: 100" + "\n\n Your current number of characters for each entry include: \n\n ~ Name: " + nameTextBox.Text.Length + "\n ~ Address: " + 
                        addressTextBox.Text.Length + "\n ~ City: " + cityTextBox.Text.Length + "\n ~ Postal Code: " + postalCodeTextBox.Text.Length + "\n ~ Email: " + emailTextBox.Text.Length +
                        "\n ~ Phone Number: " + phoneNumberTextBox.Text.Length + "\n ~ Comments: " + commentsTextBox.Text.Length, "Error: Invalid Number of Characters for Entries", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            else
            {
                MessageBox.Show("Please add at least two characters and no digits for the client's name.", "Error: Invalid Client Name", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void removeButton_Click(object sender, EventArgs e)
        {

            if (clientListView.SelectedItems.Count > 0)
            {
                int clientId = int.Parse(clientListView.SelectedItems[0].SubItems[0].Text);
                deleteClient(clientId);
            }

            else
            {
                MessageBox.Show("Please select a record to delete.", "Error: Unselected Client Record", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            if (clientListView.SelectedItems.Count > 0)
            {
                if (Regex.IsMatch(nameTextBox.Text, @"^[a-z,A-Z,\-,\s]{2,40}"))
                {
                    if (nameTextBox.Text.Length <= 40 && addressTextBox.Text.Length <= 30 && cityTextBox.Text.Length <= 40 && postalCodeTextBox.Text.Length <= 7 && emailTextBox.Text.Length <= 40
                        && phoneNumberTextBox.Text.Length <= 12 && commentsTextBox.Text.Length <= 100)
                    {
                        int clientId = int.Parse(clientListView.SelectedItems[0].SubItems[0].Text);
                        if (Regex.IsMatch(addressTextBox.Text, @"^[A-Za-z0-9]+(?:\s[A-Za-z0-9'_-]+)+$") && Regex.IsMatch(cityTextBox.Text, @"^[a-zA-Z]+(?:[\s-][a-zA-Z]+)*$") &&
                            Regex.IsMatch(postalCodeTextBox.Text, @"[ABCEGHJKLMNPRSTVXY][0-9][ABCEGHJKLMNPRSTVWXYZ] ?[0-9][ABCEGHJKLMNPRSTVWXYZ][0-9]") && Regex.IsMatch(emailTextBox.Text, @"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$") &&
                            Regex.IsMatch(phoneNumberTextBox.Text, @"^(?:\([2-9]\d{2}\)\ ?|[2-9]\d{2}(?:\-?|\ ?))[2-9]\d{2}[- ]?\d{4}$") && !string.IsNullOrEmpty(commentsTextBox.Text))
                        {
                            string newName = nameTextBox.Text;
                            string newAddress = addressTextBox.Text;
                            string newCity = cityTextBox.Text;
                            string newPostalCode = postalCodeTextBox.Text;
                            string newEmail = emailTextBox.Text;
                            string newPhoneNumber = phoneNumberTextBox.Text;
                            string newComments = commentsTextBox.Text;

                            updateClient(clientId, newName, newAddress, newCity, newPostalCode, newEmail, newPhoneNumber, newComments);

                            nameTextBox.Text = "";
                            addressTextBox.Text = "";
                            cityTextBox.Text = "";
                            postalCodeTextBox.Text = "";
                            emailTextBox.Text = "";
                            phoneNumberTextBox.Text = "";
                            commentsTextBox.Text = "";
                            searchClientTextBox.Text = "";
                        }

                        else if (!Regex.IsMatch(addressTextBox.Text, @"^[A-Za-z0-9]+(?:\s[A-Za-z0-9'_-]+)+$"))
                        {
                            MessageBox.Show("The address must follow the following format: \nEx: 821 Saint-Croix", "Error: Incorrect Address Format", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else if (!Regex.IsMatch(cityTextBox.Text, @"^[a-zA-Z]+(?:[\s-][a-zA-Z]+)*$"))
                        {
                            MessageBox.Show("The city must be formated as follows: \nEx: Saint-Laurent", "Error: Incorrect City Format", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else if (!Regex.IsMatch(postalCodeTextBox.Text, @"[ABCEGHJKLMNPRSTVXY][0-9][ABCEGHJKLMNPRSTVWXYZ] ?[0-9][ABCEGHJKLMNPRSTVWXYZ][0-9]"))
                        {
                            MessageBox.Show("The postal code must be formated as follows: \nEx: H4L 1H3", "Error: Incorrect Postal Code Format", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else if (!Regex.IsMatch(emailTextBox.Text, @"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$"))
                        {
                            MessageBox.Show("The email must be formated as follows: \nEx: example@gmail.com", "Error: Incorrect Email Format", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else if (!Regex.IsMatch(phoneNumberTextBox.Text, @"^(?:\([2-9]\d{2}\)\ ?|[2-9]\d{2}(?:\-?|\ ?))[2-9]\d{2}[- ]?\d{4}$"))
                        {
                            MessageBox.Show("The phone number must be formated as follows: \nEx: 514-313-6866, (514) 686-7777, 5146687777, 554-5556666, 555687-5465", "Error: Incorrect Phone Number Format", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else if (string.IsNullOrEmpty(commentsTextBox.Text))
                        {
                            MessageBox.Show("The client comment entry should not be empty.", "Error: Empty Comment Entry", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("In order to update a client, the maximum number of characters for each entry include the following: \n\n ~ Name: 40 \n ~ Address: 30 \n ~ City: 40 \n ~ Postal Code: 7 " +
                            "\n ~ Email: 40 \n ~ Phone Number: 12 \n ~ Comments: 100" + "\n\n Your current number of characters for each entry include: \n\n ~ Name: " + nameTextBox.Text.Length + "\n ~ Address: " +
                            addressTextBox.Text.Length + "\n ~ City: " + cityTextBox.Text.Length + "\n ~ Postal Code: " + postalCodeTextBox.Text.Length + "\n ~ Email: " + emailTextBox.Text.Length +
                            "\n ~ Phone Number: " + phoneNumberTextBox.Text.Length + "\n ~ Comments: " + commentsTextBox.Text.Length, "Error: Invalid Number of Characters for Entries", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }                   
                }
                else
                {
                    MessageBox.Show("The client name must contain at least two characters and no digits.", "Error: Invalid Client Name", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select a record to update.", "Error: Unselected Client Record", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            retrieveClientTable();
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

        private void ClientListForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void printButton_Click(object sender, EventArgs e)
        {
            nameTextBox.Text = "";
            addressTextBox.Text = "";
            cityTextBox.Text = "";
            postalCodeTextBox.Text = "";
            emailTextBox.Text = "";
            phoneNumberTextBox.Text = "";
            commentsTextBox.Text = "";
            searchClientTextBox.Text = "";

            while (true)
            {
                try
                {
                    connection.Open();
                    adapter = new SqlDataAdapter("SELECT * FROM Clients", connection);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    clientsDataGridView.DataSource = dataTable;
                    break;
                }

                catch (Exception)
                {
                    connection.Close();
                }

                connection.Close();
                clientsDataGridView.Update();
                clientsDataGridView.Refresh();
            }

            if (clientsDataGridView.RowCount > 1)
            {
                DialogResult result = MessageBox.Show("Would you like to print a database report of clients?", "Message: Print Client Database Report Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);                

                if (result == DialogResult.Yes)
                {
                    DGVPrinter printer = new DGVPrinter();
                    printer.Title = "Client List Report";
                    printer.SubTitle = string.Format("Date: {0}", DateTime.Now.Date.ToString("MM/dd/yyyy"));

                    printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
                    printer.PageNumbers = true;
                    printer.PageNumberInHeader = false;
                    printer.PorportionalColumns = true;
                    printer.HeaderCellAlignment = StringAlignment.Near;
                    printer.Footer = "Performaxx Client List";
                    printer.FooterSpacing = 15;
                    printer.PrintDataGridView(clientsDataGridView);
                }
            }

            else
            {
                MessageBox.Show("There are no clients in the database. Please add a client record.", "Error: No Clients", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClientListForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'accountDataSet.Clients' table. You can move, or      it, as needed.
            this.clientsTableAdapter.Fill(this.accountDataSet.Clients);
            retrieveClientTable();
        }

        private void searchClientButton_Click(object sender, EventArgs e)
        {

            // SQL statement
            string sqlQuery = "SELECT * FROM Clients WHERE Name LIKE '%" + searchClientTextBox.Text + "%'" + "OR Address LIKE '%" + searchClientTextBox.Text + "%'" 
                + "OR City LIKE '%" + searchClientTextBox.Text + "%'" + "OR PostalCode LIKE '%" + searchClientTextBox.Text + "%'" + "OR Email LIKE '%" + searchClientTextBox.Text + "%'"
                + "OR PhoneNumber LIKE '%" + searchClientTextBox.Text + "%'" + "OR Comments LIKE '%" + searchClientTextBox.Text + "%'";
            command = new SqlCommand(sqlQuery, connection);

            nameTextBox.Text = "";
            addressTextBox.Text = "";
            cityTextBox.Text = "";
            postalCodeTextBox.Text = "";
            emailTextBox.Text = "";
            phoneNumberTextBox.Text = "";
            commentsTextBox.Text = "";                

            clientListView.Items.Clear();
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
                        populateClientListView(row[0].ToString(), row[1].ToString(), row[2].ToString(), row[3].ToString(), row[4].ToString(), row[5].ToString(), row[6].ToString(), row[7].ToString());
                    }
                    
                    //CLEAR DT
                    dataTable.Rows.Clear();

                    if (clientListView.Items.Count == 0)
                    {
                        MessageBox.Show("Unable to find client. Please search again.", "Error: Invalid Client Search", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                    break;
                }

                catch (Exception)
                {                         
                    connection.Close();
                }
            }

            connection.Close();            
        }
    }
}
