namespace C__Day67
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            groupBox1 = new GroupBox();
            searchList = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            backBtn = new Button();
            ageBox = new TextBox();
            deptBox = new TextBox();
            nameBox = new TextBox();
            inputField = new TextBox();
            accountList = new DataGridView();
            NameColumn = new DataGridViewTextBoxColumn();
            Department = new DataGridViewTextBoxColumn();
            Age = new DataGridViewTextBoxColumn();
            emptyListLabel = new Label();
            accountLabel = new Label();
            clearBtn = new Button();
            delBtn = new Button();
            searchBtn = new Button();
            addBtn = new Button();
            hrLine_2 = new Label();
            universityLabel = new Label();
            hrLine_1 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)searchList).BeginInit();
            ((System.ComponentModel.ISupportInitialize)accountList).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(searchList);
            groupBox1.Controls.Add(backBtn);
            groupBox1.Controls.Add(ageBox);
            groupBox1.Controls.Add(deptBox);
            groupBox1.Controls.Add(nameBox);
            groupBox1.Controls.Add(inputField);
            groupBox1.Controls.Add(accountList);
            groupBox1.Controls.Add(emptyListLabel);
            groupBox1.Controls.Add(accountLabel);
            groupBox1.Controls.Add(clearBtn);
            groupBox1.Controls.Add(delBtn);
            groupBox1.Controls.Add(searchBtn);
            groupBox1.Controls.Add(addBtn);
            groupBox1.Controls.Add(hrLine_2);
            groupBox1.Controls.Add(universityLabel);
            groupBox1.Controls.Add(hrLine_1);
            groupBox1.FlatStyle = FlatStyle.Flat;
            groupBox1.Font = new Font("Segoe UI", 9F);
            groupBox1.Location = new Point(118, 11);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(515, 537);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Enter += groupBox1_Enter;
            // 
            // searchList
            // 
            searchList.AllowUserToAddRows = false;
            searchList.BackgroundColor = Color.MediumSeaGreen;
            searchList.BorderStyle = BorderStyle.Fixed3D;
            searchList.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            searchList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            searchList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            searchList.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3 });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            searchList.DefaultCellStyle = dataGridViewCellStyle2;
            searchList.Location = new Point(33, 159);
            searchList.Name = "searchList";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            searchList.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            searchList.RowTemplate.Height = 30;
            searchList.Size = new Size(453, 325);
            searchList.TabIndex = 12;
            searchList.Visible = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "Name";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            dataGridViewTextBoxColumn1.Width = 137;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "Department";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            dataGridViewTextBoxColumn2.Width = 137;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.HeaderText = "Age";
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            dataGridViewTextBoxColumn3.Width = 136;
            // 
            // backBtn
            // 
            backBtn.BackColor = SystemColors.Menu;
            backBtn.Font = new Font("Segoe Print", 13F, FontStyle.Bold);
            backBtn.Location = new Point(295, 83);
            backBtn.Name = "backBtn";
            backBtn.Size = new Size(107, 34);
            backBtn.TabIndex = 11;
            backBtn.Text = "BACK";
            backBtn.UseVisualStyleBackColor = false;
            backBtn.Visible = false;
            backBtn.Click += backBtn_Click;
            // 
            // ageBox
            // 
            ageBox.Location = new Point(272, 92);
            ageBox.Name = "ageBox";
            ageBox.Size = new Size(76, 23);
            ageBox.TabIndex = 10;
            ageBox.Visible = false;
            // 
            // deptBox
            // 
            deptBox.Location = new Point(136, 92);
            deptBox.Name = "deptBox";
            deptBox.Size = new Size(130, 23);
            deptBox.TabIndex = 9;
            deptBox.Visible = false;
            // 
            // nameBox
            // 
            nameBox.Location = new Point(20, 92);
            nameBox.Name = "nameBox";
            nameBox.Size = new Size(110, 23);
            nameBox.TabIndex = 8;
            nameBox.Visible = false;
            // 
            // inputField
            // 
            inputField.Location = new Point(20, 92);
            inputField.MaxLength = 40;
            inputField.Name = "inputField";
            inputField.Size = new Size(221, 23);
            inputField.TabIndex = 1;
            inputField.Visible = false;
            // 
            // accountList
            // 
            accountList.AllowUserToAddRows = false;
            accountList.BackgroundColor = Color.PaleTurquoise;
            accountList.BorderStyle = BorderStyle.Fixed3D;
            accountList.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            accountList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            accountList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            accountList.Columns.AddRange(new DataGridViewColumn[] { NameColumn, Department, Age });
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Window;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle5.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            accountList.DefaultCellStyle = dataGridViewCellStyle5;
            accountList.Location = new Point(33, 159);
            accountList.Name = "accountList";
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.Control;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            accountList.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            accountList.RowTemplate.Height = 30;
            accountList.Size = new Size(453, 325);
            accountList.TabIndex = 7;
            accountList.CellContentClick += dataGridView1_CellContentClick;
            // 
            // NameColumn
            // 
            NameColumn.HeaderText = "Name";
            NameColumn.Name = "NameColumn";
            NameColumn.ReadOnly = true;
            NameColumn.Width = 137;
            // 
            // Department
            // 
            Department.HeaderText = "Department";
            Department.Name = "Department";
            Department.ReadOnly = true;
            Department.Width = 137;
            // 
            // Age
            // 
            Age.HeaderText = "Age";
            Age.Name = "Age";
            Age.ReadOnly = true;
            Age.Width = 136;
            // 
            // emptyListLabel
            // 
            emptyListLabel.AutoSize = true;
            emptyListLabel.Font = new Font("Segoe UI", 25F);
            emptyListLabel.ForeColor = Color.Red;
            emptyListLabel.Location = new Point(44, 291);
            emptyListLabel.Name = "emptyListLabel";
            emptyListLabel.Size = new Size(358, 46);
            emptyListLabel.TabIndex = 1;
            emptyListLabel.Text = "There are no accounts.";
            emptyListLabel.Click += emptyListLabel_Click;
            // 
            // accountLabel
            // 
            accountLabel.AutoSize = true;
            accountLabel.Font = new Font("Segoe UI Semibold", 15F);
            accountLabel.ForeColor = Color.CornflowerBlue;
            accountLabel.Location = new Point(174, 128);
            accountLabel.Name = "accountLabel";
            accountLabel.Size = new Size(119, 28);
            accountLabel.TabIndex = 1;
            accountLabel.Text = "ACCOUNTS:";
            accountLabel.Click += accountLabel_Click;
            // 
            // clearBtn
            // 
            clearBtn.BackColor = SystemColors.Menu;
            clearBtn.Font = new Font("Segoe Print", 13F, FontStyle.Bold);
            clearBtn.Location = new Point(408, 83);
            clearBtn.Name = "clearBtn";
            clearBtn.Size = new Size(107, 34);
            clearBtn.TabIndex = 6;
            clearBtn.Text = "CLEAR";
            clearBtn.UseVisualStyleBackColor = false;
            clearBtn.Click += clearBtn_Click;
            // 
            // delBtn
            // 
            delBtn.BackColor = SystemColors.Menu;
            delBtn.Font = new Font("Segoe Print", 13F, FontStyle.Bold);
            delBtn.Location = new Point(272, 83);
            delBtn.Name = "delBtn";
            delBtn.Size = new Size(130, 34);
            delBtn.TabIndex = 5;
            delBtn.Text = "DELETE";
            delBtn.UseVisualStyleBackColor = false;
            delBtn.Click += delBtn_Click;
            // 
            // searchBtn
            // 
            searchBtn.BackColor = SystemColors.Menu;
            searchBtn.Font = new Font("Segoe Print", 13F, FontStyle.Bold);
            searchBtn.Location = new Point(119, 83);
            searchBtn.Name = "searchBtn";
            searchBtn.Size = new Size(132, 34);
            searchBtn.TabIndex = 4;
            searchBtn.Text = "SEARCH";
            searchBtn.UseVisualStyleBackColor = false;
            searchBtn.Click += searchBtn_Click;
            // 
            // addBtn
            // 
            addBtn.BackColor = SystemColors.Menu;
            addBtn.Cursor = Cursors.Cross;
            addBtn.FlatAppearance.BorderColor = Color.Black;
            addBtn.Font = new Font("Segoe Print", 13F, FontStyle.Bold);
            addBtn.ForeColor = SystemColors.ActiveCaptionText;
            addBtn.Location = new Point(6, 83);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(107, 34);
            addBtn.TabIndex = 3;
            addBtn.Text = "ADD";
            addBtn.UseVisualStyleBackColor = false;
            addBtn.Click += addBtn_Click;
            // 
            // hrLine_2
            // 
            hrLine_2.BorderStyle = BorderStyle.Fixed3D;
            hrLine_2.Location = new Point(6, 126);
            hrLine_2.Name = "hrLine_2";
            hrLine_2.Size = new Size(507, 2);
            hrLine_2.TabIndex = 2;
            // 
            // universityLabel
            // 
            universityLabel.AutoSize = true;
            universityLabel.Font = new Font("Sitka Small", 25F, FontStyle.Bold);
            universityLabel.Location = new Point(54, 9);
            universityLabel.Name = "universityLabel";
            universityLabel.Size = new Size(432, 50);
            universityLabel.TabIndex = 1;
            universityLabel.Text = "MEHRAN UNIVERSITY";
            universityLabel.Click += universityLabel_Click;
            // 
            // hrLine_1
            // 
            hrLine_1.BorderStyle = BorderStyle.Fixed3D;
            hrLine_1.Location = new Point(6, 72);
            hrLine_1.Name = "hrLine_1";
            hrLine_1.Size = new Size(507, 2);
            hrLine_1.TabIndex = 0;
            hrLine_1.Click += hrLine_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(800, 598);
            Controls.Add(groupBox1);
            Font = new Font("Segoe UI", 9F);
            MaximizeBox = false;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)searchList).EndInit();
            ((System.ComponentModel.ISupportInitialize)accountList).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label hrLine_1;
        private Label universityLabel;
        private Label hrLine_2;
        private Button addBtn;
        private Button clearBtn;
        private Button delBtn;
        private Button searchBtn;
        private Label accountLabel;
        private Label emptyListLabel;
        private DataGridView accountList;
        private TextBox inputField;
        private TextBox ageBox;
        private TextBox deptBox;
        private TextBox nameBox;
        private Button backBtn;
        private DataGridViewTextBoxColumn NameColumn;
        private DataGridViewTextBoxColumn Department;
        private DataGridViewTextBoxColumn Age;
        private DataGridView searchList;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}
