using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prime_Number_List
{
    public partial class prime_Number_List_Form : Form
    {
        public prime_Number_List_Form()
        {
            InitializeComponent();
        }
        // IsPrime boolean method using number as an argument
        // Bool value is set to true
        // If statement that checks to see if remainder is equal to 0, sets value to false
        // Returns value
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
            // Boolean value set to false
            bool value = false;
            // For number is set to 2, number less than or equal too 100, Increments number by 1
            for (int number = 2; number <= 100; number++)
            {
                // If number is equal too 2
                if (number == 2)
                {
                    // Displays prime number in listbox
                    prime_Listbox.Items.Add(number.ToString() + " Is A Prime Number");
                }

                else
                {
                    // value variable calls IsPrime method to see if number is prime
                    value = IsPrime(number);
                    // If statement that checks to see if value is a prime number
                    if (value)
                    {
                        // Displays Is a prime number in listbox
                        prime_Listbox.Items.Add(number.ToString() + " Is A Prime Number");
                    }
                }
            }
        }

        private void clear_Button_Click(object sender, EventArgs e)
        {
            // Clears listbox
            prime_Listbox.Items.Clear();
        }

        private void exit_Button_Click(object sender, EventArgs e)
        {
            // Closes form
            this.Close();
        }
    }
}
