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

        public sbyte player = 2;
        public sbyte turns = 0;
        public sbyte s1 = 0;
        public sbyte s2 = 0;
        public sbyte sd = 0;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

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
                if(CheckDraw()==true)
                {
                    MessageBox.Show("Tie Game!");
                    sd++;
                    NewGame();
                }
            }
        }
        bool CheckDraw() 
        {
            if (turns == 9)
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
        }

        private void btn_NewGame_Click(object sender, EventArgs e)
        {
            NewGame();
        }
    }
}
