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
            double Length, width, area, perimeter;

            //convert the string from each text box to a double
            length = double.Parse(txtLength.Text);
            width = double.Parse(txtWidth.Text);
        }
    }
    }
}
