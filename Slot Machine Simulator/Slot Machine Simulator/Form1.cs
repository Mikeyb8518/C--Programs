using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Slot_Machine_Simulator
{
    public partial class slotMachine_Form : Form
    {
        // Declares random number variable
        Random rand = new Random();
        // Declares variables
        int random1, random2, random3;
        // Declares total and amount won variables
        double amountInserted;
        double amountWon;
        // Declares total Inserted and total won set to 0
        double totalInserted = 0.00;
        double totalWon = 0.00;
        // IsInputValid method used to see if input entered is valid
        private bool IsInputValid(string str)
        {
            bool Input = false;

            try
            {
                amountInserted = double.Parse(str);

                if (amountInserted > 0.00)
                {
                    Input = true;
                    totalInserted += amountInserted;
                }
            }
            catch
            {
                MessageBox.Show("Please Enter a Valid Dollar Amount");
            }

            return Input;
        }
        // WinOrLose method that takes number1, number2, number3 as arguments 
        // If number matches another number can when double that amount
        // If number matches all 3 can win triple that amount
        // If no number matches amountWon is 0
        private void WinOrLose (int number1, int number2, int number3)
        {
            amountWon = 0;
            
            if (number1 != number2 && number1 != number3 && number2 != number3)
            {
                MessageBox.Show("You Did Not Win, Please Spin Again!");
            }
            else if (number1 == number2 && number1 != number3)
            {
                amountWon = amountInserted * 2;
                totalWon += amountWon;
                MessageBox.Show("You have Won $" + amountWon.ToString("n2"));
            }
            else if (number1 != number2 && number1 == number3)
            {
                amountWon = amountInserted * 2;
                totalWon += amountWon;
                MessageBox.Show("You have won $" + amountWon.ToString("n2"));
            }
            else if (number1 != number2 && number2 == number3)
            {
                amountWon = amountInserted * 2;
                totalWon += amountWon;
                MessageBox.Show("You have won $" + amountWon.ToString("n2"));
            }
            else if (number1 == number2 && number1 == number3)
            {
                amountWon = amountInserted * 3;
                totalWon += amountWon;
                MessageBox.Show("You have won $" + amountWon.ToString("n2"));
            }
        }
        // ClearImages method clear pictureBox images
        private void ClearImages()
        {
            pictureBox1.Image = null;
            pictureBox2.Image = null;
            pictureBox3.Image = null;
        }

        private void spin_Button_Click(object sender, EventArgs e)
        {
            // string input is set to amount_Textbox as a string
            string input = amount_Textbox.Text;
            // If function that calls IsInputValid method to see if input argument returns true
            if (IsInputValid(input))
            {
                //  Sets random numbers 0-9
                random1 = rand.Next(10);
                random2 = rand.Next(10);
                random3 = rand.Next(10);
                // Declares PictureBoxes to fruitlist images and sets random number to delcare image called 
                pictureBox1.Image = fruitList1.Images[random1];
                pictureBox2.Image = fruitList1.Images[random2];
                pictureBox3.Image = fruitList1.Images[random3];
                // Calls WinOrLose method using random1, random2, random3 as arguments 
                WinOrLose(random1, random2, random3);
                // Calls ClearImages method to clear pictureBoxes
                ClearImages();
                // Sets amount_textbox to empty string
                amount_Textbox.Text = "";
                // Resets focus to amount_Textbox
                amount_Textbox.Focus();
            }
        }

        private void exit_Button_Click(object sender, EventArgs e)
        {
            // Message Box that displays the total amount played and total amount won 
            MessageBox.Show("You have inserted $" + totalInserted.ToString("n2") + "\n\n" +
                "You won $" + totalWon.ToString("n2"));
        }

        public slotMachine_Form()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
