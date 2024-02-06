using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Data.Common;
using System.Diagnostics;
using System.Text.Json;
using System.Windows.Forms.VisualStyles;
using System.Xml.Linq;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;


namespace C__Day81
{
    public partial class Form1 : Form
    {
        public string connectionString = "datasource=localhost;port=3306;user=root;database=master;pwd=";
        public MySqlConnection connection = new MySqlConnection();
        public string query = "Empty query";
        public MySqlCommand command = new MySqlCommand();
        public int DatabasesCount = 0;
        public string selectedDatabase = "None";
        public string currentTable = "None";
        public Form1()
        {
            InitializeComponent();

            groupBox1.Select();
            connection = new MySqlConnection(connectionString);

            try
            {
                connection.Open();
                command = new MySqlCommand();
                command.Connection = connection;
                command.CommandText = "SHOW DATABASES";

                using (MySqlDataReader reader = command.ExecuteReader())


                {   //db_ListView Scope
                    db_ListView.View = View.Details;
                    dbInfo_Lbl.Visible = reader.Read() ? false : true;

                    db_ListView.Columns.Add("Database", 200);
                    db_ListView.Columns.Add("Tables", 125);

                    byte totalRows = 0;
                    string[] dbData = new string[2];

                    while (reader.Read())
                    {
                        DatabasesCount++;
                        string dbName = reader["Database"]?.ToString() ?? "false";
                        totalRows = 0;

                        //  DB Tables Rows Loading
                        try
                        {
                            if (dbName != "false")
                                foreach (var d in ListTables(dbName)) totalRows++;
                        }
                        catch (Exception ex) { Debug.WriteLine(ex.Message); }
                        //  DB Tables Rows Loaded


                        dbData[0] = dbName;
                        dbData[1] = totalRows.ToString();


                        ListViewItem item = new ListViewItem(dbData);
                        db_ListView.Items.Add(item);

                    }
                }   //db_ListView Scope End
                totalDatabases_Lbl.Text = $"Databases Count: ({DatabasesCount})";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if ((connection.State == ConnectionState.Open))
                {
                    connection.Close();
                }
            }

        }

        private void printindex(object? sender, EventArgs e)
        {
            Debug.WriteLine(searchItem_dropDown.SelectedIndex);
        }

        public IList<string> ListTables(string dbName)
        {
            string connectionStringTemp = $"datasource=localhost;port=3306;user=root;database={dbName};pwd=";
            MySqlConnection _connection = new MySqlConnection(connectionStringTemp);
            _connection.Open();
            List<string> tables = new List<string>();
            DataTable dt = _connection.GetSchema("Tables");
            foreach (DataRow row in dt.Rows)
            {
                string currentTable = (string)row[2];
                tables.Add(currentTable);
            }
            return tables;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void mark_Lbl_Click(object sender, EventArgs e)
        {

        }

        private void openSelectedItemBtn_Click(object sender, EventArgs e)
        {
            if (db_ListView.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select any db", "Database Error", MessageBoxButtons.OK);
            }
            else
            {
                selectedDatabase = db_ListView.SelectedItems[0].Text;
                query = $"SHOW TABLES";

                using (MySqlDataReader reader = GetDatabaseData(selectedDatabase, query))
                {
                    while (reader.Read())
                    {
                        currentTable = reader.GetString(0);
                    }
                }
                try
                {
                    query = $"SHOW COLUMNS FROM {currentTable}";
                    using (MySqlDataReader reader_2 = GetDatabaseData(selectedDatabase, query))
                    {

                        int ColumnCount = 0;

                        searchItem_dropDown.Items.Clear();

                        while (reader_2.Read())
                        {
                            ColumnCount += 1;
                            DataGridViewColumn column = new DataGridViewTextBoxColumn();
                            column.HeaderText = reader_2.GetString(0);
                            column.Name = column.HeaderText;
                            //Adding Column to GridView
                            db_TablesData.Columns.Add(column);
                            searchItem_dropDown.Items.Add(column.Name);
                        }

                        if (searchItem_dropDown.Items.Count > 0)
                            searchItem_dropDown.SelectedIndex = 0;


                        query = $"SELECT * FROM {currentTable}";

                        using (MySqlDataReader reader_3 = GetDatabaseData(selectedDatabase, query))
                        {
                            while (reader_3.Read())
                            {
                                db_TablesData.Rows.Add(NewRow(ColumnCount, reader_3));
                            }

                            int totalRows = 0;
                            foreach (var table in ListTables(selectedDatabase)) totalRows++;
                            totalDatabases_Lbl.Text = $"Tables Count: {totalRows}";
                            DBPanelVisibility(db_Panel.Visible);

                        }
                    }
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message);
                    MessageBox.Show("Unable to load data.", "Insufficient Tables", MessageBoxButtons.OK);
                }
            }
        }

        string[] NewRow(int columnCount, MySqlDataReader reader)
        {
            string[] Row = new string[columnCount];
            for (int i = 0; i < columnCount; i++)
            {
                Row[i] = reader.GetString(i);
            }
            return Row;
        }


        public void DBPanelVisibility(bool IsVisible)
        {
            if (IsVisible)
            {
                db_Panel.Visible = false;
                dbInfoPanel.Visible = true;
                openSelectedItemBtn.Visible = false;
                deleteSelectedItemBtn.Visible = false;
                deleteSelectedTable.Visible = true;
                goBackBtn.Visible = true;
                searchItem_dropDown.Visible = true;
                searchDB_Btn.Visible = false;
                createDB_Btn.Visible = false;
                searchDbItem_Btn.Visible = true;
                dbItem_textBox.Visible = true;
            }
            else
            {
                db_Panel.Visible = true;
                dbInfoPanel.Visible = false;
                openSelectedItemBtn.Visible = true;
                deleteSelectedItemBtn.Visible = true;
                goBackBtn.Visible = false;
                deleteSelectedTable.Visible = false;
                searchItem_dropDown.Visible = false;
                searchDB_Btn.Visible = true;
                createDB_Btn.Visible = true;
                searchDbItem_Btn.Visible = false;
                dbItem_textBox.Visible = false;
            }
        }

        private void searchDB_Btn_Click(object sender, EventArgs e)
        {
            bool isItemFound = false;
            string itemText = "";

            if (EmptyInputError())
            {
                foreach (ListViewItem item in db_ListView.Items)
                {
                    if (input_txtBox.Text == item.Text)
                    {
                        itemText = item.Text;
                        isItemFound = true;
                        break;
                    }
                    else isItemFound = false;
                }

                if (isItemFound)
                {

                    foreach (ListViewItem listViewItem in db_ListView.Items)
                    {
                        if (listViewItem.Text == itemText)
                        {
                            listViewItem.Selected = true;
                            break;
                        }
                    }

                    MessageBox.Show($"Database Info: {itemText}", "Database Found", MessageBoxButtons.OK);
                }
                else MessageBox.Show($"Database not found", "Database Not Found", MessageBoxButtons.OK);
            }
        }

        private void createDB_Btn_Click(object sender, EventArgs e)
        {


            if (EmptyInputError())
            {
                ListViewItem? item = (from ListViewItem i in db_ListView.Items
                                      where i.Text == input_txtBox.Text
                                      select i).FirstOrDefault();

                if (item != null && item.Text == input_txtBox.Text)
                {
                    MessageBox.Show("Database with same name already exists!", "Database Error", MessageBoxButtons.OK);
                }
                else
                {
                    try
                    {
                        query = $"CREATE DATABASE IF NOT EXISTS {input_txtBox.Text}";
                        updateListView(new ListViewItem(input_txtBox.Text));

                        DatabaseConnection(selectedDatabase, query);

                        DatabasesCount++;
                        totalDatabases_Lbl.Text = $"Databases Count: ({DatabasesCount})";
                        MessageBox.Show("Database created successfully!", "Database Created", MessageBoxButtons.OK);
                    }
                    catch
                    {
                        MessageBox.Show("Database not connected", "Database Connection Error", MessageBoxButtons.OK);
                    }
                }
            }
        }

        private bool EmptyInputError()
        {
            if (input_txtBox.Text == string.Empty)
            {
                MessageBox.Show("Cannot search on empty input", "Empty Input Error", MessageBoxButtons.OK);
                return false;
            }
            else return true;
        }

        private void updateListView(ListViewItem item)
        {
            string[] dbData = [item.Text, "0"];
            db_ListView.Items.Add(new ListViewItem(dbData));
        }

        private void deleteSelectedItemBtn_Click(object sender, EventArgs e)
        {
            if (db_ListView.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select any db to delete", "Database deletion Error", MessageBoxButtons.OK);
            }
            else
            {
                try
                {
                    query = $"DROP DATABASE {db_ListView.SelectedItems[0].Text}";
                    db_ListView.Items.Remove(db_ListView.SelectedItems[0]);
                    DatabaseConnection(selectedDatabase, query);
                    DatabasesCount--;
                    totalDatabases_Lbl.Text = $"Databases Count: ({DatabasesCount})";
                    MessageBox.Show("Database deleted successfully!", "Database Deleted", MessageBoxButtons.OK);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Could not delete database", MessageBoxButtons.OK);
                }
            }
        }

        private void goBackBtn_Click(object sender, EventArgs e)
        {
            DBPanelVisibility(db_Panel.Visible);
            db_TablesData.Columns.Clear();
        }

        private void deleteSelectedTable_Click(object sender, EventArgs e)
        {
            string? selectedItem;
            try
            {
                for (int i = 0; i < db_TablesData.SelectedRows.Count; i++)
                {
                    selectedItem = db_TablesData.SelectedRows[i].Cells[0].Value.ToString();
                    query = $"DELETE FROM {currentTable} WHERE {db_TablesData.Columns[0].Name} = {selectedItem}";
                    db_TablesData.Rows.Remove(db_TablesData.SelectedRows[i]);
                }
                DatabaseConnection(selectedDatabase, query);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Cannot delete the row", MessageBoxButtons.OK);
            }

        }

        private void searchDbItem_Btn_Click(object sender, EventArgs e)
        {
            string selectedItem = searchItem_dropDown.SelectedItem?.ToString() ?? "false";
            string searchedItem = dbItem_textBox.Text;
            bool isItemFound = false;

            if (dbItem_textBox.Text == string.Empty)
            {
                MessageBox.Show("Couldn't search on empty input", "Empty Field Error", MessageBoxButtons.OK);
            }
            else
            {
                if (selectedItem != "false")
                {
                    query = $"SELECT {selectedItem} FROM {currentTable}";
                }
                using (MySqlDataReader reader = GetDatabaseData(selectedDatabase, query))
                {
                    int rowCount = 0;

                    while (reader.Read())
                    {
                        if (reader.GetString(0) == searchedItem)
                        {
                            isItemFound = true;
                            db_TablesData.ClearSelection();
                            db_TablesData.Rows[rowCount].Selected = true;
                            break;
                        }
                        else
                        {
                            isItemFound = false;
                        }
                        rowCount++;
                    }
                }
                if (!isItemFound)
                {
                    MessageBox.Show("Couldn't find the item.", "Item Not Found", MessageBoxButtons.OK);
                }
            }
        }

        protected void searchItem_dropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            dbItem_textBox.PlaceholderText = $"Find {searchItem_dropDown.SelectedItem}";
            searchDbItem_Btn.Text = $"Search {searchItem_dropDown.SelectedItem}";
        }

        bool DatabaseConnection(string databaseName, string _command)
        {
            try
            {
                string connectionString = $"datasource=localhost;port=3306;user=root;database={databaseName};pwd=";
                connection = new MySqlConnection(connectionString);
                connection.Open();
                command.Connection = connection;
                command.CommandText = _command;
                command.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
        }
        MySqlDataReader GetDatabaseData(string databaseName, string _command)
        {
            string connectionString = $"datasource=localhost;port=3306;user=root;database={databaseName};pwd=";
            connection = new MySqlConnection(connectionString);
            connection.Open();
            command.Connection = connection;
            command.CommandText = _command;
            return command.ExecuteReader();
        }

        private void db_TablesData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
