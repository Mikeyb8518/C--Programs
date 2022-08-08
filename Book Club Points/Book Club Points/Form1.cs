using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Book_Club_Points
{
    public partial class bookClub_Form : Form
    {
        public bookClub_Form()
        {
            InitializeComponent();
        }

        private void calculate_Button_Click(object sender, EventArgs e)
        {
            try
            {
                // Variables to hold and convert user input to Integer
                int points;
                int purchases= Convert.ToInt32(bought_Textbox.Text);
                int total;

                // If statement for purchases, If greater than 0 will apply points
                if(purchases >= 0)
                {
                    // Formula to calculate points
                    points = purchases * 15;
                    total = points;
                    // Displays points
                    total_Textbox.Text = total.ToString();
                }
                else
                {
                    // Error Message
                    MessageBox.Show("Please Enter Number Of Books Purchased");
                }
            }
            catch (Exception ex)
            {
                // Displays error message
                MessageBox.Show(ex.Message);
            }
        }

        private void clear_Button_Click(object sender, EventArgs e)
        {
            // Clears User input/ total
            bought_Textbox.Text = "";
            total_Textbox.Text = "";
        }

        private void exit_Button_Click(object sender, EventArgs e)
        {
            // Exits form
            this.Close();
        }
    }
}
