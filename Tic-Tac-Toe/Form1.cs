using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_Tac_Toe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public sbyte player = 2; //even = X turn; odd = O turn
        public sbyte turns = 0; //counting turns
        public sbyte s1 = 0;
        public sbyte s2 = 0;
        public sbyte draws = 0;
        //counting wins for both players and draws;

     

        private void Settings_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            MessageBox.Show("Tic Tac Toe\n\nHOW TO PLAY?\n\nThere are two players. Each Player places one of their" +
                " game pieces in one of the squares. Second person puts their game place in a square.\n\nContinue" +
                " taking turns, with each person putting a game piece in one empty square on each turn.\n\n" +
                "Whoever gets three of their game pieces in a row (horizontally, diagonally or vertically)," +
                " first wins the game.\n\nIf all nine squares are filled with no one having three in a row, it's a" +
                " draw, so PLAY AGAIN!\n\nGOODLUCK & ENJOY :)");
        }

        private void buttonClick(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (button.Text == "")
            {
                if (player % 2 == 0)
                {
                    button.Text = "X";
                    player++;
                    turns++;
                }
                else
                {
                    button.Text = "O";
                    player++;
                    turns++;
                }

                if (CheckDraw() == true)
                {
                    MessageBox.Show("Tie Game!");
                    draws++;
                    NewGame();
                }

                if (CheckWinner() == true)
                {
                    if (button.Text == "X")
                    {
                        MessageBox.Show("X Won!");
                        s1++;
                        NewGame();
                    }

                    else
                    {
                        MessageBox.Show("O Won!");
                        s2++;
                        NewGame();
                    }
                }
            }
        }
        bool CheckDraw()
        {
            if ((turns == 9) && CheckWinner() == false)
                return true;
            else
                return false;
        }

        bool CheckWinner()
        {
        //horizontal checks
        if ((btn_bottomRight.Text == btn_bottomCenter.Text) && (btn_bottomCenter.Text == btn_bottomLeft.Text)
            && btn_bottomRight.Text != "")
            return true;
        else if ((btn_centerRight.Text == btn_centerCenter.Text) && (btn_centerCenter.Text == btn_centerLeft.Text)
            && btn_centerRight.Text != "")
            return true;
        else if ((btn_topRight.Text == btn_topCenter.Text) && (btn_topCenter.Text == btn_topLeft.Text)
            && btn_topRight.Text != "")
            return true;

        //vertical checks
        if ((btn_bottomRight.Text == btn_centerRight.Text) && (btn_centerRight.Text == btn_topRight.Text)
            && btn_bottomRight.Text != "")
            return true;
        else if ((btn_bottomCenter.Text == btn_centerCenter.Text) && (btn_centerCenter.Text == btn_topCenter.Text)
            && btn_bottomCenter.Text != "")
            return true;
        else if ((btn_bottomLeft.Text == btn_centerLeft.Text) && (btn_centerLeft.Text == btn_topLeft.Text)
            && btn_bottomLeft.Text != "")
            return true;

        //diagonal checks
        if ((btn_bottomRight.Text == btn_centerCenter.Text) && (btn_centerCenter.Text == btn_topLeft.Text)
            && btn_bottomRight.Text != "")
            return true;
        else if ((btn_bottomLeft.Text == btn_centerCenter.Text) && (btn_centerCenter.Text == btn_topRight.Text)
            && btn_bottomLeft.Text != "")
            return true;
        else
            return false;

        }
        

        void NewGame() 
        {
            player = 2;
            turns = 0;
            btn_bottomRight.Text = btn_bottomCenter.Text = btn_bottomLeft.Text = btn_centerRight.Text =
                btn_centerCenter.Text = btn_centerLeft.Text = btn_topRight.Text = btn_topCenter.Text =
                btn_topLeft.Text = "";

            XWins.Text = "XWins: " + s1;
            OWins.Text = "OWins: " + s2;
            DrawScore.Text = ": " + draws;
        }

        private void btn_NewGame_Click(object sender, EventArgs e)
        {
            NewGame();
        }

        void Reset()
        {
            s1 = s2 = draws = 0;
            NewGame();
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            XWins.Text = "XWins: " + s1;
            OWins.Text = "OWins: " + s2;
            DrawScore.Text = ": " + draws;
        }
    }
}
