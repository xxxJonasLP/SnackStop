using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnackStop
{
    public partial class Login : MetroForm
    {
        public Login()
        {
            InitializeComponent();
        }
        // instance of connector
        DB_Connector connector = new DB_Connector();

        private void registerButton_Click(object sender, EventArgs e)
        {
            // switch scene to register
            registerButton.Hide();
            loginButton.Hide();

            mailTB.Show();
            usernameTB.Show();
            passwdTB.Show();
            registerSendButton.Show(); // das ist der button der daten zur datenbank schicken wird mit click event
        }
        private void loginButton_Click(object sender, EventArgs e)
        {
            registerButton.Hide();
            loginButton.Hide();
            usernameTB.Show();
            passwdTB.Show();
            loginSendButton.Show();
        }

        private void testbox_Click(object sender, EventArgs e)
        {
            mailTB.Text = "";
            mailTB.ForeColor= Color.White;
        }

        private void usernameTB_Click(object sender, EventArgs e)
        {
            usernameTB.Text = "";
            usernameTB.ForeColor= Color.White;
           
        }

        private void passwdTB_Click(object sender, EventArgs e)
        {
           passwdTB.Text = "";
           passwdTB.ForeColor= Color.White;
            // hier noch damit die buchstaben als hashtag erstzt werden mache später
           
        }

        private void registerSendButton_Click(object sender, EventArgs e)
        {
            // send user data to database
            //Bruder keine ahnung
        }

        private void loginSendButton_Click(object sender, EventArgs e)
        {
            // get userdata from database to login
            // get data from database
            var loginData = connector.GetData("SELECT email, username, password FROM users");

            foreach (var credentials in loginData)
            {
                // show employees for debug
                // MessageBox.Show(employee);

                // split email,username and password

                // check if email, username and password correct
                if (mailTB.Text == credentials[0] && usernameTB.Text == credentials[1] && passwdTB.Text == credentials[2])
                {
                    // set dialogResult to OK to close login and show main window
                    this.DialogResult = DialogResult.OK;
                    return;

                    
                    
                        // hide login window
                        this.Hide();

                        // Instance MainWindow Form
                        Hauptfenster mainWindow = new Hauptfenster();

                        
                        mainWindow.Show();

                        // close login Form
                        mainWindow.FormClosed += (s, args) => this.Close();

                        return;
                    
                }
            }

            // failed login msg
            MessageBox.Show("Login failed. Invalid email,username or password.");


        }

        private void passwdTB_KeyDown(object sender, KeyEventArgs e)
        {
            // Using enter key for login
            if (e.KeyCode == Keys.Enter)
            {
                
                loginSendButton_Click(sender, e);
            }
        }
    }
}
