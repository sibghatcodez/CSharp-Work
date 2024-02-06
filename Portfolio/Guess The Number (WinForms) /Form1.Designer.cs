namespace C__Day55
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
            result = new Label();
            label3 = new Label();
            triesLbl = new Label();
            guessBtn = new Button();
            alertLbl = new Label();
            guessBox = new TextBox();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ControlLight;
            groupBox1.Controls.Add(result);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(triesLbl);
            groupBox1.Controls.Add(guessBtn);
            groupBox1.Controls.Add(alertLbl);
            groupBox1.Controls.Add(guessBox);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(160, 60);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(428, 329);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Game";
            // 
            // result
            // 
            result.AutoSize = true;
            result.Font = new Font("Segoe UI", 65F, FontStyle.Regular, GraphicsUnit.Point);
            result.Location = new Point(6, 72);
            result.Name = "result";
            result.Size = new Size(0, 116);
            result.TabIndex = 7;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Red;
            label3.Location = new Point(224, 14);
            label3.Name = "label3";
            label3.Size = new Size(233, 38);
            label3.TabIndex = 6;
            label3.Text = "TRIES REMAINING";
            // 
            // triesLbl
            // 
            triesLbl.Font = new Font("Segoe UI", 170F, FontStyle.Regular, GraphicsUnit.Point);
            triesLbl.Location = new Point(209, 0);
            triesLbl.Name = "triesLbl";
            triesLbl.Size = new Size(264, 387);
            triesLbl.TabIndex = 4;
            triesLbl.Text = "2";
            triesLbl.Click += triesLbl_Click;
            // 
            // guessBtn
            // 
            guessBtn.Location = new Point(57, 288);
            guessBtn.Name = "guessBtn";
            guessBtn.Size = new Size(111, 36);
            guessBtn.TabIndex = 3;
            guessBtn.Text = "Guess!";
            guessBtn.UseVisualStyleBackColor = true;
            guessBtn.Click += guessBtn_Click;
            // 
            // alertLbl
            // 
            alertLbl.AutoSize = true;
            alertLbl.Font = new Font("Sylfaen", 16F, FontStyle.Regular, GraphicsUnit.Point);
            alertLbl.Location = new Point(38, 197);
            alertLbl.Name = "alertLbl";
            alertLbl.Size = new Size(114, 28);
            alertLbl.TabIndex = 2;
            alertLbl.Text = "from 1 to 5";
            // 
            // guessBox
            // 
            guessBox.Font = new Font("Segoe UI", 17F, FontStyle.Regular, GraphicsUnit.Point);
            guessBox.Location = new Point(16, 228);
            guessBox.Name = "guessBox";
            guessBox.Size = new Size(187, 38);
            guessBox.TabIndex = 1;
            guessBox.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Rockwell Condensed", 27F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(38, 61);
            label1.Name = "label1";
            label1.Size = new Size(143, 94);
            label1.TabIndex = 0;
            label1.Text = "Guess the\r\nnumber";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(767, 450);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private TextBox guessBox;
        private Label alertLbl;
        private Button guessBtn;
        private Label triesLbl;
        private Label label3;
        private Label result;
    }
}
