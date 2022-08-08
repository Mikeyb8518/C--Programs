using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace How_Much_Insurance
{
    public partial class how_much_insurance_Form : Form
    {
        public how_much_insurance_Form()
        {
            InitializeComponent();
        }

        private void how_much_insurance_Form_Load(object sender, EventArgs e)
        {
            
        }

        private void calculate_Button_Click(object sender, EventArgs e)
        {
            try
            {
                decimal insurance = .8m;
                decimal replacement = decimal.Parse(replacement_cost_Box.Text);
                decimal coverage = insurance * replacement;
                coverage_Box.Text = coverage.ToString("c");
            }

            catch
            {
                MessageBox.Show("Please Enter A Valid Entry");
            }
        }

        private void clear_Button_Click(object sender, EventArgs e)
        {
            replacement_cost_Box.Text = "";
            coverage_Box.Text = "";
        }

        private void exit_Button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
