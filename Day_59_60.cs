//form.cs


using System.Diagnostics;
using System.Drawing.Text;


namespace C__Day58
{
    public partial class Form1 : Form
    {

        public int totalLists = 0;
        private int listsHeight = 25;
        public List<string> todo_List = new List<string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            todo_List.Add("I will eat a banana tommorow");
            todo_List.Add("I will take shower today");
            todo_List.Add("Eat shawarma today with bebzi");
            totalLists = todo_List.Count;


            if (totalLists < 0) itemsContainer.Visible = false;
            else
            {
                for (int i = 0; i < totalLists; i++)
                {
                    Label lbl = new Label();
                    itemsContainer.Controls.Add(lbl);


                    lbl.Location = new Point(29, listsHeight);
                    lbl.Font = new Font(Font.Name, 13, FontStyle.Regular);
                    listsHeight += 40;
                    lbl.Text = "- " + todo_List[i];
                    lbl.AutoSize = true;
                }
            }

            itemsContainer.AutoScroll = true;
        }
        public void LoadForm()
        {
            todo_List.Add("I will eat a banana tommorow");
            todo_List.Add("I will take shower today");
            todo_List.Add("Eat shawarma today with bebzi");
            totalLists = todo_List.Count;


            if (totalLists < 0) itemsContainer.Visible = false;
            else
            {
                for (int i = 0; i < totalLists; i++)
                {
                    Label lbl = new Label();
                    itemsContainer.Controls.Add(lbl);


                    lbl.Location = new Point(29, listsHeight);
                    lbl.Font = new Font(Font.Name, 13, FontStyle.Regular);
                    listsHeight += 40;
                    lbl.Text = "- " + todo_List[i];
                    lbl.AutoSize = true;
                }
            }

            itemsContainer.AutoScroll = true;
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

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void label1_Click_3(object sender, EventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {

            if (inputList.Text.Length == 0)
            {
                inputList.Text = "List cannot be empty.";
                await Task.Delay(1500);
                inputList.Text = "";
            } else
            {
                todo_List.Add(inputList.Text);
               // LoadForm();
                foreach(var list in todo_List)
                {
                    Debug.WriteLine(list);
                }
            }
            Form1 frm = new Form1();
            frm.Show();
        }

        private void inputList_TextChanged(object sender, EventArgs e)
        {

        }

        private async void clearBtn_Click(object sender, EventArgs e)
        {
            if (inputList.Text.Length == 0)
            {
                inputList.Text = "List is already empty.";
                await Task.Delay(1500);
                inputList.Text = "";
            } else inputList.Text = "";
        }
    }
}


//formdesigner.cs

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
            clearBtn = new Button();
            submitBtn = new Button();
            inputList = new TextBox();
            itemsContainer = new Panel();
            todoList.SuspendLayout();
            SuspendLayout();
            // 
            // todoList
            // 
            todoList.BackColor = Color.LightGray;
            todoList.Controls.Add(clearBtn);
            todoList.Controls.Add(submitBtn);
            todoList.Controls.Add(inputList);
            todoList.Controls.Add(itemsContainer);
            todoList.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            todoList.Location = new Point(205, 26);
            todoList.Name = "todoList";
            todoList.Size = new Size(387, 396);
            todoList.TabIndex = 0;
            todoList.TabStop = false;
            todoList.Text = "TODO LIST";
            todoList.Enter += groupBox1_Enter;
            // 
            // clearBtn
            // 
            clearBtn.BackColor = Color.LightCoral;
            clearBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            clearBtn.Location = new Point(82, 90);
            clearBtn.Name = "clearBtn";
            clearBtn.Size = new Size(67, 25);
            clearBtn.TabIndex = 3;
            clearBtn.Text = "CLEAR";
            clearBtn.UseVisualStyleBackColor = false;
            clearBtn.Click += clearBtn_Click;
            // 
            // submitBtn
            // 
            submitBtn.BackColor = Color.MediumAquamarine;
            submitBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            submitBtn.Location = new Point(219, 90);
            submitBtn.Name = "submitBtn";
            submitBtn.Size = new Size(60, 25);
            submitBtn.TabIndex = 2;
            submitBtn.Text = "ADD";
            submitBtn.UseVisualStyleBackColor = false;
            submitBtn.Click += button1_Click;
            // 
            // inputList
            // 
            inputList.Font = new Font("Segoe UI", 13F, FontStyle.Italic);
            inputList.Location = new Point(49, 54);
            inputList.Name = "inputList";
            inputList.PlaceholderText = "Enter list";
            inputList.Size = new Size(274, 31);
            inputList.TabIndex = 1;
            inputList.TextChanged += inputList_TextChanged;
            // 
            // itemsContainer
            // 
            itemsContainer.BackColor = SystemColors.ButtonFace;
            itemsContainer.Location = new Point(27, 121);
            itemsContainer.Name = "itemsContainer";
            itemsContainer.Size = new Size(335, 253);
            itemsContainer.TabIndex = 0;
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
            todoList.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox todoList;
        private Panel itemsContainer;
        private TextBox inputList;
        private Button submitBtn;
        private Button clearBtn;
    }
}
