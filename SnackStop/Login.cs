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
        }

        private void loginSendButton_Click(object sender, EventArgs e)
        {
            // get userdata from database to login
        }
    }
}
//test