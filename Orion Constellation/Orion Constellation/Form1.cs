using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Orion_Constellation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void show_Button_Click(object sender, EventArgs e)
        {
            betelgeuse_Label.Visible = true;
            meissa_Label.Visible = true;
            alnitak_Label.Visible = true;
            alnilam_Label.Visible = true;
            mintaka_Label.Visible = true;
            sapiah_Label.Visible = true;
            rigel_Label.Visible = true;
        }

        private void hide_Button_Click(object sender, EventArgs e)
        {
            betelgeuse_Label.Visible = false;
            meissa_Label.Visible = false;
            alnitak_Label.Visible = false;
            alnilam_Label.Visible = false;
            mintaka_Label.Visible = false;
            sapiah_Label.Visible = false;
            rigel_Label.Visible = false;
        }

        private void exit_Button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
