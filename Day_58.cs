//form.cs

using System.Diagnostics;
using System.Drawing.Text;


namespace C__Day58
{
    public partial class Form1 : Form
    {

        public int totalLists = 0;
        private int totalHeight = 27;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<string> todo_List = new List<string>();
            todo_List.Add("i will eat a banana tommorow");
            todo_List.Add("i will take shower today");
            totalLists += 2;


            for (int i = 0; totalLists > 0; i++)
            {
                totalHeight += 45;
                totalLists -= 1;


                Label label = CopyLabel(label1);
                label.Location = new Point(18, totalHeight);
                label.Text = todo_List[i];
                AllList.Controls.Add(label);
                label.Font = new Font("Arial", 13, FontStyle.Regular);
            }
        }
        public static Label CopyLabel(Label label)
        {
            Label l = new Label();
            l.Width = label.Width;
            l.Height = label.Height;
            l.Margin = label.Margin;
            l.Size = label.Size;
         return l;
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter_2(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}



//formdesign.cs

namespace C__Day58
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
            todoList = new GroupBox();
            AllList = new GroupBox();
            label1 = new Label();
            todoList.SuspendLayout();
            AllList.SuspendLayout();
            SuspendLayout();
            // 
            // todoList
            // 
            todoList.BackColor = Color.LightGray;
            todoList.Controls.Add(AllList);
            todoList.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            todoList.Location = new Point(205, 26);
            todoList.Name = "todoList";
            todoList.Size = new Size(387, 396);
            todoList.TabIndex = 0;
            todoList.TabStop = false;
            todoList.Text = "TODO LIST";
            todoList.Enter += groupBox1_Enter;
            // 
            // AllList
            // 
            AllList.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            AllList.Controls.Add(label1);
            AllList.Font = new Font("Segoe UI", 13F);
            AllList.Location = new Point(24, 94);
            AllList.Name = "AllList";
            AllList.Size = new Size(339, 282);
            AllList.TabIndex = 0;
            AllList.TabStop = false;
            AllList.Enter += groupBox1_Enter_2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 27);
            label1.Name = "label1";
            label1.Size = new Size(156, 25);
            label1.TabIndex = 0;
            label1.Text = "i will eat chocolate";
            label1.Click += label1_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(todoList);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            todoList.ResumeLayout(false);
            AllList.ResumeLayout(false);
            AllList.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox todoList;
        private GroupBox AllList;
        private Label label1;
        private Label label2;
    }
}
