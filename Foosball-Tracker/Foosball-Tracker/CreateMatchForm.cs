using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Foosball_Tracker
{
    public partial class CreateMatchForm : Form
    {
        public CreateMatchForm()
        {
            player entry;
            int i;
            InitializeComponent();

            for (i = 0; i < foosballList.playerCount(); i++)
            {
                entry = new player();
                entry = foosballList.getPlayer(i);
                playerABox.Items.Add(entry.name);
                playerBBox.Items.Add(entry.name);
            }
            for (i = 0; i < 11; i++)
            {
                AScoreBox.Items.Add(i);
                BScoreBox.Items.Add(i);
            }

            // Set default values for boxes
            playerABox.SelectedIndex = 0;
            playerBBox.SelectedIndex = 1;
            AScoreBox.SelectedIndex = 0;
            BScoreBox.SelectedIndex = 0;
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            match newMatch;
            newMatch = new match();
            newMatch.playerA = playerABox.SelectedIndex;
            newMatch.playerB = playerBBox.SelectedIndex;
            newMatch.scoreA = AScoreBox.SelectedIndex;
            newMatch.scoreB = BScoreBox.SelectedIndex;

            // Make sure the players aren't the same, and that one score is a 10, and that it isn't a tie
            if(newMatch.playerA == newMatch.playerB)
            {
                MessageBox.Show("You can't select the same player");
            }
            else if(newMatch.scoreA == newMatch.scoreB)
            {
                MessageBox.Show("A tie in foosball is physically impossible");
            }
            else if (newMatch.scoreA != 10 && newMatch.scoreB != 10)
            {
                MessageBox.Show("Someone must score 10 points to be a victor");
            }
            else
            {
                foosballList.addMatch(newMatch);
                foosballList.saveData();
                this.Close();
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
