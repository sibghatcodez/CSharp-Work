//form.cs
using System.Diagnostics;
using System.Drawing.Text;
using System.Security.Policy;
using System.Text.Json;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace C__Day62
{
    public partial class Form1 : Form
    {

        public int totalLists = 0;
        private int listsHeight = 25;
        public List<string> todo_List = new List<string>();
        public string filePath = "E:data.json";
        //public FileStream file = new FileStream("E:data.json", FileMode.OpenOrCreate, FileAccess.ReadWrite);


        public Form1()
        {
            InitializeComponent();
            this.FormClosing += Form1_FormClosing;
        }
        private void Form1_Activated(object sender, System.EventArgs e)
        {
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateList();


            totalLists = todo_List.Count;


            if (totalLists <= 0)
            {
                emptyListLbl.Visible = true;
            }
            else
            {

                emptyListLbl.Visible = false;


                /*for (int i = 0; i < totalLists; i++)
                {
                    Label lbl = new Label();
                    itemsContainer.Controls.Add(lbl);


                    lbl.Location = new Point(29, listsHeight);
                    lbl.Font = new Font(Font.Name, 13, FontStyle.Regular);
                    listsHeight += 40;
                    lbl.Text = "- " + todo_List[i];
                    lbl.AutoSize = true;
                }*/
            }
            itemsContainer.AutoScroll = true;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            UpdateData();
        }



        public Label labelProperties(Label lbl, string txt)
        {
            itemsContainer.Controls.Add(lbl);
            lbl.Location = new Point(29, listsHeight);
            lbl.Font = new Font(Font.Name, 13, FontStyle.Regular);
            listsHeight += 40;
            lbl.Text = "- " + txt;
            lbl.AutoSize = true;
            totalLists++;
            return lbl;
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
        private void UpdateData()
        {
            JsonSerializerOptions options = new()
            {
                WriteIndented = true
            };
            var data = JsonSerializer.Serialize(todo_List, options);
            File.WriteAllText(filePath, data);
        }
        private void UpdateList()
        {
            try
            {
                var jsonString = File.ReadAllText(filePath);
                var data = JsonSerializer.Deserialize<List<string>>(jsonString);

                if (data != null && data.Count > 0)
                {
                    foreach (var item in data)
                    {
                        Label lbl = new Label();
                        lbl = labelProperties(lbl, item);
                        totalLists += 1;
                        todo_List.Add(item);
                        Debug.WriteLine("Item added from file: " + item);
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
        }


        private async void button1_Click(object sender, EventArgs e)
        {

            if (inputList.Text.Length == 0 || inputList.Text == "List cannot be empty.")
            {
                inputList.Text = "List cannot be empty.";
                await Task.Delay(1500);
                inputList.Text = "";
            }
            else
            {
                todo_List.Add(inputList.Text);

                UpdateData();

                emptyListLbl.Visible = false;


                Label lbl = new Label();
                lbl = labelProperties(lbl, inputList.Text);
            }
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
            }
            else inputList.Text = "";
        }

        private void clearListBtn_Click(object sender, EventArgs e)
        {
            if (totalLists > 0)
            {
                todo_List.Clear();
                totalLists = 0;
                emptyListLbl.Parent = null;
                foreach (Label ctrl in itemsContainer.Controls)
                {
                    Debug.WriteLine("Item removed from control: " + ctrl);
                    Controls.Remove(ctrl);
                }
                itemsContainer.Controls.Clear();
                listsHeight = 25;
                emptyListLbl.Visible = true;
            }
            else
            {
                emptyListLbl.Visible = true;
            }
        }
    }
}
