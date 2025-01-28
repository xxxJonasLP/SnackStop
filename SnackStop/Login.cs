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
    public partial class Login : Form
    {
        private Button button2;
        private Button button1;

        public Login()
        {
            InitializeComponent();


            // instance of connector
            DB_Connector connector = new DB_Connector();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DB_Connector con = new DB_Connector();
            List<List<string?>> data = con.GetData("SELECT * FROM users");

            MessageBox.Show(data.ToString());

        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Text = "Login";

            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(97, 109);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 29);
            this.button2.TabIndex = 0;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Login
            // 
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Controls.Add(this.button2);
            this.Name = "Login";
            this.ResumeLayout(false);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DB_Connector con = new DB_Connector();
            List<List<string?>> data = con.GetData("SELECT * FROM users");

            MessageBox.Show(data.ToString());
        }
    }
}
