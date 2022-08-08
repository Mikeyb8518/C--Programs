using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rock__Paper__Scissors_Game
{
    public partial class rock_Paper_Scissor_Form : Form
    {
        public rock_Paper_Scissor_Form()
        {
            InitializeComponent();
        }
        // Declares variable
        int CompChoice;
        // ComputerChoice method 
        private void ComputerChoice()
        {
            // Declares Random Number 
            Random rand = new Random();
            // Uses CompChoice to get random number from 1-3
            CompChoice = rand.Next(1, 4);
            // If CompChoice is equal to 1
            if (CompChoice == 1)
            {
                // comp_Textbox is set to Rock
                comp_Textbox.Text = "Rock";
            }
            // Else if CompChoice is equal to 2
            else if (CompChoice == 2)
            {
                // comp_Textbox is set to Paper
                comp_Textbox.Text = "Paper";
            }
            // Else if CompChoice is equal to 3
            else if (CompChoice == 3)
            {
                // comp_Textbox is set to scissor
                comp_Textbox.Text = "Scissor";
            }           
        }
        // DisplayWinner Method
        private void DisplayWinner()
        {
            // If user_Textbox is equal to Rock and comp_Textbox is equal to Scissor
            // Or user_textbox is equal to Scissor and comp_Textbox is equal to Rock
            if ((user_Textbox.Text == "Rock" && comp_Textbox.Text == "Scissor") || (user_Textbox.Text == "Scissor" 
                && comp_Textbox.Text == "Rock"))
            {
                // Result box displays Rock smashes scissors
                result_Textbox.Text = "Rock Smashes Scissors";
            }
            // Else if user_Textbox is equal to scissor and comp_Textbox is equal to paper
            // Or user_Textbox is equal to paper and comp_Textbox is equal to scissor
            else if ((user_Textbox.Text == "Scissor" && comp_Textbox.Text == "Paper") || (user_Textbox.Text == "Paper" && 
                comp_Textbox.Text == "Scissor"))
            {
                // Result box displays scissors cut paper
                result_Textbox.Text = "Scissors Cuts Paper";
            }
            // Else if user_textbox is equal to paper and comp_Textbox is equal to rock
            //  Or user_Textbox is equal to rock and comp_Textbox is equal to paper
            else if ((user_Textbox.Text == "Paper" && comp_Textbox.Text == "Rock") || (user_Textbox.Text == "Rock" && 
                comp_Textbox.Text == "Paper"))
            {
                // Result textbox displays paper wraps rock
                result_Textbox.Text = "Paper Wraps Rock";
            }
            // Else if user_Textbox is equal to rock and comp_Textbox is equal to rock
            // Or user_Textbox is equal to scissor and comp_Textbox is equal to scissor
            // Or user_Textbox is equal to paper and comp_Textbox is equal to paper
            else if ((user_Textbox.Text == "Rock" && comp_Textbox.Text == "Rock") || (user_Textbox.Text == "Scissor" && 
                comp_Textbox.Text == "Scissor") || (user_Textbox.Text == "Paper" && comp_Textbox.Text == "Paper"))
            {
                // Result textbox displays game is a tie
                result_Textbox.Text = "Game Is A Tie!";
                // Messagebox displays Please try again, it's a tie
                MessageBox.Show("Please Try Again, It's A Tie!");
            }
        }

        private void rock_Paper_Scissor_Form_Load(object sender, EventArgs e)
        {

        }

        private void rock_Picturebox_Click(object sender, EventArgs e)
        {
            // When user clicks rock picturebox 
            // user_Textbox is set to Rock
            user_Textbox.Text = "Rock";
            // Calls ComputerChoice method, to get computers choice
            ComputerChoice();
            // Calls DisplayWinner method, Displays winning result
            DisplayWinner();
        }

        private void paper_Picturebox_Click(object sender, EventArgs e)
        {
            // When user clicks paper picturebox 
            // user_Textbox is set to paper
            user_Textbox.Text = "Paper";
            // Calls ComputerChoice method, to get computers choice
            ComputerChoice();
            // Calls DisplaysWinner method, Displays winning result
            DisplayWinner();
        }

        private void scissor_Picturebox_Click(object sender, EventArgs e)
        {
            // When user clicks scissor picturebox
            // user_Textbox is set to scissor
            user_Textbox.Text = "Scissor";
            // Calls ComputerChoice method, to get computers choice
            ComputerChoice();
            // Calls DisplaysWinner method, Displays winning result
            DisplayWinner();
        }
    }
}
