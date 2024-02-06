//form1.cs
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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






//form1 design.cs

namespace C__Day51
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            groupBox1 = new GroupBox();
            femaleBtn = new RadioButton();
            maleBtn = new RadioButton();
            cancelBtn = new Button();
            signUpBtn = new Button();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            passBtn = new Label();
            nameBtn = new Label();
            errorProvider1 = new ErrorProvider(components);
            errorProvider2 = new ErrorProvider(components);
            errorProvider3 = new ErrorProvider(components);
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider3).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.AutoSize = true;
            groupBox1.Controls.Add(femaleBtn);
            groupBox1.Controls.Add(maleBtn);
            groupBox1.Controls.Add(cancelBtn);
            groupBox1.Controls.Add(signUpBtn);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(passBtn);
            groupBox1.Controls.Add(nameBtn);
            groupBox1.Location = new Point(136, 64);
            groupBox1.Margin = new Padding(4, 3, 4, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 3, 4, 3);
            groupBox1.Size = new Size(537, 301);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Sign Up";
            // 
            // femaleBtn
            // 
            femaleBtn.AutoSize = true;
            femaleBtn.Location = new Point(375, 114);
            femaleBtn.Name = "femaleBtn";
            femaleBtn.Size = new Size(63, 19);
            femaleBtn.TabIndex = 7;
            femaleBtn.TabStop = true;
            femaleBtn.Text = "Female";
            femaleBtn.UseVisualStyleBackColor = true;
            // 
            // maleBtn
            // 
            maleBtn.AutoSize = true;
            maleBtn.Location = new Point(375, 71);
            maleBtn.Name = "maleBtn";
            maleBtn.Size = new Size(51, 19);
            maleBtn.TabIndex = 6;
            maleBtn.TabStop = true;
            maleBtn.Text = "Male";
            maleBtn.UseVisualStyleBackColor = true;
            // 
            // cancelBtn
            // 
            cancelBtn.BackColor = Color.Cornsilk;
            cancelBtn.Font = new Font("Microsoft Sans Serif", 13.25F, FontStyle.Regular, GraphicsUnit.Point);
            cancelBtn.Location = new Point(8, 238);
            cancelBtn.Margin = new Padding(4, 3, 4, 3);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(205, 37);
            cancelBtn.TabIndex = 5;
            cancelBtn.Text = "Cancel";
            cancelBtn.UseVisualStyleBackColor = false;
            cancelBtn.Click += button2_Click;
            // 
            // signUpBtn
            // 
            signUpBtn.BackColor = Color.LightBlue;
            signUpBtn.Font = new Font("Microsoft Sans Serif", 13.25F, FontStyle.Regular, GraphicsUnit.Point);
            signUpBtn.Location = new Point(270, 233);
            signUpBtn.Margin = new Padding(4, 3, 4, 3);
            signUpBtn.Name = "signUpBtn";
            signUpBtn.Size = new Size(156, 46);
            signUpBtn.TabIndex = 4;
            signUpBtn.Text = "Sign Up";
            signUpBtn.UseVisualStyleBackColor = false;
            signUpBtn.Click += button1_Click;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Microsoft Sans Serif", 15.25F, FontStyle.Bold, GraphicsUnit.Point);
            textBox2.Location = new Point(128, 114);
            textBox2.Margin = new Padding(4, 3, 4, 3);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.PasswordChar = '*';
            textBox2.Size = new Size(214, 34);
            textBox2.TabIndex = 3;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(128, 62);
            textBox1.Margin = new Padding(4, 3, 4, 3);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(214, 34);
            textBox1.TabIndex = 2;
            // 
            // passBtn
            // 
            passBtn.Font = new Font("Microsoft Sans Serif", 15.25F, FontStyle.Regular, GraphicsUnit.Point);
            passBtn.Location = new Point(21, 114);
            passBtn.Margin = new Padding(4, 0, 4, 0);
            passBtn.Name = "passBtn";
            passBtn.Size = new Size(148, 39);
            passBtn.TabIndex = 1;
            passBtn.Text = "Password:";
            // 
            // nameBtn
            // 
            nameBtn.Font = new Font("Microsoft Sans Serif", 19.25F, FontStyle.Regular, GraphicsUnit.Point);
            nameBtn.Location = new Point(21, 62);
            nameBtn.Margin = new Padding(4, 0, 4, 0);
            nameBtn.Name = "nameBtn";
            nameBtn.Size = new Size(99, 39);
            nameBtn.TabIndex = 0;
            nameBtn.Text = "Name:";
            nameBtn.Click += label1_Click_1;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            errorProvider2.ContainerControl = this;
            // 
            // errorProvider3
            // 
            errorProvider3.ContainerControl = this;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(710, 383);
            Controls.Add(groupBox1);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider2).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Label nameBtn;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label passBtn;
        private Button signUpBtn;
        private Button cancelBtn;
        private RadioButton femaleBtn;
        private RadioButton maleBtn;
        private ErrorProvider errorProvider1;
        private ErrorProvider errorProvider2;
        private ErrorProvider errorProvider3;
    }
}
