using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prime_Numbers
{
    public partial class prime_Form : Form
    {
        public prime_Form()
        {
            InitializeComponent();
        }
        // Isprime boolean method that takes integer number as a arguement
        // Sets value to true
        // Checks to see if argument number is divisable by any numbers
        // Returns false if 0
        // If remainder is 1 it returns value
        private Boolean IsPrime(int number)
        {
            bool value = true;

            for (int i = 2; i < number; i++)
            {
                if ((number % i) == 0)
                {
                    value = false;
                    break;
                }
            }
            return value;
        }

        private void check_Button_Click(object sender, EventArgs e)
        {
            try
            {
                // Declares boolean variable
                // Declares integer value
                bool value;
                int number;
                // Users data turns into integer for number variable
                number = int.Parse(prime_Textbox.Text);
                // value variable calls IsPrime method to check if number is prime
                value = IsPrime(number);
                // If value is prime
                if (value)
                {
                    // Displays Number is Prime
                    MessageBox.Show("Number Is Prime!!!");
                }
                else
                {
                    // Displays number is not prime
                    MessageBox.Show("Number Is Not Prime, Try Again!");
                }

            }
            catch (Exception ex)
            {
                // default error message
                MessageBox.Show(ex.Message);
            }
        }

        private void clear_Button_Click(object sender, EventArgs e)
        {
            // Clears users entry
            prime_Textbox.Text = null;
            // Resets focus to prime_Textbox
            prime_Textbox.Focus();
        }

        private void exit_Button_Click(object sender, EventArgs e)
        {
            // Closes form
            this.Close();
        }
    }
}
