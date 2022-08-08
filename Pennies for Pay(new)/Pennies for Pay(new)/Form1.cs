using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pennies_for_Pay_new_
{
    public partial class pennies_Form : Form
    {
        public pennies_Form()
        {
            InitializeComponent();
        }

        private void calculate_Button_Click(object sender, EventArgs e)
        {
            try
            {
                // Variables
                double pennies = .01;
                double days = 0;
                double count = 1;
                double total = 0;
                // If function that converts users day entry to a double, puts data into days variable
                if (double.TryParse(days_Textbox.Text, out days))
                {
                    // While count is less than or equal to days
                    while (count <= days)
                    {
                        // Variable to hold value of pennies
                        total = pennies;
                        // Formula to double each penny
                        pennies = pennies + pennies;
                        // Displays output to listbox, that displays days and total
                        output_Listbox.Items.Add("Salary for day " + count.ToString() + " is " + total.ToString("c") + " pennies");
                        // Adds 1 to count
                        count++;
                    }
                }
                else
                {
                    // Error message that displats invalid entry for days entered
                    MessageBox.Show("Invalid Entry For Number Of Days, Please Try Again.");
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
            // Clears days textbox and clears listbox
            days_Textbox.Text = "";
            output_Listbox.Items.Clear();
            // Resets focus back to days textbox
            days_Textbox.Focus();
        }

        private void exit_Button_Click(object sender, EventArgs e)
        {
            // Closes form
            this.Close();
        }
    }
}
