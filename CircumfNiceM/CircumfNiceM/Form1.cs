/*
 * Created by: Nice Mena
 * Created on: October 27th 2018
 * Created for: ICS3U Programming
 * Daily Assignment – Day #11 -
 * This program calculates the circumference of a circle
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

namespace CircumfNiceM
{
    public partial class CircumfNiceM : Form
    {
        public CircumfNiceM()
        {
            InitializeComponent();
            // Hiding the labels
            this.lblCircumference.Hide();
            this.lblCircumferenceAnswer.Hide();
        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            // declaring my local variables
            double radius, circumference;

            // calculate the circumference

            radius = double.Parse(txtRadius.Text);
            circumference = (3.14 * 2 * radius);

            //insert the height into the label

            this.lblCircumferenceAnswer.Text = String.Format( "{0:00.00} cm", circumference);


            // didplay the totals

            this.lblCircumferenceAnswer.Show();
            this.lblCircumference.Show();
        }
    }
}