namespace Performaxx_User_Interface
{
    partial class CalendarForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalendarForm));
            this.eventsOnDateLabel = new System.Windows.Forms.Label();
            this.eventsListView = new System.Windows.Forms.ListView();
            this.eventIdHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.taskNameHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.descriptionHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.addEventButton = new System.Windows.Forms.Button();
            this.updateEventButton = new System.Windows.Forms.Button();
            this.removeEventButton = new System.Windows.Forms.Button();
            this.returnToMainMenuButton = new System.Windows.Forms.Button();
            this.logoutButton = new System.Windows.Forms.Button();
            this.mainMenuPanel = new System.Windows.Forms.Panel();
            this.manageClientListButton = new System.Windows.Forms.Button();
            this.userSettingsButton = new System.Windows.Forms.Button();
            this.manageInventoryButton = new System.Windows.Forms.Button();
            this.eventMonthCalendar = new System.Windows.Forms.MonthCalendar();
            this.calendarEventLabel = new System.Windows.Forms.Label();
            this.eventSelectionDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.taskNameLabel = new System.Windows.Forms.Label();
            this.taskNameTextBox = new System.Windows.Forms.TextBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.eventDateLabel = new System.Windows.Forms.Label();
            this.eventDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.mainMenuPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // eventsOnDateLabel
            // 
            this.eventsOnDateLabel.AutoSize = true;
            this.eventsOnDateLabel.BackColor = System.Drawing.Color.Transparent;
            this.eventsOnDateLabel.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eventsOnDateLabel.Location = new System.Drawing.Point(177, 442);
            this.eventsOnDateLabel.Name = "eventsOnDateLabel";
            this.eventsOnDateLabel.Size = new System.Drawing.Size(108, 20);
            this.eventsOnDateLabel.TabIndex = 1;
            this.eventsOnDateLabel.Text = "Events on Date:\r\n";
            // 
            // eventsListView
            // 
            this.eventsListView.BackColor = System.Drawing.Color.Silver;
            this.eventsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.eventIdHeader,
            this.taskNameHeader,
            this.descriptionHeader});
            this.eventsListView.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eventsListView.FullRowSelect = true;
            this.eventsListView.GridLines = true;
            this.eventsListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.eventsListView.HideSelection = false;
            this.eventsListView.Location = new System.Drawing.Point(181, 471);
            this.eventsListView.Name = "eventsListView";
            this.eventsListView.Size = new System.Drawing.Size(400, 133);
            this.eventsListView.TabIndex = 2;
            this.eventsListView.UseCompatibleStateImageBehavior = false;
            this.eventsListView.View = System.Windows.Forms.View.Details;
            this.eventsListView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.eventsListView_MouseClick);
            // 
            // eventIdHeader
            // 
            this.eventIdHeader.Text = "Event ID";
            this.eventIdHeader.Width = 0;
            // 
            // taskNameHeader
            // 
            this.taskNameHeader.Text = "Task Name";
            this.taskNameHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.taskNameHeader.Width = 200;
            // 
            // descriptionHeader
            // 
            this.descriptionHeader.Text = "Description";
            this.descriptionHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.descriptionHeader.Width = 196;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(311, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Notifications:";
            // 
            // addEventButton
            // 
            this.addEventButton.BackColor = System.Drawing.Color.DarkOrange;
            this.addEventButton.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addEventButton.Location = new System.Drawing.Point(602, 532);
            this.addEventButton.Name = "addEventButton";
            this.addEventButton.Size = new System.Drawing.Size(308, 34);
            this.addEventButton.TabIndex = 5;
            this.addEventButton.Text = "Add Event";
            this.addEventButton.UseVisualStyleBackColor = false;
            this.addEventButton.Click += new System.EventHandler(this.addEventButton_Click);
            // 
            // updateEventButton
            // 
            this.updateEventButton.BackColor = System.Drawing.Color.DarkOrange;
            this.updateEventButton.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateEventButton.Location = new System.Drawing.Point(602, 570);
            this.updateEventButton.Name = "updateEventButton";
            this.updateEventButton.Size = new System.Drawing.Size(152, 34);
            this.updateEventButton.TabIndex = 6;
            this.updateEventButton.Text = "Update Event";
            this.updateEventButton.UseVisualStyleBackColor = false;
            this.updateEventButton.Click += new System.EventHandler(this.editEventButton_Click);
            // 
            // removeEventButton
            // 
            this.removeEventButton.BackColor = System.Drawing.Color.DarkOrange;
            this.removeEventButton.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeEventButton.Location = new System.Drawing.Point(758, 570);
            this.removeEventButton.Name = "removeEventButton";
            this.removeEventButton.Size = new System.Drawing.Size(152, 34);
            this.removeEventButton.TabIndex = 7;
            this.removeEventButton.Text = "Remove Event";
            this.removeEventButton.UseVisualStyleBackColor = false;
            this.removeEventButton.Click += new System.EventHandler(this.removeEventButton_Click);
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
            this.returnToMainMenuButton.Location = new System.Drawing.Point(168, 146);
            this.returnToMainMenuButton.Name = "returnToMainMenuButton";
            this.returnToMainMenuButton.Size = new System.Drawing.Size(135, 82);
            this.returnToMainMenuButton.TabIndex = 64;
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
            this.logoutButton.Location = new System.Drawing.Point(824, 146);
            this.logoutButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(87, 82);
            this.logoutButton.TabIndex = 63;
            this.logoutButton.Text = "Logout";
            this.logoutButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.logoutButton.UseVisualStyleBackColor = false;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // mainMenuPanel
            // 
            this.mainMenuPanel.BackColor = System.Drawing.SystemColors.Info;
            this.mainMenuPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.mainMenuPanel.Controls.Add(this.manageClientListButton);
            this.mainMenuPanel.Controls.Add(this.userSettingsButton);
            this.mainMenuPanel.Controls.Add(this.manageInventoryButton);
            this.mainMenuPanel.Location = new System.Drawing.Point(309, 155);
            this.mainMenuPanel.Name = "mainMenuPanel";
            this.mainMenuPanel.Size = new System.Drawing.Size(508, 63);
            this.mainMenuPanel.TabIndex = 62;
            // 
            // manageClientListButton
            // 
            this.manageClientListButton.BackColor = System.Drawing.Color.LightBlue;
            this.manageClientListButton.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manageClientListButton.Location = new System.Drawing.Point(177, 11);
            this.manageClientListButton.Name = "manageClientListButton";
            this.manageClientListButton.Size = new System.Drawing.Size(165, 35);
            this.manageClientListButton.TabIndex = 3;
            this.manageClientListButton.Text = "Manage Client List";
            this.manageClientListButton.UseVisualStyleBackColor = false;
            this.manageClientListButton.Click += new System.EventHandler(this.manageClientListButton_Click);
            // 
            // userSettingsButton
            // 
            this.userSettingsButton.BackColor = System.Drawing.Color.LightBlue;
            this.userSettingsButton.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userSettingsButton.Location = new System.Drawing.Point(362, 11);
            this.userSettingsButton.Name = "userSettingsButton";
            this.userSettingsButton.Size = new System.Drawing.Size(128, 35);
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
            // eventMonthCalendar
            // 
            this.eventMonthCalendar.BackColor = System.Drawing.SystemColors.Info;
            this.eventMonthCalendar.CalendarDimensions = new System.Drawing.Size(3, 1);
            this.eventMonthCalendar.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eventMonthCalendar.Location = new System.Drawing.Point(194, 262);
            this.eventMonthCalendar.MaxSelectionCount = 1;
            this.eventMonthCalendar.Name = "eventMonthCalendar";
            this.eventMonthCalendar.TabIndex = 65;
            // 
            // calendarEventLabel
            // 
            this.calendarEventLabel.AutoSize = true;
            this.calendarEventLabel.BackColor = System.Drawing.Color.Transparent;
            this.calendarEventLabel.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calendarEventLabel.Location = new System.Drawing.Point(484, 233);
            this.calendarEventLabel.Name = "calendarEventLabel";
            this.calendarEventLabel.Size = new System.Drawing.Size(124, 20);
            this.calendarEventLabel.TabIndex = 66;
            this.calendarEventLabel.Text = "3-Month Calendar";
            // 
            // eventSelectionDateTimePicker
            // 
            this.eventSelectionDateTimePicker.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eventSelectionDateTimePicker.Location = new System.Drawing.Point(291, 442);
            this.eventSelectionDateTimePicker.Name = "eventSelectionDateTimePicker";
            this.eventSelectionDateTimePicker.Size = new System.Drawing.Size(290, 22);
            this.eventSelectionDateTimePicker.TabIndex = 67;
            this.eventSelectionDateTimePicker.ValueChanged += new System.EventHandler(this.eventSelectionDateTimePicker_ValueChanged);
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.BackColor = System.Drawing.Color.Transparent;
            this.descriptionLabel.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionLabel.Location = new System.Drawing.Point(597, 471);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(93, 18);
            this.descriptionLabel.TabIndex = 71;
            this.descriptionLabel.Text = "Description:";
            // 
            // taskNameLabel
            // 
            this.taskNameLabel.AutoSize = true;
            this.taskNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.taskNameLabel.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taskNameLabel.Location = new System.Drawing.Point(597, 439);
            this.taskNameLabel.Name = "taskNameLabel";
            this.taskNameLabel.Size = new System.Drawing.Size(94, 18);
            this.taskNameLabel.TabIndex = 70;
            this.taskNameLabel.Text = "Task Name:";
            // 
            // taskNameTextBox
            // 
            this.taskNameTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taskNameTextBox.Location = new System.Drawing.Point(697, 436);
            this.taskNameTextBox.Name = "taskNameTextBox";
            this.taskNameTextBox.Size = new System.Drawing.Size(213, 26);
            this.taskNameTextBox.TabIndex = 69;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionTextBox.Location = new System.Drawing.Point(697, 468);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(213, 26);
            this.descriptionTextBox.TabIndex = 68;
            // 
            // eventDateLabel
            // 
            this.eventDateLabel.AutoSize = true;
            this.eventDateLabel.BackColor = System.Drawing.Color.Transparent;
            this.eventDateLabel.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eventDateLabel.Location = new System.Drawing.Point(599, 503);
            this.eventDateLabel.Name = "eventDateLabel";
            this.eventDateLabel.Size = new System.Drawing.Size(92, 18);
            this.eventDateLabel.TabIndex = 73;
            this.eventDateLabel.Text = "Event Date:";
            // 
            // eventDateTimePicker
            // 
            this.eventDateTimePicker.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eventDateTimePicker.Location = new System.Drawing.Point(697, 503);
            this.eventDateTimePicker.Name = "eventDateTimePicker";
            this.eventDateTimePicker.Size = new System.Drawing.Size(213, 22);
            this.eventDateTimePicker.TabIndex = 74;
            // 
            // CalendarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Performaxx_User_Interface.Properties.Resources.PerformaxxFrame;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1082, 754);
            this.Controls.Add(this.eventDateTimePicker);
            this.Controls.Add(this.eventDateLabel);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.taskNameLabel);
            this.Controls.Add(this.taskNameTextBox);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(this.eventSelectionDateTimePicker);
            this.Controls.Add(this.calendarEventLabel);
            this.Controls.Add(this.eventMonthCalendar);
            this.Controls.Add(this.returnToMainMenuButton);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.mainMenuPanel);
            this.Controls.Add(this.removeEventButton);
            this.Controls.Add(this.updateEventButton);
            this.Controls.Add(this.addEventButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.eventsListView);
            this.Controls.Add(this.eventsOnDateLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "CalendarForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Performaxx: Manage Calendar Events";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CalendarForm_FormClosed);
            this.mainMenuPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label eventsOnDateLabel;
        private System.Windows.Forms.ListView eventsListView;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button addEventButton;
        private System.Windows.Forms.Button updateEventButton;
        private System.Windows.Forms.Button removeEventButton;
        private System.Windows.Forms.Button returnToMainMenuButton;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.Panel mainMenuPanel;
        private System.Windows.Forms.Button manageClientListButton;
        private System.Windows.Forms.Button userSettingsButton;
        private System.Windows.Forms.Button manageInventoryButton;
        private System.Windows.Forms.MonthCalendar eventMonthCalendar;
        private System.Windows.Forms.Label calendarEventLabel;
        private System.Windows.Forms.DateTimePicker eventSelectionDateTimePicker;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.Label taskNameLabel;
        private System.Windows.Forms.TextBox taskNameTextBox;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.Label eventDateLabel;
        private System.Windows.Forms.DateTimePicker eventDateTimePicker;
        private System.Windows.Forms.ColumnHeader taskNameHeader;
        private System.Windows.Forms.ColumnHeader descriptionHeader;
        private System.Windows.Forms.ColumnHeader eventIdHeader;
    }
}