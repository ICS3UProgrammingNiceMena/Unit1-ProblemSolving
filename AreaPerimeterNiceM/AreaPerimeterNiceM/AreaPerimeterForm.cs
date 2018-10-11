using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AreaPerimeterNiceM
{
    public partial class AreaPerimeterForm : Form
    {
        public AreaPerimeterForm()
        {
            InitializeComponent();
        }

        private void lblPerimeter_Click(object sender, EventArgs e)
        {
            // HIDE the perimeter answer labels and answers until the user clicks on calculate
            this.lblPerimeter.Hide();
        }

        private void lblArea_Click(object sender, EventArgs e)
        {
            // HIDE area answer labels and answers until the user clicks on calculate
            this.lblArea.Hide();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // declare local variables
            double length, width, area, perimeter;

            //convert the string from each text box to a double
            length = double.Parse(txtLength.Text);
            width = double.Parse(txtWidth.Text);

            //calculate 
            area = (length*Width);
            perimeter = (length * 2 + width * 2);

            //Insert the answers into the labels
            this.lblAreaAnswer.Text = String.Format("{0:0.00} cm", area);
            this.lblPerimeterAnswer.Text = String.Format("{0:0.00} cm", perimeter);







        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblWidth_Click(object sender, EventArgs e)
        {

        }

        private void lbPerimeterAnswer_Click(object sender, EventArgs e)
        {

        }
    }
    
}
