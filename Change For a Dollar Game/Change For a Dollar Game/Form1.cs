using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Change_For_a_Dollar_Game
{
    public partial class dollarGame_Form : Form
    {
        public dollarGame_Form()
        {
            InitializeComponent();
        }

        private void calculate_Button_Click(object sender, EventArgs e)
        {
            try
            {
                // Variables to convert users data to amount of change
                double penny_total = .01 * Convert.ToDouble(pennies_Textbox.Text);
                double nickle_total = .05 * Convert.ToDouble(nickels_Textbox.Text);
                double dime_total = .10 * Convert.ToDouble(dimes_Textbox.Text);
                double quarter_total = .25 * Convert.ToDouble(quarters_Textbox.Text);
                double total = penny_total + nickle_total + dime_total + quarter_total;

                // If change total is equal to 1
                if (total == 1)
                {
                    // Displays total in total box
                    // Displays message that you win
                    total_Textbox.Text = total.ToString("c");
                    MessageBox.Show("Congrats You Win!");
                }
                // If change is greater than 1
                else if (total > 1)
                {
                    // Displays total in total box
                    // Displays message that total was over 1 and to try again
                    total_Textbox.Text = total.ToString("c");
                    MessageBox.Show("Sorry but your total was over a dollar! Try again!");
                }
                // If change is less than 1
                else if (total < 1)
                {
                    // Displays total in total box 
                    // Displays message that total was less than 1 and to try again 
                    total_Textbox.Text = total.ToString("c");
                    MessageBox.Show("Sorry but your total was less than a dollar! Try again!");
                }
            }
            catch (Exception ex)
            {
                // Displays error message
                MessageBox.Show(ex.Message);
            }
        }
        private void exit_Button_Click(object sender, EventArgs e)
        {
            // Closes the form
            this.Close();
        }

        private void clear_Button_Click(object sender, EventArgs e)
        {
            // Clears textboxes 
            pennies_Textbox.Text = "";
            nickels_Textbox.Text = "";
            dimes_Textbox.Text = "";
            quarters_Textbox.Text = "";
            total_Textbox.Text = "";

            // Resets focus to Penny textbox
            pennies_Textbox.Focus();
        }
    }
}
