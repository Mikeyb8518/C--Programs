using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Property_Tax
{
    public partial class property_tax_form : Form
    {
        public property_tax_form()
        {
            InitializeComponent();
        }

        private void calculate_button_Click(object sender, EventArgs e)
        {
            // Formula for calculating property sales tax
            double tax = (double.Parse(value_box.Text) / 100) * 0.64;

            total_box.Text = tax.ToString("c");

        }

        private void clear_button_Click(object sender, EventArgs e)
        {
            value_box.Text = "";
            total_box.Text = "";
        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
