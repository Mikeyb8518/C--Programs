using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Body_Mass_Index
{
    public partial class bodyMassIndex_Form : Form
    {
        public bodyMassIndex_Form()
        {
            InitializeComponent();
        }

        private void calculate_Button_Click(object sender, EventArgs e)
        {
            try
            {
                double height = double.Parse(height_Box.Text);
                double weight = double.Parse(weight_Box.Text);
                double BMI = weight * 703 / (height * height);

                output_Box.Text = BMI.ToString("n1");
            }

            catch
            {
                MessageBox.Show("Please Enter Valid Data");
            }
        }

        private void clear_Button_Click(object sender, EventArgs e)
        {
            weight_Box.Text = "";
            height_Box.Text = "";
            output_Box.Text = "";
        }

        private void exit_Button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
