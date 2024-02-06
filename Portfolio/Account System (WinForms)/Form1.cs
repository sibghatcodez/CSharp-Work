using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace C__Day51
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private string userName;
        private string userPassword;
        private string userGender;

        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == string.Empty)
            {
                errorProvider1.SetError(textBox1, "Provide a name!");
            }
            else if (textBox2.Text == string.Empty)
            {
                errorProvider2.SetError(textBox2, "Provide a password!");
            }
            else if (!maleBtn.Checked && !femaleBtn.Checked)
            {
                errorProvider3.SetError(maleBtn, "CHOOSE YOUR GENDER!");
                errorProvider3.SetError(femaleBtn, "CHOOSE YOUR GENDER!");
            }
            else
            {
                userName = textBox1.Text;
                userPassword = textBox2.Text;
                userGender = maleBtn.Checked ? "Male" : "Female";

                FileStream userInfo = new FileStream("E:userInfo.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
                using (StreamWriter userInfoWriter = new StreamWriter(userInfo))
                {
                    userInfoWriter.WriteLine($"User: {userName} Password: {userPassword} | Gender: {userGender}");
                };
                Application.Exit();
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

