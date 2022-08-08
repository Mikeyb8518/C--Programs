using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fat_Percentage_Calculator
{
    public partial class Fat_Percentage_Form : Form
    {
        public Fat_Percentage_Form()
        {
            InitializeComponent();
        }

        private void calculate_Button_Click(object sender, EventArgs e)
        {
            try
            {
                // User enters total calories and fat grams
                int total_calories = Convert.ToInt32(num_cals_Text.Text);
                int fat_grams = Convert.ToInt32(fatgrams_Text.Text);

                // If function for if calories and total grams less than 0
                if (total_calories < 0 && fat_grams < 0)
                {
                    // Displays error message within calories or fat grams enetred incorrectly
                    MessageBox.Show("Calories" + " or Fat Grams" + " entered incorrectly");
                }
                else
                {
                    // variable to convert fat grams to fat calories
                    int fat_calories = fat_grams * 9;

                    // If total calories are less than fat calories
                    if (total_calories < fat_calories)
                    {
                        // Display error message for calories or fat grams
                        MessageBox.Show("Calories" + " or Fat Grams" + " entered incorrectly");
                    }
                    else
                    {
                        // If low fat checkbox is checked
                        if (lowfat_checkBox.Checked == true)
                        {
                            // makes low fat label visable
                            lowfat_Label.Show();

                            // Variable to hold formula for low fat that is 30%
                            int low = (total_calories * 30) / 100;

                            // If fat calories are less than 30% 
                            if (fat_calories < low)
                            {
                                // Low fat label displays "Low fat Food"
                                lowfat_Label.Text = "A low-fat food";
                            }
                            else
                            {
                                // Low fat label displays "Not a low fat food"
                                lowfat_Label.Text = "Not a low-fat food";
                            }
                        }

                        else
                        {
                            // Hides low fat label
                            lowfat_Label.Hide();
                        }

                            // Variable to convert calories to percentage
                            double percent_cal = (fat_calories * 100) / total_calories;
                            
                            // Displays fat calories to string, and percentage
                            output_cal_Label.Text = fat_calories.ToString();
                            output_percentage_Label.Text = percent_cal.ToString();
                        
                    }
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
            // Clears texts boxes and total labels
            num_cals_Text.Text = "";
            fatgrams_Text.Text = "";
            lowfat_checkBox.Focus();
            output_cal_Label.Text = "0";
            output_percentage_Label.Text = "0";
            lowfat_Label.Text = "";
        }

        private void exit_Button_Click(object sender, EventArgs e)
        {
            // Closes form
            this.Close();
        }
    }
}
