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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.loginSendButton = new MetroFramework.Controls.MetroButton();
            this.registerSendButton = new MetroFramework.Controls.MetroButton();
            this.passwdTB = new MetroFramework.Controls.MetroTextBox();
            this.usernameTB = new MetroFramework.Controls.MetroTextBox();
            this.mailTB = new MetroFramework.Controls.MetroTextBox();
            this.loginButton = new MetroFramework.Controls.MetroButton();
            this.registerButton = new MetroFramework.Controls.MetroButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Loginlabel1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.newuserlabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // loginSendButton
            // 
            this.loginSendButton.Highlight = false;
            this.loginSendButton.Location = new System.Drawing.Point(88, 252);
            this.loginSendButton.Name = "loginSendButton";
            this.loginSendButton.Size = new System.Drawing.Size(238, 49);
            this.loginSendButton.Style = MetroFramework.MetroColorStyle.Silver;
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
            this.registerSendButton.Location = new System.Drawing.Point(88, 252);
            this.registerSendButton.Name = "registerSendButton";
            this.registerSendButton.Size = new System.Drawing.Size(238, 49);
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
            this.passwdTB.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.passwdTB.FontWeight = MetroFramework.MetroTextBoxWeight.Regular;
            this.passwdTB.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.passwdTB.Location = new System.Drawing.Point(88, 214);
            this.passwdTB.Multiline = false;
            this.passwdTB.Name = "passwdTB";
            this.passwdTB.SelectedText = "";
            this.passwdTB.Size = new System.Drawing.Size(238, 32);
            this.passwdTB.Style = MetroFramework.MetroColorStyle.Silver;
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
            this.usernameTB.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.usernameTB.FontWeight = MetroFramework.MetroTextBoxWeight.Regular;
            this.usernameTB.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.usernameTB.Location = new System.Drawing.Point(88, 179);
            this.usernameTB.Multiline = false;
            this.usernameTB.Name = "usernameTB";
            this.usernameTB.SelectedText = "";
            this.usernameTB.Size = new System.Drawing.Size(238, 32);
            this.usernameTB.Style = MetroFramework.MetroColorStyle.Silver;
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
            this.mailTB.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mailTB.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.mailTB.FontWeight = MetroFramework.MetroTextBoxWeight.Regular;
            this.mailTB.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.mailTB.Location = new System.Drawing.Point(88, 143);
            this.mailTB.Multiline = false;
            this.mailTB.Name = "mailTB";
            this.mailTB.SelectedText = "";
            this.mailTB.Size = new System.Drawing.Size(238, 32);
            this.mailTB.Style = MetroFramework.MetroColorStyle.Silver;
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
            this.loginButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.loginButton.Highlight = true;
            this.loginButton.Location = new System.Drawing.Point(100, 217);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(215, 42);
            this.loginButton.Style = MetroFramework.MetroColorStyle.Silver;
            this.loginButton.StyleManager = null;
            this.loginButton.TabIndex = 3;
            this.loginButton.Text = "Login";
            this.loginButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // registerButton
            // 
            this.registerButton.BackColor = System.Drawing.Color.White;
            this.registerButton.ForeColor = System.Drawing.Color.RosyBrown;
            this.registerButton.Highlight = false;
            this.registerButton.Location = new System.Drawing.Point(152, 396);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(103, 28);
            this.registerButton.Style = MetroFramework.MetroColorStyle.Silver;
            this.registerButton.StyleManager = null;
            this.registerButton.TabIndex = 2;
            this.registerButton.Text = "Register";
            this.registerButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.registerButton.UseVisualStyleBackColor = false;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(10, 335);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(115, 103);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Loginlabel1
            // 
            this.Loginlabel1.AutoSize = true;
            this.Loginlabel1.BackColor = System.Drawing.Color.Transparent;
            this.Loginlabel1.Font = new System.Drawing.Font("Britannic Bold", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Loginlabel1.ForeColor = System.Drawing.Color.Black;
            this.Loginlabel1.Location = new System.Drawing.Point(32, 140);
            this.Loginlabel1.Name = "Loginlabel1";
            this.Loginlabel1.Size = new System.Drawing.Size(322, 71);
            this.Loginlabel1.TabIndex = 14;
            this.Loginlabel1.Text = "Snackstop";
            this.Loginlabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Loginlabel1.Click += new System.EventHandler(this.Loginlabel1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(287, 318);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(117, 108);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(10, 31);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(94, 90);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 16;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(300, 31);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(93, 73);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 17;
            this.pictureBox4.TabStop = false;
            // 
            // newuserlabel1
            // 
            this.newuserlabel1.AutoSize = true;
            this.newuserlabel1.Location = new System.Drawing.Point(172, 378);
            this.newuserlabel1.Name = "newuserlabel1";
            this.newuserlabel1.Size = new System.Drawing.Size(61, 15);
            this.newuserlabel1.TabIndex = 18;
            this.newuserlabel1.Text = "New user?";
            this.newuserlabel1.Click += new System.EventHandler(this.newuserlabel1_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 444);
            this.Controls.Add(this.newuserlabel1);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.Loginlabel1);
            this.Controls.Add(this.loginSendButton);
            this.Controls.Add(this.registerSendButton);
            this.Controls.Add(this.passwdTB);
            this.Controls.Add(this.mailTB);
            this.Controls.Add(this.usernameTB);
            this.Controls.Add(this.registerButton);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.pictureBox1);
            this.Location = new System.Drawing.Point(0, 0);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "Login";
            this.Padding = new System.Windows.Forms.Padding(18, 60, 18, 15);
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Silver;
            this.TextAlign = MetroFramework.Forms.TextAlign.Right;
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroButton registerButton;
        private MetroFramework.Controls.MetroButton loginButton;
        private MetroFramework.Controls.MetroTextBox mailTB;
        private MetroFramework.Controls.MetroTextBox passwdTB;
        private MetroFramework.Controls.MetroTextBox usernameTB;
        private MetroFramework.Controls.MetroButton registerSendButton;
        private MetroFramework.Controls.MetroButton loginSendButton;
        private PictureBox pictureBox1;
        private Label Loginlabel1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private Label newuserlabel1;
    }
}