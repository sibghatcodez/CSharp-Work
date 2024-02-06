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

        private async void clearBtn_Click(object sender, EventArgs e)
        {
            if (accounts.Count == 0)
            {
                EmptyListText(true, "List is already cleared!", Color.Red);
                await Task.Delay(1500);
                EmptyListText(true, "There are no accounts", Color.Red);
            }
            else
            {
                accounts.Clear();
                accountList.Rows.Clear();

                var emptyFile =
    @"[
  {
  }
]";

                SaveAccount();
                File.WriteAllText(filePath, emptyFile);

                accountList.Visible = false;
                EmptyListText(true, "Account List has been cleared!", Color.Green);
                await Task.Delay(1500);
                EmptyListText(true, "There are no accounts", Color.Red);
                accountList.Visible = false;
            }
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


        public async void SearchAccount()
        {
            if (!isSearchBtnClicked)
            {

                inputField.Visible = true;
                clearBtn.Visible = false;
                delBtn.Visible = false;
                addBtn.Visible = false;
                accountList.Visible = false;
                emptyListLabel.Visible = false;
                backBtn.Visible = true;

                inputField.PlaceholderText = "Search account...";
                isSearchBtnClicked = true;

                searchBtn.Location = new Point(272, 83);
                backBtn.Location = new Point(clearBtn.Location.X, clearBtn.Location.Y);
            }

            else
            {
                if (searchList.Rows.Count > 0) searchList.Rows.Clear();

                if (inputField.Text == string.Empty)
                {
                    EmptyListText(true, "Enter Account name to search!", Color.Red);
                    await Task.Delay(1500);
                    emptyListLabel.Visible = false;
                }
                else
                {

                    string searchedAccount = inputField.Text;
                    bool accountFound = false;
                    int accountsWithSameName = 0;
                    List<Account> ListOfAccounts = new List<Account>();

                    //Fining accounts with same name...
                    foreach (Account account in accounts)
                    {
                        if (account.Name == searchedAccount) accountsWithSameName++;
                        else accountFound = false;
                    }

                    //Iterating over accounts
                    foreach (Account account in accounts)
                    {

                        switch (accountsWithSameName)
                        {
                            case 0:
                                if (account.Name == searchedAccount)
                                {
                                    searchList.Rows.Add(account.Name, account.Department, account.Age);
                                    processCompleted = true;
                                    accountFound = true;
                                }
                                break;


                            case 1:
                            case 2:
                            case 3:
                            case 4:
                                if (account.Name == searchedAccount)
                                {
                                    ListOfAccounts.Add(account);
                                    accountFound = true;
                                }
                                break;
                        }
                    }


                    if (!accountFound)
                    {
                        EmptyListText(true, "Account not found :/", Color.Red);
                        processCompleted = true;
                        searchList.Visible = false;
                    }
                    else
                    {


                        if (accountsWithSameName > 0)
                        {
                            emptyListLabel.Visible = false;
                            searchList.Visible = true;
                            var dataToShow = ListOfAccounts.OrderBy(user => user.Age);
                            //var dataToShow = ListOfAccounts.OrderByDescending(user => user.Age);

                            foreach (var item in dataToShow)
                            {
                                accountLabel.Text = "Searched Account(s)";
                                searchList.Rows.Add(item.Name, item.Department, item.Age);
                                processCompleted = true;
                                accountFound = true;
                            }
                        }
                    }
                }
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
                emptyListLabel.Visible = false;
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
                        emptyListLabel.Font = new Font(Font.FontFamily, 20);

                        EmptyListText(true, "SUCCESS! Account has been deleted.", Color.Green);

                        inputField.Text = string.Empty;
                        processCompleted = true;
                        accountFound = true;
                        isDeleteBtnClicked = false;
                        accounts.Remove(account);
                        accountList.Rows.RemoveAt(i - 1);
                        totalRows--;
                        SaveAccount();


                        await Task.Delay(1500);
                        EmptyListText(true, "There are no accounts :\\", Color.Red);
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
                    EmptyListText(true, "Error: Account not found :\\", Color.Red);
                }

            }
        }
        public void EmptyListText(bool tOrF, string msg, Color col)
        {
            emptyListLabel.Visible = tOrF;
            emptyListLabel.Text = msg;
            emptyListLabel.ForeColor = col;
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

            if (totalRows == 0)
            {
                accountList.Visible = false;
                emptyListLabel.Visible = true;
            }
        }

        public async void AddBtnClicked()
        {
            if (!isAddBtnClicked)
            {
                clearBtn.Visible = false;
                addBtn.Location = new Point(408, 83);
                addBtn.Text = "Add Acc";
                delBtn.Visible = false;
                searchBtn.Visible = false;
                accountList.Visible = true;
                nameBox.Visible = true;
                nameBox.PlaceholderText = "John Doe";
                deptBox.Visible = true;
                deptBox.PlaceholderText = "Paleontology";
                ageBox.Visible = true;
                ageBox.PlaceholderText = "25";
                backBtn.Location = new Point(20, 490);
                backBtn.Visible = true;

                isAddBtnClicked = true;
                emptyListLabel.Visible = false;
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
                    try
                    {
                        userAge = int.Parse(ageBox.Text);
                    }
                    catch (Exception ex) { Debug.WriteLine(ex.Message); }


                    processCompleted = true;

                    Account account = new Account()
                    {
                        Name = userName,
                        Department = userDepartment,
                        Age = userAge,
                    };

                    accounts.Add(account);
                    isAddBtnClicked = false;
                    accountList.Visible = false;
                    EmptyListText(true, "Account added successfully", Color.Green);
                    accountList.Rows.Add(userName, userDepartment, userAge);
                    totalRows++;

                    await Task.Delay(1500);

                    delBtn.Visible = true;
                    clearBtn.Visible = true;
                    searchBtn.Visible = true;
                    accountList.Visible = true;
                    nameBox.Visible = false;
                    deptBox.Visible = false;
                    ageBox.Visible = false;
                    backBtn.Visible = false;

                    backBtn.Location = new Point(295, 83);
                    addBtn.Location = new Point(6, 83);

                    addBtn.Text = "Add";
                }
            }
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            searchList.Rows.Clear();


            searchList.Visible = false;
            clearBtn.Visible = true;
            addBtn.Visible = true;
            delBtn.Visible = true;
            searchBtn.Visible = true;
            inputField.Visible = false;
            backBtn.Visible = false;
            nameBox.Visible = false;
            ageBox.Visible = false;
            deptBox.Visible = false;


            inputField.Text = string.Empty;
            addBtn.Text = "Add";

            delBtn.Location = new Point(272, 83);
            addBtn.Location = new Point(6, 83);
            addBtn.Location = new Point(6, 83);
            backBtn.Location = new Point(295, 83);
            searchBtn.Location = new Point(119, 83);

            isAddBtnClicked = false;
            isDeleteBtnClicked = false;
            isSearchBtnClicked = false;


            if (totalRows == 0)
            {
                accountList.Visible = false;
                emptyListLabel.Visible = true;
            }
            else
            {
                accountList.Visible = true;
                emptyListLabel.Visible = false;
            }
        }
    }





    public class Account
    {
        public string Name { get; set; }
        public string Department { get; set; }
        public int Age { get; set; }
    }



}
