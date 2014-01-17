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
    // This form allows the player to create a new match entry by choosing values from
    // the drop down box
    //
    public partial class CreateMatchForm : Form
    {
        //
        // When the form first loads, it'll load all the different players into the player
        // boxes as well as the scores into the score boxes
        //
        public CreateMatchForm()
        {
            player entry;
            int i;
            InitializeComponent();

            // put every player name onto the list of players selectable in both
            // player boxes
            for (i = 0; i < foosballList.playerCount(); i++)
            {
                entry = new player();
                entry = foosballList.getPlayer(i);
                playerABox.Items.Add(entry.name);
                playerBBox.Items.Add(entry.name);
            }

            // now adds the values 0 to 10 in the score boxes, as these are the
            // only scores available in foosball
            for (i = 0; i < 11; i++)
            {
                AScoreBox.Items.Add(i);
                BScoreBox.Items.Add(i);
            }

            // Set default values for boxes. The first and second players ever created
            // are the default names
            playerABox.SelectedIndex = 0;
            playerBBox.SelectedIndex = 1;
            AScoreBox.SelectedIndex = 0;
            BScoreBox.SelectedIndex = 0;
        }
        //
        // Does a few checks for the choices the user made. It will display a message and do nothing if:
        //      1 - It's the same player (since a player can't play themself)
        //      2 - If the players somehow managed to get a tie (physically impossible in foosball)
        //      3 - If one of the players didn't get 10 points (since to win a game, you need at least 10 pts)
        // If it's all good, it'll add the match to the players and the match list
        //
        private void OKButton_Click(object sender, EventArgs e)
        {
            match newMatch;
            newMatch = new match();

            // sets up the new match structure with whatever's in the boxes
            newMatch.playerA = playerABox.SelectedIndex;
            newMatch.playerB = playerBBox.SelectedIndex;
            newMatch.scoreA = AScoreBox.SelectedIndex;
            newMatch.scoreB = BScoreBox.SelectedIndex;

            // Make sure the players aren't the same, and that one score is a 10, and that it isn't a tie.
            // If all is good, then go ahead and create the player
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
                // You're good to create the match and save it
                foosballList.addMatch(newMatch);
                foosballList.saveData();
                this.Close();
            }
        }
        //
        // If the user decides he doesn't want to make a new match anymore, he can hit the cancel button
        // and it'll just bring them back to the main menu
        //
        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
