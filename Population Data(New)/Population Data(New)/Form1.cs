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

namespace Population_Data_New_
{
    public partial class population_Form : Form
    {      
        public population_Form()
        {
            InitializeComponent();
        }
        // Initializes new lists calles populationList, annualChange
        List<int> populationList = new List<int>();
        List<int> annualChange = new List<int>();
        // Declare and read text file
        StreamReader inputFile = File.OpenText("USPopulation.txt");
        // Declares variable
        int populationAverage;
        // Declares variable to hold greatIncrease and minIncrease
        int greatIncrease = 0;
        int minIncrease = 0;
        // ReadFile method to read the text file into populationList
        private void ReadFile()
        {
            try
            {
                while (!inputFile.EndOfStream)
                {
                    populationList.Add(int.Parse(inputFile.ReadLine()));
                }
            }
            catch
            {
                MessageBox.Show("File Not Read");
            }

            inputFile.Close();
        }
        // GetAverage method called and has a integer list inputList as an argument
        private int GetAverage(List<int> inputList)
        {
            // Declares variables
            int averageChange;
            int total = 0;
            // For loop delcaring index variable, when index less than inputList -1, index increaments
            for (int index = 0; index < inputList.Count - 1; index++)
            {
                // Adds index to annualChange list
                annualChange.Add(inputList[index + 1] - inputList[index]);
            }
            // Foreach loop, works through the annualChange List
            foreach (int value in annualChange)
            {
                // Getting the total of the List
                total += value;
            }
            // Calculates averageChange
            averageChange = (total / (annualChange.Count + 1));
            // Returns Average
            return averageChange;
        }
        // DisplayAverage method displays average to output_Average_Label
        private void DisplayAverage(int averageAnnualChange)
        {
            output_Average_Label.Visible = true;
            output_Average_Label.Text = averageAnnualChange.ToString();
        }
        // GreatestIncreaseYear method calcultes greatest population increase in year
        private int GreatestIncreaseYear(List<int> inputList)
        {
            // Declares a variable to find greatest increase
            // Initialized with the first index of the List
            int greatest = inputList[0];
            // Declares variable 
            int position = 0;
            // Steps through the List, starting at 1
            for (int index = 1; index < inputList.Count; index++)
            {
                // If a value greater than "greatest" 
                if (inputList[index] > greatest)
                {
                    // Assigns greatest value to "greatest" 
                    greatest = inputList[index];
                    // Assigns position to index
                    position = index;
                }
            }
            // Assigns greatIncrease to display year of greatestIncrease
            greatIncrease = position + 1951;
            // returns greatestIncrease
            return greatIncrease;
        }
        // LeastIncreaseYear method calculates least population increase in year
        private int LeastIncreaseYear(List<int> inputList)
        {
            // Declares a variable to find least increase
            // Initialized with the first index of the list
            int least = inputList[0];
            // Declares variable
            int position = 0;
            // Steps through the List, starting at 1
            for (int index = 0; index < inputList.Count; index++)
            {
                // If a value is less than least is found
                if (inputList[index] < least)
                {
                    // Assigns least value to "least"
                    least = inputList[index];
                    // Assigns position to index
                    position = index;
                }
            }
            // Assigns minIncrease to display year of LeastIncrease
            minIncrease = position + 1951;
            // Returns minIncrease
            return minIncrease;
        }
        // DisplayGreatestYear method displays greatestIncrease year
        private void DisplayGreatestYear(int year)
        {
            output_GreatIncrease_Label.Visible = true;
            output_GreatIncrease_Label.Text = year.ToString();
        }
        // DisplayLeastYear method displays LeastIncrease year
        private void DisplayLeastYear(int year)
        {
            output_LeastIncrease_Label.Visible = true;
            output_LeastIncrease_Label.Text = year.ToString();
        }

        private void population_Form_Load(object sender, EventArgs e)
        {

        }

        private void read_Button_Click(object sender, EventArgs e)
        {
            // Calls ReadFile method 
            ReadFile();
            // Assigns populationAverage to GetAverage method using populationList
            populationAverage = GetAverage(populationList);
            // Calls DisplayAverage using populationAverage as argument
            DisplayAverage(populationAverage);
            // Calls GreatestIncreaseYear using annualChange list as an argument
            GreatestIncreaseYear(annualChange);
            // Calls LeastIncreaseYear using annualChange list as an argument
            LeastIncreaseYear(annualChange);
            // Calls DisplayGreatestYear using greatIncrease as an argument
            DisplayGreatestYear(greatIncrease);
            // Calls DisplayLeastYear using minIncrease as an argument
            DisplayLeastYear(minIncrease);
        }

        private void exit_Button_Click(object sender, EventArgs e)
        {
            // Closes form
            this.Close();
        }
    }
}
