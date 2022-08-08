using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Distance_File
{
    public partial class distanceFile_Form : Form
    {
        public distanceFile_Form()
        {
            InitializeComponent();
        }

        private void calculate_Button_Click(object sender, EventArgs e)
        {
            try
            {
                // Declares a Streamwriter variable
                StreamWriter outputfile;
                // Write Distance Traveled to a "Distance Traveled" Text file
                outputfile = File.CreateText("Distance Traveled.txt");
                // Declares variables, sets count to one
                double speed;
                double hours;
                double count = 1;
                double distance;
                // If function to convert user data to a double variable called "Speed"
                if (double.TryParse(speed_Textbox.Text, out speed))
                {
                    // If function to convert user data to a double variable called "hours"
                    if (double.TryParse(hours_Textbox.Text, out hours))
                    {
                        // While count is less than or equal to hours
                        while (count <= hours)
                        {
                            // Distance formula to calculate MPH(Speed * hours)
                            distance = speed * count;
                            // Writes A new line that outputs hours, and distance travleled
                            outputfile.WriteLine("After hour " + count + " the distance is " + distance);
                            // Increases count by 1 until hours is met
                            count++;
                        }
                        {
                            // Closes outputfile;
                            outputfile.Close();
                        }
                    }
                    else
                    {
                        // Displays error message for incorrect hours entry
                        MessageBox.Show("Invalid data entry for hours");
                    }
                }
                else
                {
                    // Displays error messafe for in correct MPH
                    MessageBox.Show("Invalid data entry for MPH");
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
            // Clears users entries 
            speed_Textbox.Text = "";
            hours_Textbox.Text = "";
            // Resets focus back to speed Textbox
            speed_Textbox.Focus();
        }

        private void exit_Button_Click(object sender, EventArgs e)
        {
            // Closes form
            this.Close();
        }
    }
}
