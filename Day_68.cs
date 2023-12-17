//form1.cs
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Security.Principal;
using System.Text.Json;

namespace C__Day67
{
    public partial class Form1 : Form
    {

        public static string userName;
        public static int userAge;
        public static string userDepartment;
        public static string filePath = "E:accounts.json";
        public static List<Account> accounts = new List<Account>();
        public int totalRows = 0;
        public static bool processCompleted = true;
        public bool isAddBtnClicked = false;
        public bool isClearBtnClicked = false;
        public bool isDeleteBtnClicked = false;
        public bool isSearchBtnClicked = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadAccounts();
            SaveAccount();

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void hrLine_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            accounts.Clear();
            Console.WriteLine("\n\t\t\t Account List has been cleared");
            var emptyFile =
@"[
  {
  }
]";
            File.WriteAllText(filePath, emptyFile);
        }

        private void delBtn_Click(object sender, EventArgs e)
        {
            DelBtnClicked();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            SearchAccount();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            AddBtnClicked();
            SaveAccount();
        }

        private void emptyListLabel_Click(object sender, EventArgs e)
        {

        }

        private void universityLabel_Click(object sender, EventArgs e)
        {

        }

        private void accountLabel_Click(object sender, EventArgs e)
        {

        }


        public static void SearchAccount()
        {
            Console.Write("Enter account name you want to search: \t");
            string searchedAccount = Console.ReadLine();
            bool accountFound = false;
            int accountsWithSameName = 0;
            List<Account> ListOfAccounts = new List<Account>();


            foreach (Account account in accounts)
            {
                if (account.Name == searchedAccount) accountsWithSameName++;
            }

            foreach (Account account in accounts)
            {
                if (accountsWithSameName == 0)
                {
                    if (account.Name == searchedAccount)
                    {
                        Console.WriteLine("\tAccount Found! Details ->");
                        var details = "\t\tName: " + account.Name + "| Department: " + account.Department + "| Age:" + account.Age;
                        Console.WriteLine(details);
                        processCompleted = true;
                        accountFound = true;
                    }
                }



                else if (accountsWithSameName > 0)
                {
                    if (account.Name == searchedAccount)
                    {
                        ListOfAccounts.Add(account);
                        accountFound = true;
                    }
                }
            }
            if (!accountFound)
            {
                Console.WriteLine("Error 404: Account not found :/.");
                processCompleted = true;
            }

            var dataToShow = ListOfAccounts.OrderBy(user => user.Age);
            //var dataToShow = ListOfAccounts.OrderByDescending(user => user.Age);
            foreach (var item in dataToShow)
            {
                Console.WriteLine("\tAccount Found! Details ->");
                var details = "\t\tName: " + item.Name + "| Department: " + item.Department + "| Age:" + item.Age;
                Console.WriteLine(details);
                processCompleted = true;
                accountFound = true;
            }
        }
        public async void DelBtnClicked()
        {

            if (!isDeleteBtnClicked)
            {

                clearBtn.Visible = false;
                addBtn.Visible = false;
                delBtn.Location = new Point(408, 83);
                delBtn.Visible = true;
                searchBtn.Visible = false;
                emptyListLabel.Visible = true;
                accountList.Visible = false;
                nameBox.Visible = false;
                deptBox.Visible = false;
                ageBox.Visible = false;
                inputField.Visible = true;
                backBtn.Visible = true;
                inputField.PlaceholderText = "Enter acc name to delete";
                isDeleteBtnClicked = true;
    }

            else
            {
                string searchedAccount = inputField.Text;
                bool accountFound = false;
                int i = 0;
                foreach (Account account in accounts)
                {
                    i++;
                    if (account.Name == searchedAccount)
                    {
                        emptyListLabel.Text = "SUCCESS! Account has been deleted.";
                        emptyListLabel.Font = new Font(Font.FontFamily, 20);
                        inputField.Text = string.Empty;
                        processCompleted = true;
                        accountFound = true;
                        isDeleteBtnClicked = false;
                        accounts.Remove(account);
                        accountList.Rows.RemoveAt(i-1);
                        totalRows--;
                        SaveAccount();


                        await Task.Delay(1500);
                        emptyListLabel.Text = "There are no accounts :/";
                        emptyListLabel.Visible = false;
                        clearBtn.Visible = true;
                        addBtn.Visible = true;
                        delBtn.Location = new Point(272, 83);
                        delBtn.Visible = true;
                        searchBtn.Visible = true;
                        accountList.Visible = true;
                        inputField.Visible = false;
                        backBtn.Visible = false;

                        if (totalRows == 0)
                        {
                            accountList.Visible = false;
                            emptyListLabel.Visible = true;
                        }
                        break;
                    }
                }
                if (!accountFound)
                {
                    emptyListLabel.Text = "Error 404: Account not found :\\";
                    /*await Task.Delay(1500);
                    emptyListLabel.Text = "There are no accounts";
                    inputField.Text = string.Empty;
                    emptyListLabel.Visible = false;
                    clearBtn.Visible = true;
                    addBtn.Visible = true;
                    delBtn.Location = new Point(272, 83);
                    delBtn.Visible = true;
                    searchBtn.Visible = true;
                    accountList.Visible = true;
                    inputField.Visible = false;
                    isDeleteBtnClicked = false;
                    processCompleted = true;*/
                }

            }
        }

        public void SaveAccount()
        {
            JsonSerializerOptions options = new JsonSerializerOptions()
            {
                WriteIndented = true
            };


            string jsonString = JsonSerializer.Serialize(accounts, options);
            File.WriteAllText(filePath, jsonString);
        }


        public void LoadAccounts()
        {
            if (File.Exists(filePath))
            {
                var fileContent = File.ReadAllText(filePath);
                JsonSerializerOptions options = new JsonSerializerOptions()
                {
                    WriteIndented = true
                };
                if (fileContent.Length > 2)
                {
                    List<Account> jsonData = JsonSerializer.Deserialize<List<Account>>(fileContent, options);
                    foreach (var item in jsonData)
                    {
                        if (item.Age > 0)
                        {
                            accounts.Add(item);
                            totalRows++;
                            accountList.Rows.Add(item.Name, item.Department, item.Age);
                        }
                    }
                }
            }

            if(totalRows == 0)
            {
                accountList.Visible = false;
                emptyListLabel.Visible = true;
            }
        }

        public async void AddBtnClicked()
        {
            var backBtnLoc = new Point(295, 83);


            if (!isAddBtnClicked)
            {
                clearBtn.Visible = false;
                addBtn.Location = new Point(408, 83);
                addBtn.Text = "Add Acc";
                delBtn.Visible = false;
                searchBtn.Visible = false;
                accountList.Visible = false;
                //inputField.PlaceholderText = "Enter account name";
                nameBox.Visible = true;
                nameBox.PlaceholderText = "Amjad";
                deptBox.Visible = true;
                deptBox.PlaceholderText = "Paleontology";
                ageBox.Visible = true;
                ageBox.PlaceholderText = "25";
                backBtn.Location = new Point(20, 490);
                backBtn.Visible = true;

                isAddBtnClicked = true;
            }
            else
            {
                if (nameBox.Text == string.Empty || deptBox.Text == string.Empty || ageBox.Text == string.Empty)
                {
                    var accountLabelText = accountLabel.Text;
                    accountLabel.Text = "Fill all 3 fields.";
                    await Task.Delay(1500);
                    accountLabel.Text = accountLabelText;
                }
                else
                {
                    userName = nameBox.Text;

                    userDepartment = deptBox.Text;
                    try {
                    userAge = int.Parse(ageBox.Text);
                    } catch(Exception ex) { Debug.WriteLine(ex.Message);  }


                    processCompleted = true;

                    Account account = new Account()
                    {
                        Name = userName,
                        Department = userDepartment,
                        Age = userAge,
                    };
                    accounts.Add(account);
                    isAddBtnClicked = false;
                    emptyListLabel.Text = "Account added successfully";
                    accountList.Rows.Add(userName, userDepartment, userAge);
                    totalRows++;

                    await Task.Delay(1500);
                    emptyListLabel.Text = "Accounts";
                    clearBtn.Visible = true;
                    addBtn.Location = new Point(6, 83);
                    addBtn.Text = "Add";
                    delBtn.Visible = true;
                    searchBtn.Visible = true;
                    accountList.Visible = true;
                    nameBox.Visible = false;
                    deptBox.Visible = false;
                    ageBox.Visible = false;
                    backBtn.Location = backBtnLoc;
                    backBtn.Visible = false;
                }
            }
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
                emptyListLabel.Text = "There are no accounts";
                emptyListLabel.Visible = false;
                clearBtn.Visible = true;
                inputField.Text = string.Empty;
                addBtn.Visible = true;
                delBtn.Location = new Point(272, 83);
                delBtn.Visible = true;
                searchBtn.Visible = true;
                accountList.Visible = true;
                inputField.Visible = false;
                backBtn.Visible = false;
                isDeleteBtnClicked = false;
        }
    }
    public class Account
    {
        public string Name { get; set; }
        public string Department { get; set; }
        public int Age { get; set; }
    }



}


//formdesign.cs

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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            groupBox1 = new GroupBox();
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
            ((System.ComponentModel.ISupportInitialize)accountList).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
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
            groupBox1.Size = new Size(515, 522);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Enter += groupBox1_Enter;
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
            accountList.Location = new Point(0, 159);
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
            accountList.Size = new Size(484, 325);
            accountList.TabIndex = 7;
            accountList.CellContentClick += dataGridView1_CellContentClick;
            // 
            // NameColumn
            // 
            NameColumn.HeaderText = "Name";
            NameColumn.Name = "NameColumn";
            NameColumn.ReadOnly = true;
            NameColumn.Width = 135;
            // 
            // Department
            // 
            Department.HeaderText = "Department";
            Department.Name = "Department";
            Department.ReadOnly = true;
            Department.Width = 135;
            // 
            // Age
            // 
            Age.HeaderText = "Age";
            Age.Name = "Age";
            Age.ReadOnly = true;
            Age.Width = 135;
            // 
            // emptyListLabel
            // 
            emptyListLabel.AutoSize = true;
            emptyListLabel.Font = new Font("Segoe UI", 25F);
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
        private DataGridViewTextBoxColumn NameColumn;
        private DataGridViewTextBoxColumn Department;
        private DataGridViewTextBoxColumn Age;
        private Button backBtn;
    }
}
