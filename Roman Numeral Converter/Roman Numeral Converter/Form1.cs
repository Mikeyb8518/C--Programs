using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Roman_Numeral_Converter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void convert_Button_Click(object sender, EventArgs e)
        {
            try
            {
                string Roman_Numeral = input_Textbox.Text; // Variable used for the users input

                switch (Roman_Numeral)      // Switch Statement to convert users input to Roman Numerals
                {
                    case "1":
                        output_Label.Text = "I";
                        break;

                    case "2":
                        output_Label.Text = "II";
                        break;
                    
                    case "3":
                        output_Label.Text = "III";
                        break;

                    case "4":
                        output_Label.Text = "IV";
                        break;

                    case "5":
                        output_Label.Text = "V";
                        break;

                    case "6":
                        output_Label.Text = "VI";
                        break;

                    case "7":
                        output_Label.Text = "VII";
                        break;

                    case "8":
                        output_Label.Text = "VIII";
                        break;

                    case "9":
                        output_Label.Text = "IX";
                        break;

                    case "10":
                        output_Label.Text = "X";
                        break;

                    default:
                        MessageBox.Show("Please Enter A Value From 1-10");
                        break;
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void clear_Button_Click(object sender, EventArgs e)
        {
            input_Textbox.Text = "";
            output_Label.Text = "";
        }

        private void exit_Button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
