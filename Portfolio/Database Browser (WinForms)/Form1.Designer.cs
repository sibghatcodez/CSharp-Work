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
            dbItem_textBox = new TextBox();
            searchDbItem_Btn = new Button();
            searchItem_dropDown = new ComboBox();
            goBackBtn = new Button();
            deleteSelectedTable = new Button();
            dbInfoPanel = new Panel();
            db_TablesData = new DataGridView();
            pictureBox1 = new PictureBox();
            totalDatabases_Lbl = new Label();
            deleteSelectedItemBtn = new Button();
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
            groupBox1.SuspendLayout();
            dbInfoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)db_TablesData).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            db_Panel.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.LightSkyBlue;
            groupBox1.Controls.Add(dbItem_textBox);
            groupBox1.Controls.Add(searchDbItem_Btn);
            groupBox1.Controls.Add(searchItem_dropDown);
            groupBox1.Controls.Add(goBackBtn);
            groupBox1.Controls.Add(deleteSelectedTable);
            groupBox1.Controls.Add(dbInfoPanel);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(totalDatabases_Lbl);
            groupBox1.Controls.Add(deleteSelectedItemBtn);
            groupBox1.Controls.Add(input_txtBox);
            groupBox1.Controls.Add(openSelectedItemBtn);
            groupBox1.Controls.Add(horizontlLine_1);
            groupBox1.Controls.Add(mark_Lbl);
            groupBox1.Controls.Add(searchDB_Btn);
            groupBox1.Controls.Add(db_Panel);
            groupBox1.Controls.Add(createDB_Btn);
            groupBox1.Controls.Add(mysqlDB_Lbl);
            groupBox1.ForeColor = Color.DarkSlateGray;
            groupBox1.Location = new Point(130, 9);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(552, 509);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // dbItem_textBox
            // 
            dbItem_textBox.BorderStyle = BorderStyle.FixedSingle;
            dbItem_textBox.Cursor = Cursors.IBeam;
            dbItem_textBox.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            dbItem_textBox.Location = new Point(206, 122);
            dbItem_textBox.Name = "dbItem_textBox";
            dbItem_textBox.PlaceholderText = "search or create";
            dbItem_textBox.Size = new Size(144, 23);
            dbItem_textBox.TabIndex = 12;
            dbItem_textBox.TextAlign = HorizontalAlignment.Center;
            dbItem_textBox.Visible = false;
            // 
            // searchDbItem_Btn
            // 
            searchDbItem_Btn.BackColor = SystemColors.ControlLight;
            searchDbItem_Btn.Font = new Font("Segoe UI", 13F);
            searchDbItem_Btn.Location = new Point(356, 109);
            searchDbItem_Btn.Name = "searchDbItem_Btn";
            searchDbItem_Btn.Size = new Size(178, 35);
            searchDbItem_Btn.TabIndex = 11;
            searchDbItem_Btn.Text = "Search Item";
            searchDbItem_Btn.UseVisualStyleBackColor = false;
            searchDbItem_Btn.Visible = false;
            searchDbItem_Btn.Click += searchDbItem_Btn_Click;
            // 
            // searchItem_dropDown
            // 
            searchItem_dropDown.BackColor = SystemColors.InactiveBorder;
            searchItem_dropDown.Cursor = Cursors.Hand;
            searchItem_dropDown.DropDownStyle = ComboBoxStyle.DropDownList;
            searchItem_dropDown.Font = new Font("Tahoma", 11F, FontStyle.Bold);
            searchItem_dropDown.ForeColor = Color.DodgerBlue;
            searchItem_dropDown.FormattingEnabled = true;
            searchItem_dropDown.Location = new Point(79, 118);
            searchItem_dropDown.MaxDropDownItems = 50;
            searchItem_dropDown.Name = "searchItem_dropDown";
            searchItem_dropDown.Size = new Size(121, 26);
            searchItem_dropDown.TabIndex = 2;
            searchItem_dropDown.Visible = false;
            searchItem_dropDown.SelectedIndexChanged += searchItem_dropDown_SelectedIndexChanged;
            // 
            // goBackBtn
            // 
            goBackBtn.Location = new Point(163, 437);
            goBackBtn.Name = "goBackBtn";
            goBackBtn.Size = new Size(195, 23);
            goBackBtn.TabIndex = 10;
            goBackBtn.Text = "Go Back";
            goBackBtn.UseVisualStyleBackColor = true;
            goBackBtn.Visible = false;
            goBackBtn.Click += goBackBtn_Click;
            // 
            // deleteSelectedTable
            // 
            deleteSelectedTable.Location = new Point(163, 408);
            deleteSelectedTable.Name = "deleteSelectedTable";
            deleteSelectedTable.Size = new Size(195, 23);
            deleteSelectedTable.TabIndex = 9;
            deleteSelectedTable.Text = "Delete Selected Table";
            deleteSelectedTable.UseVisualStyleBackColor = true;
            deleteSelectedTable.Visible = false;
            deleteSelectedTable.Click += deleteSelectedTable_Click;
            // 
            // dbInfoPanel
            // 
            dbInfoPanel.BackColor = Color.MintCream;
            dbInfoPanel.Controls.Add(db_TablesData);
            dbInfoPanel.ForeColor = Color.Blue;
            dbInfoPanel.Location = new Point(107, 190);
            dbInfoPanel.Name = "dbInfoPanel";
            dbInfoPanel.Size = new Size(333, 212);
            dbInfoPanel.TabIndex = 8;
            dbInfoPanel.Visible = false;
            // 
            // db_TablesData
            // 
            db_TablesData.AllowUserToOrderColumns = true;
            db_TablesData.BackgroundColor = SystemColors.ControlLight;
            db_TablesData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            db_TablesData.Location = new Point(0, 0);
            db_TablesData.MultiSelect = false;
            db_TablesData.Name = "db_TablesData";
            db_TablesData.Size = new Size(333, 212);
            db_TablesData.TabIndex = 1;
            db_TablesData.CellContentClick += db_TablesData_CellContentClick;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.mysqlLogo;
            pictureBox1.Location = new Point(41, 28);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(60, 36);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // totalDatabases_Lbl
            // 
            totalDatabases_Lbl.AutoSize = true;
            totalDatabases_Lbl.Location = new Point(107, 174);
            totalDatabases_Lbl.Name = "totalDatabases_Lbl";
            totalDatabases_Lbl.Size = new Size(116, 15);
            totalDatabases_Lbl.TabIndex = 1;
            totalDatabases_Lbl.Text = "Databases Count: (0)";
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
            // input_txtBox
            // 
            input_txtBox.BorderStyle = BorderStyle.FixedSingle;
            input_txtBox.Cursor = Cursors.IBeam;
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
            mark_Lbl.ForeColor = SystemColors.ActiveCaptionText;
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
            searchDB_Btn.Location = new Point(22, 112);
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
            dbInfo_Lbl.Font = new Font("Trebuchet MS", 18F, FontStyle.Underline);
            dbInfo_Lbl.ForeColor = Color.RoyalBlue;
            dbInfo_Lbl.Location = new Point(18, 75);
            dbInfo_Lbl.Name = "dbInfo_Lbl";
            dbInfo_Lbl.Size = new Size(287, 29);
            dbInfo_Lbl.TabIndex = 3;
            dbInfo_Lbl.Text = "NO DATABASES DETECTED";
            // 
            // db_ListView
            // 
            db_ListView.BackColor = SystemColors.MenuBar;
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
            mysqlDB_Lbl.Location = new Point(107, 28);
            mysqlDB_Lbl.Name = "mysqlDB_Lbl";
            mysqlDB_Lbl.Size = new Size(399, 36);
            mysqlDB_Lbl.TabIndex = 0;
            mysqlDB_Lbl.Text = "MYSQL DATABASE APPLICATION";
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
            dbInfoPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)db_TablesData).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private Label totalDatabases_Lbl;
        private PictureBox pictureBox1;
        private Panel dbInfoPanel;
        private Button deleteSelectedTable;
        private DataGridView db_TablesData;
        private Button goBackBtn;
        private ComboBox searchItem_dropDown;
        private Button searchDbItem_Btn;
        private TextBox dbItem_textBox;
    }
}
