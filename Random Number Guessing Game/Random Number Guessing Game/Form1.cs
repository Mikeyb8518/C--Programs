using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Random_Number_Guessing_Game
{
    public partial class random_Number_Form : Form
    {
        // Public variable to hold count set to 0
        int count = 0;
        public random_Number_Form()
        {
            InitializeComponent();

            // Random variable
            Random random = new Random();
            // Integer variable guess set to random numbers 1-100
            int guess = random.Next(1, 101);
            // Displays guess(1-100) in random number label
            random_Number_Label.Text = guess.ToString();
        }

        public void check_Button_Click(object sender, EventArgs e)
        {
            // Variable user_guess to hold user answer
            int user_guess = Int32.Parse(user_Answer_Textbox.Text);
            // If user guess is less than random number chosen
            if (user_guess < Convert.ToInt32(random_Number_Label.Text))
            {
                // Answer label is visible
                answer_Label.Visible = true;
                // Displays "too low try again" in answer label
                answer_Label.Text = "Too low, try again";
                // Increases count
                count++;
                // Resets user answer textbox
                user_Answer_Textbox.Text = "";
            }
            // If user guess is greater than random number chosen
            else if (user_guess > Convert.ToInt32(random_Number_Label.Text))
            {
                // Answer label is visible
                answer_Label.Visible = true;
                // Displays "Too high, try again" in answer label
                answer_Label.Text = "Too high, try again";
                // Increaes count
                count++;
                // Resets user answer textbox
                user_Answer_Textbox.Text = "";
            }
            // else user guess is equal to random number chosen
            else
            {
                // Answer label visibilty set to false
                answer_Label.Visible = false;
                // Random number is visible
                random_Number_Label.Visible = true;
                // Increases count
                count++;
                // Messagebox that displays congrats you got the right number and the number of guesses
                MessageBox.Show("Congrats you got the right number!, Try again!" + "\n The number of guesses was " + count);
                // Random number label visblity to false
                random_Number_Label.Visible = false;
                // Resets random number label to a new random number
                random_Number_Label.Focus();
                // Clears user answer textbox
                user_Answer_Textbox.Text = "";  
            }
        }

        private void random_Number_Form_Load(object sender, EventArgs e)
        {

        }

        private void exit_Button_Click(object sender, EventArgs e)
        {
            // Closes form
            this.Close();
        }
    }
}
