using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Celsius_and_Fahrenheit_Converter
{
    public partial class celsius_fahrenheit_converter_Form : Form
    {
        public celsius_fahrenheit_converter_Form()
        {
            InitializeComponent();
        }

        private void convert_Fahrenheit_Button_Click(object sender, EventArgs e)
        {
            try
            {
                double c = double.Parse(input_Box.Text);
                double fahrenheit = (c * 9 / 5) + 32;
                double total = fahrenheit;

                output_Box.Text = total.ToString("n2");
            }

            catch
            {
                MessageBox.Show("Please Enter a Valid Temperature");
            }
        }

        private void convert_Celsius_Button_Click(object sender, EventArgs e)
        {
            try
            {
                double f = double.Parse(input_Box.Text);
                double celsius = (f - 32) * 5 / 9;
                double total = celsius;

                output_Box.Text = total.ToString("n2");
            }

            catch
            {
                MessageBox.Show("Please Enter a Valid Temperature");
            }
        }

        private void clear_Button_Click(object sender, EventArgs e)
        {
            input_Box.Text = "";
            output_Box.Text = "";
        }

        private void exit_Button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
