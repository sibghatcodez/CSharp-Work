//form.cs

using System.Diagnostics;

namespace C__Day55
{
    public partial class Form1 : Form
    {
        private int numberToGuess;
        private int numberGuessed;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Random rand = new Random();
            numberToGuess = rand.Next(6);
            Debug.WriteLine(numberToGuess);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guessBtn_Click(object sender, EventArgs e)
        {
            try {
            numberGuessed = int.Parse(guessBox.Text);
            } catch (Exception ex)
            {
                var alertTxt = alertLbl.Text;
                alertLbl.Text = ex.Message;
                //Thread.Sleep(3000);
                //alertLbl.Text = alertTxt;
            }

            if (numberGuessed == numberToGuess)
            {
                alertLbl.Text = "Correct guess!";
                alertLbl.ForeColor = Color.DarkGreen;
            }
            else
            {
                alertLbl.Text = "Wrong guess!";
                alertLbl.ForeColor = Color.OrangeRed;
            }
        }

        private void resultLbl_Click(object sender, EventArgs e)
        {

        }
    }
}


//formdesigner.cs
using System.Diagnostics;

namespace C__Day55
{
    public partial class Form1 : Form
    {
        private int numberToGuess;
        private int numberGuessed;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Random rand = new Random();
            numberToGuess = rand.Next(6);
            Debug.WriteLine(numberToGuess);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guessBtn_Click(object sender, EventArgs e)
        {
            try {
            numberGuessed = int.Parse(guessBox.Text);
            } catch (Exception ex)
            {
                var alertTxt = alertLbl.Text;
                alertLbl.Text = ex.Message;
                //Thread.Sleep(3000);
                //alertLbl.Text = alertTxt;
            }

            if (numberGuessed == numberToGuess)
            {
                alertLbl.Text = "Correct guess!";
                alertLbl.ForeColor = Color.DarkGreen;
            }
            else
            {
                alertLbl.Text = "Wrong guess!";
                alertLbl.ForeColor = Color.OrangeRed;
            }
        }

        private void resultLbl_Click(object sender, EventArgs e)
        {

        }
    }
}

