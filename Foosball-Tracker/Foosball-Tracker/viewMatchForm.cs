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
    //
    // This form is for viewing the result of an individual match.
    // They will get to this form by viewing an individual player, 
    // and then viewing the matches they participated in
    //
    public partial class viewMatchForm : Form
    {
        //
        // Anyone can access this variable, but only viewPlayerForm will manipulate it.
        // It's so that the form knows which match the player selected on the viewPlayerForm
        //
        public static int matchId;
        //
        // This form will populate the match's statistics, based on what is loaded into matchId.
        // It will also determine who won, and give them a special label underneath their score.
        // The only action the user can take is closing the form.
        //
        public viewMatchForm()
        {
            match currentMatch;
            player playerA, playerB;
            InitializeComponent();

            // loads the match as well as the player names that participated in the match
            currentMatch = new match();
            playerA = new player();
            playerB = new player();
            currentMatch = foosballList.getMatch(matchId);
            playerA = foosballList.getPlayer(currentMatch.playerA);
            playerB = foosballList.getPlayer(currentMatch.playerB);

            // make the labels match the player names and scores
            playerALabel.Text = playerA.name;
            playerBLabel.Text = playerB.name;
            scoreALabel.Text = currentMatch.scoreA.ToString();
            scoreBLabel.Text = currentMatch.scoreB.ToString();

            // by default, both labels under the scores say "The Loser". This will determine
            // who won and change their label to "The Winner"
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
