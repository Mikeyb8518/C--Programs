using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Workshop_Selector
{
    public partial class workshop_Form : Form
    {
        public workshop_Form()
        {
            InitializeComponent();
        }

        private void select_Button_Click(object sender, EventArgs e)
        {
            try
            {
                // Variables for users selection for workshop and location
                string workshop = workshop_Listbox.SelectedItem.ToString();
                string location = location_Listbox.SelectedItem.ToString();

                // Variables to hold Days, Registration, Lodging Fee, 
                // Total and Lodging Total
                double days = 0;
                double registration = 0;
                double lodging = 0;
                double total;
                double lodging_total;

                // If functions for workshop selection holding registration fee and days
                if (workshop == "Handling Stress")
                {
                    registration = 1000;
                    days = 3;
                }
                else if (workshop == "Time Management")
                {
                    registration = 800;
                    days = 3;
                }
                else if (workshop == "Supervision Skills")
                {
                    registration = 1500;
                    days = 3;
                }
                else if (workshop == "Negotitation")
                {
                    registration = 1300;
                    days = 5;
                }
                else if (workshop == "How to Interview")
                {
                    registration = 500;
                    days = 1;
                }

                // If function for location selected holding lodging fee 
                if (location == "Austin")
                {
                    lodging = 150;
                }
                else if (location == "Chicago")
                {
                    lodging = 225;
                }
                else if (location == "Dallas")
                {
                    lodging = 175;
                }
                else if (location == "Orlando")
                {
                    lodging = 300;
                }
                else if (location == "Phoenix")
                {
                    lodging = 175;
                }
                else if (location == "Raleigh")
                {
                    lodging = 150;
                }

                // Formulas to hold total and lodging total
                total = registration + (lodging * days);
                lodging_total = lodging * days;

                // Makes registration Label visable
                // Converts registration variable to string 
                output_registration_Label.Visible = true;
                output_registration_Label.Text = registration.ToString("c");

                // Makes lodging label visable
                // Converts lodging total variable to string 
                output_lodging_Label.Visible = true;
                output_lodging_Label.Text = lodging_total.ToString("c");

                // Makes total label visable
                // Converts total variable to string
                output_total_Label.Visible = true;
                output_total_Label.Text = total.ToString("c");
            }
            catch (Exception ex)
            {
                // Displays default error message
                MessageBox.Show(ex.Message);
            }
        }

        private void clear_Button_Click(object sender, EventArgs e)
        {
            // Clears output labels
            output_registration_Label.Text = "";
            output_lodging_Label.Text = "";
            output_total_Label.Text = "";
        }

        private void exit_Button_Click(object sender, EventArgs e)
        {
            // Closes form
            this.Close();
        }
    }
}
