using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calories_from_Fat_and_Carbohydrates
{
    public partial class Calories_Fat_Carbs_Form : Form
    {
        public Calories_Fat_Carbs_Form()
        {
            InitializeComponent();
        }
        // Fatcalories method that accepts fatGrams as an argument
        private int FatCalories(int fatGrams)
        {
            // Returns fatgram to calories
            return fatGrams * 9;
        }
        // CarbCalories method that accepts carbGrams as an argument
        private int CarbCalories(int carbGrams)
        {
            // Returns carbGrams to calories
            return carbGrams * 4;
        }
        private void calculate_Button_Click(object sender, EventArgs e)
        {
            // Declares variables
            int fatGrams, carbGrams, total;
            // Get the number of fatGrams
            if (int.TryParse(fatGrams_Textbox.Text, out fatGrams))
            {
                // Get the number of carbGrams
                if (int.TryParse(carbs_Textbox.Text, out carbGrams))
                {
                    // Gets the total of calroies using FatCalories method with fatGrams as an argument
                    // Uses CarbCalories method with carbGrams as an argument 
                    total = FatCalories(fatGrams) + CarbCalories(carbGrams);
                    // Makes output label visable
                    output_Label.Visible = true;
                    // Displays total to output label
                    output_Label.Text = total.ToString() + " Calories";
                }
                else
                {
                    // Displays error message
                    MessageBox.Show("Please Enter a Valid Integer for Carbs");
                }
            }
            else
            {
                // Displays error message
                MessageBox.Show("Please Enter a Valid Integer for Fat Grams");
            }
        }

        private void clear_Button_Click(object sender, EventArgs e)
        {
            // Clears textboxes and sets output label to 0
            fatGrams_Textbox.Text = "";
            carbs_Textbox.Text = "";
            output_Label.Text = "0";
            // Makes output label not visable
            output_Label.Visible = false;
            // Resets fatGrams textbox focus
            fatGrams_Textbox.Focus();
        }

        private void exit_Button_Click(object sender, EventArgs e)
        {
            // Closes form
            this.Close();
        }
    }
}
