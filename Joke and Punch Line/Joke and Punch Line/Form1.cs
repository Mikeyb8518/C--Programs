using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Joke_and_Punch_Line
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void setup_Button_Click(object sender, EventArgs e)
        {
            setup_Box.Text = "How many programmers does it take to change a lightbulb?";
        }

        private void punchline_Button_Click(object sender, EventArgs e)
        {
            punchline_Box.Text = "None. That's a hardware problem.";
        }
    }
}
