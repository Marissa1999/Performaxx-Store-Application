namespace Performaxx_User_Interface
{
    partial class ClientListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientListForm));
            this.clientListView = new System.Windows.Forms.ListView();
            this.ClientIdHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NameHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AddressHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CityHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PostalCodeHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.EmailHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PhoneNumberHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CommentsHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.emailLabel = new System.Windows.Forms.Label();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.postalCodeLabel = new System.Windows.Forms.Label();
            this.cityLabel = new System.Windows.Forms.Label();
            this.addressLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.postalCodeTextBox = new System.Windows.Forms.TextBox();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.searchClientButton = new System.Windows.Forms.Button();
            this.searchClientTextBox = new System.Windows.Forms.TextBox();
            this.clientListTableLabel = new System.Windows.Forms.Label();
            this.returnToMainMenuButton = new System.Windows.Forms.Button();
            this.logoutButton = new System.Windows.Forms.Button();
            this.mainMenuPanel = new System.Windows.Forms.Panel();
            this.manageCalendarEventsButton = new System.Windows.Forms.Button();
            this.userSettingsButton = new System.Windows.Forms.Button();
            this.manageInventoryButton = new System.Windows.Forms.Button();
            this.printButton = new System.Windows.Forms.Button();
            this.refreshIconPictureBox = new System.Windows.Forms.PictureBox();
            this.updatingIconPictureBox = new System.Windows.Forms.PictureBox();
            this.removingIconPictureBox = new System.Windows.Forms.PictureBox();
            this.addingIconPictureBox = new System.Windows.Forms.PictureBox();
            this.removeButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.refreshButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.phoneNumberLabel = new System.Windows.Forms.Label();
            this.phoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.commentsLabel = new System.Windows.Forms.Label();
            this.commentsTextBox = new System.Windows.Forms.TextBox();
            this.accountDataSet = new Performaxx_User_Interface.AccountDataSet();
            this.clientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientsTableAdapter = new Performaxx_User_Interface.AccountDataSetTableAdapters.ClientsTableAdapter();
            this.tableAdapterManager = new Performaxx_User_Interface.AccountDataSetTableAdapters.TableAdapterManager();
            this.clientsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientListPrintDialog = new System.Windows.Forms.PrintDialog();
            this.mainMenuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.refreshIconPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.updatingIconPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.removingIconPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addingIconPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // clientListView
            // 
            this.clientListView.BackColor = System.Drawing.Color.Silver;
            this.clientListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ClientIdHeader,
            this.NameHeader,
            this.AddressHeader,
            this.CityHeader,
            this.PostalCodeHeader,
            this.EmailHeader,
            this.PhoneNumberHeader,
            this.CommentsHeader});
            this.clientListView.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientListView.FullRowSelect = true;
            this.clientListView.GridLines = true;
            this.clientListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.clientListView.HideSelection = false;
            this.clientListView.Location = new System.Drawing.Point(177, 280);
            this.clientListView.Name = "clientListView";
            this.clientListView.Size = new System.Drawing.Size(449, 330);
            this.clientListView.TabIndex = 58;
            this.clientListView.UseCompatibleStateImageBehavior = false;
            this.clientListView.View = System.Windows.Forms.View.Details;
            this.clientListView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.clientListView_MouseClick);
            // 
            // ClientIdHeader
            // 
            this.ClientIdHeader.Text = "Client ID";
            this.ClientIdHeader.Width = 0;
            // 
            // NameHeader
            // 
            this.NameHeader.Text = "Name";
            this.NameHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NameHeader.Width = 86;
            // 
            // AddressHeader
            // 
            this.AddressHeader.Text = "Address";
            this.AddressHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.AddressHeader.Width = 97;
            // 
            // CityHeader
            // 
            this.CityHeader.Text = "City";
            this.CityHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CityHeader.Width = 72;
            // 
            // PostalCodeHeader
            // 
            this.PostalCodeHeader.Text = "Postal Code";
            this.PostalCodeHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PostalCodeHeader.Width = 78;
            // 
            // EmailHeader
            // 
            this.EmailHeader.Text = "Email";
            this.EmailHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.EmailHeader.Width = 87;
            // 
            // PhoneNumberHeader
            // 
            this.PhoneNumberHeader.Text = "Phone Number";
            this.PhoneNumberHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PhoneNumberHeader.Width = 103;
            // 
            // CommentsHeader
            // 
            this.CommentsHeader.Text = "Comments";
            this.CommentsHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CommentsHeader.Width = 99;
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.BackColor = System.Drawing.Color.Transparent;
            this.emailLabel.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLabel.Location = new System.Drawing.Point(689, 368);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(47, 16);
            this.emailLabel.TabIndex = 79;
            this.emailLabel.Text = "Email:";
            // 
            // emailTextBox
            // 
            this.emailTextBox.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailTextBox.Location = new System.Drawing.Point(743, 365);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(165, 22);
            this.emailTextBox.TabIndex = 78;
            // 
            // postalCodeLabel
            // 
            this.postalCodeLabel.AutoSize = true;
            this.postalCodeLabel.BackColor = System.Drawing.Color.Transparent;
            this.postalCodeLabel.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.postalCodeLabel.Location = new System.Drawing.Point(653, 336);
            this.postalCodeLabel.Name = "postalCodeLabel";
            this.postalCodeLabel.Size = new System.Drawing.Size(84, 16);
            this.postalCodeLabel.TabIndex = 77;
            this.postalCodeLabel.Text = "Postal Code:";
            // 
            // cityLabel
            // 
            this.cityLabel.AutoSize = true;
            this.cityLabel.BackColor = System.Drawing.Color.Transparent;
            this.cityLabel.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cityLabel.Location = new System.Drawing.Point(699, 303);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(37, 16);
            this.cityLabel.TabIndex = 76;
            this.cityLabel.Text = "City:";
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.BackColor = System.Drawing.Color.Transparent;
            this.addressLabel.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressLabel.Location = new System.Drawing.Point(673, 271);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(63, 16);
            this.addressLabel.TabIndex = 75;
            this.addressLabel.Text = "Address:";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.BackColor = System.Drawing.Color.Transparent;
            this.nameLabel.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(688, 239);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(48, 16);
            this.nameLabel.TabIndex = 74;
            this.nameLabel.Text = "Name:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTextBox.Location = new System.Drawing.Point(743, 236);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(165, 22);
            this.nameTextBox.TabIndex = 73;
            // 
            // postalCodeTextBox
            // 
            this.postalCodeTextBox.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.postalCodeTextBox.Location = new System.Drawing.Point(743, 333);
            this.postalCodeTextBox.Name = "postalCodeTextBox";
            this.postalCodeTextBox.Size = new System.Drawing.Size(165, 22);
            this.postalCodeTextBox.TabIndex = 72;
            // 
            // cityTextBox
            // 
            this.cityTextBox.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cityTextBox.Location = new System.Drawing.Point(743, 300);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(165, 22);
            this.cityTextBox.TabIndex = 71;
            // 
            // addressTextBox
            // 
            this.addressTextBox.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressTextBox.Location = new System.Drawing.Point(743, 268);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(165, 22);
            this.addressTextBox.TabIndex = 70;
            // 
            // searchClientButton
            // 
            this.searchClientButton.BackColor = System.Drawing.Color.DarkOrange;
            this.searchClientButton.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchClientButton.Location = new System.Drawing.Point(540, 243);
            this.searchClientButton.Name = "searchClientButton";
            this.searchClientButton.Size = new System.Drawing.Size(86, 31);
            this.searchClientButton.TabIndex = 69;
            this.searchClientButton.Text = "Search";
            this.searchClientButton.UseVisualStyleBackColor = false;
            this.searchClientButton.Click += new System.EventHandler(this.searchClientButton_Click);
            // 
            // searchClientTextBox
            // 
            this.searchClientTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchClientTextBox.Location = new System.Drawing.Point(309, 246);
            this.searchClientTextBox.Name = "searchClientTextBox";
            this.searchClientTextBox.Size = new System.Drawing.Size(225, 26);
            this.searchClientTextBox.TabIndex = 68;
            // 
            // clientListTableLabel
            // 
            this.clientListTableLabel.AutoSize = true;
            this.clientListTableLabel.BackColor = System.Drawing.Color.Transparent;
            this.clientListTableLabel.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientListTableLabel.Location = new System.Drawing.Point(189, 247);
            this.clientListTableLabel.Name = "clientListTableLabel";
            this.clientListTableLabel.Size = new System.Drawing.Size(113, 20);
            this.clientListTableLabel.TabIndex = 62;
            this.clientListTableLabel.Text = "Client List Table:";
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
            this.returnToMainMenuButton.Location = new System.Drawing.Point(167, 149);
            this.returnToMainMenuButton.Name = "returnToMainMenuButton";
            this.returnToMainMenuButton.Size = new System.Drawing.Size(135, 82);
            this.returnToMainMenuButton.TabIndex = 61;
            this.returnToMainMenuButton.Text = "Return to Main Menu";
            this.returnToMainMenuButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.returnToMainMenuButton.UseVisualStyleBackColor = false;
            this.returnToMainMenuButton.Click += new System.EventHandler(this.returnToMainMenuButton_Click);
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
            this.logoutButton.Location = new System.Drawing.Point(823, 149);
            this.logoutButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(87, 82);
            this.logoutButton.TabIndex = 60;
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
            this.mainMenuPanel.Controls.Add(this.manageInventoryButton);
            this.mainMenuPanel.Location = new System.Drawing.Point(308, 158);
            this.mainMenuPanel.Name = "mainMenuPanel";
            this.mainMenuPanel.Size = new System.Drawing.Size(508, 63);
            this.mainMenuPanel.TabIndex = 59;
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
            // manageInventoryButton
            // 
            this.manageInventoryButton.BackColor = System.Drawing.Color.LightBlue;
            this.manageInventoryButton.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manageInventoryButton.Location = new System.Drawing.Point(12, 11);
            this.manageInventoryButton.Name = "manageInventoryButton";
            this.manageInventoryButton.Size = new System.Drawing.Size(147, 35);
            this.manageInventoryButton.TabIndex = 1;
            this.manageInventoryButton.Text = "Manage Inventory";
            this.manageInventoryButton.UseVisualStyleBackColor = false;
            this.manageInventoryButton.Click += new System.EventHandler(this.manageInventoryButton_Click);
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
            this.printButton.Location = new System.Drawing.Point(831, 486);
            this.printButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.printButton.Name = "printButton";
            this.printButton.Size = new System.Drawing.Size(79, 102);
            this.printButton.TabIndex = 87;
            this.printButton.Text = "Print Database";
            this.printButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.printButton.UseVisualStyleBackColor = false;
            this.printButton.Click += new System.EventHandler(this.printButton_Click);
            // 
            // refreshIconPictureBox
            // 
            this.refreshIconPictureBox.BackColor = System.Drawing.Color.MediumTurquoise;
            this.refreshIconPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.refreshIconPictureBox.Image = global::Performaxx_User_Interface.Properties.Resources.UpdatingButtonImage;
            this.refreshIconPictureBox.Location = new System.Drawing.Point(640, 578);
            this.refreshIconPictureBox.Name = "refreshIconPictureBox";
            this.refreshIconPictureBox.Size = new System.Drawing.Size(32, 32);
            this.refreshIconPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.refreshIconPictureBox.TabIndex = 95;
            this.refreshIconPictureBox.TabStop = false;
            // 
            // updatingIconPictureBox
            // 
            this.updatingIconPictureBox.BackColor = System.Drawing.Color.Gold;
            this.updatingIconPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.updatingIconPictureBox.Image = global::Performaxx_User_Interface.Properties.Resources.PopulateButtonImage;
            this.updatingIconPictureBox.Location = new System.Drawing.Point(640, 540);
            this.updatingIconPictureBox.Name = "updatingIconPictureBox";
            this.updatingIconPictureBox.Size = new System.Drawing.Size(32, 32);
            this.updatingIconPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.updatingIconPictureBox.TabIndex = 94;
            this.updatingIconPictureBox.TabStop = false;
            // 
            // removingIconPictureBox
            // 
            this.removingIconPictureBox.BackColor = System.Drawing.Color.OrangeRed;
            this.removingIconPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.removingIconPictureBox.Image = global::Performaxx_User_Interface.Properties.Resources.RemovingButtonImage;
            this.removingIconPictureBox.Location = new System.Drawing.Point(640, 502);
            this.removingIconPictureBox.Name = "removingIconPictureBox";
            this.removingIconPictureBox.Size = new System.Drawing.Size(32, 32);
            this.removingIconPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.removingIconPictureBox.TabIndex = 93;
            this.removingIconPictureBox.TabStop = false;
            // 
            // addingIconPictureBox
            // 
            this.addingIconPictureBox.BackColor = System.Drawing.Color.LimeGreen;
            this.addingIconPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.addingIconPictureBox.Image = global::Performaxx_User_Interface.Properties.Resources.AddingButtonImage;
            this.addingIconPictureBox.Location = new System.Drawing.Point(640, 464);
            this.addingIconPictureBox.Name = "addingIconPictureBox";
            this.addingIconPictureBox.Size = new System.Drawing.Size(32, 32);
            this.addingIconPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.addingIconPictureBox.TabIndex = 92;
            this.addingIconPictureBox.TabStop = false;
            // 
            // removeButton
            // 
            this.removeButton.BackColor = System.Drawing.Color.DarkOrange;
            this.removeButton.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeButton.Location = new System.Drawing.Point(678, 502);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(146, 32);
            this.removeButton.TabIndex = 91;
            this.removeButton.Text = "Remove Record";
            this.removeButton.UseVisualStyleBackColor = false;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.BackColor = System.Drawing.Color.DarkOrange;
            this.updateButton.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateButton.Location = new System.Drawing.Point(678, 540);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(146, 32);
            this.updateButton.TabIndex = 90;
            this.updateButton.Text = "Update Record";
            this.updateButton.UseVisualStyleBackColor = false;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // refreshButton
            // 
            this.refreshButton.BackColor = System.Drawing.Color.DarkOrange;
            this.refreshButton.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refreshButton.Location = new System.Drawing.Point(678, 578);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(144, 32);
            this.refreshButton.TabIndex = 89;
            this.refreshButton.Text = "Refresh Table";
            this.refreshButton.UseVisualStyleBackColor = false;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.DarkOrange;
            this.addButton.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.Location = new System.Drawing.Point(680, 464);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(144, 32);
            this.addButton.TabIndex = 88;
            this.addButton.Text = "Add Record";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // phoneNumberLabel
            // 
            this.phoneNumberLabel.AutoSize = true;
            this.phoneNumberLabel.BackColor = System.Drawing.Color.Transparent;
            this.phoneNumberLabel.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneNumberLabel.Location = new System.Drawing.Point(632, 400);
            this.phoneNumberLabel.Name = "phoneNumberLabel";
            this.phoneNumberLabel.Size = new System.Drawing.Size(105, 16);
            this.phoneNumberLabel.TabIndex = 97;
            this.phoneNumberLabel.Text = "Phone Number:";
            // 
            // phoneNumberTextBox
            // 
            this.phoneNumberTextBox.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneNumberTextBox.Location = new System.Drawing.Point(743, 397);
            this.phoneNumberTextBox.Name = "phoneNumberTextBox";
            this.phoneNumberTextBox.Size = new System.Drawing.Size(165, 22);
            this.phoneNumberTextBox.TabIndex = 96;
            // 
            // commentsLabel
            // 
            this.commentsLabel.AutoSize = true;
            this.commentsLabel.BackColor = System.Drawing.Color.Transparent;
            this.commentsLabel.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.commentsLabel.Location = new System.Drawing.Point(659, 432);
            this.commentsLabel.Name = "commentsLabel";
            this.commentsLabel.Size = new System.Drawing.Size(78, 16);
            this.commentsLabel.TabIndex = 99;
            this.commentsLabel.Text = "Comments:";
            // 
            // commentsTextBox
            // 
            this.commentsTextBox.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.commentsTextBox.Location = new System.Drawing.Point(743, 429);
            this.commentsTextBox.Name = "commentsTextBox";
            this.commentsTextBox.Size = new System.Drawing.Size(165, 22);
            this.commentsTextBox.TabIndex = 98;
            // 
            // accountDataSet
            // 
            this.accountDataSet.DataSetName = "AccountDataSet";
            this.accountDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientsBindingSource
            // 
            this.clientsBindingSource.DataMember = "Clients";
            this.clientsBindingSource.DataSource = this.accountDataSet;
            // 
            // clientsTableAdapter
            // 
            this.clientsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClientsTableAdapter = this.clientsTableAdapter;
            this.tableAdapterManager.EventTableAdapter = null;
            this.tableAdapterManager.InventoryTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Performaxx_User_Interface.AccountDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UserAccountTableAdapter = null;
            // 
            // clientsDataGridView
            // 
            this.clientsDataGridView.AutoGenerateColumns = false;
            this.clientsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clientsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.clientsDataGridView.DataSource = this.clientsBindingSource;
            this.clientsDataGridView.Location = new System.Drawing.Point(177, 280);
            this.clientsDataGridView.Name = "clientsDataGridView";
            this.clientsDataGridView.Size = new System.Drawing.Size(449, 330);
            this.clientsDataGridView.TabIndex = 100;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ClientId";
            this.dataGridViewTextBoxColumn1.HeaderText = "ClientId";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Address";
            this.dataGridViewTextBoxColumn3.HeaderText = "Address";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "City";
            this.dataGridViewTextBoxColumn4.HeaderText = "City";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "PostalCode";
            this.dataGridViewTextBoxColumn5.HeaderText = "PostalCode";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Email";
            this.dataGridViewTextBoxColumn6.HeaderText = "Email";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "PhoneNumber";
            this.dataGridViewTextBoxColumn7.HeaderText = "PhoneNumber";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Comments";
            this.dataGridViewTextBoxColumn8.HeaderText = "Comments";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // clientListPrintDialog
            // 
            this.clientListPrintDialog.UseEXDialog = true;
            // 
            // ClientListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Performaxx_User_Interface.Properties.Resources.PerformaxxFrame;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1082, 754);
            this.Controls.Add(this.clientListView);
            this.Controls.Add(this.clientsDataGridView);
            this.Controls.Add(this.commentsLabel);
            this.Controls.Add(this.commentsTextBox);
            this.Controls.Add(this.phoneNumberLabel);
            this.Controls.Add(this.phoneNumberTextBox);
            this.Controls.Add(this.refreshIconPictureBox);
            this.Controls.Add(this.updatingIconPictureBox);
            this.Controls.Add(this.removingIconPictureBox);
            this.Controls.Add(this.addingIconPictureBox);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.printButton);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.postalCodeLabel);
            this.Controls.Add(this.cityLabel);
            this.Controls.Add(this.addressLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.postalCodeTextBox);
            this.Controls.Add(this.cityTextBox);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(this.searchClientButton);
            this.Controls.Add(this.searchClientTextBox);
            this.Controls.Add(this.clientListTableLabel);
            this.Controls.Add(this.returnToMainMenuButton);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.mainMenuPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ClientListForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Performaxx: Manage Client List";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ClientListForm_FormClosed);
            this.Load += new System.EventHandler(this.ClientListForm_Load);
            this.mainMenuPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.refreshIconPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.updatingIconPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.removingIconPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addingIconPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView clientListView;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.Label postalCodeLabel;
        private System.Windows.Forms.Label cityLabel;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox postalCodeTextBox;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.Button searchClientButton;
        private System.Windows.Forms.TextBox searchClientTextBox;
        private System.Windows.Forms.Label clientListTableLabel;
        private System.Windows.Forms.Button returnToMainMenuButton;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.Panel mainMenuPanel;
        private System.Windows.Forms.Button manageCalendarEventsButton;
        private System.Windows.Forms.Button userSettingsButton;
        private System.Windows.Forms.Button manageInventoryButton;
        private System.Windows.Forms.Button printButton;
        private System.Windows.Forms.PictureBox refreshIconPictureBox;
        private System.Windows.Forms.PictureBox updatingIconPictureBox;
        private System.Windows.Forms.PictureBox removingIconPictureBox;
        private System.Windows.Forms.PictureBox addingIconPictureBox;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label phoneNumberLabel;
        private System.Windows.Forms.TextBox phoneNumberTextBox;
        private System.Windows.Forms.Label commentsLabel;
        private System.Windows.Forms.TextBox commentsTextBox;
        private System.Windows.Forms.ColumnHeader ClientIdHeader;
        private System.Windows.Forms.ColumnHeader NameHeader;
        private System.Windows.Forms.ColumnHeader AddressHeader;
        private System.Windows.Forms.ColumnHeader CityHeader;
        private System.Windows.Forms.ColumnHeader PostalCodeHeader;
        private System.Windows.Forms.ColumnHeader EmailHeader;
        private System.Windows.Forms.ColumnHeader PhoneNumberHeader;
        private System.Windows.Forms.ColumnHeader CommentsHeader;
        private AccountDataSet accountDataSet;
        private System.Windows.Forms.BindingSource clientsBindingSource;
        private AccountDataSetTableAdapters.ClientsTableAdapter clientsTableAdapter;
        private AccountDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView clientsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.PrintDialog clientListPrintDialog;
    }
}