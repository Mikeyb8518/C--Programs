using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kinetic_Energy
{
    public partial class kinetic_Energy_Form : Form
    {
        public kinetic_Energy_Form()
        {
            InitializeComponent();
        }
        // The KineticEnergy Method accepts a number for
        // mass argument and a number for velocity argument 
        private double KineticEnergy(double mass, double velocity)
        {
            // Formula to calculate Kinetic energy
            return 0.5 * mass * (velocity * velocity);
        }

        private void calculate_Button_Click(object sender, EventArgs e)
        {
            // Declares variables to hold mass, velocity and total
            double mass, velocity, total;
            // Takes users entry for mass 
            if (double.TryParse(mass_Textbox.Text, out mass))
            {
                // Takes users entry for velocity
                if (double.TryParse(velocity_Textbox.Text, out velocity))
                {
                    // Takes total variable and assigns the KineticEnergy Method to accept mass and velocity input
                    total = KineticEnergy(mass, velocity);
                    // Makes output label visable 
                    output_Label.Visible = true;
                    // Displays total to output label
                    output_Label.Text = total.ToString("n2") + " Joules";
                }
                else
                {
                    // Displays error message
                    MessageBox.Show("Please Enter a Valid Number For Velocity");
                }
            }
            else
            {
                // Displays error message
                MessageBox.Show("Please Enter a Valid Number for Seconds");
            }
        }

        private void clear_Button_Click(object sender, EventArgs e)
        {
            // Clears users textboxes and output label
            mass_Textbox.Text = "";
            velocity_Textbox.Text = "";
            output_Label.Text =  "0";
            // Output label visable set to false
            output_Label.Visible = false;
            // Resets focus back to mass textbox
            mass_Textbox.Focus();
        }

        private void exit_Button_Click(object sender, EventArgs e)
        {
            // Closes form
            this.Close();
        }
    }
}
