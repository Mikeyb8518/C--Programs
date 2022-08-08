using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Retail_Price_Calculator
{
    public partial class retail_Price_Form : Form
    {
        public retail_Price_Form()
        {
            InitializeComponent();
        }
        // CalculateRetail Method accepts two double arguments
        // and returns the retail total of the arguments
        private double CalculateRetail(double cost, double markup)
        {

            return (cost * markup) + cost;
        }

        private void calculate_Button_Click(object sender, EventArgs e)
        {
            // Declare variables to hold cost, markup and total
            double cost, markup, total;
            // Gets the cost of the item from user
            if (double.TryParse(cost_Textbox.Text, out cost))
            {
                // Gets the markup percentage of the item from user
                if (double.TryParse(markup_Textbox.Text, out markup))
                {
                    // Converts markup to a percentage
                    markup = markup / 100;
                    // Gets the total cost of the item 
                    total = CalculateRetail(cost, markup);
                    // Displays total 
                    total_Textbox.Text = total.ToString("c");
                }
                else
                {
                    // Displays error message
                    MessageBox.Show("Enter an integer for markup percentage");
                }
            }
            else
            {
                // Displays error message
                MessageBox.Show("Enter an intger for retail cost");
            }
        }

        private void clear_Button_Click(object sender, EventArgs e)
        {
            // Clears users entries and total textboxes
            cost_Textbox.Text = "";
            markup_Textbox.Text = "";
            total_Textbox.Text = "";
            // Resets focus to cost textbox
            cost_Textbox.Focus();
        }

        private void exit_Button_Click(object sender, EventArgs e)
        {
            // Closes form
            this.Close();
        }
    }
}
