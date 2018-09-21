namespace MovingCatNiceM
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mniExit = new System.Windows.Forms.ToolStripMenuItem();
            this.cat1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mniCardi1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mniCardi2 = new System.Windows.Forms.ToolStripMenuItem();
            this.picCardi = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCardi)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.cat1ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(922, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniExit});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // mniExit
            // 
            this.mniExit.Name = "mniExit";
            this.mniExit.Size = new System.Drawing.Size(152, 22);
            this.mniExit.Text = "Exit";
            this.mniExit.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // cat1ToolStripMenuItem
            // 
            this.cat1ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniCardi1,
            this.mniCardi2});
            this.cat1ToolStripMenuItem.Name = "cat1ToolStripMenuItem";
            this.cat1ToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.cat1ToolStripMenuItem.Text = "Cardi";
            // 
            // mniCardi1
            // 
            this.mniCardi1.Name = "mniCardi1";
            this.mniCardi1.Size = new System.Drawing.Size(111, 22);
            this.mniCardi1.Text = "Cardi1";
            this.mniCardi1.Click += new System.EventHandler(this.cat1ToolStripMenuItem1_Click);
            // 
            // mniCardi2
            // 
            this.mniCardi2.Name = "mniCardi2";
            this.mniCardi2.Size = new System.Drawing.Size(111, 22);
            this.mniCardi2.Text = "Cardi 2";
            this.mniCardi2.Click += new System.EventHandler(this.mniCardi2_Click);
            // 
            // picCardi
            // 
            this.picCardi.BackColor = System.Drawing.Color.Transparent;
            this.picCardi.ErrorImage = ((System.Drawing.Image)(resources.GetObject("picCardi.ErrorImage")));
            this.picCardi.Image = global::MovingCatNiceM.Properties.Resources.cardi2;
            this.picCardi.InitialImage = ((System.Drawing.Image)(resources.GetObject("picCardi.InitialImage")));
            this.picCardi.Location = new System.Drawing.Point(314, 42);
            this.picCardi.Name = "picCardi";
            this.picCardi.Size = new System.Drawing.Size(317, 420);
            this.picCardi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCardi.TabIndex = 0;
            this.picCardi.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 543);
            this.Controls.Add(this.picCardi);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCardi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picCardi;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mniExit;
        private System.Windows.Forms.ToolStripMenuItem cat1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mniCardi1;
        private System.Windows.Forms.ToolStripMenuItem mniCardi2;
    }
}

