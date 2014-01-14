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
    public partial class viewMatchForm : Form
    {
        public static int matchId;
        public viewMatchForm()
        {
            match currentMatch;
            player playerA, playerB;
            InitializeComponent();

            currentMatch = new match();
            playerA = new player();
            playerB = new player();
            currentMatch = foosballList.getMatch(matchId);
            playerA = foosballList.getPlayer(currentMatch.playerA);
            playerB = foosballList.getPlayer(currentMatch.playerB);

            playerALabel.Text = playerA.name;
            playerBLabel.Text = playerB.name;
            scoreALabel.Text = currentMatch.scoreA.ToString();
            scoreBLabel.Text = currentMatch.scoreB.ToString();

            if(currentMatch.scoreA > currentMatch.scoreB)
            {
                resultALabel.Text = "The Winner";
            }
            else if (currentMatch.scoreA < currentMatch.scoreB)
            {
                resultBLabel.Text = "The Winner";
            }
        }

    }
}
