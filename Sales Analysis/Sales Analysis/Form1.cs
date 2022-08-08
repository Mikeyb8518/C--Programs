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

namespace Sales_Analysis
{
    public partial class sales_Analysis_Form : Form
    {
        public sales_Analysis_Form()
        {
            InitializeComponent();
        }
        // AverageSales method accepts a double array argument
        // Returns the average value in that array
        private double AverageSales(double[] average_Sale)
        {
            double total = 0;
            double average;

            for (int index = 0; index < average_Sale.Length; index++)
            {
                total = average_Sale[index];
            }

            average = total / average_Sale.Length;
            output_Average_Label.Visible = true;
            output_Average_Label.Text = average.ToString("c");

            return average;
        }
        // Highest method accepts a double array argument
        // Returns the highest value in that array
        private double Highest(double[] highest_Sale)
        {
            double highest = highest_Sale[0];

            for (int index = 1; index < highest_Sale.Length; index++)
            {
                if (highest_Sale[index] > highest)
                {
                    highest = highest_Sale[index];
                    output_High_Label.Visible = true;
                    output_High_Label.Text = highest.ToString("c");
                }
            }

            return highest;
        }
        // Lowest method accepts a double array argument 
        // Reutrns the lowest value in that array
        private double Lowest(double[] lowest_Sale)
        {
            double lowest = lowest_Sale[0];

            for (int index = 1; index < lowest_Sale.Length; index++)
            {
                if (lowest_Sale[index] < lowest)
                {
                    lowest = lowest_Sale[index];
                    output_Lowest_Label.Visible = true;
                    output_Lowest_Label.Text = lowest.ToString("c");
                }
            }

            return lowest;
        }
        // TotalSales method accepts a double array argument
        // returns the total value in that array
        private double TotalSales(double[] total_Sales)
        {
            double total = 0;

            for (int index = 0; index < total_Sales.Length;index++)
            {
                total += total_Sales[index];
                output_Total_Label.Visible = true;
                output_Total_Label.Text = total.ToString("c");
            }

            return total;
        }
        

        private void sales_Button_Click(object sender, EventArgs e)
        {
            try
            {
                // number of sales
                const int SIZE = 7;
                // Array of sales
                double[] sales = new double[SIZE];
                // loop counter
                int index = 0;
                // variables to hold average, total, highest/lowest sales
                double highestSale;
                double lowestSale;
                double averageSale;
                double totalSale;
                // Declares inputfile variable, open file and gets a streamreader object
                StreamReader inputFile = File.OpenText("Sales.txt");
                // Read sales into the array
                while(!inputFile.EndOfStream && index < sales.Length)
                {
                    sales[index] = double.Parse(inputFile.ReadLine());
                    index++;
                }
                // Closes file
                inputFile.Close();
                // Displays array in listbox
                foreach (double value in sales)
                {
                    sales_Listbox.Items.Add(value);
                }
                // Calls methods to display total, highest, lowest, average
                totalSale = TotalSales(sales);
                averageSale = AverageSales(sales);
                highestSale = Highest(sales);
                lowestSale = Lowest(sales);


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
