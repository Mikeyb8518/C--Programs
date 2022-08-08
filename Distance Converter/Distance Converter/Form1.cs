using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Distance_Converter
{
    public partial class distanceConverter_Form : Form
    {
        public distanceConverter_Form()
        {
            InitializeComponent();
        }

        private void convert_Button_Click(object sender, EventArgs e)
        {
            try
            {
                // Varibale to hold users value entered
                double value = Convert.ToDouble(distance_Textbox.Text);

                // Variable to hold the total
                double total;

                // If user selects Yards and Feet will convert
                if (from_Listbox.SelectedItem.ToString() == "Yards" && to_Listbox.SelectedItem.ToString() == "Feet")
                {
                    // Formula to convert Yards to Feet
                    total = value * 3;
                    // Displays conversion
                    total_Box.Text = total.ToString();
                }
                // If user selects Feet and Inches will convert
                else if (from_Listbox.SelectedItem.ToString() == "Feet" && to_Listbox.SelectedItem.ToString() == "Inches")
                {
                    // Formula to convert Feet to Inches
                    total = value * 12;
                    // Displays conversion
                    total_Box.Text = total.ToString();
                }
                // If user selects Inches and Feet will convert
                else if (from_Listbox.SelectedItem.ToString() == "Inches" && to_Listbox.SelectedItem.ToString() == "Feet")
                {
                    // Formula to convert Inches to Feet
                    total = value / 12;
                    // Displays conversion
                    total_Box.Text = total.ToString();
                }
                // If user selects Feet and Yards
                else if (from_Listbox.SelectedItem.ToString() == "Feet" && to_Listbox.SelectedItem.ToString() == "Yards")
                {
                    // Formula to convert Feet to Yards
                    total = value / 3;
                    // Display conversion
                    total_Box.Text = total.ToString();
                }
                // If user selects Yards and Inches will convert
                else if(from_Listbox.SelectedItem.ToString() == "Yards" && to_Listbox.SelectedItem.ToString() == "Inches")
                {
                    // Formula to convert Yards to Inches
                    total = value * 36;
                    // Display conversion
                    total_Box.Text = total.ToString();
                }
                // If user selects Inches and Yards will convert
                else if(from_Listbox.SelectedItem.ToString() == "Inches" && to_Listbox.SelectedItem.ToString() == "Yards")
                {
                    //  Formula to convert Inches to Yards
                    total = value / 36;
                    // Display conversion
                    total_Box.Text = total.ToString();
                }
                // If user selects Yards and Yards
                else if(from_Listbox.SelectedItem.ToString() == "Yards" && to_Listbox.SelectedItem.ToString() == "Yards")
                {
                    // Hold user input value
                    total = value;
                    // Displays Value
                    total_Box.Text = total.ToString();
                }
                // If user selects Feet and Feet
                else if(from_Listbox.SelectedItem.ToString() == "Feet" && to_Listbox.SelectedItem.ToString() == "Feet")
                {
                    // Hold user input
                    total = value;
                    // Displays Value
                    total_Box.Text = total.ToString();
                }
                // If user selects Inches and Inches
                else if(from_Listbox.SelectedItem.ToString() == "Inches" && to_Listbox.SelectedItem.ToString() == "Inches")
                {
                    // Hold user input
                    total = value;
                    // Displays Value
                    total_Box.Text = total.ToString();
                }
            }
            catch (Exception ex)
            {
                // Displays error message
                MessageBox.Show(ex.Message);

            }
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            // Closes Form
            this.Close();
        }
    }
}
