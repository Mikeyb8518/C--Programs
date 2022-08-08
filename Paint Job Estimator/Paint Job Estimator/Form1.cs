using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paint_Job_Estimator
{
    public partial class paint_Job_Form : Form
    {
        public paint_Job_Form()
        {
            InitializeComponent();
        }

        private void calculate_button_Click(object sender, EventArgs e)
        {
            double wallspace;
            double gallons_of_paint;
            double hours_of_labor;
            double cost_of_paint;
            double labor_charge;
            double total_cost;

            // Read The Number of Sqaure Feet Value For Wall Space
            wallspace = double.Parse(wallspace_box.Text);

            // Find the Number of Gallons of Paint Needed
            gallons_of_paint = (wallspace / 115);

            // Find the Hours of Labor Needed
            hours_of_labor = gallons_of_paint * 8.0;

            // Find The Cost of Paint
            cost_of_paint = double.Parse(paint_cost_box.Text) * double.Parse(gallons_of_paint.ToString());

            // Find the Cost Of Labor
            labor_charge = double.Parse(hours_of_labor.ToString()) * 20;

            // Find the Total Cost of The Paint Job
            total_cost = cost_of_paint + labor_charge;

            // display Totals
            total_label.Text = "The Number of Gallons of Paint required is: " + gallons_of_paint.ToString("n4")
                + "\n\r";
            total_label.Text += "The Hours of Labor required is: " + hours_of_labor.ToString("n0") + "\n\r";
            total_label.Text += "The Cost of Paint is: " + cost_of_paint.ToString("c") + "\n\r";
            total_label.Text += "The Labor Charge Is: " + labor_charge.ToString("c") + "\n\r";
            total_label.Text += "The Total Cost For the Paint Job Is: " + total_cost.ToString("c");



        }

        private void paint_Job_Form_Load(object sender, EventArgs e)
        {

        }

        private void clear_button_Click(object sender, EventArgs e)
        {
            wallspace_box.Text = "";
            paint_cost_box.Text = "";
        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
