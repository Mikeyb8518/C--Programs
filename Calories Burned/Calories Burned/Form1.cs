using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calories_Burned
{
    public partial class caloriesBurned_Form : Form
    {
        public caloriesBurned_Form()
        {
            InitializeComponent();
        }

        private void display_Button_Click(object sender, EventArgs e)
        {
            try
            {
                // Variables
                double calorie = 3.9;
                double minutes = 30;
                double total;
                // For count starts at 10, and is less than or equal to minutes(30), count increases by 5
                for (double count = 10; count <= minutes; count += 5)
                {
                    // Formula to get total calories burned
                    total = calorie * count;
                    // Displays the minutes and total calories burned
                    caloriesBurned_Listbox.Items.Add("After " + count + " Minutes on the treadmill you have burned " + total + " Calories");
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
            // clears listbox
            caloriesBurned_Listbox.Items.Clear();
        }

        private void exit_Button_Click(object sender, EventArgs e)
        {
            // closes form
            this.Close();
        }
    }
}
