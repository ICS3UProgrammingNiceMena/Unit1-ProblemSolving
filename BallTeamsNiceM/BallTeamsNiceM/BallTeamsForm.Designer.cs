namespace BallTeamsNiceM
{
    partial class BallTeam
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BallTeam));
            this.grbTeams = new System.Windows.Forms.GroupBox();
            this.lblGoldenPlayer = new System.Windows.Forms.Label();
            this.lblTeam = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mniTeams = new System.Windows.Forms.ToolStripMenuItem();
            this.mniBC = new System.Windows.Forms.ToolStripMenuItem();
            this.mniGSW = new System.Windows.Forms.ToolStripMenuItem();
            this.mniTR = new System.Windows.Forms.ToolStripMenuItem();
            this.mniLL = new System.Windows.Forms.ToolStripMenuItem();
            this.mniCC = new System.Windows.Forms.ToolStripMenuItem();
            this.grbTeams.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbTeams
            // 
            this.grbTeams.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.grbTeams.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("grbTeams.BackgroundImage")));
            this.grbTeams.Controls.Add(this.lblGoldenPlayer);
            this.grbTeams.Controls.Add(this.lblTeam);
            this.grbTeams.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbTeams.ForeColor = System.Drawing.Color.Red;
            this.grbTeams.Location = new System.Drawing.Point(466, 27);
            this.grbTeams.Name = "grbTeams";
            this.grbTeams.Size = new System.Drawing.Size(506, 182);
            this.grbTeams.TabIndex = 0;
            this.grbTeams.TabStop = false;
            this.grbTeams.Text = "PRESENTING";
            this.grbTeams.Enter += new System.EventHandler(this.grbTeams_Enter);
            // 
            // lblGoldenPlayer
            // 
            this.lblGoldenPlayer.AutoSize = true;
            this.lblGoldenPlayer.BackColor = System.Drawing.Color.Black;
            this.lblGoldenPlayer.Font = new System.Drawing.Font("Stencil Std", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGoldenPlayer.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblGoldenPlayer.Location = new System.Drawing.Point(239, 84);
            this.lblGoldenPlayer.Name = "lblGoldenPlayer";
            this.lblGoldenPlayer.Size = new System.Drawing.Size(0, 28);
            this.lblGoldenPlayer.TabIndex = 1;
            this.lblGoldenPlayer.Click += new System.EventHandler(this.lblGoldenPlayer_Click);
            // 
            // lblTeam
            // 
            this.lblTeam.AutoSize = true;
            this.lblTeam.BackColor = System.Drawing.Color.Black;
            this.lblTeam.Font = new System.Drawing.Font("Rosewood Std Regular", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeam.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblTeam.Location = new System.Drawing.Point(69, 47);
            this.lblTeam.Name = "lblTeam";
            this.lblTeam.Size = new System.Drawing.Size(0, 37);
            this.lblTeam.TabIndex = 0;
            this.lblTeam.Click += new System.EventHandler(this.lblTeam_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniTeams});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(972, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mniTeams
            // 
            this.mniTeams.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniBC,
            this.mniGSW,
            this.mniTR,
            this.mniLL,
            this.mniCC});
            this.mniTeams.Name = "mniTeams";
            this.mniTeams.Size = new System.Drawing.Size(124, 20);
            this.mniTeams.Text = "Team Golden Player";
            this.mniTeams.Click += new System.EventHandler(this.cleavelanToolStripMenuItem_Click);
            // 
            // mniBC
            // 
            this.mniBC.Name = "mniBC";
            this.mniBC.Size = new System.Drawing.Size(188, 22);
            this.mniBC.Text = "Boston Celtcs";
            this.mniBC.Click += new System.EventHandler(this.mniBC_Click);
            // 
            // mniGSW
            // 
            this.mniGSW.Name = "mniGSW";
            this.mniGSW.Size = new System.Drawing.Size(188, 22);
            this.mniGSW.Text = "Golden State Warriors";
            this.mniGSW.Click += new System.EventHandler(this.mniGSW_Click);
            // 
            // mniTR
            // 
            this.mniTR.Name = "mniTR";
            this.mniTR.Size = new System.Drawing.Size(188, 22);
            this.mniTR.Text = "Toronto Raptors";
            this.mniTR.Click += new System.EventHandler(this.mniTR_Click);
            // 
            // mniLL
            // 
            this.mniLL.Name = "mniLL";
            this.mniLL.Size = new System.Drawing.Size(188, 22);
            this.mniLL.Text = "LA Lakers";
            this.mniLL.Click += new System.EventHandler(this.mniLL_Click);
            // 
            // mniCC
            // 
            this.mniCC.Name = "mniCC";
            this.mniCC.Size = new System.Drawing.Size(188, 22);
            this.mniCC.Text = "Cleveland Cavaliers";
            this.mniCC.Click += new System.EventHandler(this.mniCC_Click);
            // 
            // BallTeam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(972, 593);
            this.Controls.Add(this.grbTeams);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "BallTeam";
            this.Text = "Form1";
            this.grbTeams.ResumeLayout(false);
            this.grbTeams.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbTeams;
        private System.Windows.Forms.Label lblGoldenPlayer;
        private System.Windows.Forms.Label lblTeam;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mniTeams;
        private System.Windows.Forms.ToolStripMenuItem mniBC;
        private System.Windows.Forms.ToolStripMenuItem mniGSW;
        private System.Windows.Forms.ToolStripMenuItem mniTR;
        private System.Windows.Forms.ToolStripMenuItem mniLL;
        private System.Windows.Forms.ToolStripMenuItem mniCC;
    }
}

