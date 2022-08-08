using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculating_the_Factorial_of_a_Number
{
    public partial class factorialNumber_Form : Form
    {
        public factorialNumber_Form()
        {
            InitializeComponent();
        }

        private void calculate_Button_Click(object sender, EventArgs e)
        {
            try
            {
                // Variables to hold number and count
                int number = 0;
                int count = 1;
                // Takes number variable to hold user data textbox
                number = Int32.Parse(data_Textbox.Text);
                // If number is less than 0
                if (number < 0)
                {
                    // Displays error message that number must be postive
                    MessageBox.Show("Please enter a valid positive number");
                }
                // While number is greater than 0
                while (number > 0)
                {
                    // Formula to get factorial total
                    count = count * number;
                    // Makes output label visible
                    output_Label.Visible = true;
                    // Displays count total to output label
                    output_Label.Text = count.ToString();
                    // Decreases count by 1
                    number--;
                }
            }
            catch (Exception ex)
            {
                // Default error message
                MessageBox.Show(ex.Message);
            }
        }

        private void clear_Button_Click(object sender, EventArgs e)
        {
            // Clears user data entry
            data_Textbox.Text = "";
            // Makes output label not visible
            output_Label.Visible = false;
            // Resets focus back to data textbox
            data_Textbox.Focus();
        }

        private void exit_Button_Click(object sender, EventArgs e)
        {
            // Closes form
            this.Close();
        }
    }
}
