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

namespace Charge_Account_Information
{
    public partial class charge_Account_Form : Form
    {
        public charge_Account_Form()
        {
            InitializeComponent();
        }
        // AccountNumber method searches a int array for a specifed value
        // If found the value is found its position returns true
        // Otherwise, -1 is returned
        private int AccountNumber(int[] account, int number)
        {
            // Flag indicating search results
            bool found = false;
            // Used to step through array
            int index = 0;
            // Postion of value if found
            int postition = -1;
            // Searches the array
            while (!found && index < account.Length)
            {
                if (account[index] == number)
                {
                    found = true;
                    postition = index;
                }
                index++;
            }
            return postition;
        }
        // ClearUserInput method clears users input
        // Resets focus back to output_Textbox
        private void ClearUsersInput()
        {
            output_Textbox.Text = null;
            output_Textbox.Focus();
        }

        private void check_Button_Click(object sender, EventArgs e)
        {
            try
            {
                // Creates array size read from file
                const int SIZE = 18;
                int[] account_Number = new int[SIZE];
                // Loop counter
                int index = 0;
                // Variable to hold users selection
                int selection;
                // Delcares streamreader variable to read contents of file
                StreamReader inputFile = inputFile = File.OpenText("ChargeAccounts.txt");
                // Read contents of file into the array
                while (!inputFile.EndOfStream && index < account_Number.Length)
                {
                    account_Number[index] = int.Parse(inputFile.ReadLine());
                    index++;
                }
                // Closes file
                inputFile.Close();
                
                if (Convert.ToInt32(output_Textbox.Text) != -1)
                {
                    // Gets the users input value 
                    selection = Convert.ToInt32(output_Textbox.Text);
                    // Determines if users input is in the array
                    if (AccountNumber(account_Number, selection) != -1)
                    {
                        // Displays users input is in the array
                        MessageBox.Show("That is a correct Charge Account");
                    }
                    else
                    {
                        // Displays users input is not in the array
                        MessageBox.Show("That is not one of the Charge Accounts");
                    }
                }
            }
            catch (Exception ex)
            {
                // Deafult error message
                MessageBox.Show(ex.Message);
            }
        }

        private void clear_Button_Click(object sender, EventArgs e)
        {
            // Calls ClearsUsersInput method, to clear input, reset focus
            ClearUsersInput();
        }

        private void exit_Button_Click(object sender, EventArgs e)
        {
            // Closes form
            this.Close();
        }
    }

}
