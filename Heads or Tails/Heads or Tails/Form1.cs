using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Heads_or_Tails
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void show_Heads_Button_Click(object sender, EventArgs e)
        {
            heads_Pic.Visible = true;
            tails_Pic.Visible = false;
        }

        private void show_Tails_Button_Click(object sender, EventArgs e)
        {
            heads_Pic.Visible = false;
            tails_Pic.Visible = true;
        }

        private void exit_Button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
