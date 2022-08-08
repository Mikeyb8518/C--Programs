using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Card_Identifier
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void queenOfDiamonds_Pic_Click(object sender, EventArgs e)
        {
            answer_Box.Text = "Queen of Diamonds";
        }

        private void twoOfHearts_Pic_Click(object sender, EventArgs e)
        {
            answer_Box.Text = "Two of Hearts";
        }

        private void sevenOfSpades_Pic_Click(object sender, EventArgs e)
        {
            answer_Box.Text = "Seven of Spades";
        }

        private void aceOfClubs_Pic_Click(object sender, EventArgs e)
        {
            answer_Box.Text = "Ace of Clubs";
        }

        private void fourOfDiamonds_Pic_Click(object sender, EventArgs e)
        {
            answer_Box.Text = "Four of Diamonds";
        }
    }
}
