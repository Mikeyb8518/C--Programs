using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Distance_Calculator
{
    public partial class distanceCalculator_Form : Form
    {
        public distanceCalculator_Form()
        {
            InitializeComponent();
        }

        private void calculate_Button_Click(object sender, EventArgs e)
        {
            // Variables
            double speed;
            double hours;
            double count = 1;
            double distance;

            try
            {
                // If function to convert users MPH to a double
                if (double.TryParse(speed_Textbox.Text, out speed))
                {
                    // If function to convert users Hours entered to a double
                    if (double.TryParse(hours_Textbox.Text, out hours))
                    {
                        // While count is less than or equal too hours
                        while (count <= hours)
                        {
                            // Distance formula to calculate MPH
                            distance = speed * count;
                            // Adds count and distance to Listbox
                            distance_Listbox.Items.Add("After hour " + count + " the distance is " + distance);
                            // Count increases by 1
                            count++;
                        }
                    }
                    else
                    {
                        // Displays error message 
                        MessageBox.Show("Invalid entry for hours entered");
                    }
                }
                else
                {
                    // Displays error message
                    MessageBox.Show("Invalid entry for MPH entered");
                }

            }
            // Dislpays default error message
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void clear_Button_Click(object sender, EventArgs e)
        {
            // Clears users data entries, and Listbox
            speed_Textbox.Text = "";
            hours_Textbox.Text = "";
            distance_Listbox.Items.Clear();
            // Resets focus back to speed textbox
            speed_Textbox.Focus();
        }

        private void exit_Button_Click(object sender, EventArgs e)
        {
            // Closes form
            this.Close();
        }
    }
}
