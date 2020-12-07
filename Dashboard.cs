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
    public partial class Dashboard : Form
    {
        public Dashboard(User u)
        {
            InitializeComponent();
            string output = String.Format("Name: {0}" +
                 "\nEmail: {1}"+
                 "\nDate Of Birth: {2}"+
                 "\nGender: {3}", u.Name, u.Email, u.Profession, u.Gender);
          //  MessageBox.Show(output);
            richTextBox1.Text = output;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Registration().Show();
            this.Hide();
        }
    }
}
