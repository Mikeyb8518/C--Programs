using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stadium_Seating
{
    public partial class stadium_seating_form : Form
    {
        const double classA = 15;   // Price for class A seats
        const double classB = 12;   // Price for class B seats
        const double classC = 9;    // Price for class C seats
        /// </summary>
        public stadium_seating_form()
        {
            InitializeComponent();
        }

        private void tickets_sold_label_Click(object sender, EventArgs e)
        {

        }

        private void ticket_sold_label_Click(object sender, EventArgs e)
        {
         
        }

        private void calculate_button_Click(object sender, EventArgs e)
        {
            try
            {
                double ClassA_total = double.Parse(classA_box.Text) * classA;   // Revenue total for class A
                double ClassB_total = double.Parse(classB_box.Text) * classB;   // Revenue total for class B
                double ClassC_total = double.Parse(classC_box.Text) * classC;   // Revenue total for class C
                double total_cost;    // Variable to hold Total cost

                revenue_classA_box.Text = ClassA_total.ToString("c");   // Displays Class A total revenue
                revenue_classB_box.Text = ClassB_total.ToString("c");   // Displays Class B total revenue
                revenue_classC_box.Text = ClassC_total.ToString("c");   // displays Class C total revenue
                total_cost = ClassA_total + ClassB_total + ClassC_total; // Formula to calculate total cost

                total_box.Text = total_cost.ToString("c"); // Displays total revenue earned
            }
            catch
            {
                MessageBox.Show("Please enter a valid entry!");
            }
        }

        private void clear_button_Click(object sender, EventArgs e)
        {
            classA_box.Text = "";   // Clears Ticket Sold for Class A
            classB_box.Text = "";   // Clears Ticket Sold for Class B
            classC_box.Text = "";   // Clears Ticket Sold for Class C

            revenue_classA_box.Text = "";   // Clears revenue cost for Class A
            revenue_classB_box.Text = "";   // Clears revenue cost for Class B
            revenue_classC_box.Text = "";   // Clears revenue cost for Class C

            total_box.Text = "";    // Clears Total box

            classA_box.Focus();
        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
