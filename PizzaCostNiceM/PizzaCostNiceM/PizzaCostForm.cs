/*
 * Created by: Nice Mena
 * Created on: October 1st 2018
 * Created for: ICS3U Programming
 * Daily Assignment – Day #12 - Pseudocode
 * This program calculates the total for a pizza.
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

namespace PizzaCostNiceM
{
    public partial class PizzaCostForm : Form
    {
        public PizzaCostForm()
        {
            InitializeComponent();
            //Hide the label
            this.lblSubtotalAnswer.Hide();
            this.lblTaxAnswer.Hide();
            this.lblTotalAnswer.Hide();
        }


        private void btnCost_Click(object sender, EventArgs e)

        {

            // declaring my local variables
            double subtotal, total, tax, diameter, pizzas;

            // calculate the subtotal

            diameter = (double)(nudDiameter.Value);
            pizzas = double.Parse(txtPizzas.Text);

            subtotal = (0.99 + 0.75 + 0.50 * diameter) * pizzas;
            tax = subtotal * 0.13;
            total = subtotal + tax;

            //insert the height into the label

            this.lblSubtotalAnswer.Text = String.Format("$ {0:00.00}", subtotal);
            this.lblTaxAnswer.Text = String.Format("$ {0:0.00}", tax);
            this.lblTotalAnswer.Text = String.Format("$ {0:00.00}", total);

            // didplay the totals

            this.lblSubtotalAnswer.Show();
            this.lblTaxAnswer.Show();
            this.lblTotalAnswer.Show();

           
        }
    }
}