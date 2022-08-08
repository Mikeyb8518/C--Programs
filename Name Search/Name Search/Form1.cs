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

namespace Name_Search
{
    public partial class search_Form : Form
    {
        // Declares boyName/girlName array to hold boyNames.txt and girlNames.txt 
        string[] boysName = new string[200];
        string[] girlsName = new string[200];
        // Variable to hold loop interation
        int i = 0;
        // ReadNamesIntoArray method to read files names into names array
        // Returns array
        private string[] ReadNamesIntoArray(string filename)
        {
            // Initializing names array with size of 200
            string[] names = new string[200];
            // Resets i to 0 
            i = 0;
            // Opens the file
            StreamReader inputFile = File.OpenText(filename);
            // Loops until the inputFile reaches the end of the file
            while (!inputFile.EndOfStream)
            {
                // Puts names into the names array
                names[i] = inputFile.ReadLine();
                i++;
            }
            // Closes file
            inputFile.Close();
            // Returns array
            return names;
        }
        public search_Form()
        {
            InitializeComponent();
        }


        private void search_Form_Load(object sender, EventArgs e)
        {
            // Fills the boysName/girlNames array calling the ReadNamesIntoArray method
            // Filling the names into the arrays
            boysName = ReadNamesIntoArray("BoyNames.txt");
            girlsName = ReadNamesIntoArray("GirlNames.txt");
        }
        // SearchName method searches names in nameList and reutrns true or false
        private Boolean SearchName(string name, string[] nameList)
        {
            for (int i = 0; i < nameList.Count(); i++)
            {
                if (nameList[i] == name)
                    return true;
            }
            return false;
        }
        // ReturnResults method returns the result of the final output if the isFound is true or false
        private string ReturnResults(string name, Boolean isFound)
        {
            string result = "";

            if (isFound)
            {
                result = "The name " + name + " is " + "found in the popular list";
            }
            else
            {
                result = "The name " + name + " is " + "not found in the popular list";
            }

            return result;
        }
        // ClearData method clears the users entries
        private void ClearData()
        {
            boySearch_Textbox.Text = null;
            girlSearch_Textbox.Text = null;

            boySearch_Textbox.Focus();
        }

        private void search_Button_Click(object sender, EventArgs e)
        {
            // Variable to hold boySearch_Textbox 
            string boy_name = "";
            // Variable to hold girlSearch_Textbox
            string girl_name = "";
            // Variable to hold results
            string strResult = "";
            // Variable to hold the status of boyNames
            bool boyNameCheck = false;
            // Variable to hold status of girlNames
            bool girlNameCheck = false;
            // If boySearch_Textbox and girlSearch_Textbox is not empty
            if (boySearch_Textbox.Text != "" && girlSearch_Textbox.Text != "")
            {
                // Assigns boy_name to boySearch_Textbox
                boy_name = boySearch_Textbox.Text;
                // Assigns girl_name to girlSearch_Textbox
                girl_name = girlSearch_Textbox.Text;
                // Calling the SearchName method by passing boy_name and boysName 
                // Returns name true or false
                boyNameCheck = SearchName(boy_name, boysName);
                // Calling the SearchName method by passing girl_name and girlsName
                // Returns name true or false
                girlNameCheck = SearchName(girl_name, girlsName);
                // Calls ReturResults method by passing boy_name and boyNameCheck
                // Returns result
                strResult = ReturnResults(boy_name, boyNameCheck);
                // Add a new line to strResults
                strResult += "\n";
                // Calls the ReturnResults method by passing girl_name and girlNameCheck
                // Returns results
                strResult += ReturnResults(girl_name, girlNameCheck);
            }
            // Else if boySearch_Textbox is not empty
            else if (boySearch_Textbox.Text != "")
            {
                // Assigns boy_name to boySearch_Textbox
                boy_name = boySearch_Textbox.Text;
                // Calling the SearchName method by passing boy_name and boysName 
                // Returns name true or false
                boyNameCheck = SearchName(boy_name, boysName);
                // Calls ReturResults method by passing boy_name and boyNameCheck
                // Returns result
                strResult = ReturnResults(boy_name, boyNameCheck);
            }
            // Else if girlSearch_Textbox is not empty
            else if (girlSearch_Textbox.Text != "")
            {
                // Assigns girl_name to girlSearch_Textbox 
                girl_name = girlSearch_Textbox.Text;
                // Calling the SearchName method by passing girl_name and girlsName
                // Returns name true or false
                girlNameCheck = SearchName(girl_name, girlsName);
                // Calls the ReturnResults method by passing girl_name and girlNameCheck
                // Returns results
                strResult = ReturnResults(girl_name, girlNameCheck);
            }
            else
            {
                // If both girl and boy name textboxes are empty
                // Result displays message
                strResult = "Please Enter a Girl Name or Boy Name or Both";
            }
            // Displays strResults into messagebox
            MessageBox.Show(strResult);
        }

        private void clear_Button_Click(object sender, EventArgs e)
        {
            // Calls ClearData method to clear all users entries
            ClearData();
        }

        private void exit_Button_Click(object sender, EventArgs e)
        {
            // Closes form
            this.Close();
        }
    }
}
