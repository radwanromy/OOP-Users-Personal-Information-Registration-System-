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
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        

        

        private void btnRegister_Click(object sender, EventArgs e)
        {
            User u = new User();
            u.Name = txtName.Text;
            u.Email = txtEmail.Text;
            u.Profession = boxProfession.SelectedItem.ToString();
            RadioButton rb = groupBox1.Controls.OfType<RadioButton>().FirstOrDefault(n => n.Checked);
            u.Gender = rb.Text; 

            /* string output = String.Format("Name: {0}"+
                 "\n Email: {1}",name,email);
             MessageBox.Show(output);
             richTextBox1.Text = output; */
            new Dashboard(u).Show();
            this.Hide();
        }

        private void Registration_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void boxGender_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }
    }
}
