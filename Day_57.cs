//form.cs _ corrupted

//formdesign.cs


namespace C__Day57
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
            TODOLIST = new Label();
            listItems = new Label();
            item = new Label();
            groupBox1 = new GroupBox();
            button1 = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // TODOLIST
            // 
            TODOLIST.AutoSize = true;
            TODOLIST.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            TODOLIST.ForeColor = Color.DimGray;
            TODOLIST.Location = new Point(45, 53);
            TODOLIST.Name = "TODOLIST";
            TODOLIST.Size = new Size(182, 45);
            TODOLIST.TabIndex = 0;
            TODOLIST.Text = "TODO LIST";
            // 
            // listItems
            // 
            listItems.AutoSize = true;
            listItems.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            listItems.Location = new Point(75, 108);
            listItems.Name = "listItems";
            listItems.Size = new Size(113, 28);
            listItems.TabIndex = 1;
            listItems.Text = "List Items: 0";
            // 
            // item
            // 
            item.AutoSize = true;
            item.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            item.ForeColor = Color.Snow;
            item.Location = new Point(6, 16);
            item.Name = "item";
            item.Size = new Size(165, 25);
            item.TabIndex = 2;
            item.Text = "i will eat a banana";
            item.Click += item_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(item);
            groupBox1.Location = new Point(33, 178);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(236, 51);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            // 
            // button1
            // 
            button1.Location = new Point(182, 18);
            button1.Name = "button1";
            button1.Size = new Size(48, 26);
            button1.TabIndex = 3;
            button1.Text = "DEL";
            button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCoral;
            ClientSize = new Size(284, 450);
            Controls.Add(groupBox1);
            Controls.Add(listItems);
            Controls.Add(TODOLIST);
            Name = "Form1";
            Text = "ToDo List";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label TODOLIST;
        private Label listItems;
        private Label item;
        private GroupBox groupBox1;
        private Button button1;
    }
}
