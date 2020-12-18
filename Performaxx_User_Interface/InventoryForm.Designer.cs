namespace Performaxx_User_Interface
{
    partial class InventoryForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InventoryForm));
            this.inventoryListView = new System.Windows.Forms.ListView();
            this.partIdHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.partNameHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.partPriceHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.partLocationHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.partQuantityHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.partSupplierHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.logoutButton = new System.Windows.Forms.Button();
            this.mainMenuPanel = new System.Windows.Forms.Panel();
            this.manageCalendarEventsButton = new System.Windows.Forms.Button();
            this.userSettingsButton = new System.Windows.Forms.Button();
            this.manageClientListButton = new System.Windows.Forms.Button();
            this.returnToMainMenuButton = new System.Windows.Forms.Button();
            this.inventoryTableLabel = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.refreshButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.searchInventoryTextBox = new System.Windows.Forms.TextBox();
            this.searchInventoryButton = new System.Windows.Forms.Button();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.locationTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.locationLabel = new System.Windows.Forms.Label();
            this.quantityLabel = new System.Windows.Forms.Label();
            this.supplierTextBox = new System.Windows.Forms.TextBox();
            this.supplierLabel = new System.Windows.Forms.Label();
            this.printButton = new System.Windows.Forms.Button();
            this.addingIconPictureBox = new System.Windows.Forms.PictureBox();
            this.removingIconPictureBox = new System.Windows.Forms.PictureBox();
            this.updatingIconPictureBox = new System.Windows.Forms.PictureBox();
            this.refreshIconPictureBox = new System.Windows.Forms.PictureBox();
            this.quantityNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.accountDataSet = new Performaxx_User_Interface.AccountDataSet();
            this.inventoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inventoryTableAdapter = new Performaxx_User_Interface.AccountDataSetTableAdapters.InventoryTableAdapter();
            this.tableAdapterManager = new Performaxx_User_Interface.AccountDataSetTableAdapters.TableAdapterManager();
            this.inventoryDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inventoryPrintDialog = new System.Windows.Forms.PrintDialog();
            this.mainMenuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addingIconPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.removingIconPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.updatingIconPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.refreshIconPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantityNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // inventoryListView
            // 
            this.inventoryListView.BackColor = System.Drawing.Color.Silver;
            this.inventoryListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.partIdHeader,
            this.partNameHeader,
            this.partPriceHeader,
            this.partLocationHeader,
            this.partQuantityHeader,
            this.partSupplierHeader});
            this.inventoryListView.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventoryListView.FullRowSelect = true;
            this.inventoryListView.GridLines = true;
            this.inventoryListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.inventoryListView.HideSelection = false;
            this.inventoryListView.Location = new System.Drawing.Point(179, 274);
            this.inventoryListView.Name = "inventoryListView";
            this.inventoryListView.Size = new System.Drawing.Size(446, 333);
            this.inventoryListView.TabIndex = 0;
            this.inventoryListView.UseCompatibleStateImageBehavior = false;
            this.inventoryListView.View = System.Windows.Forms.View.Details;
            this.inventoryListView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.inventoryListView_MouseClick);
            // 
            // partIdHeader
            // 
            this.partIdHeader.Text = "Part ID";
            this.partIdHeader.Width = 0;
            // 
            // partNameHeader
            // 
            this.partNameHeader.Text = "Name";
            this.partNameHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.partNameHeader.Width = 110;
            // 
            // partPriceHeader
            // 
            this.partPriceHeader.Text = "Price";
            this.partPriceHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.partPriceHeader.Width = 81;
            // 
            // partLocationHeader
            // 
            this.partLocationHeader.Text = "Location";
            this.partLocationHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.partLocationHeader.Width = 84;
            // 
            // partQuantityHeader
            // 
            this.partQuantityHeader.Text = "Quantity";
            this.partQuantityHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.partQuantityHeader.Width = 77;
            // 
            // partSupplierHeader
            // 
            this.partSupplierHeader.Text = "Supplier";
            this.partSupplierHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.partSupplierHeader.Width = 90;
            // 
            // logoutButton
            // 
            this.logoutButton.BackColor = System.Drawing.Color.Transparent;
            this.logoutButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(236)))), ((int)(((byte)(209)))));
            this.logoutButton.FlatAppearance.BorderSize = 0;
            this.logoutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoutButton.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutButton.Image = ((System.Drawing.Image)(resources.GetObject("logoutButton.Image")));
            this.logoutButton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.logoutButton.Location = new System.Drawing.Point(824, 147);
            this.logoutButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(87, 82);
            this.logoutButton.TabIndex = 36;
            this.logoutButton.Text = "Logout";
            this.logoutButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.logoutButton.UseVisualStyleBackColor = false;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // mainMenuPanel
            // 
            this.mainMenuPanel.BackColor = System.Drawing.SystemColors.Info;
            this.mainMenuPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.mainMenuPanel.Controls.Add(this.manageCalendarEventsButton);
            this.mainMenuPanel.Controls.Add(this.userSettingsButton);
            this.mainMenuPanel.Controls.Add(this.manageClientListButton);
            this.mainMenuPanel.Location = new System.Drawing.Point(309, 156);
            this.mainMenuPanel.Name = "mainMenuPanel";
            this.mainMenuPanel.Size = new System.Drawing.Size(508, 63);
            this.mainMenuPanel.TabIndex = 35;
            // 
            // manageCalendarEventsButton
            // 
            this.manageCalendarEventsButton.BackColor = System.Drawing.Color.LightBlue;
            this.manageCalendarEventsButton.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manageCalendarEventsButton.Location = new System.Drawing.Point(174, 11);
            this.manageCalendarEventsButton.Name = "manageCalendarEventsButton";
            this.manageCalendarEventsButton.Size = new System.Drawing.Size(178, 35);
            this.manageCalendarEventsButton.TabIndex = 3;
            this.manageCalendarEventsButton.Text = "Manage Calendar Events";
            this.manageCalendarEventsButton.UseVisualStyleBackColor = false;
            this.manageCalendarEventsButton.Click += new System.EventHandler(this.manageCalendarEventsButton_Click);
            // 
            // userSettingsButton
            // 
            this.userSettingsButton.BackColor = System.Drawing.Color.LightBlue;
            this.userSettingsButton.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userSettingsButton.Location = new System.Drawing.Point(369, 11);
            this.userSettingsButton.Name = "userSettingsButton";
            this.userSettingsButton.Size = new System.Drawing.Size(123, 35);
            this.userSettingsButton.TabIndex = 2;
            this.userSettingsButton.Text = "User Settings";
            this.userSettingsButton.UseVisualStyleBackColor = false;
            this.userSettingsButton.Click += new System.EventHandler(this.userSettingsButton_Click);
            // 
            // manageClientListButton
            // 
            this.manageClientListButton.BackColor = System.Drawing.Color.LightBlue;
            this.manageClientListButton.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manageClientListButton.Location = new System.Drawing.Point(12, 11);
            this.manageClientListButton.Name = "manageClientListButton";
            this.manageClientListButton.Size = new System.Drawing.Size(147, 35);
            this.manageClientListButton.TabIndex = 1;
            this.manageClientListButton.Text = "Manage Client List";
            this.manageClientListButton.UseVisualStyleBackColor = false;
            this.manageClientListButton.Click += new System.EventHandler(this.manageClientListButton_Click);
            // 
            // returnToMainMenuButton
            // 
            this.returnToMainMenuButton.BackColor = System.Drawing.Color.Transparent;
            this.returnToMainMenuButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.returnToMainMenuButton.FlatAppearance.BorderSize = 0;
            this.returnToMainMenuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.returnToMainMenuButton.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnToMainMenuButton.Image = ((System.Drawing.Image)(resources.GetObject("returnToMainMenuButton.Image")));
            this.returnToMainMenuButton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.returnToMainMenuButton.Location = new System.Drawing.Point(168, 147);
            this.returnToMainMenuButton.Name = "returnToMainMenuButton";
            this.returnToMainMenuButton.Size = new System.Drawing.Size(135, 82);
            this.returnToMainMenuButton.TabIndex = 37;
            this.returnToMainMenuButton.Text = "Return to Main Menu";
            this.returnToMainMenuButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.returnToMainMenuButton.UseVisualStyleBackColor = false;
            this.returnToMainMenuButton.Click += new System.EventHandler(this.returnToMainMenuButton_Click);
            // 
            // inventoryTableLabel
            // 
            this.inventoryTableLabel.AutoSize = true;
            this.inventoryTableLabel.BackColor = System.Drawing.Color.Transparent;
            this.inventoryTableLabel.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventoryTableLabel.Location = new System.Drawing.Point(191, 245);
            this.inventoryTableLabel.Name = "inventoryTableLabel";
            this.inventoryTableLabel.Size = new System.Drawing.Size(112, 20);
            this.inventoryTableLabel.TabIndex = 38;
            this.inventoryTableLabel.Text = "Inventory Table:";
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.DarkOrange;
            this.addButton.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.Location = new System.Drawing.Point(682, 444);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(144, 32);
            this.addButton.TabIndex = 39;
            this.addButton.Text = "Add Record";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // refreshButton
            // 
            this.refreshButton.BackColor = System.Drawing.Color.DarkOrange;
            this.refreshButton.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refreshButton.Location = new System.Drawing.Point(680, 558);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(144, 32);
            this.refreshButton.TabIndex = 40;
            this.refreshButton.Text = "Refresh Table";
            this.refreshButton.UseVisualStyleBackColor = false;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.BackColor = System.Drawing.Color.DarkOrange;
            this.updateButton.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateButton.Location = new System.Drawing.Point(680, 520);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(146, 32);
            this.updateButton.TabIndex = 41;
            this.updateButton.Text = "Update Record";
            this.updateButton.UseVisualStyleBackColor = false;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // removeButton
            // 
            this.removeButton.BackColor = System.Drawing.Color.DarkOrange;
            this.removeButton.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeButton.Location = new System.Drawing.Point(680, 482);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(146, 32);
            this.removeButton.TabIndex = 42;
            this.removeButton.Text = "Remove Record";
            this.removeButton.UseVisualStyleBackColor = false;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // searchInventoryTextBox
            // 
            this.searchInventoryTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchInventoryTextBox.Location = new System.Drawing.Point(323, 242);
            this.searchInventoryTextBox.Name = "searchInventoryTextBox";
            this.searchInventoryTextBox.Size = new System.Drawing.Size(210, 26);
            this.searchInventoryTextBox.TabIndex = 44;
            // 
            // searchInventoryButton
            // 
            this.searchInventoryButton.BackColor = System.Drawing.Color.DarkOrange;
            this.searchInventoryButton.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchInventoryButton.Location = new System.Drawing.Point(539, 239);
            this.searchInventoryButton.Name = "searchInventoryButton";
            this.searchInventoryButton.Size = new System.Drawing.Size(86, 31);
            this.searchInventoryButton.TabIndex = 45;
            this.searchInventoryButton.Text = "Search";
            this.searchInventoryButton.UseVisualStyleBackColor = false;
            this.searchInventoryButton.Click += new System.EventHandler(this.searchInventoryButton_Click);
            // 
            // priceTextBox
            // 
            this.priceTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceTextBox.Location = new System.Drawing.Point(722, 291);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(179, 26);
            this.priceTextBox.TabIndex = 46;
            // 
            // locationTextBox
            // 
            this.locationTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.locationTextBox.Location = new System.Drawing.Point(722, 323);
            this.locationTextBox.Name = "locationTextBox";
            this.locationTextBox.Size = new System.Drawing.Size(179, 26);
            this.locationTextBox.TabIndex = 47;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTextBox.Location = new System.Drawing.Point(722, 259);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(179, 26);
            this.nameTextBox.TabIndex = 49;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.BackColor = System.Drawing.Color.Transparent;
            this.nameLabel.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(662, 262);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(55, 18);
            this.nameLabel.TabIndex = 50;
            this.nameLabel.Text = "Name:";
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.BackColor = System.Drawing.Color.Transparent;
            this.priceLabel.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceLabel.Location = new System.Drawing.Point(668, 294);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(49, 18);
            this.priceLabel.TabIndex = 51;
            this.priceLabel.Text = "Price:";
            // 
            // locationLabel
            // 
            this.locationLabel.AutoSize = true;
            this.locationLabel.BackColor = System.Drawing.Color.Transparent;
            this.locationLabel.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.locationLabel.Location = new System.Drawing.Point(646, 326);
            this.locationLabel.Name = "locationLabel";
            this.locationLabel.Size = new System.Drawing.Size(73, 18);
            this.locationLabel.TabIndex = 52;
            this.locationLabel.Text = "Location:";
            // 
            // quantityLabel
            // 
            this.quantityLabel.AutoSize = true;
            this.quantityLabel.BackColor = System.Drawing.Color.Transparent;
            this.quantityLabel.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantityLabel.Location = new System.Drawing.Point(642, 359);
            this.quantityLabel.Name = "quantityLabel";
            this.quantityLabel.Size = new System.Drawing.Size(76, 18);
            this.quantityLabel.TabIndex = 53;
            this.quantityLabel.Text = "Quantity:";
            // 
            // supplierTextBox
            // 
            this.supplierTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supplierTextBox.Location = new System.Drawing.Point(722, 388);
            this.supplierTextBox.Name = "supplierTextBox";
            this.supplierTextBox.Size = new System.Drawing.Size(179, 26);
            this.supplierTextBox.TabIndex = 54;
            // 
            // supplierLabel
            // 
            this.supplierLabel.AutoSize = true;
            this.supplierLabel.BackColor = System.Drawing.Color.Transparent;
            this.supplierLabel.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supplierLabel.Location = new System.Drawing.Point(646, 391);
            this.supplierLabel.Name = "supplierLabel";
            this.supplierLabel.Size = new System.Drawing.Size(72, 18);
            this.supplierLabel.TabIndex = 55;
            this.supplierLabel.Text = "Supplier:";
            // 
            // printButton
            // 
            this.printButton.BackColor = System.Drawing.Color.Transparent;
            this.printButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(236)))), ((int)(((byte)(209)))));
            this.printButton.FlatAppearance.BorderSize = 0;
            this.printButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.printButton.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printButton.Image = ((System.Drawing.Image)(resources.GetObject("printButton.Image")));
            this.printButton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.printButton.Location = new System.Drawing.Point(833, 462);
            this.printButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.printButton.Name = "printButton";
            this.printButton.Size = new System.Drawing.Size(79, 102);
            this.printButton.TabIndex = 56;
            this.printButton.Text = "Print Database";
            this.printButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.printButton.UseVisualStyleBackColor = false;
            this.printButton.Click += new System.EventHandler(this.printButton_Click);
            // 
            // addingIconPictureBox
            // 
            this.addingIconPictureBox.BackColor = System.Drawing.Color.LimeGreen;
            this.addingIconPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.addingIconPictureBox.Image = global::Performaxx_User_Interface.Properties.Resources.AddingButtonImage;
            this.addingIconPictureBox.Location = new System.Drawing.Point(642, 444);
            this.addingIconPictureBox.Name = "addingIconPictureBox";
            this.addingIconPictureBox.Size = new System.Drawing.Size(32, 32);
            this.addingIconPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.addingIconPictureBox.TabIndex = 58;
            this.addingIconPictureBox.TabStop = false;
            // 
            // removingIconPictureBox
            // 
            this.removingIconPictureBox.BackColor = System.Drawing.Color.OrangeRed;
            this.removingIconPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.removingIconPictureBox.Image = global::Performaxx_User_Interface.Properties.Resources.RemovingButtonImage;
            this.removingIconPictureBox.Location = new System.Drawing.Point(642, 482);
            this.removingIconPictureBox.Name = "removingIconPictureBox";
            this.removingIconPictureBox.Size = new System.Drawing.Size(32, 32);
            this.removingIconPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.removingIconPictureBox.TabIndex = 59;
            this.removingIconPictureBox.TabStop = false;
            // 
            // updatingIconPictureBox
            // 
            this.updatingIconPictureBox.BackColor = System.Drawing.Color.Gold;
            this.updatingIconPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.updatingIconPictureBox.Image = global::Performaxx_User_Interface.Properties.Resources.PopulateButtonImage;
            this.updatingIconPictureBox.Location = new System.Drawing.Point(642, 520);
            this.updatingIconPictureBox.Name = "updatingIconPictureBox";
            this.updatingIconPictureBox.Size = new System.Drawing.Size(32, 32);
            this.updatingIconPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.updatingIconPictureBox.TabIndex = 60;
            this.updatingIconPictureBox.TabStop = false;
            // 
            // refreshIconPictureBox
            // 
            this.refreshIconPictureBox.BackColor = System.Drawing.Color.MediumTurquoise;
            this.refreshIconPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.refreshIconPictureBox.Image = global::Performaxx_User_Interface.Properties.Resources.UpdatingButtonImage;
            this.refreshIconPictureBox.Location = new System.Drawing.Point(642, 558);
            this.refreshIconPictureBox.Name = "refreshIconPictureBox";
            this.refreshIconPictureBox.Size = new System.Drawing.Size(32, 32);
            this.refreshIconPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.refreshIconPictureBox.TabIndex = 61;
            this.refreshIconPictureBox.TabStop = false;
            // 
            // quantityNumericUpDown
            // 
            this.quantityNumericUpDown.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantityNumericUpDown.Location = new System.Drawing.Point(722, 355);
            this.quantityNumericUpDown.Name = "quantityNumericUpDown";
            this.quantityNumericUpDown.Size = new System.Drawing.Size(179, 26);
            this.quantityNumericUpDown.TabIndex = 63;
            // 
            // accountDataSet
            // 
            this.accountDataSet.DataSetName = "AccountDataSet";
            this.accountDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // inventoryBindingSource
            // 
            this.inventoryBindingSource.DataMember = "Inventory";
            this.inventoryBindingSource.DataSource = this.accountDataSet;
            // 
            // inventoryTableAdapter
            // 
            this.inventoryTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClientsTableAdapter = null;
            this.tableAdapterManager.EventTableAdapter = null;
            this.tableAdapterManager.InventoryTableAdapter = this.inventoryTableAdapter;
            this.tableAdapterManager.UpdateOrder = Performaxx_User_Interface.AccountDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UserAccountTableAdapter = null;
            // 
            // inventoryDataGridView
            // 
            this.inventoryDataGridView.AutoGenerateColumns = false;
            this.inventoryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.inventoryDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.inventoryDataGridView.DataSource = this.inventoryBindingSource;
            this.inventoryDataGridView.Location = new System.Drawing.Point(179, 274);
            this.inventoryDataGridView.Name = "inventoryDataGridView";
            this.inventoryDataGridView.Size = new System.Drawing.Size(446, 333);
            this.inventoryDataGridView.TabIndex = 64;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "PartId";
            this.dataGridViewTextBoxColumn1.HeaderText = "PartId";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "PartName";
            this.dataGridViewTextBoxColumn2.HeaderText = "PartName";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Price";
            this.dataGridViewTextBoxColumn3.HeaderText = "Price";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Location";
            this.dataGridViewTextBoxColumn4.HeaderText = "Location";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Quantity";
            this.dataGridViewTextBoxColumn5.HeaderText = "Quantity";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Supplier";
            this.dataGridViewTextBoxColumn6.HeaderText = "Supplier";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // inventoryPrintDialog
            // 
            this.inventoryPrintDialog.UseEXDialog = true;
            // 
            // InventoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Performaxx_User_Interface.Properties.Resources.PerformaxxFrame;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1082, 754);
            this.Controls.Add(this.inventoryListView);
            this.Controls.Add(this.inventoryDataGridView);
            this.Controls.Add(this.quantityNumericUpDown);
            this.Controls.Add(this.refreshIconPictureBox);
            this.Controls.Add(this.updatingIconPictureBox);
            this.Controls.Add(this.removingIconPictureBox);
            this.Controls.Add(this.addingIconPictureBox);
            this.Controls.Add(this.printButton);
            this.Controls.Add(this.supplierLabel);
            this.Controls.Add(this.supplierTextBox);
            this.Controls.Add(this.quantityLabel);
            this.Controls.Add(this.locationLabel);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.locationTextBox);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(this.searchInventoryButton);
            this.Controls.Add(this.searchInventoryTextBox);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.inventoryTableLabel);
            this.Controls.Add(this.returnToMainMenuButton);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.mainMenuPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "InventoryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Performaxx: Manage Inventory";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.InventoryForm_FormClosed);
            this.Load += new System.EventHandler(this.InventoryForm_Load);
            this.mainMenuPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.addingIconPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.removingIconPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.updatingIconPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.refreshIconPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantityNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView inventoryListView;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.Panel mainMenuPanel;
        private System.Windows.Forms.Button manageCalendarEventsButton;
        private System.Windows.Forms.Button userSettingsButton;
        private System.Windows.Forms.Button manageClientListButton;
        private System.Windows.Forms.Button returnToMainMenuButton;
        private System.Windows.Forms.Label inventoryTableLabel;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.TextBox searchInventoryTextBox;
        private System.Windows.Forms.Button searchInventoryButton;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.TextBox locationTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Label locationLabel;
        private System.Windows.Forms.Label quantityLabel;
        private System.Windows.Forms.TextBox supplierTextBox;
        private System.Windows.Forms.Label supplierLabel;
        private System.Windows.Forms.Button printButton;
        private System.Windows.Forms.PictureBox addingIconPictureBox;
        private System.Windows.Forms.PictureBox removingIconPictureBox;
        private System.Windows.Forms.PictureBox updatingIconPictureBox;
        private System.Windows.Forms.PictureBox refreshIconPictureBox;
        private System.Windows.Forms.NumericUpDown quantityNumericUpDown;
        private System.Windows.Forms.ColumnHeader partIdHeader;
        private System.Windows.Forms.ColumnHeader partNameHeader;
        private System.Windows.Forms.ColumnHeader partPriceHeader;
        private System.Windows.Forms.ColumnHeader partLocationHeader;
        private System.Windows.Forms.ColumnHeader partQuantityHeader;
        private System.Windows.Forms.ColumnHeader partSupplierHeader;
        private AccountDataSet accountDataSet;
        private System.Windows.Forms.BindingSource inventoryBindingSource;
        private AccountDataSetTableAdapters.InventoryTableAdapter inventoryTableAdapter;
        private AccountDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView inventoryDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.PrintDialog inventoryPrintDialog;
    }
}