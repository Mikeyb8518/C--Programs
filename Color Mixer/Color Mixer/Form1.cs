using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Color_Mixer
{
    public partial class color_Mixer_Form : Form
    {
        public color_Mixer_Form()
        {
            InitializeComponent();
        }

        private void mix_Button_Click(object sender, EventArgs e)
        {
            try
            {
                //If user selects Red and Blue colors to mix
                if (red_RadioButton1.Checked && blue_RadioButton2.Checked)
                {
                    // Form color will display Purple
                    this.BackColor = Color.Purple;
                }
                // If user selects Red and Yellow colors to mix
                else if (red_RadioButton1.Checked && yellow_RadioButton2.Checked)
                {
                    // Form color will display Orange 
                    this.BackColor = Color.Orange;
                }
                // If user selects Blue and Yellow colors to mix
                else if (blue_RadioButton1.Checked && yellow_RadioButton2.Checked)
                {
                    // Form color will display Green
                    this.BackColor = Color.Green;
                }
                // If user selects both Red
                else if (red_RadioButton1.Checked && red_RadioButton2.Checked)
                {
                    // Form color will display Red
                    this.BackColor = Color.Red;
                }
                // If user selects both blue
                else if (blue_RadioButton1.Checked && blue_RadioButton2.Checked)
                {
                    // Form color will display Blue
                    this.BackColor = Color.Blue;
                }
                // If user selects both Yellow
                else if (yellow_RadioButton1.Checked && yellow_RadioButton2.Checked)
                {
                    // Form color will display Yellow
                    this.BackColor = Color.Yellow;
                }
                else
                {
                    // Message to display 2 mixing colors
                    MessageBox.Show("Please select 2 mixing colors");
                }
            }
            catch (Exception ex)
            {
                // Display default error message
                MessageBox.Show(ex.Message);
            }
        }

        private void exit_Button_Click(object sender, EventArgs e)
        {
            // Closes the form
            this.Close();
        }
    }
}
