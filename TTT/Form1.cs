using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TTT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public int[,] gameState = new int[3, 3];
        public bool player1 = true;
        public bool checkForWin(int player)
        {
            if (gameState[0, 0] * gameState[0, 1] * gameState[0, 2] == player * player * player) return true;
            if (gameState[1, 0] * gameState[1, 1] * gameState[1, 2] == player * player * player) return true;
            if (gameState[2, 0] * gameState[2, 1] * gameState[2, 2] == player * player * player) return true;
            if (gameState[0, 0] * gameState[0, 0] * gameState[0, 0] == player * player * player) return true;
            if (gameState[0, 1] * gameState[0, 1] * gameState[0, 1] == player * player * player) return true;
            if (gameState[0, 2] * gameState[0, 2] * gameState[0, 2] == player * player * player) return true;
            if (gameState[0, 0] * gameState[1, 1] * gameState[2, 2] == player * player * player) return true;
            if (gameState[2, 0] * gameState[1, 1] * gameState[0, 2] == player * player * player) return true;
            return false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if(button1.Text=="")
            {
                if (player1)
                    button1.Text = "X";
                else
                    button1.Text = "O";
                gameState[0, 0] = 1;
               //makeMove();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button2.Text == "")
            {
                if (player1)
                    button2.Text = "X";
                else
                    button2.Text = "O";
                gameState[0, 1] = 1;
                //makeMove();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button3.Text == "")
            {
                if (player1)
                    button3.Text = "X";
                else
                    button3.Text = "O";
                gameState[0, 2] = 1;
                //makeMove();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button4.Text == "")
            {
                if (player1)
                    button4.Text = "X";
                else
                    button4.Text = "O";
                gameState[1, 0] = 1;
                //makeMove();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (button5.Text == "")
            {
                if (player1)
                    button5.Text = "X";
                else
                    button5.Text = "O";
                gameState[1, 1] = 1;
                //makeMove();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (button6.Text == "")
            {
                if (player1)
                    button6.Text = "X";
                else
                    button6.Text = "O";
                gameState[1, 2] = 1;
                //makeMove();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (button7.Text == "")
            {
                if (player1)
                    button7.Text = "X";
                else
                    button7.Text = "O";
                gameState[2, 0] = 1;
                //makeMove();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (button8.Text == "")
            {
                if (player1)
                    button8.Text = "X";
                else
                    button8.Text = "O";
                gameState[2, 1] = 1;
                //makeMove();
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (button9.Text == "")
            {
                if (player1)
                    button9.Text = "X";
                else
                    button9.Text = "O";
                gameState[2, 2] = 1;
                //makeMove();
            }
        }
    }
}
