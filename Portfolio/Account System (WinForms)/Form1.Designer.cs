namespace C__Day54
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            signBtn = new Button();
            cancelBtn = new Button();
            femaleRadio = new RadioButton();
            maleRadio = new RadioButton();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            ageBtn = new Label();
            nameBtn = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.InactiveCaption;
            groupBox1.Controls.Add(signBtn);
            groupBox1.Controls.Add(cancelBtn);
            groupBox1.Controls.Add(femaleRadio);
            groupBox1.Controls.Add(maleRadio);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(ageBtn);
            groupBox1.Controls.Add(nameBtn);
            groupBox1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.ForeColor = SystemColors.ControlText;
            groupBox1.Location = new Point(235, 44);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(251, 340);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Sign Up";
            // 
            // signBtn
            // 
            signBtn.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            signBtn.Location = new Point(123, 255);
            signBtn.Name = "signBtn";
            signBtn.Size = new Size(104, 40);
            signBtn.TabIndex = 7;
            signBtn.Text = "Sign Up";
            signBtn.UseVisualStyleBackColor = true;
            signBtn.Click += button2_Click;
            // 
            // cancelBtn
            // 
            cancelBtn.Location = new Point(12, 255);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(96, 40);
            cancelBtn.TabIndex = 6;
            cancelBtn.Text = "Cancel";
            cancelBtn.UseVisualStyleBackColor = true;
            cancelBtn.Click += button1_Click;
            // 
            // femaleRadio
            // 
            femaleRadio.AutoSize = true;
            femaleRadio.Location = new Point(94, 188);
            femaleRadio.Name = "femaleRadio";
            femaleRadio.Size = new Size(90, 29);
            femaleRadio.TabIndex = 5;
            femaleRadio.TabStop = true;
            femaleRadio.Text = "Female";
            femaleRadio.UseVisualStyleBackColor = true;
            femaleRadio.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // maleRadio
            // 
            maleRadio.AutoSize = true;
            maleRadio.Location = new Point(16, 188);
            maleRadio.Name = "maleRadio";
            maleRadio.Size = new Size(72, 29);
            maleRadio.TabIndex = 4;
            maleRadio.TabStop = true;
            maleRadio.Text = "Male";
            maleRadio.UseVisualStyleBackColor = true;
            maleRadio.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(92, 133);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(80, 32);
            textBox2.TabIndex = 3;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(92, 73);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(135, 32);
            textBox1.TabIndex = 2;
            // 
            // ageBtn
            // 
            ageBtn.AutoSize = true;
            ageBtn.Font = new Font("Segoe UI", 19F, FontStyle.Regular, GraphicsUnit.Point);
            ageBtn.Location = new Point(12, 128);
            ageBtn.Name = "ageBtn";
            ageBtn.Size = new Size(67, 36);
            ageBtn.TabIndex = 1;
            ageBtn.Text = "Age:";
            ageBtn.Click += label2_Click;
            // 
            // nameBtn
            // 
            nameBtn.AutoSize = true;
            nameBtn.Font = new Font("Segoe UI", 17F, FontStyle.Regular, GraphicsUnit.Point);
            nameBtn.Location = new Point(6, 71);
            nameBtn.Name = "nameBtn";
            nameBtn.Size = new Size(80, 31);
            nameBtn.TabIndex = 0;
            nameBtn.Text = "Name:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label ageBtn;
        private Label nameBtn;
        private RadioButton maleRadio;
        private TextBox textBox2;
        private TextBox textBox1;
        private RadioButton femaleRadio;
        private Button cancelBtn;
        private Button signBtn;
    }
}
