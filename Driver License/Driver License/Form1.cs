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

namespace Driver_License
{
    public partial class driver_License_Form : Form
    {
        public driver_License_Form()
        {
            InitializeComponent();
        }
        // Creates a string array of CorrectAnswers holding answers
        private string[] CorrectAnswers = {"B", "D", "A", "A", "C",
                                           "A", "B", "A", "C", "D",
                                           "B", "C", "D", "A", "D",
                                           "C", "C", "B", "D", "A"};
        // Creates a string array of UserAnswers with a array index of 20
        private string[] UserAnswers = new string[20];
        // ClearData method that clears labels and textboxes and listbox
        // Makes label not visable
        // Resets focus back to student_File_Textbox
        private void ClearData()
        {
            student_File_Textbox.Text = null;
            output_Result_Textbox.Text = null;
            output_NumCorrect_Label.Text = null;
            output_NumIncorrect_Label.Text = null;
            incorrect_Listbox.Items.Clear();

            output_NumCorrect_Label.Visible = false;
            output_NumIncorrect_Label.Visible = false;

            student_File_Textbox.Focus();
        }

        

        private void check_Button_Click(object sender, EventArgs e)
        {
            try
            {
                // Variable to hold correct count
                // Variable to hold incorrect count
                // Variable to hold indext count
                // Variable to hold count for loop
                int numCorrect = 0;
                int numIncorrect = 0;
                int index = 0;
                int count = 0;
                // filename variable assigned to student_File_Textbox
                string filename = student_File_Textbox.Text;
                // Declares streamreader inputFile
                // Opens file from student_File_Textbox
                StreamReader inputFile = File.OpenText(filename);
                // Reads file until the end of file
                while (!inputFile.EndOfStream)
                {
                    // Calles UserAnswers array and reads lines from inputfile
                    UserAnswers[index] = inputFile.ReadLine();
                    // If UserAnswers equals CorrectAnswers using index
                    if (UserAnswers[index] == CorrectAnswers[index])
                    {
                        // Increments numCorrect
                        numCorrect++;
                        // Displays label set to true
                        // Displays numCorrect to string
                        output_NumCorrect_Label.Visible = true;
                        output_NumCorrect_Label.Text = numCorrect.ToString();
                    }
                    else
                    {
                        // Else incorrect, increments numIncorrect
                        numIncorrect++;
                        // count variable equals to index + 1
                        count = index + 1;
                        // Displays label set to true
                        // Displays numIncorrect to string
                        output_NumIncorrect_Label.Visible = true;
                        output_NumIncorrect_Label.Text = numIncorrect.ToString();
                        // Displays question number incorrect to string
                        incorrect_Listbox.Items.Add(count.ToString());
                    }
                    // Increments index
                    index++;
                }
                // Closes file
                inputFile.Close();
                // If numCorrect is greater than or equal to 15
                if (numCorrect >= 15)
                {
                    // Result textbox displays pass
                    output_Result_Textbox.Text = "Pass";
                }
                else
                {
                    // Result textbox displays false
                    output_Result_Textbox.Text = "Fail";
                }

            }
            catch (Exception ex)
            {
                // Displays default error message
                MessageBox.Show(ex.Message);
            }
        }

        private void clear_Button_Click(object sender, EventArgs e)
        {
            // Calls ClearData method to clear data entries
            ClearData();
        }

        private void exit_Button_Click(object sender, EventArgs e)
        {
            // Closes form
            this.Close();
        }
    }
}
