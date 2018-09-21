
/*
 * Created by: Nice Mena
 * Created on: 18-09-2018
 * Created for: ICS3U Programming
 * Daily Assignment – Day #8 - Moving Cat
 * This program creates an illusin of cardi b moving every time I click on the the different menu item.
 * Also it closes the program when you click exit.
*/



using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovingCatNiceM
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

        private void cat1ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.picCardi.Image = Properties.Resources.cardi;

        }

        private void mniCardi2_Click(object sender, EventArgs e)
        {
            this.picCardi.Image = Properties.Resources.cardi2;

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {
         
        }
    }
}
