using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Population
{
    public partial class population_Form : Form
    {
        public population_Form()
        {
            InitializeComponent();
        }

        private void calculate_Button_Click(object sender, EventArgs e)
        {
            try
            {
                // Variables
                double organisms = 0;
                double daily_increase = 0;
                double days = 0;
                double count = 1;
                double population = 0.0;
                // Takes users starting number data as a double, and puts converted data into organisms variable
                if (double.TryParse(startingNumber_Textbox.Text, out organisms))
                {
                    // Takes users daily increase percentage as a double, and puts converted data into daily_increase variable 
                    if (double.TryParse(dailyIncrease_Textbox.Text, out daily_increase))
                    {
                        // Takes users days entry and converts into a double, puts converted data into days variable
                        if (double.TryParse(days_Textbox.Text, out days))
                        {
                            // While count is less than or equal to days
                            while (count <= days)
                            {
                                // Sets population to number of organisms
                                population = organisms;
                                // Formula to find the increased population 
                                organisms = (population * daily_increase / 100) + population;
                                // Displays to Listbox the number of days and population as it increases
                                output_Listbox.Items.Add(count + "\t\t" + population);
                                // Count increases by 1
                                count++;
                            }
                        }
                        else
                        {
                            // Displays error message for days entry
                            MessageBox.Show("Invalid Entry for Days");
                        }
                    }
                    else
                    {
                        // Displays error message for daily percentage 
                        MessageBox.Show("Invalid Entry for Daily Percentage Increase");
                    }
                }
                else
                {
                    // Displays error message for starting population
                    MessageBox.Show("Invalid Entry for Starting Population");
                }
            }
            catch (Exception ex)
            {
                // Displays default error message
                MessageBox.Show(ex.Message);
            }
        }

        private void clear_Button_Click(object sender, EventArgs e)
        {
            // Clears users data entries and listbox
            startingNumber_Textbox.Text = "";
            dailyIncrease_Textbox.Text = "";
            days_Textbox.Text = "";
            output_Listbox.Items.Clear();
            // Resets focus to starting number textbox
            startingNumber_Textbox.Focus();
        }

        private void exit_Button_Click(object sender, EventArgs e)
        {
            // Closes form
            this.Close();
        }
    }
}
