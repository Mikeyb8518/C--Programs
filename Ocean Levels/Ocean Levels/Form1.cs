using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ocean_Levels
{
    public partial class oceanLevels_Form : Form
    {
        public oceanLevels_Form()
        {
            InitializeComponent();
        }

        private void display_Button_Click(object sender, EventArgs e)
        {
            try
            {
                // Variables
                double count = 1;
                double ocean_level = 1.5;
                double year = 10;
                double rising;
                // Displays the rising ocean level for the spand of 10 years, increasing the count
                for (rising = ocean_level; count <= year; count++)
                {
                    oceanLevel_Listbox.Items.Add("The ocean level for year " + count.ToString() + " will have risen " + ocean_level.ToString() + " millimeters");
                    
                    ocean_level = rising + ocean_level;
                }
            }
            catch (Exception ex)
            {
                // Default error message
                MessageBox.Show(ex.Message);
            }
        }

        private void clear_Button_Click(object sender, EventArgs e)
        {
            // Clears ocean level listbox
            oceanLevel_Listbox.Items.Clear();
        }

        private void exit_Button_Click(object sender, EventArgs e)
        {
            // Closes form
            this.Close();
        }
    }
}
