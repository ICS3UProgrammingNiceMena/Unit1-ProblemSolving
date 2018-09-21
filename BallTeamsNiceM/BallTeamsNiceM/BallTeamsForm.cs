/*
 * Created by: Nice M
 * Created on: 17/09/18
 * Created for: ICS3U Programming
 * Daily Assignment – Day #8 school mascot
 * This program changes the name of the basket bal team and star player when you click on
 a different team on the menu bar....
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

namespace BallTeamsNiceM
{
    public partial class BallTeam : Form
    {
        public BallTeam()
        {
            InitializeComponent();
        }

        private void cleavelanToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void grbTeams_Enter(object sender, EventArgs e)
        {

        }
       
        private void lblTeam_Click(object sender, EventArgs e)
        {
       
        }

    private void lblGoldenPlayer_Click(object sender, EventArgs e)
        {

        }
        // This changes the name of the team and star player displayed on the screen.//
        private void mniBC_Click(object sender, EventArgs e)
        {
            lblTeam.Text = "Boston Celtics";
            lblGoldenPlayer.Text = "Jayson Tatum";
        }
        // This changes the name of the team and star player displayed on the screen.//
        private void mniTR_Click(object sender, EventArgs e)
        {
            lblTeam.Text = "Toronto Raptors";
            lblGoldenPlayer.Text = "Kyle Lowry";
        }
        // This changes the name of the team and star player displayed on the screen.//
        private void mniLL_Click(object sender, EventArgs e)
        {
            lblTeam.Text = "LA Lakers";
            lblGoldenPlayer.Text = "Kobe Bryant";
        }
        // This changes the name of the team and star player displayed on the screen.//
        private void mniCC_Click(object sender, EventArgs e)
        {
            lblTeam.Text = "Cleveland Cavaliers";
            lblGoldenPlayer.Text = "Tristan Thompson";

       }
        // This changes the name of the team and star player displayed on the screen.//
        private void mniGSW_Click(object sender, EventArgs e)
        {
            lblTeam.Text = "Golden State Warriors";
            lblGoldenPlayer.Text = "Steph Curry";
        }

    }



}
