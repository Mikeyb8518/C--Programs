using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Distance_Traveled
{
    public partial class distacne_Form : Form
    {
        public distacne_Form()
        {
            InitializeComponent();
        }

        private void fiveHour_Button_Click(object sender, EventArgs e)
        {
            try
            {
                int distance;
                int hours = 5;
                int total;

                distance = int.Parse(speed_Text.Text) * hours;
                total = distance;
                output_Text.Text = total.ToString();
            }

            catch 
            {
                MessageBox.Show("Invalid Data Entered!");
            }
        }

        private void eightHour_Button_Click(object sender, EventArgs e)
        {
            try
            {
                int distance;
                int hours = 8;
                int total;

                distance = int.Parse(speed_Text.Text) * hours;
                total = distance;
                output_Text.Text = total.ToString();
            }

            catch
            {
                MessageBox.Show("Invalid Data Entered!");
            }
        }

        private void twelveHours_Button_Click(object sender, EventArgs e)
        {
            try
            {
                int distance;
                int hours = 12;
                int total;

                distance = int.Parse(speed_Text.Text) * hours;
                total = distance;
                output_Text.Text = total.ToString();
            }

            catch
            {
                MessageBox.Show("Invalid Data Entered!");
            }
        }

        private void clear_Button_Click(object sender, EventArgs e)
        {
            speed_Text.Text = "";
            output_Text.Text = "";
        }

        private void exit_Button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
