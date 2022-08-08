using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tuition_Increase
{
    public partial class tuitionIncrease_Form : Form
    {
        public tuitionIncrease_Form()
        {
            InitializeComponent();
        }

        private void display_Button_Click(object sender, EventArgs e)
        {
            try
            {
                // Variables
                double tuition = 6000;
                double increase;
                double year = 5;
                double count = 1;
                double percent = 2;
                double total;
                // For loop that hold increase percentage, count less than or equal to year(5), increases the count by 1
                for (increase = (percent / 100 * tuition); count <= year; count++)
                {
                    // Total is equal to tuition(6,000)
                    total = tuition;
                    // Tuition percentage total is added to tuition 
                    tuition = total + increase;
                    // Displays year, and the total tuition cost for the semester
                    tuition_Listbox.Items.Add("For year " + count.ToString() + ", Semester tuition will be " + total.ToString("c") + " dollars");
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
            // Clears tuition listbox
            tuition_Listbox.Items.Clear();
        }

        private void exit_Button_Click(object sender, EventArgs e)
        {
            // Closes form
            this.Close();
        }
    }
}
