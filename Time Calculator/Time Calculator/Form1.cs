using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Time_Calculator
{
    public partial class time_calculator_Form : Form
    {
        public time_calculator_Form()
        {
            InitializeComponent();
        }

        private void convert_Button_Click(object sender, EventArgs e)
        {
            try
            {
                // Variables to hold user seconds and work
                double seconds = Convert.ToDouble(seconds_Textbox.Text);
                double works = Convert.ToDouble(works_Textbox.Text);

                // Formula variable to hold total seconds, and hold total
                double total_sec = seconds * works;
                double total;

                // Total seconds is greater than 60 seconds and less than 3600 seconds
                if (total_sec >= 60 && total_sec < 3600)
                {
                    // Total is divided by 60
                    total = total_sec / 60;
                    // Displays display_label to say Number of minutes
                    display_Label.Visible = true;
                    display_Label.Text = "Number of Minutes: ";
                    // Displays total to output textbox
                    output_Textbox.Text = total.ToString("n2");
                }
                // If total seconds is greater than 3600 and less than 86400
                else if (total_sec >= 3600 && total_sec < 86400)
                {
                    // Total is divided by 3600
                    total = total_sec / 3600;
                    // Display label is visable, displays Number of hours
                    display_Label.Visible = true;
                    display_Label.Text = "Number of Hours: ";
                    // Displays total to output textbox
                    output_Textbox.Text = total.ToString("n2");
                }
                // If total is greater than or equal to 86400 seconds
                else if (total_sec >= 86400)
                {
                    // Total is divided by 86400
                    total = total_sec / 86400;
                    // Display label is made visable and displays Number of days
                    display_Label.Visible = true;
                    display_Label.Text = "Number of Days: ";
                    // Displays total to output textbox
                    output_Textbox.Text = total.ToString("n2");
                }
                // If total is less than 0, Displays error message
                else if (total_sec < 0)
                {
                    MessageBox.Show("Please Enter Number of Seconds");
                }
            }
            // Displays default error message
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void clear_Button_Click(object sender, EventArgs e)
        {
            // Clears users data, display label, output textbox
            // Resets focus back to seconds textbox
            seconds_Textbox.Text = "";
            works_Textbox.Text = "";
            display_Label.Text = "";
            output_Textbox.Text = "";

            seconds_Textbox.Focus();
        }

        private void exit_Button_Click(object sender, EventArgs e)
        {
            // Closes form
            this.Close();
        }
    }
}
