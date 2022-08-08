using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mass_and_Weight
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculate_Button_Click(object sender, EventArgs e)
        {
            double mass = double.Parse(mass_input_textbox.Text);    //Variable to hold mass input from user

            double weight = mass * 9.8;     // Formula to calculate weight

            if (mass <= 10)     // If statment to check if mass less than 10
            {
                MessageBox.Show("Object Is Less Than 10 Newtons"); // Display Message that shows mass less than 10
            }
            else if (mass >= 1000)  // Else if statement to check if mass heavier than 1,000 newtons
            {
                MessageBox.Show("Object Is Heavier Than 1,000 Newtons");    // Display Message that shows mass heavier than 1,000 newtons
            }
            else
            {
                weight_textbox.Text = weight.ToString();    // Converts user input to weight and displays in text box
            }
        }

        private void clear_Button_Click(object sender, EventArgs e)
        {
            mass_input_textbox.Text = "";   // Clears Mass input textbox
            weight_textbox.Text = "";       // Clears weight textbox
        }

        private void exit_Button_Click(object sender, EventArgs e)
        {
            this.Close();       // Exits the form
        }
    }
}
