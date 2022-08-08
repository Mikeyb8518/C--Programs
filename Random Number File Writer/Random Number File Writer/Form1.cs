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

namespace Random_Number_File_Writer
{
    public partial class randomNumber_Form : Form
    {
        public randomNumber_Form()
        {
            InitializeComponent();
        }

        private void generate_Button_Click(object sender, EventArgs e)
        {
            try
            {
                // Creates a random object
                Random random = new Random();
                // Variable 
                int random_number = 0;
                // Variable to hold user entry
                int number = Convert.ToInt32(user_Entry_Textbox.Text);
                // Declares a stream writer object adn creates file
                StreamWriter outputfile = File.CreateText("Random Number.txt");
                // While number is greater than 0
                while (number > 0)
                {
                    // Assigns random number to choose a number from 1-100
                    random_number = random.Next(1, 101);
                    // Writes ranndom number to file
                    outputfile.WriteLine(random_number.ToString());
                    // Number is decreased by 1
                    number--;
                }
                // Closes file
                outputfile.Close();
                // Displays file saved
                MessageBox.Show("File Saved");
            }
            catch (Exception ex)
            {
                // Default error message
                MessageBox.Show(ex.Message);
            }
        }

        private void exit_Button_Click(object sender, EventArgs e)
        {
            // Closes form
            this.Close();
        }
    }
}
