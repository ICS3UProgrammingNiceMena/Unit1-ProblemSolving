namespace PizzaCostNiceM
{
    partial class PizzaCostForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.nudDiameter = new System.Windows.Forms.NumericUpDown();
            this.lblDiameter = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblTotalAnswer = new System.Windows.Forms.Label();
            this.lblNumberOfPizzas = new System.Windows.Forms.Label();
            this.txtPizzas = new System.Windows.Forms.TextBox();
            this.btnCost = new System.Windows.Forms.Button();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.lblTax = new System.Windows.Forms.Label();
            this.lblTaxAnswer = new System.Windows.Forms.Label();
            this.lblSubtotalAnswer = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudDiameter)).BeginInit();
            this.SuspendLayout();
            // 
            // nudDiameter
            // 
            this.nudDiameter.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudDiameter.Location = new System.Drawing.Point(414, 84);
            this.nudDiameter.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nudDiameter.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.nudDiameter.Name = "nudDiameter";
            this.nudDiameter.Size = new System.Drawing.Size(173, 31);
            this.nudDiameter.TabIndex = 0;
            this.nudDiameter.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // lblDiameter
            // 
            this.lblDiameter.AutoSize = true;
            this.lblDiameter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiameter.Location = new System.Drawing.Point(48, 84);
            this.lblDiameter.Name = "lblDiameter";
            this.lblDiameter.Size = new System.Drawing.Size(295, 24);
            this.lblDiameter.TabIndex = 1;
            this.lblDiameter.Text = "Enter the diameter of the pizza (in)";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(106, 369);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(260, 24);
            this.lblTotal.TabIndex = 2;
            this.lblTotal.Text = "The total cost including tax is: ";
            // 
            // lblTotalAnswer
            // 
            this.lblTotalAnswer.AutoSize = true;
            this.lblTotalAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAnswer.Location = new System.Drawing.Point(400, 369);
            this.lblTotalAnswer.Name = "lblTotalAnswer";
            this.lblTotalAnswer.Size = new System.Drawing.Size(15, 24);
            this.lblTotalAnswer.TabIndex = 3;
            this.lblTotalAnswer.Text = ".";
            // 
            // lblNumberOfPizzas
            // 
            this.lblNumberOfPizzas.AutoSize = true;
            this.lblNumberOfPizzas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberOfPizzas.Location = new System.Drawing.Point(48, 135);
            this.lblNumberOfPizzas.Name = "lblNumberOfPizzas";
            this.lblNumberOfPizzas.Size = new System.Drawing.Size(302, 24);
            this.lblNumberOfPizzas.TabIndex = 4;
            this.lblNumberOfPizzas.Text = "Enter the desired number of pizzas";
            // 
            // txtPizzas
            // 
            this.txtPizzas.Location = new System.Drawing.Point(414, 139);
            this.txtPizzas.Name = "txtPizzas";
            this.txtPizzas.Size = new System.Drawing.Size(173, 20);
            this.txtPizzas.TabIndex = 5;
            // 
            // btnCost
            // 
            this.btnCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCost.Location = new System.Drawing.Point(259, 192);
            this.btnCost.Name = "btnCost";
            this.btnCost.Size = new System.Drawing.Size(205, 48);
            this.btnCost.TabIndex = 6;
            this.btnCost.Text = "Calucate Cost";
            this.btnCost.UseVisualStyleBackColor = true;
            this.btnCost.Click += new System.EventHandler(this.btnCost_Click);
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtotal.Location = new System.Drawing.Point(106, 276);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(136, 24);
            this.lblSubtotal.TabIndex = 7;
            this.lblSubtotal.Text = "The subtotal is:";
            // 
            // lblTax
            // 
            this.lblTax.AutoSize = true;
            this.lblTax.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTax.Location = new System.Drawing.Point(106, 322);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(96, 24);
            this.lblTax.TabIndex = 8;
            this.lblTax.Text = "The tax is:";
            // 
            // lblTaxAnswer
            // 
            this.lblTaxAnswer.AutoSize = true;
            this.lblTaxAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaxAnswer.Location = new System.Drawing.Point(217, 322);
            this.lblTaxAnswer.Name = "lblTaxAnswer";
            this.lblTaxAnswer.Size = new System.Drawing.Size(15, 24);
            this.lblTaxAnswer.TabIndex = 9;
            this.lblTaxAnswer.Text = ".";
            // 
            // lblSubtotalAnswer
            // 
            this.lblSubtotalAnswer.AutoSize = true;
            this.lblSubtotalAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtotalAnswer.Location = new System.Drawing.Point(255, 276);
            this.lblSubtotalAnswer.Name = "lblSubtotalAnswer";
            this.lblSubtotalAnswer.Size = new System.Drawing.Size(15, 24);
            this.lblSubtotalAnswer.TabIndex = 10;
            this.lblSubtotalAnswer.Text = ".";
            // 
            // PizzaCostForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 459);
            this.Controls.Add(this.lblSubtotalAnswer);
            this.Controls.Add(this.lblTaxAnswer);
            this.Controls.Add(this.lblTax);
            this.Controls.Add(this.lblSubtotal);
            this.Controls.Add(this.btnCost);
            this.Controls.Add(this.txtPizzas);
            this.Controls.Add(this.lblNumberOfPizzas);
            this.Controls.Add(this.lblTotalAnswer);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblDiameter);
            this.Controls.Add(this.nudDiameter);
            this.Name = "PizzaCostForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nudDiameter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nudDiameter;
        private System.Windows.Forms.Label lblDiameter;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblTotalAnswer;
        private System.Windows.Forms.Label lblNumberOfPizzas;
        private System.Windows.Forms.TextBox txtPizzas;
        private System.Windows.Forms.Button btnCost;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Label lblTax;
        private System.Windows.Forms.Label lblTaxAnswer;
        private System.Windows.Forms.Label lblSubtotalAnswer;
    }
}

