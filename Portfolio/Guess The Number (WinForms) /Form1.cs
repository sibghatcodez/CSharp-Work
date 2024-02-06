using System.Diagnostics;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace C__Day55
{
    public partial class Form1 : Form
    {
        private int numberToGuess;
        private int numberGuessed;
        private int triesRemaining = 2;
        private bool isTypeTrue = true;
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

        private async void guessBtn_Click(object sender, EventArgs e)
        {

            if (guessBtn.Text == "Guess!")
            {
                try
                {
                    numberGuessed = int.Parse(guessBox.Text);
                    isTypeTrue = true;
                }
                catch (Exception ex)
                {
                    var alertTxt = alertLbl.Text;
                    alertLbl.Text = "Integers only! 1-5";
                    alertLbl.ForeColor = Color.MediumVioletRed;
                    isTypeTrue = false;
                    await Task.Delay(2000);
                    alertLbl.Text = alertTxt;
                    alertLbl.ForeColor = Color.Black;
                }

                //----------\\

                if (isTypeTrue)
                {
                    if (numberGuessed == numberToGuess)
                    {
                        GameResult(1);
                    }
                    //
                    else
                    {
                        if (triesRemaining <= 1)
                        {
                            GameResult(0);
                        }
                        else
                        {
                            alertLbl.Text = "Wrong guess!";
                            alertLbl.ForeColor = Color.OrangeRed;
                            triesRemaining--;
                            triesLbl.Text = triesRemaining.ToString();
                        }
                    }
                }
            }
            else
            {
                label1.Visible = true;
                label3.Visible = true;
                alertLbl.Visible = true;
                guessBox.Visible = true;
                triesLbl.Visible = true;
                result.Text = "";
                triesRemaining = 2;
                triesLbl.Text = triesRemaining.ToString();
                guessBtn.Location = new Point(57, 288);
                guessBtn.Text = "Guess!";
                alertLbl.Text = "from 1 to 5";
                alertLbl.ForeColor = Color.Black;
                guessBox.Text = "";
            }
            //----
        }

        private void resultLbl_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void triesLbl_Click(object sender, EventArgs e)
        {

        }
        private void GameResult(int i)
        {
            Random rand = new Random();
            numberToGuess = rand.Next(6);

            if (i == 1)
            {
                result.Text = "Correct guess!";
                result.Font = new Font("Segoe UI", 50);
                result.ForeColor = Color.Green;
                triesRemaining = 2;

                label1.Visible = false;
                alertLbl.Visible = false;
                guessBox.Visible = false;
                triesLbl.Visible = false;
                label3.Visible = false;
                guessBtn.Location = new Point(158, 197);
                guessBtn.Text = "Play Again!";
            }
            else
            {
                result.Text = "You Lost!";
                result.Font = new Font("Segoe UI", 65);
                result.ForeColor = Color.DarkRed;

                label1.Visible = false;
                alertLbl.Visible = false;
                guessBox.Visible = false;
                triesLbl.Visible = false;
                label3.Visible = false;
                guessBtn.Location = new Point(158, 197);
                guessBtn.Text = "Try Again!";
            }
        }
    }
}
