using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Addition_Tutor
{
    public partial class addition_Tutor_Form : Form
    {
        public addition_Tutor_Form()
        {
            InitializeComponent();
        }

        private void generate_Button_Click(object sender, EventArgs e)
        {
            // Generates a random variable
            Random random = new Random();
            // num1 picks a number from 100-500
            // num2 picks a number from 100-500
            int num1 = random.Next(100, 501);
            int num2 = random.Next(100, 501);
            // Displays the num1 random number chosen to number 1 label
            // Displays the num2 random number chose to number 2 label
            number1_Label.Text = num1.ToString();
            number2_Label.Text = num2.ToString();
            // Sets focus to the answer textbox
            answer_Textbox.Focus();
        }

        private void check_Button_Click(object sender, EventArgs e)
        {
            // Formula to hold actual answer of number 1 and number 2 label total
            // Variable user_answer holds users data entry
            int answer = Convert.ToInt32(number1_Label.Text) + Convert.ToInt32(number2_Label.Text);
            int user_answer = int.Parse(answer_Textbox.Text);

            // If user_answer is not equal to answer
            if (user_answer != answer)
            {
                // Messagebox display incorrect answer message and shows correct answer
                MessageBox.Show("This is not the correct answer, The answer is " + answer.ToString());                
            }
            else
            {
                // Messagebox congrats user on the right answer entered
                MessageBox.Show("Congrats you have entered the correct answer");
            }
        }

        private void clear_Button_Click(object sender, EventArgs e)
        {
            // Sets number1 label to 0
            // Sets number2 label to 0
            // Clears answer textbox 
            number1_Label.Text = "0";
            number2_Label.Text = "0";
            answer_Textbox.Text = "";
        }

        private void exit_Button_Click(object sender, EventArgs e)
        {
            // Closes form
            this.Close();
        }
    }
}
