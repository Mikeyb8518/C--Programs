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

namespace Jagged_Array_of_Exam_Scores
{
    public partial class jagged_Exam_Scores_Form : Form
    {
        public jagged_Exam_Scores_Form()
        {
            InitializeComponent();
        }
        // Declares a constant SIZE of 3
        const int SIZE = 3;
        // Creates a jaggedArray with SIZE of 3 in the Row
        int[][] jaggedArray = new int[SIZE][];
        // StreamReader declared to read Section file texts
        StreamReader input1 = File.OpenText("Section1.txt");
        StreamReader input2 = File.OpenText("Section2.txt");
        StreamReader input3 = File.OpenText("Section3.txt");
        // Declares variables to hold section averages, and overall averages
        double section1Average;
        double section2Average;
        double section3Average;
        double overallSection;
        // Delcares varibales to hold highest scores and lowest scores
        double highestScore;
        double lowestScore;
        // Creates a List of strings to hold Highestscore and LowestScore
        List<string> HighestScore = new List<string>();
        List<string> LowestScore = new List<string>();
        // JaggedArray method that declares the jaggedArray column sizes(12,8,10)
        private void JaggedArray()
        {
            jaggedArray[0] = new int[12];
            jaggedArray[1] = new int[8];
            jaggedArray[2] = new int[10];
        }
        // ReadFile method that reads the contents of the files and adds them to the index
        private void ReadFile()
        {
            try
            {
                int index1 = 0;
                int index2 = 0;
                int index3 = 0;

                while (!input1.EndOfStream)
                {
                    jaggedArray[0][index1] = int.Parse(input1.ReadLine());
                    index1++;
                }

                while (!input2.EndOfStream)
                {
                    jaggedArray[1][index2] = int.Parse(input2.ReadLine());
                    index2++;
                }
                
                while (!input3.EndOfStream)
                {
                    jaggedArray[2][index3] = int.Parse(input3.ReadLine());
                    index3++;
                }
            }

            catch
            {
                MessageBox.Show("File Could Not Be Read");
            }
        }
        // DisplayScores mehtod that takes jaggedArray integer, and index1, index2, index3 as arguments
        // For loop to add the contents indexes to the listboxes
        private void DisplayScores(int[][] jaggedArray, int index1, int index2, int index3)
        {
            for (int position = 0; position < jaggedArray[index1].Length; position++)
            {
                exam1_Listbox.Items.Add(jaggedArray[index1][position].ToString());
            }

            for (int position = 0; position < jaggedArray[index2].Length; position++)
            {
                exam2_Listbox.Items.Add(jaggedArray[index2][position].ToString());
            }

            for (var position = 0; position < jaggedArray[index3].Length; position++)
            {
                exam3_Listbox.Items.Add(jaggedArray[index3][position].ToString());
            }
        }
        // GetAverage method that takes a jaggedArray and index argument
        // For loop that adds the colummn totals together as well as average
        // Returns average
        private double GetAverage(int[][] jaggedArray, int index)
        {
            double average;
            int total = 0;

            for (int col = 0; col < jaggedArray[index].Length; col++)
            {
                total += jaggedArray[index][col];
            }

            average = (double)total / jaggedArray[index].Length;

            return average;
        }
        // DisplaySection1Average method that makes output visable true
        // Displays average to string in section1 output
        private void DisplaySection1Average(double average)
        {
            output_Average1_Label.Visible = true;
            output_Average1_Label.Text = average.ToString("n2");
        }
        // DisplaySection2Average method that makes output visbale true
        // Displays average to string in section2 output
        private void DisplaySection2Average(double average)
        {
            output_Average2_Label.Visible = true;
            output_Average2_Label.Text = average.ToString("n2");
        }
        // DisplaySection3Average method that makes output visable true
        // Displays average to string in section3 output
        private void DisplaySection3Average(double average)
        {
            output_Average3_Label.Visible = true;
            output_Average3_Label.Text = average.ToString("n2");
        }
        // GetOverallAverage method calls average1, average2, average3 as arguments
        // Gets the overall average of all three sections
        // Returns average
        private double GetOverallAverage(double average1, double average2, double average3)
        {
            double total = average1 + average2 + average3;
            double average = total / 3.0;

            return average;
        }
        // DisplayOverallAverage method that calls average as an argument
        // Displays TotalAverage label visable true
        // Dsiplays average to string to TotalAvg_Label
        private void DisplayOverallAverage(double average)
        {
            output_TotalAvg_Label.Visible = true;
            output_TotalAvg_Label.Text = average.ToString("n2");
        }
        // FindHighestScore method that calls jaggedArray argument
        // For loop used to find highest score of all three sections
        // Displays section where the highscore is located 
        private double FindHighestScore(int[][] jaggedArray)
        {
            highestScore = jaggedArray[0][0];

            for (int row = 0; row < jaggedArray.Length; row++)
            {
                for (int col = 0; col < jaggedArray[row].Length; col++)
                {
                    if (highestScore < jaggedArray[row][col])
                    {
                        highestScore = jaggedArray[row][col];
                    }
                }
            }

            for (int row = 0; row < jaggedArray.Length; row++)
            {
                for (int col = 0; col < jaggedArray[row].Length; col++)
                {
                    if (highestScore == jaggedArray[row][col])
                    {
                        HighestScore.Add((row + 1).ToString());
                    }
                }
            }

            return highestScore;
        }
        // DisplayHighestScore method calls highest as an argument
        // Makes output label visable 
        // Displays highest to string 
        // Uses for loop to work through index to display highestScore location as well as highest score
        private void DisplayHighestScore(double highest)
        {
            output_Hightest_Label.Visible = true;
            output_Hightest_Label.Text = highest.ToString("n2");

            string str = "";

            for (int index = 0; index < HighestScore.Count - 1; index++)
            {
                str += (HighestScore[index] + ",");
            }

            str += HighestScore[HighestScore.Count - 1];

            output_Hightest_Label.Text = highest.ToString() + " in section " + str;
        }
        // FindLowestScore method that calls jaggedArray as an argument
        // For loop used to find lowest score of all three sections
        // Gets the row of the lowest score to string
        private double FindLowestScore(int[][] jaggedArray)
        {
            lowestScore = jaggedArray[0][0];

            for (int row = 0; row < jaggedArray.Length; row++)
            {
                for (int col = 0; col < jaggedArray[row].Length; col++)
                {
                    if (lowestScore > jaggedArray[row][col])
                    {
                        lowestScore = jaggedArray[row][col];
                    }
                }
            }

            for (int row = 0; row < jaggedArray.Length; row++)
            {
                for (int col = 0; col < jaggedArray[row].Length; col++)
                {
                    if (lowestScore == jaggedArray[row][col])
                    {
                        LowestScore.Add((row + 1).ToString());
                    }
                }
            }

            return lowestScore;
        }
        // DisplayLowestScore method as lowest as the argument
        // output label is made visable
        // Displays lowest score to string
        private void DisplayLowestScore(double lowest)
        {
            output_Lowest_Label.Visible = true;
            output_Lowest_Label.Text = lowest.ToString("n2");

            string str = "";

            for (int index = 0; index < LowestScore.Count - 1; index++)
            {
                str += (LowestScore[index] + ",");
            }

            str += LowestScore[LowestScore.Count - 1];

            output_Lowest_Label.Text = lowest.ToString() + " in section " + str;
        }


        private void jagged_Exam_Scores_Form_Load(object sender, EventArgs e)
        {

        }

        private void average_Button_Click(object sender, EventArgs e)
        {
            // Calls JaggedArray method to initalize JaggedArrays
            JaggedArray();
            // Calls ReadFile method to read contents of text files
            ReadFile();
            // DisplayScores method displays jaggedArray to listboxes
            DisplayScores(jaggedArray, 0, 1, 2);
            // section1Average calls GetAverage method to get section 1 average
            section1Average = GetAverage(jaggedArray, 0);
            // Calls DisplaySection1Average method to display average using section1Average variable
            DisplaySection1Average(section1Average);
            // section2Average calls GetAverage method to get section 2 average
            section2Average = GetAverage(jaggedArray, 1);
            // Calls DisplaySection2Average using section2Average as an argument
            DisplaySection2Average(section2Average);
            // section3Average calls GetAverage method to get section 3 average
            section3Average = GetAverage(jaggedArray, 2);
            // Calls DisplaySection3Average using section3Average variable as an argument
            DisplaySection3Average(section3Average);
            // overallSection variable calls GetOverallSection method using section1Average, section2Average, section3Average as arguments
            overallSection = GetOverallAverage(section1Average, section2Average, section3Average);
            // DisplayOverallAverage method using overallSection as an argument 
            DisplayOverallAverage(overallSection);
            // highestScore variable calls FindHighestScore using jaggedArray as an argument 
            highestScore = FindHighestScore(jaggedArray);
            // DisplayHighestScore using highestScore as an argument 
            DisplayHighestScore(highestScore);
            // lowestScore variable set to FindLowestScore method using jaggedArray as an argument
            lowestScore = FindLowestScore(jaggedArray);
            // DisplayLowestScore called using lowestScore as an argument 
            DisplayLowestScore(lowestScore);
        }

        private void exit_Button_Click(object sender, EventArgs e)
        {
            // Closes form
            this.Close();
        }
    }
}
