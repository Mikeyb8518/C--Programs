using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital_Charges
{
    public partial class hospitalCharges_Form : Form
    {
        public hospitalCharges_Form()
        {
            InitializeComponent();
        }
        // CalcStayCharges method that takes days as an argument
        // Returns daily base charges times days
        private double CalcStayCharges(double days)
        {
            return 350 * days;
        }
        // CalcMiscCharges method that takes meds, surgery, lab, Phy_Rehab as arguments
        // Returns meds + surgery + lab + Phy_Rehab 
        private double CalcMiscCharges(double meds, double surgery, double lab, double Phy_Rehab)
        {
            return meds + surgery + lab + Phy_Rehab;
        }
        // CalcTotalCharges method that takes misc and days as arguments
        // Returns misc + days
        private double CalcTotalCharges(double misc, double days)
        {
            return misc + days;
        }
        // ClearCharges method that clears as textboxes
        private void ClearCharges()
        {
            days_Textbox.Text = null;
            med_Charges_Textbox.Text = null;
            surgical_Charges_Textbox.Text = null;
            lab_Fee_Textbox.Text = null;
            phy_Rehab_Textbox.Text = null;
            output_Label.Text = null;
        }

        private void calculate_Button_Click(object sender, EventArgs e)
        {
            // Declare double variables
            double days, meds = 0, surgery = 0, lab = 0, Phy_Rehab = 0;
            double misc_total, total;
            // If statement that gets user data out as days
            if (double.TryParse(days_Textbox.Text, out days))
            {
                // If statement that gets user data out as meds
                if (double.TryParse(med_Charges_Textbox.Text, out meds))
                {
                    // If statement that gets user data out as surgery
                    if (double.TryParse(surgical_Charges_Textbox.Text, out surgery ))
                    {
                        // If statement that gets user data out as lab
                        if (double.TryParse(lab_Fee_Textbox.Text, out lab))
                        {
                            // If statement that gets user data out as Phy_Rehab
                            if (double.TryParse(phy_Rehab_Textbox.Text, out Phy_Rehab))
                            {

                            }
                            else
                            {
                                // Displays error message
                                MessageBox.Show("Please Enter a Valid Input for Physical Rehabilitation");
                            }
                        }
                        else
                        {
                            // Displays error message 
                            MessageBox.Show("Please Enter a Valid Input for Lab Fees");
                        }
                    }
                    else
                    {
                        // Displays error message
                        MessageBox.Show("Please Enter a Valid Input for Surgical Charges");
                    }
                }
                else
                {
                    // Displays error message 
                    MessageBox.Show("Please Enter a Valid Input for Medication Charges");
                }
            }
            else
            {
                // Displays error message
                MessageBox.Show("Please Enter a Valid Input for Days Spent");
            }
            // Takes days variable and calls CalcStayCharges method with days as argument to get total
            days = CalcStayCharges(days);
            // misc_total variable calls CalcMiscCharges mthod to get misc_total
            misc_total = CalcMiscCharges(meds, surgery, lab, Phy_Rehab);
            // Total variable that gets the total of days and misc_total together
            total = days + misc_total;
            // Makes output variable visable
            // Displays total as string to output label
            output_Label.Visible = true;
            output_Label.Text = total.ToString("c");
        }

        private void clear_Button_Click(object sender, EventArgs e)
        {
            // Calls ClearCharges method to clear all textboxes 
            ClearCharges();
            // output label is not visable
            output_Label.Visible = false;
            // Resets days_Textbox focus
            days_Textbox.Focus();
        }

        private void exit_Button_Click(object sender, EventArgs e)
        {
            // Closes form
            this.Close();
        }
    }
}
