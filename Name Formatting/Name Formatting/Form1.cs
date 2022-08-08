using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Name_Formatting
{
    public partial class name_Form : Form
    {
        public name_Form()
        {
            InitializeComponent();
        }

        private void name_Form_Load(object sender, EventArgs e)
        {

        }

        private void allNames_Button_Click(object sender, EventArgs e)
        {
            string output;

            output = titleName_Text.Text + " " + firstName_Text.Text + " " + middleName_Text.Text + " " + lastName_Text.Text;

            name_Output.Text = output;
        }

        private void firstMiddleLast_Button_Click(object sender, EventArgs e)
        {
            string output;

            output = firstName_Text.Text + " " + middleName_Text.Text + " " + lastName_Text.Text;

            name_Output.Text = output;
        }

        private void firstLast_Button_Click(object sender, EventArgs e)
        {
            string output;

            output = firstName_Text.Text + " " + lastName_Text.Text;

            name_Output.Text = output;
        }

        private void lastFirstMiddleTitle_Button_Click(object sender, EventArgs e)
        {
            string output;

            output = lastName_Text.Text + ", " + firstName_Text.Text + " " + middleName_Text.Text + ", " + titleName_Text.Text;

            name_Output.Text = output;
        }

        private void lastFirstMiddle_Button_Click(object sender, EventArgs e)
        {
            string output;

            output = lastName_Text.Text + ", " + firstName_Text.Text + " " + lastName_Text.Text;

            name_Output.Text = output;
        }

        private void lastFirst_Button_Click(object sender, EventArgs e)
        {
            string output;

            output = lastName_Text.Text + ", " + firstName_Text.Text;

            name_Output.Text = output;
        }

        private void clear_Button_Click(object sender, EventArgs e)
        {
            firstName_Text.Text = "";
            middleName_Text.Text = "";
            lastName_Text.Text = "";
            titleName_Text.Text = "";
            name_Output.Text = "";
        }

        private void exit_Button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
