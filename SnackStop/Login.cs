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
            Loginlabel1.Hide();
            newuserlabel1.Hide();
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
            Loginlabel1.Hide();
            newuserlabel1.Hide();
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
                // check if email, username and password correct
                if (usernameTB.Text == credentials[0] && passwdTB.Text == credentials[1])
                {
                    // set dialogResult to OK to close login and show main window
                    this.DialogResult = DialogResult.OK;
                    return;
                    
                }

            }

            // failed login msg
            MessageBox.Show("Login failed. Invalid username or password.");

        }

        private void passwdTB_KeyDown(object sender, KeyEventArgs e)
        {
            // Using enter key for login
            if (e.KeyCode == Keys.Enter)
            {
                
                loginSendButton_Click(sender, e);
            }
        }

       //Trash
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Loginlabel1_Click(object sender, EventArgs e)
        {

        }

        private void newuserlabel1_Click(object sender, EventArgs e)
        {

        }
    }
}
