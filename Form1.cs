using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToeGame
{
    public partial class Form1 : Form
    {
        string player1Name;
        string player2Name;
        int turn;
 
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if(turn == 1)
            {
                button1.Text = "O";
                checkGameState();
                turn = 2;
                label4.Text = player2Name + "'s turn";
            }
            else if(turn == 2)
            {
                button1.Text = "X";
                checkGameState();
                turn = 1;
                label4.Text = player1Name + "'s turn";
            }
            
        }

        private void button10_Click(object sender, EventArgs e) // Click Listener for start
        {
            player1Name = player1.Text;
            player2Name = player2.Text;
            setTurn();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (turn == 1)
            {
                button2.Text = "O";
                checkGameState();
                turn = 2;
                label4.Text = player2Name + "'s turn";
            }
            else if (turn == 2)
            {
                button2.Text = "X";
                checkGameState();
                turn = 1;
                label4.Text = player1Name + "'s turn";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (turn == 1)
            {
                button3.Text = "O";
                checkGameState();
                turn = 2;
                label4.Text = player2Name + "'s turn";
            }
            else if (turn == 2)
            {
                button3.Text = "X";
                checkGameState();
                turn = 1;
                label4.Text = player1Name + "'s turn";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (turn == 1)
            {
                button4.Text = "O";
                checkGameState();
                turn = 2;
                label4.Text = player2Name + "'s turn";
            }
            else if (turn == 2)
            {
                button4.Text = "X";
                checkGameState();
                turn = 1;
                label4.Text = player1Name + "'s turn";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (turn == 1)
            {
                button5.Text = "O";
                checkGameState();
                turn = 2;
                label4.Text = player2Name + "'s turn";
            }
            else if (turn == 2)
            {
                button5.Text = "X";
                checkGameState();
                turn = 1;
                label4.Text = player1Name + "'s turn";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (turn == 1)
            {
                button6.Text = "O";
                checkGameState();
                turn = 2;
                label4.Text = player2Name + "'s turn";
            }
            else if (turn == 2)
            {
                button6.Text = "X";
                checkGameState();
                turn = 1;
                label4.Text = player1Name + "'s turn";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (turn == 1)
            {
                button7.Text = "O";
                checkGameState();
                turn = 2;
                label4.Text = player2Name + "'s turn";
            }
            else if (turn == 2)
            {
                button7.Text = "X";
                checkGameState();
                turn = 1;
                label4.Text = player1Name + "'s turn";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (turn == 1)
            {
                button8.Text = "O";
                checkGameState();
                turn = 2;
                label4.Text = player2Name + "'s turn";
            }
            else if (turn == 2)
            {
                button8.Text = "X";
                checkGameState();
                turn = 1;
                label4.Text = player1Name + "'s turn";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (turn == 1)
            {
                button9.Text = "O";
                checkGameState();
                turn = 2;
                label4.Text = player2Name + "'s turn";
            }
            else if (turn == 2)
            {
                button9.Text = "X";
                checkGameState();
                turn = 1;
                label4.Text = player1Name + "'s turn";
            }
        }

        private void button11_Click(object sender, EventArgs e) //Click Listener for Replay
        {
            button1.Text = button2.Text = button3.Text = button4.Text = button5.Text = button6.Text = button7.Text = button8.Text = button9.Text = label5.Text = "";
            setTurn();
        }

        private void button12_Click(object sender, EventArgs e) //Click Listener for Quit
        {
            this.Close();
        }

        private void setTurn()
        {
            Random random = new Random();
            turn = random.Next(1, 3);
            if (turn == 1)
            {
                label4.Text = player1Name + "'s turn";
            }
            else if (turn == 2)
            {
                label4.Text = player2Name + "'s turn";
            }
        }
        private void checkGameState()
        {
            if((button1.Text == button2.Text && button2.Text == button3.Text && button3.Text == "O") || 
                (button4.Text == button5.Text && button5.Text == button6.Text && button6.Text == "O") ||
                (button7.Text == button8.Text && button8.Text == button9.Text && button9.Text == "O") ||
                (button1.Text == button4.Text && button4.Text == button7.Text && button7.Text == "O") ||
                (button2.Text == button5.Text && button5.Text == button8.Text && button8.Text == "O") ||
                (button3.Text == button6.Text && button6.Text == button9.Text && button9.Text == "O") ||
                (button1.Text == button5.Text && button5.Text == button9.Text && button9.Text == "O") ||
                (button3.Text == button5.Text && button5.Text == button7.Text && button7.Text == "O"))
            {
                label5.Text = "Congratulations!" + player1Name + ". You Won!";
            }
            else if((button1.Text == button2.Text && button2.Text == button3.Text && button3.Text == "X") || 
                (button4.Text == button5.Text && button5.Text == button6.Text && button6.Text == "X") ||
                (button7.Text == button8.Text && button8.Text == button9.Text && button9.Text == "X") ||
                (button1.Text == button4.Text && button4.Text == button7.Text && button7.Text == "X") ||
                (button2.Text == button5.Text && button5.Text == button8.Text && button8.Text == "X") ||
                (button3.Text == button6.Text && button6.Text == button9.Text && button9.Text == "X") ||
                (button1.Text == button5.Text && button5.Text == button9.Text && button9.Text == "X") ||
                (button3.Text == button5.Text && button5.Text == button7.Text && button7.Text == "X"))
            {
                label5.Text = "Congratulations!" + player2Name + ". You Won!";
            }
            else
            {
                if (button1.Text != "" && button2.Text != "" && button3.Text != "" && button4.Text != "" && button5.Text != "" && button6.Text != "" && button7.Text != "" && button8.Text != "" && button9.Text != "")
                    label5.Text = "Game Draw!";
            }
        }
    }
}
