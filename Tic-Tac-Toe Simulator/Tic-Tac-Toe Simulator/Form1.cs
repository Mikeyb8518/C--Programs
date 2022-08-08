using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_Tac_Toe_Simulator
{
    public partial class game_Form : Form
    {

        const int ROW = 3;
        const int COL = 3;

        int[,] gameBoard = new int[ROW, COL];
        string[,] Xs_and_Os = new string[ROW, COL];

        Random Rand = new Random();
        public game_Form()
        {
            InitializeComponent();
        }

        private void GetXsandOs(int[,] gamepieces)
        {
            for (int row = 0; row < ROW; row++)
            {
                for (int col = 0; col < COL; col++)
                {
                    gamepieces[row, col] = Rand.Next(2);
                }
            }
        }

        private void ConvertToLetters(int[,] gamepieces)
        {
            for (int row = 0; row < ROW; row++)
            {
                for (int col = 0; col < COL; col++)
                {
                    if (gamepieces[row, col] == 0)
                    {
                        Xs_and_Os[row, col] = "O";
                    }
                    else
                    {
                        Xs_and_Os[row, col] = "X";
                    }
                }
            }
        }

        private void DisplayWinner()
        {
            if (gameBoard[0,0] == gameBoard[0,1] && gameBoard[0,1] == gameBoard[0,2])
            {
                output_Winner_Textbox.Text = Xs_and_Os[0, 0] + " Wins!";
            }
            else if (gameBoard[0,0] == gameBoard[1,1] && gameBoard[1,1] == gameBoard[2,2])
            {
                output_Winner_Textbox.Text = Xs_and_Os[0, 0] + " Wins!";
            }
            else if (gameBoard[0, 0] == gameBoard[1, 0] && gameBoard[1, 0] == gameBoard[2,0])
            {
                output_Winner_Textbox.Text = Xs_and_Os[0, 0] + " Wins!";
            }
            else if (gameBoard[1, 0] == gameBoard[1, 1] && gameBoard[1,1] == gameBoard[1, 2])
            {
                output_Winner_Textbox.Text = Xs_and_Os[1, 0] + " Wins!";
            }
            else if (gameBoard[0, 1] == gameBoard[1, 1] && gameBoard[1, 1] == gameBoard[2, 1])
            {
                output_Winner_Textbox.Text = Xs_and_Os[0, 1] + " Wins!";
            }
            else if (gameBoard[0, 2] == gameBoard[1, 2] && gameBoard[1, 2] == gameBoard[2, 2])
            {
                output_Winner_Textbox.Text = Xs_and_Os[0, 2] + " Wins!";
            }
            else if (gameBoard[2, 0] == gameBoard[2, 1] && gameBoard[2, 1] == gameBoard[2, 2])
            {
                output_Winner_Textbox.Text = Xs_and_Os[2, 0] + " Wins!";
            }
            else
            {
                output_Winner_Textbox.Text = "Game Is A Tie!";
            }
        }

        private void DisplayLetters(string[,] letters)
        {
            label1.Visible = true;
            label1.Text = Xs_and_Os[0, 0].ToString();

            label2.Visible = true;
            label2.Text = Xs_and_Os[0, 1].ToString();

            label3.Visible = true;
            label3.Text = Xs_and_Os[0, 2].ToString();

            label4.Visible = true;
            label4.Text = Xs_and_Os[1, 0].ToString();

            label5.Visible = true;
            label5.Text = Xs_and_Os[1, 1].ToString();

            label6.Visible = true;
            label6.Text = Xs_and_Os[1, 2].ToString();

            label7.Visible = true;
            label7.Text = Xs_and_Os[2, 0].ToString();

            label8.Visible = true;
            label8.Text = Xs_and_Os[2, 1].ToString();

            label9.Visible = true;
            label9.Text = Xs_and_Os[2, 2].ToString();
        }

        private void new_Game_Button_Click(object sender, EventArgs e)
        {
            GetXsandOs(gameBoard);

            ConvertToLetters(gameBoard);

            DisplayLetters(Xs_and_Os);

            DisplayWinner();
        }

        private void exit_Button_Click(object sender, EventArgs e)
        {

            this.Close();
        }
    }
}
