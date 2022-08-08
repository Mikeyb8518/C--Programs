using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Picture_Calorie_Counter
{
    public partial class calorie_Counter : Form
    {
        const int apple = 80;
        const int banana = 115;
        const int orange = 90;
        const int pear = 120;

        private int total = 0;
        public calorie_Counter()
        {
            InitializeComponent();
        }

        private void calorie_Counter_Load(object sender, EventArgs e)
        {

        }

        private void banana_Box_Click(object sender, EventArgs e)
        {
            total += banana;
            total_Box.Text = total.ToString();
        }

        private void apple_Box_Click(object sender, EventArgs e)
        {
            total += apple;
            total_Box.Text = total.ToString();
        }

        private void orange_Box_Click(object sender, EventArgs e)
        {
            total += orange;
            total_Box.Text = total.ToString();
        }

        private void pear_Box_Click(object sender, EventArgs e)
        {
            total += pear;
            total_Box.Text = total.ToString();
        }

        private void reset_Button_Click(object sender, EventArgs e)
        {
            total_Box.Text = "";
            total = 0;
        }

        private void exit_Button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
