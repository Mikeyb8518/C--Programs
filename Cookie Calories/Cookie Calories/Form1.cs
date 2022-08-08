using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cookie_Calories
{
    public partial class cookie_counter_Form : Form
    {
        const int cookie = 75;
        public cookie_counter_Form()
        {
            InitializeComponent();
        }

        private void cookie_counter_Form_Load(object sender, EventArgs e)
        {

        }

        private void calculate_Button_Click(object sender, EventArgs e)
        {
            int total = int.Parse(cookies_Box.Text) * cookie;
            calorie_Box.Text = total.ToString();
        }

        private void clear_Button_Click(object sender, EventArgs e)
        {
            cookies_Box.Text = "";
            calorie_Box.Text = "";
        }

        private void exit_Button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
