using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tip__Tax_and_Total
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void total_Button_Click(object sender, EventArgs e)
        {
            try
            {
                double Charge;
                double Tip;
                double SalesTax;
                double Total;

                Charge = double.Parse(charge_Text.Text);
                Tip = Charge * 15 / 100;
                SalesTax = (Charge + Tip) * 7 / 100;
                Total = Charge + Tip + SalesTax;

                total_Text.Text = Total.ToString("c");
            }
            catch
            {
                MessageBox.Show("Invalid Data Was Entered!");
            }
        }

        private void exit_Button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void charge_Text_TextChanged(object sender, EventArgs e)
        {

        }

        private void clear_Button_Click(object sender, EventArgs e)
        {
            charge_Text.Text = "";
            total_Text.Text = "";
        }
    }
}
