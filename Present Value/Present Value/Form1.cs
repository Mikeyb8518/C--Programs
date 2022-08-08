using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Present_Value
{
    public partial class present_Value_Form : Form
    {
        public present_Value_Form()
        {
            InitializeComponent();
        }
        // PresentValue method that takes future, interest, years as arguments
        // Returns Present Value Formula
        private double PresentValue(double future, double interest, double years)
        {
            return future / Math.Pow(1 + interest / 100, years);
        }
        // ClearValues method that clear all users entries 
        private void ClearValues()
        {
            future_Value_Textbox.Text = null;
            interest_Rate_Textbox.Text = null;
            num_Years_Textbox.Text = null;
        }

        private void calculate_Button_Click(object sender, EventArgs e)
        {
            try
            {
                // Declares double variables
                double future, interest, years, total;
                // Future variable that takes users future value entry as a double
                future = double.Parse(future_Value_Textbox.Text);
                // Interest variable that takes users interest rate as a double
                interest = double.Parse(interest_Rate_Textbox.Text);
                // Years variable that takes users years as a double
                years = double.Parse(num_Years_Textbox.Text);
                // If statement that if future, interest and years are not equal to 0
                if (future != 0 && interest != 0 && years != 0)
                {
                    // total calls PresentValue method with users enteries as arguments
                    total = PresentValue(future, interest, years);
                    // Makes output label visible
                    output_Label.Visible = true;
                    // Displays total to string
                    output_Label.Text = total.ToString("c");
                }
                else
                {
                    // Displays invalid entry message
                    MessageBox.Show("Please Enter a Valid Entry");
                    // Resets focus back to future value textbox
                    future_Value_Textbox.Focus();
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
            // ClearValues method that clears all users enteries 
            ClearValues();
            // Makes output_label not visible
            output_Label.Visible = false;
            // Sets output_label tp 0 
            output_Label.Text = "0";
            // Resets future value focus
            future_Value_Textbox.Focus();
        }

        private void exit_Button_Click(object sender, EventArgs e)
        {
            // Closes form
            this.Close();
        }
    }
}
