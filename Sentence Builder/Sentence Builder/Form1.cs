using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sentence_Builder
{
    public partial class sentenceBuilder_Form : Form
    {
        public sentenceBuilder_Form()
        {
            InitializeComponent();
        }

        private void Button_A_Click(object sender, EventArgs e)
        {
            string text = "A";
            string total = text;
            output_Box.Text += total;
        }

        private void exit_Button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lowercase_a_Button_Click(object sender, EventArgs e)
        {
            string text = "a";
            string total = text;
            output_Box.Text += total;
        }

        private void button_An_Click(object sender, EventArgs e)
        {
            string text = "An";
            string total = text;
            output_Box.Text += total;
        }

        private void button_an__Click(object sender, EventArgs e)
        {
            string text = "an";
            string total = text;
            output_Box.Text += total;
        }

        private void button_The_Click(object sender, EventArgs e)
        {
            string text = "The";
            string total = text;
            output_Box.Text += total;
        }

        private void button_the__Click(object sender, EventArgs e)
        {
            string text = "the";
            string total = text;
            output_Box.Text += total;
        }

        private void button_man_Click(object sender, EventArgs e)
        {
            string text = "man";
            string total = text;
            output_Box.Text += total;
        }

        private void button_woman_Click(object sender, EventArgs e)
        {
            string text = "woman";
            string total = text;
            output_Box.Text += total;
        }

        private void button_dog_Click(object sender, EventArgs e)
        {
            string text = "dog";
            string total = text;
            output_Box.Text += total;
        }

        private void button_cat_Click(object sender, EventArgs e)
        {
            string text = "cat";
            string total = text;
            output_Box.Text += total;
        }

        private void button_car_Click(object sender, EventArgs e)
        {
            string text = "car";
            string total = text;
            output_Box.Text += total;
        }

        private void button_bicycle_Click(object sender, EventArgs e)
        {
            string text = "bicycle";
            string total = text;
            output_Box.Text += total;
        }

        private void button_beautiful_Click(object sender, EventArgs e)
        {
            string text = "beautiful";
            string total = text;
            output_Box.Text += total;
        }

        private void button_big_Click(object sender, EventArgs e)
        {
            string text = "big";
            string total = text;
            output_Box.Text += total;
        }

        private void button_small_Click(object sender, EventArgs e)
        {
            string text = "small";
            string total = text;
            output_Box.Text += total;
        }

        private void button_strange_Click(object sender, EventArgs e)
        {
            string text = "strange";
            string total = text;
            output_Box.Text += total;
        }

        private void button_looked_at_Click(object sender, EventArgs e)
        {
            string text = "looked at";
            string total = text;
            output_Box.Text += total;
        }

        private void button_rode_Click(object sender, EventArgs e)
        {
            string text = "rode";
            string total = text;
            output_Box.Text += total;
        }

        private void button_spoke_to_Click(object sender, EventArgs e)
        {
            string text = "spoke to";
            string total = text;
            output_Box.Text += total;
        }

        private void button_laughed_at_Click(object sender, EventArgs e)
        {
            string text = "laughed at";
            string total = text;
            output_Box.Text += total;
        }

        private void button_drove_Click(object sender, EventArgs e)
        {
            string text = "drove";
            string total = text;
            output_Box.Text += total;
        }

        private void button_space_Click(object sender, EventArgs e)
        {
            string text = " ";
            string total = text;
            output_Box.Text += total;
        }

        private void button_period_Click(object sender, EventArgs e)
        {
            string text = ".";
            string total = text;
            output_Box.Text += total;
        }

        private void button_exclaimation_point_Click(object sender, EventArgs e)
        {
            string text = "!";
            string total = text;
            output_Box.Text += total;
        }

        private void clear_Button_Click(object sender, EventArgs e)
        {
            output_Box.Text = "";
        }
    }
}
