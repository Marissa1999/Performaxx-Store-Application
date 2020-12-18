namespace Performaxx_User_Interface
{
    partial class MainMenuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenuForm));
            this.performaxxTitlePictureBox = new System.Windows.Forms.PictureBox();
            this.mainMenuPanel = new System.Windows.Forms.Panel();
            this.manageCalendarEventsButton = new System.Windows.Forms.Button();
            this.userSettingsButton = new System.Windows.Forms.Button();
            this.manageClientListButton = new System.Windows.Forms.Button();
            this.manageInventoryButton = new System.Windows.Forms.Button();
            this.userMonthCalendar = new System.Windows.Forms.MonthCalendar();
            this.userCalendarLabel = new System.Windows.Forms.Label();
            this.mainMenuDescriptionLabel = new System.Windows.Forms.Label();
            this.logoutButton = new System.Windows.Forms.Button();
            this.performaxxSkatePictureBox = new System.Windows.Forms.PictureBox();
            this.performaxxLogoPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.performaxxTitlePictureBox)).BeginInit();
            this.mainMenuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.performaxxSkatePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.performaxxLogoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // performaxxTitlePictureBox
            // 
            this.performaxxTitlePictureBox.Image = global::Performaxx_User_Interface.Properties.Resources.PerformaxxTitle;
            this.performaxxTitlePictureBox.Location = new System.Drawing.Point(237, 146);
            this.performaxxTitlePictureBox.Name = "performaxxTitlePictureBox";
            this.performaxxTitlePictureBox.Size = new System.Drawing.Size(640, 136);
            this.performaxxTitlePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.performaxxTitlePictureBox.TabIndex = 25;
            this.performaxxTitlePictureBox.TabStop = false;
            // 
            // mainMenuPanel
            // 
            this.mainMenuPanel.BackColor = System.Drawing.SystemColors.Info;
            this.mainMenuPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.mainMenuPanel.Controls.Add(this.manageCalendarEventsButton);
            this.mainMenuPanel.Controls.Add(this.userSettingsButton);
            this.mainMenuPanel.Controls.Add(this.manageClientListButton);
            this.mainMenuPanel.Controls.Add(this.manageInventoryButton);
            this.mainMenuPanel.Location = new System.Drawing.Point(171, 297);
            this.mainMenuPanel.Name = "mainMenuPanel";
            this.mainMenuPanel.Size = new System.Drawing.Size(742, 65);
            this.mainMenuPanel.TabIndex = 26;
            // 
            // manageCalendarEventsButton
            // 
            this.manageCalendarEventsButton.BackColor = System.Drawing.Color.LightBlue;
            this.manageCalendarEventsButton.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manageCalendarEventsButton.Location = new System.Drawing.Point(380, 11);
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
            this.userSettingsButton.Location = new System.Drawing.Point(575, 11);
            this.userSettingsButton.Name = "userSettingsButton";
            this.userSettingsButton.Size = new System.Drawing.Size(140, 35);
            this.userSettingsButton.TabIndex = 2;
            this.userSettingsButton.Text = "User Settings";
            this.userSettingsButton.UseVisualStyleBackColor = false;
            this.userSettingsButton.Click += new System.EventHandler(this.userSettingsButton_Click);
            // 
            // manageClientListButton
            // 
            this.manageClientListButton.BackColor = System.Drawing.Color.LightBlue;
            this.manageClientListButton.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manageClientListButton.Location = new System.Drawing.Point(206, 11);
            this.manageClientListButton.Name = "manageClientListButton";
            this.manageClientListButton.Size = new System.Drawing.Size(157, 35);
            this.manageClientListButton.TabIndex = 1;
            this.manageClientListButton.Text = "Manage Client List";
            this.manageClientListButton.UseVisualStyleBackColor = false;
            this.manageClientListButton.Click += new System.EventHandler(this.manageClientListButton_Click);
            // 
            // manageInventoryButton
            // 
            this.manageInventoryButton.BackColor = System.Drawing.Color.LightBlue;
            this.manageInventoryButton.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manageInventoryButton.Location = new System.Drawing.Point(32, 11);
            this.manageInventoryButton.Name = "manageInventoryButton";
            this.manageInventoryButton.Size = new System.Drawing.Size(152, 35);
            this.manageInventoryButton.TabIndex = 0;
            this.manageInventoryButton.Text = "Manage Inventory";
            this.manageInventoryButton.UseVisualStyleBackColor = false;
            this.manageInventoryButton.Click += new System.EventHandler(this.manageInventoryButton_Click);
            // 
            // userMonthCalendar
            // 
            this.userMonthCalendar.BackColor = System.Drawing.SystemColors.Info;
            this.userMonthCalendar.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userMonthCalendar.Location = new System.Drawing.Point(180, 437);
            this.userMonthCalendar.Name = "userMonthCalendar";
            this.userMonthCalendar.TabIndex = 27;
            // 
            // userCalendarLabel
            // 
            this.userCalendarLabel.BackColor = System.Drawing.Color.Coral;
            this.userCalendarLabel.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userCalendarLabel.Location = new System.Drawing.Point(180, 389);
            this.userCalendarLabel.Name = "userCalendarLabel";
            this.userCalendarLabel.Size = new System.Drawing.Size(227, 39);
            this.userCalendarLabel.TabIndex = 28;
            this.userCalendarLabel.Text = "Daily Calendar";
            this.userCalendarLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mainMenuDescriptionLabel
            // 
            this.mainMenuDescriptionLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.mainMenuDescriptionLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.mainMenuDescriptionLabel.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainMenuDescriptionLabel.Location = new System.Drawing.Point(667, 389);
            this.mainMenuDescriptionLabel.Name = "mainMenuDescriptionLabel";
            this.mainMenuDescriptionLabel.Size = new System.Drawing.Size(233, 210);
            this.mainMenuDescriptionLabel.TabIndex = 29;
            this.mainMenuDescriptionLabel.Text = resources.GetString("mainMenuDescriptionLabel.Text");
            this.mainMenuDescriptionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // logoutButton
            // 
            this.logoutButton.BackColor = System.Drawing.Color.Transparent;
            this.logoutButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(236)))), ((int)(((byte)(209)))));
            this.logoutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoutButton.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutButton.Image = ((System.Drawing.Image)(resources.GetObject("logoutButton.Image")));
            this.logoutButton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.logoutButton.Location = new System.Drawing.Point(841, 146);
            this.logoutButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(72, 81);
            this.logoutButton.TabIndex = 30;
            this.logoutButton.Text = "Logout";
            this.logoutButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.logoutButton.UseVisualStyleBackColor = false;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // performaxxSkatePictureBox
            // 
            this.performaxxSkatePictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.performaxxSkatePictureBox.Image = global::Performaxx_User_Interface.Properties.Resources.SkateBladesImage;
            this.performaxxSkatePictureBox.Location = new System.Drawing.Point(419, 389);
            this.performaxxSkatePictureBox.Name = "performaxxSkatePictureBox";
            this.performaxxSkatePictureBox.Size = new System.Drawing.Size(231, 210);
            this.performaxxSkatePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.performaxxSkatePictureBox.TabIndex = 32;
            this.performaxxSkatePictureBox.TabStop = false;
            // 
            // performaxxLogoPictureBox
            // 
            this.performaxxLogoPictureBox.Image = global::Performaxx_User_Interface.Properties.Resources.PerformaxxMainMenuLogo;
            this.performaxxLogoPictureBox.Location = new System.Drawing.Point(171, 146);
            this.performaxxLogoPictureBox.Name = "performaxxLogoPictureBox";
            this.performaxxLogoPictureBox.Size = new System.Drawing.Size(116, 136);
            this.performaxxLogoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.performaxxLogoPictureBox.TabIndex = 33;
            this.performaxxLogoPictureBox.TabStop = false;
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Performaxx_User_Interface.Properties.Resources.PerformaxxFrame;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1082, 754);
            this.Controls.Add(this.performaxxLogoPictureBox);
            this.Controls.Add(this.performaxxSkatePictureBox);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.mainMenuDescriptionLabel);
            this.Controls.Add(this.userCalendarLabel);
            this.Controls.Add(this.userMonthCalendar);
            this.Controls.Add(this.mainMenuPanel);
            this.Controls.Add(this.performaxxTitlePictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainMenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Performaxx: Main Menu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainMenuForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.performaxxTitlePictureBox)).EndInit();
            this.mainMenuPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.performaxxSkatePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.performaxxLogoPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox performaxxTitlePictureBox;
        private System.Windows.Forms.Panel mainMenuPanel;
        private System.Windows.Forms.Button manageCalendarEventsButton;
        private System.Windows.Forms.Button userSettingsButton;
        private System.Windows.Forms.Button manageClientListButton;
        private System.Windows.Forms.Button manageInventoryButton;
        private System.Windows.Forms.MonthCalendar userMonthCalendar;
        private System.Windows.Forms.Label userCalendarLabel;
        private System.Windows.Forms.Label mainMenuDescriptionLabel;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.PictureBox performaxxSkatePictureBox;
        private System.Windows.Forms.PictureBox performaxxLogoPictureBox;
    }
}