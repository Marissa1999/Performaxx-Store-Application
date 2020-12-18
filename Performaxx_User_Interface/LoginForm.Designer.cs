namespace Performaxx_User_Interface
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.signInGroupBox = new System.Windows.Forms.GroupBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.userNameTextBox = new System.Windows.Forms.TextBox();
            this.userNameLabel = new System.Windows.Forms.Label();
            this.createAccountButton = new System.Windows.Forms.Button();
            this.performaxxLogoPictureBox = new System.Windows.Forms.PictureBox();
            this.performaxxTitlePictureBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.loginButton = new System.Windows.Forms.Button();
            this.loginPictureBox = new System.Windows.Forms.PictureBox();
            this.createAccountPictureBox = new System.Windows.Forms.PictureBox();
            this.signInGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.performaxxLogoPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.performaxxTitlePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.createAccountPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // signInGroupBox
            // 
            this.signInGroupBox.BackColor = System.Drawing.Color.Beige;
            this.signInGroupBox.Controls.Add(this.passwordTextBox);
            this.signInGroupBox.Controls.Add(this.passwordLabel);
            this.signInGroupBox.Controls.Add(this.userNameTextBox);
            this.signInGroupBox.Controls.Add(this.userNameLabel);
            this.signInGroupBox.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signInGroupBox.Location = new System.Drawing.Point(186, 302);
            this.signInGroupBox.Name = "signInGroupBox";
            this.signInGroupBox.Size = new System.Drawing.Size(408, 135);
            this.signInGroupBox.TabIndex = 27;
            this.signInGroupBox.TabStop = false;
            this.signInGroupBox.Text = "Login";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTextBox.Location = new System.Drawing.Point(145, 92);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '●';
            this.passwordTextBox.Size = new System.Drawing.Size(231, 26);
            this.passwordTextBox.TabIndex = 26;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.Location = new System.Drawing.Point(58, 95);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(81, 18);
            this.passwordLabel.TabIndex = 24;
            this.passwordLabel.Text = "Password:";
            // 
            // userNameTextBox
            // 
            this.userNameTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameTextBox.Location = new System.Drawing.Point(145, 35);
            this.userNameTextBox.Name = "userNameTextBox";
            this.userNameTextBox.Size = new System.Drawing.Size(231, 26);
            this.userNameTextBox.TabIndex = 25;
            // 
            // userNameLabel
            // 
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameLabel.Location = new System.Drawing.Point(53, 38);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(86, 18);
            this.userNameLabel.TabIndex = 23;
            this.userNameLabel.Text = "Username:";
            // 
            // createAccountButton
            // 
            this.createAccountButton.BackColor = System.Drawing.Color.LightBlue;
            this.createAccountButton.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createAccountButton.Location = new System.Drawing.Point(186, 551);
            this.createAccountButton.Name = "createAccountButton";
            this.createAccountButton.Size = new System.Drawing.Size(347, 49);
            this.createAccountButton.TabIndex = 26;
            this.createAccountButton.Text = "Create Account";
            this.createAccountButton.UseVisualStyleBackColor = false;
            this.createAccountButton.Click += new System.EventHandler(this.createAccountButton_Click);
            // 
            // performaxxLogoPictureBox
            // 
            this.performaxxLogoPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("performaxxLogoPictureBox.Image")));
            this.performaxxLogoPictureBox.Location = new System.Drawing.Point(613, 289);
            this.performaxxLogoPictureBox.Name = "performaxxLogoPictureBox";
            this.performaxxLogoPictureBox.Size = new System.Drawing.Size(289, 311);
            this.performaxxLogoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.performaxxLogoPictureBox.TabIndex = 25;
            this.performaxxLogoPictureBox.TabStop = false;
            // 
            // performaxxTitlePictureBox
            // 
            this.performaxxTitlePictureBox.Image = global::Performaxx_User_Interface.Properties.Resources.PerformaxxTitle;
            this.performaxxTitlePictureBox.Location = new System.Drawing.Point(186, 148);
            this.performaxxTitlePictureBox.Name = "performaxxTitlePictureBox";
            this.performaxxTitlePictureBox.Size = new System.Drawing.Size(716, 135);
            this.performaxxTitlePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.performaxxTitlePictureBox.TabIndex = 24;
            this.performaxxTitlePictureBox.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(222, 532);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(287, 16);
            this.label1.TabIndex = 29;
            this.label1.Text = "New to Peformaxx? Please create an account.";
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.Color.LightBlue;
            this.loginButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.loginButton.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.loginButton.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.loginButton.Location = new System.Drawing.Point(186, 458);
            this.loginButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(347, 52);
            this.loginButton.TabIndex = 30;
            this.loginButton.Text = "Sign In";
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // loginPictureBox
            // 
            this.loginPictureBox.BackColor = System.Drawing.Color.White;
            this.loginPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.loginPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("loginPictureBox.Image")));
            this.loginPictureBox.Location = new System.Drawing.Point(544, 458);
            this.loginPictureBox.Name = "loginPictureBox";
            this.loginPictureBox.Size = new System.Drawing.Size(50, 52);
            this.loginPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.loginPictureBox.TabIndex = 31;
            this.loginPictureBox.TabStop = false;
            // 
            // createAccountPictureBox
            // 
            this.createAccountPictureBox.BackColor = System.Drawing.Color.LightBlue;
            this.createAccountPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.createAccountPictureBox.Image = global::Performaxx_User_Interface.Properties.Resources.CreateAccountImage;
            this.createAccountPictureBox.Location = new System.Drawing.Point(544, 551);
            this.createAccountPictureBox.Name = "createAccountPictureBox";
            this.createAccountPictureBox.Size = new System.Drawing.Size(50, 49);
            this.createAccountPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.createAccountPictureBox.TabIndex = 32;
            this.createAccountPictureBox.TabStop = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Performaxx_User_Interface.Properties.Resources.PerformaxxFrame;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1082, 754);
            this.Controls.Add(this.createAccountPictureBox);
            this.Controls.Add(this.loginPictureBox);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.signInGroupBox);
            this.Controls.Add(this.createAccountButton);
            this.Controls.Add(this.performaxxLogoPictureBox);
            this.Controls.Add(this.performaxxTitlePictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Performaxx: Login";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LoginForm_FormClosed);
            this.signInGroupBox.ResumeLayout(false);
            this.signInGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.performaxxLogoPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.performaxxTitlePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.createAccountPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox signInGroupBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox userNameTextBox;
        private System.Windows.Forms.Label userNameLabel;
        private System.Windows.Forms.Button createAccountButton;
        private System.Windows.Forms.PictureBox performaxxLogoPictureBox;
        private System.Windows.Forms.PictureBox performaxxTitlePictureBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.PictureBox loginPictureBox;
        private System.Windows.Forms.PictureBox createAccountPictureBox;
    }
}

