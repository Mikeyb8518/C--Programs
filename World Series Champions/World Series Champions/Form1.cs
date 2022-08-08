using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace World_Series_Champions
{
    public partial class champions_Form : Form
    {
        // List of strings to hold champlist
        List<string> champList = new List<string>();
        // variable to hold loop counter
        int i = 0;


        public champions_Form()
        {
            InitializeComponent();
        }

        private void champions_Form_Load(object sender, EventArgs e)
        {
            // Declared string variable
            string display;
            // Declares StreamReader variable to open text files
            StreamReader teamFile = File.OpenText("Teams.txt");
            StreamReader champFile = File.OpenText("WorldSeriesWinners.txt");
            // Display is assigned to teamFile and reads contents as long as not empty
            while ((display = teamFile.ReadLine()) != null)
            {
                // Displays teamFile to teams_Listbox
                teams_Listbox.Items.Add(display);
            }
            // Declares string varibale and assigns/ reads champFile
            string champs = champFile.ReadLine();
            // While champsFile is not empty
            while (champs != null)
            {
                // Adds to the champList 
                champList.Add(champs);
                champs = champFile.ReadLine();
                // Increments I for every readline in champsFile
                i++;
            }

        }

        private void teams_Listbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Assigns display variable to teams_Listbox selected item 
            string display = teams_Listbox.SelectedItems[0].ToString();
            // Variables to hold counters
            int index = 0;
            int count = 0;
            // While index is less than I
            while (index < i)
            {
                // If champList index is equal to selected item
                if (champList[index] == display)
                {
                    // Count increases
                    count++;
                }
                // Increments index placement 
                index++;
            }
            // Dislays selected team and count of world series won
            MessageBox.Show(display + " Won " + count + " World Series");
        }

    }
}
