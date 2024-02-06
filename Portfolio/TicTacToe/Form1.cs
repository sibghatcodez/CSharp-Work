using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C__Day94
{
    public partial class Form1 : Form
    {
        PictureBox[] pictures = new PictureBox[10];

        string player1Name;
        string player2Name;
        string winner;

        byte boxSelected = 0;
        byte boxesSelected = 0;
        const byte CHAR_LIMIT = 9;

        bool isGameStarted = false;
        bool rematch = false;
        bool player = false; //false=player1 & true=player2

        int[] box1_3 = new int[4];
        int[] box3_6 = new int[4];
        int[] box6_9 = new int[4];


        public Form1()
        {
            InitializeComponent();

            pictures[1] = pictureBox1;
            pictures[2] = pictureBox2;
            pictures[3] = pictureBox3;
            pictures[4] = pictureBox4;
            pictures[5] = pictureBox5;
            pictures[6] = pictureBox6;
            pictures[7] = pictureBox7;
            pictures[8] = pictureBox8;
            pictures[9] = pictureBox9;


            PrivateFontCollection pf = new PrivateFontCollection();
            pf.AddFontFile("C:\\Users\\gitoi\\Downloads\\Compressed\\Greek-Freak.ttf");
            pf.AddFontFile("C:\\Users\\gitoi\\Downloads\\Compressed\\desktop\\Sono-Regular.ttf");
            gameTitle.Font = new Font(pf.Families[0], gameTitle.Font.Size);
            gameResult.Font = new Font(pf.Families[1], gameResult.Font.Size);
            playerTurnText.Font = new Font(pf.Families[1], playerTurnText.Font.Size);
            StartGame(isGameStarted);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void gameBox_Enter(object sender, EventArgs e)
        {

        }
        private void UpdatePlayerTurnText(bool player)
        {
            if (!player) 
            {
                player1Name = player1_Name.Text;
                playerTurnText.Text = player1Name + "'s";
                playerTurnText.ForeColor = Color.SeaGreen;
            } 
            else
            {
                player2Name = player2_Name.Text;
                playerTurnText.Text = player2Name + "'s";
                playerTurnText.ForeColor = Color.Crimson;
            }

            turnLabel.ForeColor = playerTurnText.ForeColor;

            if(boxesSelected >= 5) CheckDiagonal();
        }

        private void CheckDiagonal()
        {
            byte n = 1;
            bool isResult = false;
            playAgainPicture.Parent = playAgainBtn;

            while (n < 3)
            {
                if ((box1_3[1] == n && box1_3[2] == n && box1_3[3] == n) ||
                    (box3_6[1] == n && box3_6[2] == n && box3_6[3] == n) ||
                    (box6_9[1] == n && box6_9[2] == n && box6_9[3] == n))
                {
                    winner = (n == 1) ? player1Name : player2Name;
                    isResult = true;
                }

                if ((box1_3[1] == n && box3_6[2] == n && box6_9[3] == n) ||
                    (box1_3[3] == n && box3_6[2] == n && box6_9[1] == n))
                {
                    winner = (n == 1) ? player1Name : player2Name;
                    isResult = true;
                }

                if ((box1_3[1] == n && box3_6[1] == n && box6_9[1] == n) ||
                    (box1_3[2] == n && box3_6[2] == n && box6_9[2] == n) ||
                    (box1_3[3] == n && box3_6[3] == n && box6_9[3] == n))
                {
                    winner = (n == 1) ? player1Name : player2Name;
                    isResult = true;
                }

                n++;
            }

            if (isResult)
            {
                gameResult.Text = winner.ToUpper() + " WON";
                gameVisibility(isResult, isGameStarted);
                isGameStarted = false;
            }
            else
            {
                isResult = false;

                if(boxesSelected == 9) 
                {
                    gameResult.Text = "MATCH DRAWN".ToUpper();
                    gameVisibility(true, isGameStarted);
                    isGameStarted = false;
                }
            }
        }

        private void StartGame(bool signal)
        {
            if (!signal)
            {
                foreach (Control control in gameBox.Controls)
                {
                    if (control.Name == "groupBox1")
                    {
                        foreach (Control ctrls in groupBox1.Controls)
                        {
                            ctrls.Visible = true;
                        }
                        control.Visible = true;
                    }
                    else control.Visible = false;
                }
            }
            else
            {

                foreach (Control control in gameBox.Controls)
                {
                    if (control.Name == "groupBox1")
                    {
                        foreach (Control ctrls in groupBox1.Controls)
                        {
                            ctrls.Visible = false;
                        }
                        control.Visible = false;
                    }
                    else control.Visible = true;
                }
                playAgainBtn.Visible = false;
                newMatchBtn.Visible = false;
                playAgainPicture.Visible = false;
                gameResult.Visible = false;
            }
        }
        private void gameVisibility(bool Visibility, bool isGameStarted)
        {
                playAgainPicture.Visible = Visibility;
                gameResult.Visible = Visibility;
                playAgainBtn.Visible = Visibility;
                newMatchBtn.Visible = Visibility;
                gameTitle.Visible = true;
                gameTitle.Location = Visibility ? new Point(177, 58) : new Point(73, 58);
                Visibility = Visibility ? false : true;

                {
                    col_1.Visible = Visibility;
                    col_2.Visible = Visibility;
                    col_3.Visible = Visibility;
                    col_4.Visible = Visibility;
                    col_5.Visible = Visibility;
                    col_6.Visible = Visibility;
                    col_7.Visible = Visibility;
                    col_8.Visible = Visibility;
                    col_9.Visible = Visibility;

                    playerTurnText.Visible = Visibility;
                    turnLabel.Visible = Visibility;

                    for (int i = 1; i <= 9; i++)
                    {
                        pictures[i].BackgroundImage = null;
                    }
                    boxSelected = 0;
                    boxesSelected = 0;
                }
        }

        private void addImg()
        {
            boxesSelected += 1;

            if (!player)
            {
                pictures[boxSelected].BackgroundImage = Image.FromFile("C:\\Users\\gitoi\\Desktop\\check.png");
            }
            else
            {
                pictures[boxSelected].BackgroundImage = Image.FromFile("C:\\Users\\gitoi\\Desktop\\cross.png");
            }
            player = player ? false : true;
            UpdatePlayerTurnText(player);
        }

        private void col_1_Enter(object sender, EventArgs e)
        {
            boxSelected = 1;

            if(box1_3[boxSelected] != 1 && box1_3[boxSelected] != 2) {
                box1_3[boxSelected] = player ? 2 : 1;
                addImg();
            }
        }
        private void col_2_Enter(object sender, EventArgs e)
        {
            boxSelected = 2;

            if (box1_3[boxSelected] != 1 && box1_3[boxSelected] != 2)
            {
                box1_3[2] = player ? 2 : 1;
                addImg();
            }
        }
        private void col_3_Enter(object sender, EventArgs e)
        {
            boxSelected = 3;

            if (box1_3[boxSelected] != 1 && box1_3[boxSelected] != 2)
            {
                box1_3[3] = player ? 2 : 1;
                addImg();
            }
        }

        private void col_4_Enter(object sender, EventArgs e)
        {
            boxSelected = 4;

            if (box3_6[1] != 1 && box3_6[1] != 2)
            {
                box3_6[1] = player ? 2 : 1;
                addImg();
            }
        }
        private void col_5_Enter(object sender, EventArgs e)
        {
            boxSelected = 5;

            if (box3_6[2] != 1 && box3_6[2] != 2)
            {
                box3_6[2] = player ? 2 : 1;
                addImg();
            }
        }
        private void col_6_Enter(object sender, EventArgs e)
        {
            boxSelected = 6;

            if (box3_6[3] != 1 && box3_6[3] != 2)
            {
                box3_6[3] = player ? 2 : 1;
                addImg();
            }
        }

        private void col_7_Enter(object sender, EventArgs e)
        {
            boxSelected = 7;

            if (box6_9[1] != 1 && box6_9[1] != 2)
            {
                box6_9[1] = player ? 2 : 1;
                addImg();
            }
        }
        private void col_8_Enter(object sender, EventArgs e)
        {
            boxSelected = 8;

            if (box6_9[2] != 1 && box6_9[2] != 2)
            {
                box6_9[2] = player ? 2 : 1;
                addImg();
            }
        }
        private void col_9_Enter(object sender, EventArgs e)
        {
            boxSelected = 9;

            if (box6_9[3] != 1 && box6_9[3] != 2)
            {
                box6_9[3] = player ? 2 : 1;
                addImg();
            }
        }

        private void playAgainBtn_Click(object sender, EventArgs e)
        {
            rematch = true;
            gameVisibility(false, isGameStarted);
            boxesSelected = 0;
            player = false;
            UpdatePlayerTurnText(player);

            for(int i = 1; i <= 3; i++) 
            {
                box1_3[i] = 0;
                box3_6[i] = 0;
                box6_9[i] = 0;
            }
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            if (player1_Name.Text == string.Empty)
            {
                errorProvider1.Clear();
                errorProvider1.SetError(player1_Name, "ERROR: NAME REQUIRED.");
            }
            else if (player2_Name.Text == string.Empty)
            {
                errorProvider1.Clear();
                errorProvider1.SetError(player2_Name, "ERROR: NAME REQUIRED.");
            }
            else if (player1_Name.Text.Length > CHAR_LIMIT || player2_Name.Text.Length > CHAR_LIMIT)
            {
                errorProvider1.Clear();
                TextBox playerTxtBox = player1_Name.Text.Length > CHAR_LIMIT ? player1_Name : player2_Name;
                errorProvider1.SetError(playerTxtBox, "ERROR: LONG NAME!.");
            }
            else
            {
                isGameStarted = true;
                StartGame(isGameStarted);
                errorProvider1.Clear();

                player1Name = player1_Name.Text;
                player2Name = player2_Name.Text;
                playerTurnText.Text = player1Name;
                boxesSelected = 0;
            }
        }

        private void newMatchBtn_Click(object sender, EventArgs e)
        {
            rematch = false;
            isGameStarted = false;
            StartGame(isGameStarted);
            player1_Name.Text = string.Empty;
            player2_Name.Text = string.Empty;
            boxesSelected = 0;
            player = false;
            UpdatePlayerTurnText(player);
            for (int i = 1; i <= 3; i++)
            {
                box1_3[i] = 0;
                box3_6[i] = 0;
                box6_9[i] = 0;
            }
        }
    }
}
