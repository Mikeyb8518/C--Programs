using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clickable_Number_Images
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void onePictureBox_Click_Click(object sender, EventArgs e)
        {
            MessageBox.Show("One");
        }

        private void twoPictureBox_Click_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Two");
        }

        private void threePictureBox_Click_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Three");
        }

        private void fourPictureBox_Click_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Four");
        }

        private void fivePictureBox_Click_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Five");
        }
    }
}
