//form1.cs
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C__Day94
{
    public partial class Form1 : Form
    {
        bool player = false;
        /*false = player 1
        true = player 2*/

        string player1_Sign = "check";
        string player2_Sign = "cross";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void gameBox_Enter(object sender, EventArgs e)
        {

        }
        private void addImg(object sender, EventArgs e)
        {
            if (!player)
            {
                pictureBox1.BackgroundImage = Image.FromFile("C:\\Users\\gitoi\\Desktop\\check.png");
            }
            else
            {
                pictureBox1.BackgroundImage = Image.FromFile("C:\\Users\\gitoi\\Desktop\\cross.png");
            }
            Debug.WriteLine(e);
            player = player ? false : true;
        }
        private void col_1_Enter(object sender, EventArgs e)
        {
        }
        private void col_2_Enter(object sender, EventArgs e)
        {

        }
        private void col_3_Enter(object sender, EventArgs e)
        {

        }

        private void col_4_Enter(object sender, EventArgs e)
        {

        }
        private void col_5_Enter(object sender, EventArgs e)
        {

        }
        private void col_6_Enter(object sender, EventArgs e)
        {

        }

        private void col_7_Enter(object sender, EventArgs e)
        {

        }
        private void col_8_Enter(object sender, EventArgs e)
        {

        }
        private void col_9_Enter(object sender, EventArgs e)
        {

        }
    }
}



//formdesgin.cs

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
            this.gameBox = new System.Windows.Forms.GroupBox();
            this.col_8 = new System.Windows.Forms.GroupBox();
            this.col_9 = new System.Windows.Forms.GroupBox();
            this.col_7 = new System.Windows.Forms.GroupBox();
            this.col_5 = new System.Windows.Forms.GroupBox();
            this.col_6 = new System.Windows.Forms.GroupBox();
            this.col_4 = new System.Windows.Forms.GroupBox();
            this.col_2 = new System.Windows.Forms.GroupBox();
            this.col_3 = new System.Windows.Forms.GroupBox();
            this.col_1 = new System.Windows.Forms.GroupBox();
            this.gameTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gameBox.SuspendLayout();
            this.col_8.SuspendLayout();
            this.col_9.SuspendLayout();
            this.col_7.SuspendLayout();
            this.col_5.SuspendLayout();
            this.col_6.SuspendLayout();
            this.col_4.SuspendLayout();
            this.col_2.SuspendLayout();
            this.col_3.SuspendLayout();
            this.col_1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gameBox
            // 
            this.gameBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.gameBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gameBox.Controls.Add(this.col_3);
            this.gameBox.Controls.Add(this.label1);
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
            // gameTitle
            // 
            this.gameTitle.AutoSize = true;
            this.gameTitle.BackColor = System.Drawing.Color.Transparent;
            this.gameTitle.Font = new System.Drawing.Font("Tahoma", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameTitle.ForeColor = System.Drawing.SystemColors.Desktop;
            this.gameTitle.Location = new System.Drawing.Point(63, 56);
            this.gameTitle.Name = "gameTitle";
            this.gameTitle.Size = new System.Drawing.Size(377, 81);
            this.gameTitle.TabIndex = 0;
            this.gameTitle.Text = "Tic Tac Toe";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Crimson;
            this.label1.Location = new System.Drawing.Point(499, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 140);
            this.label1.TabIndex = 10;
            this.label1.Text = "Player 1s\r\n  Turn\r\n";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(0, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(80, 62);
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.addImg);
            // 
            // pictureBox8
            // 
            this.pictureBox8.Location = new System.Drawing.Point(0, 0);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(80, 62);
            this.pictureBox8.TabIndex = 1;
            this.pictureBox8.TabStop = false;
            this.pictureBox8.Click += new System.EventHandler(this.addImg);
            // 
            // pictureBox9
            // 
            this.pictureBox9.Location = new System.Drawing.Point(0, 0);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(80, 62);
            this.pictureBox9.TabIndex = 1;
            this.pictureBox9.TabStop = false;
            this.pictureBox9.Click += new System.EventHandler(this.addImg);
            // 
            // pictureBox7
            // 
            this.pictureBox7.Location = new System.Drawing.Point(0, 0);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(80, 62);
            this.pictureBox7.TabIndex = 1;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.Click += new System.EventHandler(this.addImg);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Location = new System.Drawing.Point(0, 0);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(80, 62);
            this.pictureBox5.TabIndex = 1;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.addImg);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Location = new System.Drawing.Point(0, 0);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(80, 62);
            this.pictureBox6.TabIndex = 1;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Click += new System.EventHandler(this.addImg);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Location = new System.Drawing.Point(0, 0);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(80, 62);
            this.pictureBox4.TabIndex = 1;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.addImg);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(80, 62);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.addImg);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 62);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.addImg);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gameBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gameBox.ResumeLayout(false);
            this.gameBox.PerformLayout();
            this.col_8.ResumeLayout(false);
            this.col_9.ResumeLayout(false);
            this.col_7.ResumeLayout(false);
            this.col_5.ResumeLayout(false);
            this.col_6.ResumeLayout(false);
            this.col_4.ResumeLayout(false);
            this.col_2.ResumeLayout(false);
            this.col_3.ResumeLayout(false);
            this.col_1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gameBox;
        private System.Windows.Forms.Label gameTitle;
        private System.Windows.Forms.GroupBox col_3;
        private System.Windows.Forms.GroupBox col_1;
        private System.Windows.Forms.GroupBox col_2;
        private System.Windows.Forms.GroupBox col_8;
        private System.Windows.Forms.GroupBox col_9;
        private System.Windows.Forms.GroupBox col_7;
        private System.Windows.Forms.GroupBox col_5;
        private System.Windows.Forms.GroupBox col_6;
        private System.Windows.Forms.GroupBox col_4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

