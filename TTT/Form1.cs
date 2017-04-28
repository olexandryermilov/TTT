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
        public void restart()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    gameState[i, j] = 0;
                }
            }

            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";

            player = 1;

            winLabel.Visible = false;
            lostLabel.Visible = false;
            drawLabel.Visible = false;

            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;
        }
        public Form1()
        {
            InitializeComponent();
            restart();
        }
        public int[,] gameState = new int[3, 3];
        public int player = 1;
        public bool checkForWin(int player)
        {
            if (gameState[0, 0] * gameState[0, 1] * gameState[0, 2] == player * player * player) return true;
            if (gameState[1, 0] * gameState[1, 1] * gameState[1, 2] == player * player * player) return true;
            if (gameState[2, 0] * gameState[2, 1] * gameState[2, 2] == player * player * player) return true;
            if (gameState[0, 0] * gameState[1, 0] * gameState[2, 0] == player * player * player) return true;
            if (gameState[0, 1] * gameState[1, 1] * gameState[2, 1] == player * player * player) return true;
            if (gameState[0, 2] * gameState[1, 2] * gameState[2, 2] == player * player * player) return true;
            if (gameState[0, 0] * gameState[1, 1] * gameState[2, 2] == player * player * player) return true;
            if (gameState[2, 0] * gameState[1, 1] * gameState[0, 2] == player * player * player) return true;
            return false;
        }
        public bool checkForDraw()
        {
            for(int i=0;i<3;i++)
            {
                for(int j=0;j<3;j++)
                {
                    if (gameState[i, j] == 0) return false;
                }
            }
            return true;
        }
        public void gameOver(int playerWon)
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
            if (playerWon == 0) drawLabel.Visible = true;
            else if (playerWon == 1) winLabel.Visible = true;
            else lostLabel.Visible = true;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if(button1.Text=="")
            {
                if (player==1)
                    button1.Text = "X";
                else
                    button1.Text = "O";
                gameState[0, 0] = player;
                if(checkForWin(player))
                {
                    gameOver(player);
                }
                if(checkForDraw())
                {
                    gameOver(0);
                }
                player = 3-player;
               //makeMove();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button2.Text == "")
            {
                if (player==1)
                    button2.Text = "X";
                else
                    button2.Text = "O";
                gameState[0, 1] = player;
                if (checkForWin(player))
                {
                    gameOver(player);
                }
                if (checkForDraw())
                {
                    gameOver(0);
                }
                player = 3-player;
                //makeMove();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button3.Text == "")
            {
                if (player==1)
                    button3.Text = "X";
                else
                    button3.Text = "O";
                gameState[0, 2] = player;
                if(checkForWin(player))
                {
                    gameOver(player);
                }
                if (checkForDraw())
                {
                    gameOver(0);
                }
                player = 3 - player;
                //makeMove();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button4.Text == "")
            {
                if (player==1)
                    button4.Text = "X";
                else
                    button4.Text = "O";
                gameState[1, 0] = player;
                if(checkForWin(player))
                {
                    gameOver(player);
                }
                if (checkForDraw())
                {
                    gameOver(0);
                }
                player = 3 - player;
                //makeMove();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (button5.Text == "")
            {
                if (player==1)
                    button5.Text = "X";
                else
                    button5.Text = "O";
                gameState[1, 1] = player;
                if (checkForWin(player))
                {
                    gameOver(player);
                }
                if (checkForDraw())
                {
                    gameOver(0);
                }
                player = 3 - player;
                //makeMove();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (button6.Text == "")
            {
                if (player==1)
                    button6.Text = "X";
                else
                    button6.Text = "O";
                gameState[1, 2] = player;
                if (checkForWin(player))
                {
                    gameOver(player);
                }
                if (checkForDraw())
                {
                    gameOver(0);
                }
                player = 3 - player;
                //makeMove();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (button7.Text == "")
            {
                if (player==1)
                    button7.Text = "X";
                else
                    button7.Text = "O";
                gameState[2, 0] = player;
                if (checkForWin(player))
                {
                    gameOver(player);
                }
                if (checkForDraw())
                {
                    gameOver(0);
                }
                player = 3 - player;
                //makeMove();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (button8.Text == "")
            {
                if (player==1)
                    button8.Text = "X";
                else
                    button8.Text = "O";
                gameState[2, 1] = player;
                if (checkForWin(player))
                {
                    gameOver(player);
                }
                if (checkForDraw())
                {
                    gameOver(0);
                }
                player = 3 - player;
                //makeMove();
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (button9.Text == "")
            {
                if (player==1)
                    button9.Text = "X";
                else
                    button9.Text = "O";
                gameState[2, 2] = player;
                if (checkForWin(player))
                {
                    gameOver(player);
                }
                if (checkForDraw())
                {
                    gameOver(0);
                }
                player = 3 - player;
                //makeMove();
            }
        }

        private void restartButton_Click(object sender, EventArgs e)
        {
            restart();
        }
    }
}
