using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sum_Of_Numbers_in_a_String
{
    public partial class Sum_Form : Form
    {
        public Sum_Form()
        {
            InitializeComponent();
        }

        private void total_Button_Click(object sender, EventArgs e)
        {
            try
            {

                // Accumulator
                double total = 0;

                // Gets input from user
                string str = input_Textbox.Text;

                // Create a delimiter array
                char[] delim = { ',' };

                // Tokenize the users input
                string[] tokens = str.Split(delim);

                // Calculate the total of numbers
                foreach (string s in tokens)
                {
                    total += double.Parse(s);
                }

                // Display the  total
                total_Textbox.Text = total.ToString("n1");
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
