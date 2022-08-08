using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Body_Mass_Index_Program_Enhancement
{
    public partial class BMI_Form : Form
    {
        public BMI_Form()
        {
            InitializeComponent();
        }

        private void convert_Button_Click(object sender, EventArgs e)
        {
            try
            {
                // Variables to hold users weight, height
                // Variable to hold BMI formula
                double weight = double.Parse(weight_Textbox.Text);
                double height = double.Parse(height_Textbox.Text);
                double BMI = weight * 703 / (height * height);

                // If BMI is less than or equal to 18.5
                if(BMI <= 18.5)
                {
                    // Displays BMI total
                    // Displays Underweight
                    total_Textbox.Text = BMI.ToString("n2");
                    output_Textbox.Text = "Underweight";
                }
                // If BMI is between 18.5 - 25 percent
                else if(BMI > 18.5 && BMI < 25)
                {
                    // Displays BMI total
                    // Displays Optimal
                    total_Textbox.Text = BMI.ToString("n2");
                    output_Textbox.Text = "Optimal";
                }
                // If BMI is greater than 25
                else if(BMI > 25)
                {
                    // Displays BMI total
                    // Displays Overweight
                    total_Textbox.Text = BMI.ToString("n2");
                    output_Textbox.Text = "Overweight";
                }
            }
            catch (Exception ex)
            {
                // Error message
                MessageBox.Show(ex.Message);
            }
        }

        private void clear_Button_Click(object sender, EventArgs e)
        {
            // Clears Textboxes and resets focus
            weight_Textbox.Text = "";
            height_Textbox.Text = "";
            total_Textbox.Text = "";
            output_Textbox.Text = "";

            height_Textbox.Focus();
        }

        private void exit_Button_Click(object sender, EventArgs e)
        {
            // Closes form
            this.Close();
        }
    }
}
