using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dice_Simulator
{
    public partial class dice_Simulator_Form : Form
    {
        public dice_Simulator_Form()
        {
            InitializeComponent();
        }
        private void roll_Button_Click_1(object sender, EventArgs e)
        {
            // Creates a random variable
            Random rnd = new Random();

            // Dice 1 selects a random number 1-6
            // Dice 2 selects a random number 1-6
            int dice1 = rnd.Next(1, 7);
            int dice2 = rnd.Next(1, 7);

            // Switch statement that if dice 1 is a number from 1-6
            // Displays dice number picture from picturebox1 selection
            switch (dice1)
            {
                case 1:
                    dice1_Picturebox1.Visible = true;
                    break;
                case 2:
                    dice2_Picturebox1.Visible = true;
                    break;
                case 3:
                    dice3_Picturebox1.Visible = true;
                    break;
                case 4:
                    dice4_Picturebox1.Visible = true;
                    break;
                case 5:
                    dice5_Picturebox1.Visible = true;
                    break;
                case 6:
                    dice6_Picturebox1.Visible = true;
                    break;
            }
            // Switch statement that if dice 2 is a number from 1-6
            // Displays dice number picture from picturebox2 selection
            switch (dice2)
            {
                case 1:
                    dice1_Picturebox2.Visible = true;
                    break;
                case 2:
                    dice2_Picturebox2.Visible = true;
                    break;
                case 3:
                    dice3_Picturebox2.Visible = true;
                    break;
                case 4:
                    dice4_Picturebox2.Visible = true;
                    break;
                case 5:
                    dice5_Picturebox2.Visible = true;
                    break;
                case 6:
                    dice6_Picturebox2.Visible = true;
                    break;
            }
        }

        private void clear_Button_Click(object sender, EventArgs e)
        {
            // Turns picturebox visibility false for number 1
            dice1_Picturebox1.Visible = false;
            dice1_Picturebox2.Visible = false;
            // Turns picturebox visibility false for number 2
            dice2_Picturebox1.Visible = false;
            dice2_Picturebox2.Visible = false;
            // Turns picturebox visibility false for number 3
            dice3_Picturebox1.Visible = false;
            dice3_Picturebox2.Visible = false;
            // Turns picturebox visibility false for number 4
            dice4_Picturebox1.Visible = false;
            dice4_Picturebox2.Visible = false;
            // Turns picturebox visibility false for number 5
            dice5_Picturebox1.Visible = false;
            dice5_Picturebox2.Visible = false;
            // Turns picturebox visibility false for number 6
            dice6_Picturebox1.Visible = false;
            dice6_Picturebox2.Visible = false;
        }

        private void exit_Button_Click(object sender, EventArgs e)
        {
            // Closes form
            this.Close();
        }
    }
}
