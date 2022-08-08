using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Software_Sales
{
    public partial class softwareSales_Form : Form
    {
        public softwareSales_Form()
        {
            InitializeComponent();
        }

        private void calculate_Button_Click(object sender, EventArgs e)
        {
            try
            {
                // Variables to hold Package Price, Discount Total, Discount, Total, Packages Bought
                const double package = 99;
                double discount_Total;
                double discount;
                double total;
                double packages_Bought = Convert.ToDouble(packagesBought_Textbox.Text);

                // If user enters packages bought between 10-19
                if(packages_Bought >= 10 && packages_Bought <= 19)
                {
                    // Discount will be 20%, Displays discount total
                    discount = .2;
                    discount_Total = packages_Bought * package * discount;
                    discount_Textbox.Text = discount_Total.ToString("c");

                    // Displays total for number of packages bought including discount
                    total = (packages_Bought * package) - discount_Total;
                    total_Textbox.Text = total.ToString("c");
                }
                // If user enters packages bought between 20-49
                else if(packages_Bought >= 20 && packages_Bought <= 49)
                {
                    // Discount will be 30%, Displays discount total
                    discount = .3;
                    discount_Total = packages_Bought * package * discount;
                    discount_Textbox.Text = discount_Total.ToString("c");

                    // Displays total for number of packages bought including discount
                    total = (packages_Bought * package) - discount_Total;
                    total_Textbox.Text = total.ToString("c");
                }
                // If user enters packages bought between 50-99
                else if(packages_Bought >= 50 && packages_Bought <= 99)
                {
                    // Discount will be 40%, Displays discount total
                    discount = .4;
                    discount_Total = packages_Bought * package * discount;
                    discount_Textbox.Text = discount_Total.ToString("c");

                    // Displays total for number of packages bought including discount
                    total = (packages_Bought * package) - discount_Total;
                    total_Textbox.Text = total.ToString("c");
                }
                // If user enters packages bought 100 or more
                else if(packages_Bought >= 100)
                {
                    // Discount will be 50%, Displays discount total
                    discount = .5;
                    discount_Total = packages_Bought * package * discount;
                    discount_Textbox.Text = discount_Total.ToString("c");

                    // Displays total for number of packages bought including discount
                    total = (packages_Bought * package) - discount_Total;
                    total_Textbox.Text = total.ToString("c");
                }
                // If user enters 10 or less packages
                else if(packages_Bought < 10)
                {
                    // No discount will be given
                    discount_Textbox.Text = "None";

                    // Displays total for number of packages bought
                    total = packages_Bought * package;
                    total_Textbox.Text = total.ToString("c");
                }

            }
            catch (Exception ex)
            {
                // Displays Error Message
                MessageBox.Show(ex.Message);
            }
        }

        private void clear_Button_Click(object sender, EventArgs e)
        {
            // Clears textboxs, and resets focus back to Packages Bought
            packagesBought_Textbox.Text = "";
            discount_Textbox.Text = "";
            total_Textbox.Text = "";
            packagesBought_Textbox.Focus();
        }

        private void exit_Button_Click(object sender, EventArgs e)
        {
            // Closes form
            this.Close();
        }
    }
}
