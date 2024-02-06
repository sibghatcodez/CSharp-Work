using System.Drawing;

namespace C__Day94
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gameBox = new System.Windows.Forms.GroupBox();
            this.newMatchBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.playButton = new System.Windows.Forms.Button();
            this.player2_Name = new System.Windows.Forms.TextBox();
            this.player1_Name = new System.Windows.Forms.TextBox();
            this.player2_Lbl = new System.Windows.Forms.Label();
            this.player1_Lbl = new System.Windows.Forms.Label();
            this.playAgainPicture = new System.Windows.Forms.PictureBox();
            this.playAgainBtn = new System.Windows.Forms.Button();
            this.gameResult = new System.Windows.Forms.Label();
            this.turnLabel = new System.Windows.Forms.Label();
            this.col_3 = new System.Windows.Forms.GroupBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.playerTurnText = new System.Windows.Forms.Label();
            this.col_8 = new System.Windows.Forms.GroupBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.col_9 = new System.Windows.Forms.GroupBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.col_7 = new System.Windows.Forms.GroupBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.col_5 = new System.Windows.Forms.GroupBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.col_6 = new System.Windows.Forms.GroupBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.col_4 = new System.Windows.Forms.GroupBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.col_2 = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.col_1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gameTitle = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.gameBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.playAgainPicture)).BeginInit();
            this.col_3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.col_8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            this.col_9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            this.col_7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.col_5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.col_6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.col_4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.col_2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.col_1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // gameBox
            // 
            this.gameBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.gameBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gameBox.Controls.Add(this.newMatchBtn);
            this.gameBox.Controls.Add(this.groupBox1);
            this.gameBox.Controls.Add(this.playAgainPicture);
            this.gameBox.Controls.Add(this.playAgainBtn);
            this.gameBox.Controls.Add(this.gameResult);
            this.gameBox.Controls.Add(this.turnLabel);
            this.gameBox.Controls.Add(this.col_3);
            this.gameBox.Controls.Add(this.playerTurnText);
            this.gameBox.Controls.Add(this.col_8);
            this.gameBox.Controls.Add(this.col_9);
            this.gameBox.Controls.Add(this.col_7);
            this.gameBox.Controls.Add(this.col_5);
            this.gameBox.Controls.Add(this.col_6);
            this.gameBox.Controls.Add(this.col_4);
            this.gameBox.Controls.Add(this.col_2);
            this.gameBox.Controls.Add(this.col_1);
            this.gameBox.Controls.Add(this.gameTitle);
            this.gameBox.Location = new System.Drawing.Point(0, 0);
            this.gameBox.Name = "gameBox";
            this.gameBox.Size = new System.Drawing.Size(803, 452);
            this.gameBox.TabIndex = 0;
            this.gameBox.TabStop = false;
            this.gameBox.Enter += new System.EventHandler(this.gameBox_Enter);
            // 
            // newMatchBtn
            // 
            this.newMatchBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newMatchBtn.ForeColor = System.Drawing.Color.Black;
            this.newMatchBtn.Location = new System.Drawing.Point(254, 325);
            this.newMatchBtn.Name = "newMatchBtn";
            this.newMatchBtn.Size = new System.Drawing.Size(296, 52);
            this.newMatchBtn.TabIndex = 16;
            this.newMatchBtn.Text = "NEW MATCH";
            this.newMatchBtn.UseVisualStyleBackColor = true;
            this.newMatchBtn.Visible = false;
            this.newMatchBtn.Click += new System.EventHandler(this.newMatchBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox1.Controls.Add(this.playButton);
            this.groupBox1.Controls.Add(this.player2_Name);
            this.groupBox1.Controls.Add(this.player1_Name);
            this.groupBox1.Controls.Add(this.player2_Lbl);
            this.groupBox1.Controls.Add(this.player1_Lbl);
            this.groupBox1.Location = new System.Drawing.Point(165, 131);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(460, 221);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Visible = false;
            // 
            // playButton
            // 
            this.playButton.Font = new System.Drawing.Font("MingLiU-ExtB", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playButton.ForeColor = System.Drawing.Color.ForestGreen;
            this.playButton.Location = new System.Drawing.Point(137, 182);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(181, 33);
            this.playButton.TabIndex = 4;
            this.playButton.Text = "PLAY";
            this.playButton.UseVisualStyleBackColor = true;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // player2_Name
            // 
            this.player2_Name.BackColor = System.Drawing.Color.OrangeRed;
            this.player2_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player2_Name.ForeColor = System.Drawing.Color.Snow;
            this.player2_Name.Location = new System.Drawing.Point(188, 97);
            this.player2_Name.Multiline = true;
            this.player2_Name.Name = "player2_Name";
            this.player2_Name.Size = new System.Drawing.Size(180, 25);
            this.player2_Name.TabIndex = 3;
            this.player2_Name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.player2_Name.Visible = false;
            // 
            // player1_Name
            // 
            this.player1_Name.BackColor = System.Drawing.Color.GreenYellow;
            this.player1_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player1_Name.Location = new System.Drawing.Point(188, 48);
            this.player1_Name.Multiline = true;
            this.player1_Name.Name = "player1_Name";
            this.player1_Name.Size = new System.Drawing.Size(180, 25);
            this.player1_Name.TabIndex = 2;
            this.player1_Name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.player1_Name.Visible = false;
            // 
            // player2_Lbl
            // 
            this.player2_Lbl.AutoSize = true;
            this.player2_Lbl.BackColor = System.Drawing.Color.Transparent;
            this.player2_Lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player2_Lbl.ForeColor = System.Drawing.Color.OrangeRed;
            this.player2_Lbl.Location = new System.Drawing.Point(51, 91);
            this.player2_Lbl.Name = "player2_Lbl";
            this.player2_Lbl.Size = new System.Drawing.Size(130, 31);
            this.player2_Lbl.TabIndex = 1;
            this.player2_Lbl.Text = "Player 2:";
            this.player2_Lbl.Visible = false;
            // 
            // player1_Lbl
            // 
            this.player1_Lbl.AutoSize = true;
            this.player1_Lbl.BackColor = System.Drawing.Color.Transparent;
            this.player1_Lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player1_Lbl.ForeColor = System.Drawing.Color.GreenYellow;
            this.player1_Lbl.Location = new System.Drawing.Point(51, 42);
            this.player1_Lbl.Name = "player1_Lbl";
            this.player1_Lbl.Size = new System.Drawing.Size(130, 31);
            this.player1_Lbl.TabIndex = 0;
            this.player1_Lbl.Text = "Player 1:";
            this.player1_Lbl.Visible = false;
            // 
            // playAgainPicture
            // 
            this.playAgainPicture.BackColor = System.Drawing.Color.Transparent;
            this.playAgainPicture.BackgroundImage = global::C__Day94.Properties.Resources._1921206_200;
            this.playAgainPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.playAgainPicture.Location = new System.Drawing.Point(490, 275);
            this.playAgainPicture.Name = "playAgainPicture";
            this.playAgainPicture.Size = new System.Drawing.Size(43, 34);
            this.playAgainPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.playAgainPicture.TabIndex = 14;
            this.playAgainPicture.TabStop = false;
            this.playAgainPicture.Visible = false;
            // 
            // playAgainBtn
            // 
            this.playAgainBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playAgainBtn.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.playAgainBtn.Location = new System.Drawing.Point(254, 265);
            this.playAgainBtn.Name = "playAgainBtn";
            this.playAgainBtn.Size = new System.Drawing.Size(296, 58);
            this.playAgainBtn.TabIndex = 13;
            this.playAgainBtn.Text = "REMATCH";
            this.playAgainBtn.UseVisualStyleBackColor = true;
            this.playAgainBtn.Visible = false;
            this.playAgainBtn.Click += new System.EventHandler(this.playAgainBtn_Click);
            // 
            // gameResult
            // 
            this.gameResult.BackColor = System.Drawing.Color.Transparent;
            this.gameResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameResult.Location = new System.Drawing.Point(170, 186);
            this.gameResult.Name = "gameResult";
            this.gameResult.Size = new System.Drawing.Size(496, 80);
            this.gameResult.TabIndex = 12;
            this.gameResult.Text = "ASGHAR WON";
            this.gameResult.Visible = false;
            // 
            // turnLabel
            // 
            this.turnLabel.AutoSize = true;
            this.turnLabel.BackColor = System.Drawing.Color.Transparent;
            this.turnLabel.Font = new System.Drawing.Font("MS Gothic", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.turnLabel.ForeColor = System.Drawing.Color.SeaGreen;
            this.turnLabel.Location = new System.Drawing.Point(539, 237);
            this.turnLabel.Name = "turnLabel";
            this.turnLabel.Size = new System.Drawing.Size(131, 54);
            this.turnLabel.TabIndex = 11;
            this.turnLabel.Text = "TURN";
            // 
            // col_3
            // 
            this.col_3.BackColor = System.Drawing.Color.Ivory;
            this.col_3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.col_3.Controls.Add(this.pictureBox3);
            this.col_3.Cursor = System.Windows.Forms.Cursors.Cross;
            this.col_3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.col_3.Location = new System.Drawing.Point(296, 170);
            this.col_3.Name = "col_3";
            this.col_3.Size = new System.Drawing.Size(80, 62);
            this.col_3.TabIndex = 3;
            this.col_3.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(0, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(80, 62);
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.col_3_Enter);
            // 
            // playerTurnText
            // 
            this.playerTurnText.AutoSize = true;
            this.playerTurnText.BackColor = System.Drawing.Color.Transparent;
            this.playerTurnText.Font = new System.Drawing.Font("MS PGothic", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerTurnText.ForeColor = System.Drawing.Color.SeaGreen;
            this.playerTurnText.Location = new System.Drawing.Point(489, 170);
            this.playerTurnText.Name = "playerTurnText";
            this.playerTurnText.Size = new System.Drawing.Size(0, 47);
            this.playerTurnText.TabIndex = 10;
            // 
            // col_8
            // 
            this.col_8.BackColor = System.Drawing.Color.Ivory;
            this.col_8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.col_8.Controls.Add(this.pictureBox8);
            this.col_8.Cursor = System.Windows.Forms.Cursors.Cross;
            this.col_8.Location = new System.Drawing.Point(210, 306);
            this.col_8.Name = "col_8";
            this.col_8.Size = new System.Drawing.Size(80, 62);
            this.col_8.TabIndex = 8;
            this.col_8.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox8.Location = new System.Drawing.Point(0, 0);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(80, 62);
            this.pictureBox8.TabIndex = 1;
            this.pictureBox8.TabStop = false;
            this.pictureBox8.Click += new System.EventHandler(this.col_8_Enter);
            // 
            // col_9
            // 
            this.col_9.BackColor = System.Drawing.Color.Ivory;
            this.col_9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.col_9.Controls.Add(this.pictureBox9);
            this.col_9.Cursor = System.Windows.Forms.Cursors.Cross;
            this.col_9.Location = new System.Drawing.Point(296, 306);
            this.col_9.Name = "col_9";
            this.col_9.Size = new System.Drawing.Size(80, 62);
            this.col_9.TabIndex = 9;
            this.col_9.TabStop = false;
            // 
            // pictureBox9
            // 
            this.pictureBox9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox9.Location = new System.Drawing.Point(0, 0);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(80, 62);
            this.pictureBox9.TabIndex = 1;
            this.pictureBox9.TabStop = false;
            this.pictureBox9.Click += new System.EventHandler(this.col_9_Enter);
            // 
            // col_7
            // 
            this.col_7.BackColor = System.Drawing.Color.Ivory;
            this.col_7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.col_7.Controls.Add(this.pictureBox7);
            this.col_7.Cursor = System.Windows.Forms.Cursors.Cross;
            this.col_7.Location = new System.Drawing.Point(124, 306);
            this.col_7.Name = "col_7";
            this.col_7.Size = new System.Drawing.Size(80, 62);
            this.col_7.TabIndex = 7;
            this.col_7.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox7.Location = new System.Drawing.Point(0, 0);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(80, 62);
            this.pictureBox7.TabIndex = 1;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.Click += new System.EventHandler(this.col_7_Enter);
            // 
            // col_5
            // 
            this.col_5.BackColor = System.Drawing.Color.Ivory;
            this.col_5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.col_5.Controls.Add(this.pictureBox5);
            this.col_5.Cursor = System.Windows.Forms.Cursors.Cross;
            this.col_5.Location = new System.Drawing.Point(210, 238);
            this.col_5.Name = "col_5";
            this.col_5.Size = new System.Drawing.Size(80, 62);
            this.col_5.TabIndex = 5;
            this.col_5.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox5.Location = new System.Drawing.Point(0, 0);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(80, 62);
            this.pictureBox5.TabIndex = 1;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.col_5_Enter);
            // 
            // col_6
            // 
            this.col_6.BackColor = System.Drawing.Color.Ivory;
            this.col_6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.col_6.Controls.Add(this.pictureBox6);
            this.col_6.Cursor = System.Windows.Forms.Cursors.Cross;
            this.col_6.Location = new System.Drawing.Point(296, 238);
            this.col_6.Name = "col_6";
            this.col_6.Size = new System.Drawing.Size(80, 62);
            this.col_6.TabIndex = 6;
            this.col_6.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox6.Location = new System.Drawing.Point(0, 0);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(80, 62);
            this.pictureBox6.TabIndex = 1;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Click += new System.EventHandler(this.col_6_Enter);
            // 
            // col_4
            // 
            this.col_4.BackColor = System.Drawing.Color.Ivory;
            this.col_4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.col_4.Controls.Add(this.pictureBox4);
            this.col_4.Cursor = System.Windows.Forms.Cursors.Cross;
            this.col_4.Location = new System.Drawing.Point(124, 238);
            this.col_4.Name = "col_4";
            this.col_4.Size = new System.Drawing.Size(80, 62);
            this.col_4.TabIndex = 4;
            this.col_4.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.Location = new System.Drawing.Point(0, 0);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(80, 62);
            this.pictureBox4.TabIndex = 1;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.col_4_Enter);
            // 
            // col_2
            // 
            this.col_2.BackColor = System.Drawing.Color.Ivory;
            this.col_2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.col_2.Controls.Add(this.pictureBox2);
            this.col_2.Cursor = System.Windows.Forms.Cursors.Cross;
            this.col_2.Location = new System.Drawing.Point(210, 170);
            this.col_2.Name = "col_2";
            this.col_2.Size = new System.Drawing.Size(80, 62);
            this.col_2.TabIndex = 2;
            this.col_2.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(80, 62);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.col_2_Enter);
            // 
            // col_1
            // 
            this.col_1.BackColor = System.Drawing.Color.Ivory;
            this.col_1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.col_1.Controls.Add(this.pictureBox1);
            this.col_1.Cursor = System.Windows.Forms.Cursors.Cross;
            this.col_1.Location = new System.Drawing.Point(124, 170);
            this.col_1.Name = "col_1";
            this.col_1.Size = new System.Drawing.Size(80, 62);
            this.col_1.TabIndex = 1;
            this.col_1.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 62);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.col_1_Enter);
            // 
            // gameTitle
            // 
            this.gameTitle.AutoSize = true;
            this.gameTitle.BackColor = System.Drawing.Color.Transparent;
            this.gameTitle.Font = new System.Drawing.Font("Tahoma", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameTitle.ForeColor = System.Drawing.SystemColors.Desktop;
            this.gameTitle.Location = new System.Drawing.Point(73, 58);
            this.gameTitle.Name = "gameTitle";
            this.gameTitle.Size = new System.Drawing.Size(452, 97);
            this.gameTitle.TabIndex = 0;
            this.gameTitle.Text = "Tic Tac Toe";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gameBox);
            this.Name = "Form1";
            this.Text = "TicTacToe";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gameBox.ResumeLayout(false);
            this.gameBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.playAgainPicture)).EndInit();
            this.col_3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.col_8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            this.col_9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            this.col_7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.col_5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.col_6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.col_4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.col_2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.col_1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gameBox;
        private System.Windows.Forms.GroupBox col_3;
        private System.Windows.Forms.GroupBox col_1;
        private System.Windows.Forms.GroupBox col_2;
        private System.Windows.Forms.GroupBox col_8;
        private System.Windows.Forms.GroupBox col_9;
        private System.Windows.Forms.GroupBox col_7;
        private System.Windows.Forms.GroupBox col_5;
        private System.Windows.Forms.GroupBox col_6;
        private System.Windows.Forms.GroupBox col_4;
        private System.Windows.Forms.Label playerTurnText;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label turnLabel;
        private System.Windows.Forms.Label gameTitle;
        private System.Windows.Forms.PictureBox playAgainPicture;
        private System.Windows.Forms.Button playAgainBtn;
        private System.Windows.Forms.Label gameResult;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox player2_Name;
        private System.Windows.Forms.TextBox player1_Name;
        private System.Windows.Forms.Label player2_Lbl;
        private System.Windows.Forms.Label player1_Lbl;
        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button newMatchBtn;
    }
}
