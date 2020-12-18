using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DGVPrinterHelper;

namespace Performaxx_User_Interface
{
    public partial class InventoryForm : Form
    {
        static string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\cstuser\Source\Repos\storeuserapplication\Performaxx_User_Interface\AccountDatabase.mdf;Integrated Security=True";
        SqlConnection connection = new SqlConnection(connectionString);
        SqlCommand command;
        SqlDataAdapter adapter;
        DataTable dataTable = new DataTable();        
        string loggedUser;
        string backgroundColor = "";
        public InventoryForm(string username, string backgroundColor)
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

        private void populateInventoryListView(string partId, string name, string price, string location,
            string quantity, string supplier)
        {
            string[] row = { partId, name, price, location, quantity, supplier };

            inventoryListView.Items.Add(new ListViewItem(row));
        }

        private void addPart(string partName, string price, string location,
            string quantity, string supplier)
        {
            // Insert SQL statement
            string sql = "INSERT INTO Inventory(partName, price, location, quantity, supplier)" +
                "VALUES(@PARTNAME, @PRICE, @LOCATION, @QUANTITY, @SUPPLIER)";
            command = new SqlCommand(sql, connection);
            searchInventoryTextBox.Text = "";

            command.Parameters.AddWithValue("@PARTNAME", partName);
            command.Parameters.AddWithValue("@PRICE", decimal.Parse(price));
            command.Parameters.AddWithValue("@LOCATION", location);
            command.Parameters.AddWithValue("@QUANTITY", int.Parse(quantity));
            command.Parameters.AddWithValue("@SUPPLIER", supplier);
            
            while (true)
            {
                try
                {
                    connection.Open();

                    if (command.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Part Successfully Inserted.");
                    }
                    connection.Close();

                    retrieveInventoryTable();
                    break;
                }
                catch (Exception)
                {
                    connection.Close();
                }
            }

            nameTextBox.Text = "";
            priceTextBox.Text = "";
            locationTextBox.Text = "";
            quantityNumericUpDown.Text = "";
            supplierTextBox.Text = "";
        }

        private void retrieveInventoryTable()
        {
            inventoryListView.Items.Clear();

            //SQL STMT
            string sqlQuery = "SELECT * FROM Inventory";
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
                        populateInventoryListView(row[0].ToString(), row[1].ToString(), row[2].ToString(), row[3].ToString(), row[4].ToString(), row[5].ToString());
                    }

                    //CLEAR DT
                    dataTable.Rows.Clear();

                    int count = inventoryListView.Items.Count;

                    if (count == 0)
                    {
                        inventoryListView.Columns[1].Width = -2;
                        inventoryListView.Columns[2].Width = -2;
                        inventoryListView.Columns[3].Width = -2;
                        inventoryListView.Columns[4].Width = -2;
                        inventoryListView.Columns[5].Width = -2;                   
                    }

                    else
                    {
                        inventoryListView.Columns[1].Width = -1;
                        inventoryListView.Columns[2].Width = -2;
                        inventoryListView.Columns[3].Width = -2;
                        inventoryListView.Columns[4].Width = -2;
                        inventoryListView.Columns[5].Width = -1;                      
                    }

                    break;
                }
                catch (Exception)
                {
                    connection.Close();
                }
            }
        }

        private void update(int partId, string partName, string price, string location,
            string quantity, string supplier)
        {
            string sql = "UPDATE Inventory SET PartName='" + partName + "', Price='" + decimal.Parse(price) +
                "', Location='" + location + "', Quantity='" + int.Parse(quantity) + "', Supplier='" + supplier +
                "' WHERE PartId=" + partId + "";
            searchInventoryTextBox.Text = "";

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
                        priceTextBox.Text = "";
                        locationTextBox.Text = "";
                        quantityNumericUpDown.Text = "";
                        supplierTextBox.Text = "";                        
                        MessageBox.Show("Part Successfully Updated.");
                    }

                    connection.Close();

                    retrieveInventoryTable();
                    break;
                }
                catch (Exception)
                {
                    connection.Close();
                }
            }
        }

        private void deletePart(int partId)
        {
            // SQL statement
            string sql = "DELETE FROM Inventory WHERE PartId=" + partId + "";
            command = new SqlCommand(sql, connection);

            searchInventoryTextBox.Text = "";
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
                    if (MessageBox.Show("Do you wish to delete this part?", "Message: Part Deletion Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                    {
                        if (command.ExecuteNonQuery() > 0)
                        {
                            nameTextBox.Text = "";
                            priceTextBox.Text = "";
                            locationTextBox.Text = "";
                            quantityNumericUpDown.Text = "";
                            supplierTextBox.Text = "";                            
                            MessageBox.Show("Part Successfully Deleted.");
                        }
                    }
                    connection.Close();

                    // Refresh
                    retrieveInventoryTable();
                    break;
                }
                catch (Exception)
                {
                    connection.Close();
                }
            }
        }
        private void returnToMainMenuButton_Click(object sender, EventArgs e)
        {
            MainMenuForm mainMenuForm = new MainMenuForm(loggedUser, backgroundColor);
            mainMenuForm.Show();
            this.Hide();
        }

        private void manageClientListButton_Click(object sender, EventArgs e)
        {
            ClientListForm clientListForm = new ClientListForm(loggedUser, backgroundColor);
            clientListForm.Show();
            this.Hide();
        }

        private void userSettingsButton_Click(object sender, EventArgs e)
        {
            UserSettingsForm userSettingsForm = new UserSettingsForm(loggedUser, backgroundColor);
            userSettingsForm.Show();
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

        private void InventoryForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void inventoryListView_MouseClick(object sender, MouseEventArgs e)
        {
            nameTextBox.Text = inventoryListView.SelectedItems[0].SubItems[1].Text;
            priceTextBox.Text = inventoryListView.SelectedItems[0].SubItems[2].Text;
            locationTextBox.Text = inventoryListView.SelectedItems[0].SubItems[3].Text;
            quantityNumericUpDown.Text = inventoryListView.SelectedItems[0].SubItems[4].Text;
            supplierTextBox.Text = inventoryListView.SelectedItems[0].SubItems[5].Text;            
        }

        private void searchInventoryButton_Click(object sender, EventArgs e)
        {
            // SQL statement          
            string sqlQuery = "SELECT * FROM Inventory WHERE PartName LIKE '%" + searchInventoryTextBox.Text + "%'" + "OR Price LIKE '%" + searchInventoryTextBox.Text + "%'"
                + "OR Location LIKE '%" + searchInventoryTextBox.Text + "%'" + "OR Quantity LIKE '%" + searchInventoryTextBox.Text + "%'" + "OR Supplier LIKE '%" + searchInventoryTextBox.Text + "%'";
            
            command = new SqlCommand(sqlQuery, connection);

            nameTextBox.Text = "";
            priceTextBox.Text = "";
            locationTextBox.Text = "";
            quantityNumericUpDown.Text = "";
            supplierTextBox.Text = "";           

            inventoryListView.Items.Clear();
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
                        populateInventoryListView(row[0].ToString(), row[1].ToString(), row[2].ToString(), row[3].ToString(), row[4].ToString(), row[5].ToString());
                    }

                    //CLEAR DT
                    dataTable.Rows.Clear();

                    if (inventoryListView.Items.Count == 0)
                    {
                        MessageBox.Show("Unable to find part. Please search again.", "Error: Invalid Part Search", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void addButton_Click(object sender, EventArgs e)
        {
            decimal priceNum;
            if (nameTextBox.Text.Length <= 30 && priceTextBox.Text.Length <= 18 && locationTextBox.Text.Length <= 30 && supplierTextBox.Text.Length <= 50){

                if (!string.IsNullOrEmpty(nameTextBox.Text) && decimal.TryParse(priceTextBox.Text, out priceNum) && !string.IsNullOrEmpty(locationTextBox.Text))
                {
                    addPart(nameTextBox.Text, priceTextBox.Text, locationTextBox.Text, quantityNumericUpDown.Value.ToString(), supplierTextBox.Text);
                    searchInventoryTextBox.Text = "";
                    nameTextBox.Text = "";
                    priceTextBox.Text = "";
                    locationTextBox.Text = "";
                    quantityNumericUpDown.Text = "";
                    supplierTextBox.Text = "";
                }
                else if (string.IsNullOrEmpty(nameTextBox.Text))
                {
                    MessageBox.Show("You must enter a part name.", "Error: No Part Name Entered", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }   
                else if (!decimal.TryParse(priceTextBox.Text, out priceNum))
                {
                    MessageBox.Show("You must enter a number with two digtis after the decimal point.\nEx: 2.00, 55.50, 14.99", "Error: Incorrect Price Format", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (string.IsNullOrEmpty(locationTextBox.Text))
                {
                    MessageBox.Show("You must enter a location for the part.", "Error: No Location Entered", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("In order to add a part, the maximum number of characters for each entry include the following: \n\n ~ Part name: 30 \n ~ Location: 30 \n ~ Supplier: 50 \n" +
                        "\n Your current number of characters for each entry include: \n\n ~ Part Name: " + nameTextBox.Text.Length + "\n ~ Location: " + locationTextBox.Text.Length +
                        "\n ~ Supplier: " + supplierTextBox.Text.Length, "Error: Invalid Number of Characters for Entries", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            searchInventoryTextBox.Text = "";
            if (inventoryListView.SelectedItems.Count > 0)
            {
                int partId = int.Parse(inventoryListView.SelectedItems[0].SubItems[0].Text);
                deletePart(partId);
            }
            else
            {
                MessageBox.Show("Please select a record to delete.", "Error: Unselected Part Record", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            decimal priceNum;
            searchInventoryTextBox.Text = "";

            if (inventoryListView.SelectedItems.Count > 0)
            {
                if (!string.IsNullOrEmpty(nameTextBox.Text) && decimal.TryParse(priceTextBox.Text, out priceNum) && !string.IsNullOrEmpty(locationTextBox.Text))
                {
                    int partId = int.Parse(inventoryListView.SelectedItems[0].SubItems[0].Text);
                    update(partId, nameTextBox.Text, priceTextBox.Text, locationTextBox.Text, quantityNumericUpDown.Value.ToString(), supplierTextBox.Text);
                }                
                else if (string.IsNullOrEmpty(nameTextBox.Text))
                {
                    MessageBox.Show("You must enter a part name.", "Error: No Part Name Entered", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (!decimal.TryParse(priceTextBox.Text, out priceNum))
                {
                    MessageBox.Show("You must enter a number with two numbers after the decimal point.\nEx: 2.00, 55.50, 14.99", "Error: Incorrect Price Format", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (string.IsNullOrEmpty(locationTextBox.Text))
                {
                    MessageBox.Show("You must enter a location for the part.", "Error: No Location Entered", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select a record to delete.", "Error: Unselected Part Record", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            searchInventoryTextBox.Text = "";
            retrieveInventoryTable();  
        }

        private void printButton_Click(object sender, EventArgs e)
        {
            searchInventoryTextBox.Text = "";
            nameTextBox.Text = "";
            priceTextBox.Text = "";
            locationTextBox.Text = "";
            quantityNumericUpDown.Text = "";
            supplierTextBox.Text = "";

            while (true)
            {
                try
                {
                    connection.Open();
                    adapter = new SqlDataAdapter("SELECT * FROM Inventory", connection);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    inventoryDataGridView.DataSource = dataTable;
                    break;
                }
                catch (Exception)
                {
                    connection.Close();
                }
                connection.Close();
                inventoryDataGridView.Update();
                inventoryDataGridView.Refresh();
            }

            if (inventoryDataGridView.RowCount > 1)
            {
                DialogResult result = MessageBox.Show("Do you want to print a database report of parts?", "Message: Print Part List Database Report Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                if (result == DialogResult.Yes)
                {
                    DGVPrinter printer = new DGVPrinter();
                    printer.Title = "Part List Report";
                    printer.SubTitle = string.Format("Date: {0}", DateTime.Now.Date.ToString("MM/dd/yyyy"));

                    printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
                    printer.PageNumbers = true;
                    printer.PageNumberInHeader = false;
                    printer.PorportionalColumns = true;
                    printer.HeaderCellAlignment = StringAlignment.Near;
                    printer.Footer = "Performaxx Part List";
                    printer.FooterSpacing = 15;
                    printer.PrintDataGridView(inventoryDataGridView);
                }
            }
            else
            {
                MessageBox.Show("There are no parts in the database. Please add a part record.", "Error: No Parts", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void InventoryForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'accountDataSet.Inventory' table. You can move, or remove it, as needed.
            this.inventoryTableAdapter.Fill(this.accountDataSet.Inventory);
            retrieveInventoryTable();
        }
    }
}
