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

namespace Random_Number_File_Reader
{
    public partial class random_Number_Form : Form
    {
        public random_Number_Form()
        {
            InitializeComponent();
        }

        private void display_Button_Click(object sender, EventArgs e)
        {
            // Variables
            string random_number;
            int total = 0;
            int total_read;
            // Declares a streamreader variable
            StreamReader inputfile;
            // Open the file and get a streamreader object
            inputfile = File.OpenText(@"D:\C# Programs\Random Number File Writer\Random Number File Writer\bin\Debug\Random Number.txt");
            // Clears Listbox of items
            numberOutput_Listbox.Items.Clear();
            // Reads the file contents until it ends
            while (!inputfile.EndOfStream)
            {
                // Reads each line of the file content
                random_number = inputfile.ReadLine();
                // Adds the contents of the file to the listbox
                numberOutput_Listbox.Items.Add(random_number);
                // Counts the number of items in the listbox
                total_read = numberOutput_Listbox.Items.Count;
                // Displays the number of items to the number read label
                numbers_Read_Label.Text = total_read.ToString();
                // Formula to add each line from file read together
                total = Convert.ToInt32(random_number) + total;
                // Displays the total of the number to the total output label
                total_Output_Label.Text = total.ToString();
            }
        }

        private void exit_Button_Click(object sender, EventArgs e)
        {
            // Closes form
            this.Close();
        }
    }
}
