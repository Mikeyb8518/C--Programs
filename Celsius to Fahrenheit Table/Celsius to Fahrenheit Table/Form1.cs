using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Celsius_to_Fahrenheit_Table
{
    public partial class celsiusTofahrenheit_Form : Form
    {
        public celsiusTofahrenheit_Form()
        {
            InitializeComponent();
        }

        private void convert_Button_Click(object sender, EventArgs e)
        {
            try
            {
                // Variables
                double celsius = 0;
                double fahrenheit;
                // While celsius is less than or equal too 20
                while (celsius <= 20)
                {
                    // formula to convert celsius to fahrenheit
                    fahrenheit = (celsius * 9 / 5) + 32;
                    // Prints celsius degree 0-20 and prints fahrenheit conversion
                    temperature_Listbox.Items.Add(celsius + " degree Celsius is " + fahrenheit + " degree Fahrenheit");
                    // Increases celsius by 1
                    celsius++;
                }
            }
            catch (Exception ex)
            {
                // Prints default error message
                MessageBox.Show(ex.Message);
            }
        }

        private void clear_Button_Click(object sender, EventArgs e)
        {
            // Clears Listbox
            temperature_Listbox.Items.Clear();
        }

        private void exit_Button_Click(object sender, EventArgs e)
        {
            // Closes form
            this.Close();
        }
    }
}
