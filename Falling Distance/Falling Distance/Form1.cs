using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Falling_Distance
{
    public partial class falling_distance_Form : Form
    {
        public falling_distance_Form()
        {
            InitializeComponent();
        }
        // Falling Distance Method that provides default arguments for distance and gravity parameters
        // Holds a argument for seconds
        private double FallingDistance(double seconds, double distance = 0.5, double gravity = 9.8)
        {
            // Returns the distance formula 
            return (seconds * seconds) * distance * gravity;
        }

        private void convert_Button_Click(object sender, EventArgs e)
        {
            // Declares local double variable 
            double seconds;
            // Gets the users seconds
            if (double.TryParse(seconds_Textbox.Text, out seconds))
            {
                // Displays total by calling the FallingDistance Method and returns the formula to a string in meters
                total_textbox.Text = FallingDistance(seconds).ToString() + " Meters";
            }
            else
            {
                // Displays error message 
                MessageBox.Show("Please Enter a Valid Number of Seconds");
            }
        }

        private void clear_Button_Click(object sender, EventArgs e)
        {
            // Clears seconds and total textboxes
            seconds_Textbox.Text = "";
            total_textbox.Text = "";
            // Resets focus back to seconds textbox
            seconds_Textbox.Focus();
        }

        private void exit_Button_Click(object sender, EventArgs e)
        {
            // Closes form
            this.Close();
        }
    }
}
