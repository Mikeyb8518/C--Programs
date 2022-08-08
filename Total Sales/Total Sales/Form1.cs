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

namespace Total_Sales
{
    public partial class total_Sales_Form : Form
    {
        public total_Sales_Form()
        {
            InitializeComponent();
        }
        // Counter variable used for loop
        int index = 0;
        // Declares an initialize an accumulator variable
        double total = 0;
        // TotalSales method that holds a double array with totalSales as argument
        private void TotalSales(double[] totalSales)
        {
            // Stepping through the array using adding each element to the accumulator 
            for (index = 0; index < totalSales.Length; index++)
            {
                // Gets total of array
                total += totalSales[index];
                // Displays output label true
                output_Label.Visible = true;
                // Displays output_label to textbox
                output_Label.Text = total.ToString("c");
            }
        }


        private void sales_Button_Click(object sender, EventArgs e)
        {
            try
            {
                // Creates an array to hold items read from file
                const int SIZE = 7;
                double[] sales = new double[SIZE];

                // Declares streamreader variable to read file from "Sales.txt"
                StreamReader inputFile = File.OpenText("Sales.txt");
                // Read files contents into the array
                while (index < sales.Length && !inputFile.EndOfStream)
                {
                    sales[index] = double.Parse(inputFile.ReadLine());
                    index++;
                }
                // Calls TotalSales method using sales to displays total
                TotalSales(sales);
                // Closes File
                inputFile.Close();
                // Displays arrays elements in the list box
                foreach (double value in sales)
                {
                    sales_Listbox.Items.Add(value);
                }
            }

            catch (Exception ex)
            {
                // Displays error message
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
