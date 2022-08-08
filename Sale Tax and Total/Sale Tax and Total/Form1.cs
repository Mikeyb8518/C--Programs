using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sale_Tax_and_Total
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculate_Button_Click(object sender, EventArgs e)
        {
            try 
            {
                decimal purchase;
                decimal stateTax;
                decimal countyTax;
                decimal total;

                purchase = decimal.Parse(purchase_Box.Text);
                stateTax = purchase * 04 / 100;
                countyTax = purchase * 02 / 100;
                total = purchase + stateTax + countyTax;

                stateTax_Box.Text = stateTax.ToString("c");
                countyTax_Box.Text = countyTax.ToString("c");
                total_Box.Text = total.ToString("c");
            }
            
            catch
            {
                MessageBox.Show("Please Enter Valid Data!");
            }
        }

        private void clear_Button_Click(object sender, EventArgs e)
        {
            purchase_Box.Text = "";
            stateTax_Box.Text = "";
            countyTax_Box.Text = "";
            total_Box.Text = "";
        }

        private void exit_Button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
