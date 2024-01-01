//form1.cs


using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Diagnostics;
using System.Text.Json;
using MySql.Data.MySqlClient;


namespace C__Day81
{
    public partial class Form1 : Form
    {
        public string connectionString = "datasource=localhost;port=3306;user=root;database=master;pwd=";
        public MySqlConnection connection;
        public string query;
        public MySqlCommand command;

        public Form1()
        {
            InitializeComponent();

            connection = new MySqlConnection(connectionString);
            query = "CREATE DATABASE IF NOT EXISTS testdb123";
            command = new MySqlCommand(query, connection);
            try
            {
                connection.Open();
                command.ExecuteNonQuery();
                //  MessageBox.Show("Database is created successfully", "MyProgram",
                //MessageBoxButtons.OK, MessageBoxIcon.Information);

                command.CommandText = "SHOW DATABASES";

                MySqlDataReader reader = command.ExecuteReader();


                {   //db_ListView Scope
                    db_ListView.View = View.Details;
                    dbInfo_Lbl.Visible = reader.Read() ? false : true;

                    db_ListView.Columns.Add("Database", 150);
                    while (reader.Read())
                    {
                        ListViewItem item = new ListViewItem();
                        item.Text = reader["Database"].ToString();
                        db_ListView.Items.Add(item);


                        Debug.WriteLine(item.Text);
                        foreach (var prop in reader["Database"].ToString())
                        {
                            Debug.WriteLine(prop);
                        }
                    }
                }   //db_ListView Scope End


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
                MessageBox.Show($"db selected {db_ListView.SelectedItems[0].Text}", "Database deletion Error", MessageBoxButtons.OK);
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
                    MessageBox.Show($"Database Info: {itemText}", "Database Found", MessageBoxButtons.OK);
                }
                else MessageBox.Show($"Database not found", "Database Not Found", MessageBoxButtons.OK);
            }
        }

        private void createDB_Btn_Click(object sender, EventArgs e)
        {


            if (EmptyInputError())
            {
                ListViewItem item = (from ListViewItem i in db_ListView.Items
                                     where i.Text == input_txtBox.Text
                                     select i).FirstOrDefault();

                if (item != null && item.Text == input_txtBox.Text)
                {
                    MessageBox.Show("Database with same name already exists!", "Database Error", MessageBoxButtons.OK);
                }
                else
                {
                    connection = new MySqlConnection(connectionString);
                    connection.Open();
                    query = $"CREATE DATABASE IF NOT EXISTS {input_txtBox.Text}";
                    updateListView(new ListViewItem(input_txtBox.Text));
                    command = new MySqlCommand(query, connection);
                    command.ExecuteNonQuery();

                    MessageBox.Show("Database created successfully!", "Database Created", MessageBoxButtons.OK);
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
            db_ListView.Items.Add(item);
        }

        private void deleteSelectedItemBtn_Click(object sender, EventArgs e)
        {
            if(db_ListView.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select any db to delete", "Database deletion Error", MessageBoxButtons.OK);
            } else
            {
                connection = new MySqlConnection(connectionString);
                connection.Open();
                query = $"DROP DATABASE {db_ListView.SelectedItems[0].Text}";
                db_ListView.Items.Remove(db_ListView.SelectedItems[0]);
                command = new MySqlCommand(query, connection);
                command.ExecuteNonQuery();
                MessageBox.Show("Database deleted successfully!", "Database Deleted", MessageBoxButtons.OK);
            }
        }
    }
}



//formdesign.cs

namespace C__Day81
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
            input_txtBox = new TextBox();
            openSelectedItemBtn = new Button();
            horizontlLine_1 = new Label();
            mark_Lbl = new Label();
            searchDB_Btn = new Button();
            db_Panel = new Panel();
            dbInfo_Lbl = new Label();
            db_ListView = new ListView();
            createDB_Btn = new Button();
            mysqlDB_Lbl = new Label();
            deleteSelectedItemBtn = new Button();
            groupBox1.SuspendLayout();
            db_Panel.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(deleteSelectedItemBtn);
            groupBox1.Controls.Add(input_txtBox);
            groupBox1.Controls.Add(openSelectedItemBtn);
            groupBox1.Controls.Add(horizontlLine_1);
            groupBox1.Controls.Add(mark_Lbl);
            groupBox1.Controls.Add(searchDB_Btn);
            groupBox1.Controls.Add(db_Panel);
            groupBox1.Controls.Add(createDB_Btn);
            groupBox1.Controls.Add(mysqlDB_Lbl);
            groupBox1.Location = new Point(130, 9);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(552, 509);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // input_txtBox
            // 
            input_txtBox.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            input_txtBox.Location = new Point(206, 121);
            input_txtBox.Name = "input_txtBox";
            input_txtBox.PlaceholderText = "search or create";
            input_txtBox.Size = new Size(144, 23);
            input_txtBox.TabIndex = 1;
            input_txtBox.TextAlign = HorizontalAlignment.Center;
            // 
            // openSelectedItemBtn
            // 
            openSelectedItemBtn.Location = new Point(163, 408);
            openSelectedItemBtn.Name = "openSelectedItemBtn";
            openSelectedItemBtn.Size = new Size(195, 23);
            openSelectedItemBtn.TabIndex = 5;
            openSelectedItemBtn.Text = "Open Selected Database";
            openSelectedItemBtn.UseVisualStyleBackColor = true;
            openSelectedItemBtn.Click += openSelectedItemBtn_Click;
            // 
            // horizontlLine_1
            // 
            horizontlLine_1.BorderStyle = BorderStyle.Fixed3D;
            horizontlLine_1.Location = new Point(53, 73);
            horizontlLine_1.Name = "horizontlLine_1";
            horizontlLine_1.Size = new Size(428, 1);
            horizontlLine_1.TabIndex = 1;
            // 
            // mark_Lbl
            // 
            mark_Lbl.AutoSize = true;
            mark_Lbl.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            mark_Lbl.Location = new Point(296, 491);
            mark_Lbl.Name = "mark_Lbl";
            mark_Lbl.Size = new Size(250, 15);
            mark_Lbl.TabIndex = 4;
            mark_Lbl.Text = "Sibghat's Project Inc / All Rights Reserved 2024";
            mark_Lbl.Click += mark_Lbl_Click;
            // 
            // searchDB_Btn
            // 
            searchDB_Btn.BackColor = SystemColors.ControlLight;
            searchDB_Btn.Font = new Font("Segoe UI", 13F);
            searchDB_Btn.Location = new Point(22, 109);
            searchDB_Btn.Name = "searchDB_Btn";
            searchDB_Btn.Size = new Size(178, 35);
            searchDB_Btn.TabIndex = 3;
            searchDB_Btn.Text = "SEARCH DATABASE";
            searchDB_Btn.UseVisualStyleBackColor = false;
            searchDB_Btn.Click += searchDB_Btn_Click;
            // 
            // db_Panel
            // 
            db_Panel.BackColor = Color.WhiteSmoke;
            db_Panel.BorderStyle = BorderStyle.FixedSingle;
            db_Panel.Controls.Add(dbInfo_Lbl);
            db_Panel.Controls.Add(db_ListView);
            db_Panel.Location = new Point(107, 192);
            db_Panel.Name = "db_Panel";
            db_Panel.Size = new Size(330, 210);
            db_Panel.TabIndex = 2;
            // 
            // dbInfo_Lbl
            // 
            dbInfo_Lbl.AutoSize = true;
            dbInfo_Lbl.Font = new Font("Segoe UI", 18F, FontStyle.Underline);
            dbInfo_Lbl.ForeColor = Color.Red;
            dbInfo_Lbl.Location = new Point(18, 75);
            dbInfo_Lbl.Name = "dbInfo_Lbl";
            dbInfo_Lbl.Size = new Size(297, 32);
            dbInfo_Lbl.TabIndex = 3;
            dbInfo_Lbl.Text = "NO DATABASES DETECTED";
            // 
            // db_ListView
            // 
            db_ListView.Location = new Point(-1, -1);
            db_ListView.MultiSelect = false;
            db_ListView.Name = "db_ListView";
            db_ListView.Size = new Size(330, 210);
            db_ListView.TabIndex = 2;
            db_ListView.UseCompatibleStateImageBehavior = false;
            // 
            // createDB_Btn
            // 
            createDB_Btn.BackColor = SystemColors.ControlLight;
            createDB_Btn.Font = new Font("Segoe UI", 13F);
            createDB_Btn.Location = new Point(356, 109);
            createDB_Btn.Name = "createDB_Btn";
            createDB_Btn.Size = new Size(178, 35);
            createDB_Btn.TabIndex = 1;
            createDB_Btn.Text = "CREATE DATABASE";
            createDB_Btn.UseVisualStyleBackColor = false;
            createDB_Btn.Click += createDB_Btn_Click;
            // 
            // mysqlDB_Lbl
            // 
            mysqlDB_Lbl.AutoSize = true;
            mysqlDB_Lbl.Font = new Font("Segoe UI Semibold", 19F);
            mysqlDB_Lbl.Location = new Point(68, 28);
            mysqlDB_Lbl.Name = "mysqlDB_Lbl";
            mysqlDB_Lbl.Size = new Size(399, 36);
            mysqlDB_Lbl.TabIndex = 0;
            mysqlDB_Lbl.Text = "MYSQL DATABASE APPLICATION";
            // 
            // deleteSelectedItemBtn
            // 
            deleteSelectedItemBtn.Location = new Point(163, 437);
            deleteSelectedItemBtn.Name = "deleteSelectedItemBtn";
            deleteSelectedItemBtn.Size = new Size(195, 23);
            deleteSelectedItemBtn.TabIndex = 6;
            deleteSelectedItemBtn.Text = "Delete Selected Database";
            deleteSelectedItemBtn.UseVisualStyleBackColor = true;
            deleteSelectedItemBtn.Click += deleteSelectedItemBtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 542);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            db_Panel.ResumeLayout(false);
            db_Panel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label mysqlDB_Lbl;
        private Button createDB_Btn;
        private Panel db_Panel;
        private Label dbInfo_Lbl;
        private Label mark_Lbl;
        private Button searchDB_Btn;
        private Label horizontlLine_1;
        private ListView db_ListView;
        private Button openSelectedItemBtn;
        private TextBox input_txtBox;
        private Button deleteSelectedItemBtn;
    }
}
