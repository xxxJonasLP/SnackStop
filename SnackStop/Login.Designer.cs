namespace SnackStop
{
    partial class Login
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
            this.loginPanel = new MetroFramework.Controls.MetroPanel();
            this.loginSendButton = new MetroFramework.Controls.MetroButton();
            this.registerSendButton = new MetroFramework.Controls.MetroButton();
            this.passwdTB = new MetroFramework.Controls.MetroTextBox();
            this.usernameTB = new MetroFramework.Controls.MetroTextBox();
            this.mailTB = new MetroFramework.Controls.MetroTextBox();
            this.loginButton = new MetroFramework.Controls.MetroButton();
            this.registerButton = new MetroFramework.Controls.MetroButton();
            this.loginPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // loginPanel
            // 
            this.loginPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.loginPanel.Controls.Add(this.loginSendButton);
            this.loginPanel.Controls.Add(this.registerSendButton);
            this.loginPanel.Controls.Add(this.passwdTB);
            this.loginPanel.Controls.Add(this.usernameTB);
            this.loginPanel.Controls.Add(this.mailTB);
            this.loginPanel.Controls.Add(this.loginButton);
            this.loginPanel.Controls.Add(this.registerButton);
            this.loginPanel.CustomBackground = true;
            this.loginPanel.HorizontalScrollbar = false;
            this.loginPanel.HorizontalScrollbarBarColor = true;
            this.loginPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.loginPanel.HorizontalScrollbarSize = 11;
            this.loginPanel.Location = new System.Drawing.Point(54, 212);
            this.loginPanel.Name = "loginPanel";
            this.loginPanel.Size = new System.Drawing.Size(315, 385);
            this.loginPanel.Style = MetroFramework.MetroColorStyle.Blue;
            this.loginPanel.StyleManager = null;
            this.loginPanel.TabIndex = 0;
            this.loginPanel.Theme = MetroFramework.MetroThemeStyle.Light;
            this.loginPanel.VerticalScrollbar = false;
            this.loginPanel.VerticalScrollbarBarColor = true;
            this.loginPanel.VerticalScrollbarHighlightOnWheel = false;
            this.loginPanel.VerticalScrollbarSize = 10;
            // 
            // loginSendButton
            // 
            this.loginSendButton.Highlight = false;
            this.loginSendButton.Location = new System.Drawing.Point(71, 317);
            this.loginSendButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.loginSendButton.Name = "loginSendButton";
            this.loginSendButton.Size = new System.Drawing.Size(175, 31);
            this.loginSendButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.loginSendButton.StyleManager = null;
            this.loginSendButton.TabIndex = 12;
            this.loginSendButton.Text = "Login";
            this.loginSendButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.loginSendButton.Visible = false;
            this.loginSendButton.Click += new System.EventHandler(this.loginSendButton_Click);
            // 
            // registerSendButton
            // 
            this.registerSendButton.Highlight = false;
            this.registerSendButton.Location = new System.Drawing.Point(71, 317);
            this.registerSendButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.registerSendButton.Name = "registerSendButton";
            this.registerSendButton.Size = new System.Drawing.Size(175, 31);
            this.registerSendButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.registerSendButton.StyleManager = null;
            this.registerSendButton.TabIndex = 11;
            this.registerSendButton.Text = "Register";
            this.registerSendButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.registerSendButton.Visible = false;
            this.registerSendButton.Click += new System.EventHandler(this.registerSendButton_Click);
            // 
            // passwdTB
            // 
            this.passwdTB.FontSize = MetroFramework.MetroTextBoxSize.Small;
            this.passwdTB.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.passwdTB.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.passwdTB.Location = new System.Drawing.Point(28, 259);
            this.passwdTB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.passwdTB.Multiline = false;
            this.passwdTB.Name = "passwdTB";
            this.passwdTB.SelectedText = "";
            this.passwdTB.Size = new System.Drawing.Size(251, 31);
            this.passwdTB.Style = MetroFramework.MetroColorStyle.Blue;
            this.passwdTB.StyleManager = null;
            this.passwdTB.TabIndex = 10;
            this.passwdTB.Text = "Password";
            this.passwdTB.Theme = MetroFramework.MetroThemeStyle.Light;
            this.passwdTB.UseStyleColors = false;
            this.passwdTB.Visible = false;
            this.passwdTB.Click += new System.EventHandler(this.passwdTB_Click);
            this.passwdTB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.passwdTB_KeyDown);
            // 
            // usernameTB
            // 
            this.usernameTB.FontSize = MetroFramework.MetroTextBoxSize.Small;
            this.usernameTB.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.usernameTB.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.usernameTB.Location = new System.Drawing.Point(28, 220);
            this.usernameTB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.usernameTB.Multiline = false;
            this.usernameTB.Name = "usernameTB";
            this.usernameTB.SelectedText = "";
            this.usernameTB.Size = new System.Drawing.Size(251, 31);
            this.usernameTB.Style = MetroFramework.MetroColorStyle.Blue;
            this.usernameTB.StyleManager = null;
            this.usernameTB.TabIndex = 9;
            this.usernameTB.Text = "Username";
            this.usernameTB.Theme = MetroFramework.MetroThemeStyle.Light;
            this.usernameTB.UseStyleColors = false;
            this.usernameTB.Visible = false;
            this.usernameTB.Click += new System.EventHandler(this.usernameTB_Click);
            // 
            // mailTB
            // 
            this.mailTB.FontSize = MetroFramework.MetroTextBoxSize.Small;
            this.mailTB.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.mailTB.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.mailTB.Location = new System.Drawing.Point(28, 181);
            this.mailTB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mailTB.Multiline = false;
            this.mailTB.Name = "mailTB";
            this.mailTB.SelectedText = "";
            this.mailTB.Size = new System.Drawing.Size(251, 31);
            this.mailTB.Style = MetroFramework.MetroColorStyle.Blue;
            this.mailTB.StyleManager = null;
            this.mailTB.TabIndex = 8;
            this.mailTB.Text = "E-Mail";
            this.mailTB.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mailTB.UseStyleColors = false;
            this.mailTB.Visible = false;
            this.mailTB.Click += new System.EventHandler(this.testbox_Click);
            // 
            // loginButton
            // 
            this.loginButton.Highlight = false;
            this.loginButton.Location = new System.Drawing.Point(71, 239);
            this.loginButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(175, 31);
            this.loginButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.loginButton.StyleManager = null;
            this.loginButton.TabIndex = 3;
            this.loginButton.Text = "Login";
            this.loginButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // registerButton
            // 
            this.registerButton.Highlight = false;
            this.registerButton.Location = new System.Drawing.Point(71, 200);
            this.registerButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(175, 31);
            this.registerButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.registerButton.StyleManager = null;
            this.registerButton.TabIndex = 2;
            this.registerButton.Text = "Register";
            this.registerButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 729);
            this.Controls.Add(this.loginPanel);
            this.Location = new System.Drawing.Point(0, 0);
            this.MaximizeBox = false;
            this.Name = "Login";
            this.Padding = new System.Windows.Forms.Padding(21, 80, 21, 20);
            this.TextAlign = MetroFramework.Forms.TextAlign.Right;
            this.TopMost = true;
            this.loginPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel loginPanel;
        private MetroFramework.Controls.MetroButton registerButton;
        private MetroFramework.Controls.MetroButton loginButton;
        private MetroFramework.Controls.MetroTextBox mailTB;
        private MetroFramework.Controls.MetroTextBox passwdTB;
        private MetroFramework.Controls.MetroTextBox usernameTB;
        private MetroFramework.Controls.MetroButton registerSendButton;
        private MetroFramework.Controls.MetroButton loginSendButton;
    }
}