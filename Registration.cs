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
            u.Email2 = txtEmail2.Text;
            u.ReEmail = txtReEmail.Text;
            u.Password2 = txtPass2.Text;
            u.RePassword2 = txtRePass.Text;
            u.SQ = comboSQ.SelectedItem.ToString();
            u.SA = txtSA.Text;
            String a = comboBox5.SelectedItem.ToString();
            String b = comboBox6.SelectedItem.ToString();
            String c = comboBox7.SelectedItem.ToString();
            //ComboBox rb = groupBox1.Controls.OfType<ComboBox>().FirstOrDefault(n => n.Enabled);
            //u.Gender = rb.Text; 
            u.Gender = " Month :"+a+" Day :"+b+" Year :"+c; ;
            string output = String.Format("First Name: {0}" +
                 "\nLast Name: {1}" +
                 "\nDate Of Birth: {2}" +
                 "\nGender: {3}"+
                 "\nEmail: {4}" +
                 "\nRe- Typed Email: {5}" +
                 "\nPassword: {6}" +
                 "\nRe-Typeed Password: {7}" +
                 "\nSQ: {8}" +
                 "\nSA: {9}"  , u.Name, u.Email, u.Profession, u.Gender, u.Email2,u.ReEmail,u.Password2,u.RePassword2,u.SQ,u.SA);
            richTextBox.Text = output; 
           // new Dashboard(u).Show();
            //this.Hide();
        }//

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

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
