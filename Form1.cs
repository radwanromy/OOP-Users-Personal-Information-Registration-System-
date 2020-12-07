using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sss
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = "";
            string password = "";
            string errMsg = "";
            bool hasError = false;

            if (txtUsername.Text.Equals(""))
            {
                errMsg += "Username Required";
                hasError = true;
            }
            else
            {
                username = txtUsername.Text;
            }
            if (txtPassword.Text.Equals(""))
            {
                errMsg += "\nPassword Required";
                hasError = true;
            }
            else
            {
                password = txtPassword.Text;
            }
            if (!hasError)
            {
                if (username.Equals("18-36384-1") && password.Equals("radwan"))
                {
                    User u = new User();
                    u.Name = username;
                    u.Password = password;
                    //other values from DB
                    new Dashboard(u).Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid Username or Password");

                    txtPassword.Clear();
                }
            }
            else
            {
                MessageBox.Show(errMsg);
            }
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        

        private void Regi_Click(object sender, EventArgs e)
        {
            new Registration().Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
