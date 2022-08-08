using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Magic_Dates
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void month_Textbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Calculate_Button_Click(object sender, EventArgs e)
        {
            try
            {

                int month = int.Parse(month_Textbox.Text);  // Variable to hold month as integer
                int day = int.Parse(day_Textbox.Text);      // Variable to hold day as integer
                int year = int.Parse(year_Textbox.Text);    // Variable to hold year as intger
                int magic_date = month * day;               // Variable to calculate magic date

                if (magic_date == year)     // If statement to see if the users data is a magic date
                {
                    MessageBox.Show("The Date Is Magic");   // Displays users data is a magic date
                    return;
                }

                else
                {
                    MessageBox.Show("The Date Is Not Magic");   // Displays users data is not a magic date
                    return;
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);    // Displays an error message
            }
        }

        private void reset_Button_Click(object sender, EventArgs e)
        {
            month_Textbox.Text = "";    // Clears month textbox
            day_Textbox.Text = "";      // Clears day textbox
            year_Textbox.Text = "";     // Clears year textbox
        }

        private void exit_Button_Click(object sender, EventArgs e)
        {
            this.Close();               // Closes form
        }
    }
}
