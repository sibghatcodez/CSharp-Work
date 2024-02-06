using System.Drawing;
using System.Windows.Forms;

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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.femaleBtn = new System.Windows.Forms.RadioButton();
            this.maleBtn = new System.Windows.Forms.RadioButton();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.signUpBtn = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.passBtn = new System.Windows.Forms.Label();
            this.nameBtn = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.femaleBtn);
            this.groupBox1.Controls.Add(this.maleBtn);
            this.groupBox1.Controls.Add(this.cancelBtn);
            this.groupBox1.Controls.Add(this.signUpBtn);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.passBtn);
            this.groupBox1.Controls.Add(this.nameBtn);
            this.groupBox1.Location = new System.Drawing.Point(117, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(460, 261);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sign Up";
            // 
            // femaleBtn
            // 
            this.femaleBtn.AutoSize = true;
            this.femaleBtn.Location = new System.Drawing.Point(321, 99);
            this.femaleBtn.Name = "femaleBtn";
            this.femaleBtn.Size = new System.Drawing.Size(59, 17);
            this.femaleBtn.TabIndex = 7;
            this.femaleBtn.TabStop = true;
            this.femaleBtn.Text = "Female";
            this.femaleBtn.UseVisualStyleBackColor = true;
            // 
            // maleBtn
            // 
            this.maleBtn.AutoSize = true;
            this.maleBtn.Location = new System.Drawing.Point(321, 62);
            this.maleBtn.Name = "maleBtn";
            this.maleBtn.Size = new System.Drawing.Size(48, 17);
            this.maleBtn.TabIndex = 6;
            this.maleBtn.TabStop = true;
            this.maleBtn.Text = "Male";
            this.maleBtn.UseVisualStyleBackColor = true;
            // 
            // cancelBtn
            // 
            this.cancelBtn.BackColor = System.Drawing.Color.Cornsilk;
            this.cancelBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.cancelBtn.Location = new System.Drawing.Point(7, 206);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(176, 32);
            this.cancelBtn.TabIndex = 5;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = false;
            // 
            // signUpBtn
            // 
            this.signUpBtn.BackColor = System.Drawing.Color.LightBlue;
            this.signUpBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.signUpBtn.Location = new System.Drawing.Point(231, 202);
            this.signUpBtn.Name = "signUpBtn";
            this.signUpBtn.Size = new System.Drawing.Size(134, 40);
            this.signUpBtn.TabIndex = 4;
            this.signUpBtn.Text = "Sign Up";
            this.signUpBtn.UseVisualStyleBackColor = false;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Bold);
            this.textBox2.Location = new System.Drawing.Point(110, 99);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.PasswordChar = '*';
            this.textBox2.Size = new System.Drawing.Size(184, 30);
            this.textBox2.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(110, 54);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(184, 30);
            this.textBox1.TabIndex = 2;
            // 
            // passBtn
            // 
            this.passBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.passBtn.Location = new System.Drawing.Point(18, 99);
            this.passBtn.Name = "passBtn";
            this.passBtn.Size = new System.Drawing.Size(127, 34);
            this.passBtn.TabIndex = 1;
            this.passBtn.Text = "Password";
            // 
            // nameBtn
            // 
            this.nameBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.25F);
            this.nameBtn.Location = new System.Drawing.Point(18, 54);
            this.nameBtn.Name = "nameBtn";
            this.nameBtn.Size = new System.Drawing.Size(85, 34);
            this.nameBtn.TabIndex = 0;
            this.nameBtn.Text = "Name:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // errorProvider3
            // 
            this.errorProvider3.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(609, 332);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
