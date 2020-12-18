namespace Performaxx_User_Interface
{
    partial class CreateAccountForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateAccountForm));
            this.createAccountButton = new System.Windows.Forms.Button();
            this.createAccountGroupBox = new System.Windows.Forms.GroupBox();
            this.accountTypeLabel = new System.Windows.Forms.Label();
            this.showPasswordsCheckBox = new System.Windows.Forms.CheckBox();
            this.viewAccountRequirementsButton = new System.Windows.Forms.Button();
            this.confirmPasswordTextBox = new System.Windows.Forms.TextBox();
            this.confirmPasswordLabel = new System.Windows.Forms.Label();
            this.employeeRadioButton = new System.Windows.Forms.RadioButton();
            this.administratorRadioButton = new System.Windows.Forms.RadioButton();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.userNameTextBox = new System.Windows.Forms.TextBox();
            this.userNameLabel = new System.Windows.Forms.Label();
            this.performaxxLogoPictureBox = new System.Windows.Forms.PictureBox();
            this.performaxxTitlePictureBox = new System.Windows.Forms.PictureBox();
            this.returnToLoginScreenButton = new System.Windows.Forms.Button();
            this.createAccountGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.performaxxLogoPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.performaxxTitlePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // createAccountButton
            // 
            this.createAccountButton.BackColor = System.Drawing.Color.LightBlue;
            this.createAccountButton.Font = new System.Drawing.Font("Impact", 14F);
            this.createAccountButton.Location = new System.Drawing.Point(580, 566);
            this.createAccountButton.Name = "createAccountButton";
            this.createAccountButton.Size = new System.Drawing.Size(237, 44);
            this.createAccountButton.TabIndex = 20;
            this.createAccountButton.Text = "Create Account";
            this.createAccountButton.UseVisualStyleBackColor = false;
            this.createAccountButton.Click += new System.EventHandler(this.createAccountButton_Click);
            // 
            // createAccountGroupBox
            // 
            this.createAccountGroupBox.BackColor = System.Drawing.Color.Beige;
            this.createAccountGroupBox.Controls.Add(this.accountTypeLabel);
            this.createAccountGroupBox.Controls.Add(this.showPasswordsCheckBox);
            this.createAccountGroupBox.Controls.Add(this.viewAccountRequirementsButton);
            this.createAccountGroupBox.Controls.Add(this.confirmPasswordTextBox);
            this.createAccountGroupBox.Controls.Add(this.confirmPasswordLabel);
            this.createAccountGroupBox.Controls.Add(this.employeeRadioButton);
            this.createAccountGroupBox.Controls.Add(this.administratorRadioButton);
            this.createAccountGroupBox.Controls.Add(this.passwordTextBox);
            this.createAccountGroupBox.Controls.Add(this.passwordLabel);
            this.createAccountGroupBox.Controls.Add(this.userNameTextBox);
            this.createAccountGroupBox.Controls.Add(this.userNameLabel);
            this.createAccountGroupBox.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createAccountGroupBox.Location = new System.Drawing.Point(496, 291);
            this.createAccountGroupBox.Name = "createAccountGroupBox";
            this.createAccountGroupBox.Size = new System.Drawing.Size(396, 269);
            this.createAccountGroupBox.TabIndex = 23;
            this.createAccountGroupBox.TabStop = false;
            this.createAccountGroupBox.Text = "New Account";
            // 
            // accountTypeLabel
            // 
            this.accountTypeLabel.AutoSize = true;
            this.accountTypeLabel.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountTypeLabel.Location = new System.Drawing.Point(54, 230);
            this.accountTypeLabel.Name = "accountTypeLabel";
            this.accountTypeLabel.Size = new System.Drawing.Size(111, 18);
            this.accountTypeLabel.TabIndex = 33;
            this.accountTypeLabel.Text = "Account Type:";
            // 
            // showPasswordsCheckBox
            // 
            this.showPasswordsCheckBox.AutoSize = true;
            this.showPasswordsCheckBox.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showPasswordsCheckBox.Location = new System.Drawing.Point(261, 200);
            this.showPasswordsCheckBox.Name = "showPasswordsCheckBox";
            this.showPasswordsCheckBox.Size = new System.Drawing.Size(118, 19);
            this.showPasswordsCheckBox.TabIndex = 32;
            this.showPasswordsCheckBox.Text = "Show Passwords";
            this.showPasswordsCheckBox.UseVisualStyleBackColor = true;
            this.showPasswordsCheckBox.CheckedChanged += new System.EventHandler(this.showPasswordsCheckBox_CheckedChanged);
            // 
            // viewAccountRequirementsButton
            // 
            this.viewAccountRequirementsButton.BackColor = System.Drawing.Color.DarkOrange;
            this.viewAccountRequirementsButton.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewAccountRequirementsButton.Location = new System.Drawing.Point(26, 30);
            this.viewAccountRequirementsButton.Name = "viewAccountRequirementsButton";
            this.viewAccountRequirementsButton.Size = new System.Drawing.Size(353, 38);
            this.viewAccountRequirementsButton.TabIndex = 31;
            this.viewAccountRequirementsButton.Text = "View Account Requirements";
            this.viewAccountRequirementsButton.UseVisualStyleBackColor = false;
            this.viewAccountRequirementsButton.Click += new System.EventHandler(this.viewAccountRequirementsButton_Click);
            // 
            // confirmPasswordTextBox
            // 
            this.confirmPasswordTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmPasswordTextBox.Location = new System.Drawing.Point(171, 166);
            this.confirmPasswordTextBox.Name = "confirmPasswordTextBox";
            this.confirmPasswordTextBox.PasswordChar = '●';
            this.confirmPasswordTextBox.Size = new System.Drawing.Size(208, 26);
            this.confirmPasswordTextBox.TabIndex = 30;
            // 
            // confirmPasswordLabel
            // 
            this.confirmPasswordLabel.AutoSize = true;
            this.confirmPasswordLabel.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmPasswordLabel.Location = new System.Drawing.Point(23, 169);
            this.confirmPasswordLabel.Name = "confirmPasswordLabel";
            this.confirmPasswordLabel.Size = new System.Drawing.Size(142, 18);
            this.confirmPasswordLabel.TabIndex = 29;
            this.confirmPasswordLabel.Text = "Confirm Password:";
            // 
            // employeeRadioButton
            // 
            this.employeeRadioButton.AutoSize = true;
            this.employeeRadioButton.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeRadioButton.Location = new System.Drawing.Point(291, 230);
            this.employeeRadioButton.Name = "employeeRadioButton";
            this.employeeRadioButton.Size = new System.Drawing.Size(88, 20);
            this.employeeRadioButton.TabIndex = 28;
            this.employeeRadioButton.TabStop = true;
            this.employeeRadioButton.Text = "Employee";
            this.employeeRadioButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.employeeRadioButton.UseVisualStyleBackColor = true;

            // 
            // administratorRadioButton
            // 
            this.administratorRadioButton.AutoSize = true;
            this.administratorRadioButton.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.administratorRadioButton.Location = new System.Drawing.Point(171, 230);
            this.administratorRadioButton.Name = "administratorRadioButton";
            this.administratorRadioButton.Size = new System.Drawing.Size(115, 20);
            this.administratorRadioButton.TabIndex = 27;
            this.administratorRadioButton.TabStop = true;
            this.administratorRadioButton.Text = "Administrator";
            this.administratorRadioButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.administratorRadioButton.UseVisualStyleBackColor = true;

            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTextBox.Location = new System.Drawing.Point(171, 124);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '●';
            this.passwordTextBox.Size = new System.Drawing.Size(208, 26);
            this.passwordTextBox.TabIndex = 26;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.Location = new System.Drawing.Point(84, 127);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(81, 18);
            this.passwordLabel.TabIndex = 24;
            this.passwordLabel.Text = "Password:";
            // 
            // userNameTextBox
            // 
            this.userNameTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameTextBox.Location = new System.Drawing.Point(171, 83);
            this.userNameTextBox.Name = "userNameTextBox";
            this.userNameTextBox.Size = new System.Drawing.Size(208, 26);
            this.userNameTextBox.TabIndex = 25;
            // 
            // userNameLabel
            // 
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameLabel.Location = new System.Drawing.Point(79, 86);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(86, 18);
            this.userNameLabel.TabIndex = 23;
            this.userNameLabel.Text = "Username:";
            // 
            // performaxxLogoPictureBox
            // 
            this.performaxxLogoPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("performaxxLogoPictureBox.Image")));
            this.performaxxLogoPictureBox.Location = new System.Drawing.Point(173, 291);
            this.performaxxLogoPictureBox.Name = "performaxxLogoPictureBox";
            this.performaxxLogoPictureBox.Size = new System.Drawing.Size(311, 319);
            this.performaxxLogoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.performaxxLogoPictureBox.TabIndex = 17;
            this.performaxxLogoPictureBox.TabStop = false;
            // 
            // performaxxTitlePictureBox
            // 
            this.performaxxTitlePictureBox.Image = global::Performaxx_User_Interface.Properties.Resources.PerformaxxTitle;
            this.performaxxTitlePictureBox.Location = new System.Drawing.Point(271, 150);
            this.performaxxTitlePictureBox.Name = "performaxxTitlePictureBox";
            this.performaxxTitlePictureBox.Size = new System.Drawing.Size(642, 135);
            this.performaxxTitlePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.performaxxTitlePictureBox.TabIndex = 16;
            this.performaxxTitlePictureBox.TabStop = false;
            // 
            // returnToLoginScreenButton
            // 
            this.returnToLoginScreenButton.BackColor = System.Drawing.Color.Transparent;
            this.returnToLoginScreenButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.returnToLoginScreenButton.FlatAppearance.BorderSize = 0;
            this.returnToLoginScreenButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.returnToLoginScreenButton.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnToLoginScreenButton.Image = ((System.Drawing.Image)(resources.GetObject("returnToLoginScreenButton.Image")));
            this.returnToLoginScreenButton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.returnToLoginScreenButton.Location = new System.Drawing.Point(173, 150);
            this.returnToLoginScreenButton.Name = "returnToLoginScreenButton";
            this.returnToLoginScreenButton.Size = new System.Drawing.Size(143, 82);
            this.returnToLoginScreenButton.TabIndex = 69;
            this.returnToLoginScreenButton.Text = "Return to Login Screen";
            this.returnToLoginScreenButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.returnToLoginScreenButton.UseVisualStyleBackColor = false;
            this.returnToLoginScreenButton.Click += new System.EventHandler(this.returnToLoginScreenButton_Click);
            // 
            // CreateAccountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Performaxx_User_Interface.Properties.Resources.PerformaxxFrame;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1082, 754);
            this.Controls.Add(this.returnToLoginScreenButton);
            this.Controls.Add(this.createAccountGroupBox);
            this.Controls.Add(this.createAccountButton);
            this.Controls.Add(this.performaxxLogoPictureBox);
            this.Controls.Add(this.performaxxTitlePictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "CreateAccountForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Performaxx: Create Account";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CreateAccountForm_FormClosed);
            this.createAccountGroupBox.ResumeLayout(false);
            this.createAccountGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.performaxxLogoPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.performaxxTitlePictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button createAccountButton;
        private System.Windows.Forms.PictureBox performaxxLogoPictureBox;
        private System.Windows.Forms.PictureBox performaxxTitlePictureBox;
        private System.Windows.Forms.GroupBox createAccountGroupBox;
        private System.Windows.Forms.TextBox confirmPasswordTextBox;
        private System.Windows.Forms.Label confirmPasswordLabel;
        private System.Windows.Forms.RadioButton employeeRadioButton;
        private System.Windows.Forms.RadioButton administratorRadioButton;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox userNameTextBox;
        private System.Windows.Forms.Label userNameLabel;
        private System.Windows.Forms.Button returnToLoginScreenButton;
        private System.Windows.Forms.Button viewAccountRequirementsButton;
        private System.Windows.Forms.Label accountTypeLabel;
        private System.Windows.Forms.CheckBox showPasswordsCheckBox;
    }
}