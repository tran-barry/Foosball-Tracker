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
    // This form displays all of the user's statistics in a window. It'll also show in a
    // table all the matches they have participated in up until now, which they can open to
    // take a look at specific matches
    //
    public partial class ViewPlayerForm : Form
    {
        //
        // Before this form opens, it'll bring up the choosePlayerForm. However, if the user
        // closes the choosePlayerForm without making a selection, it'll also close this form
        //
        public ViewPlayerForm()
        {
            int id, id2;
            player currentPlayer, otherPlayer;
            match currentMatch;
            string result;
            InitializeComponent();

            // if this remains -1, it means the user exited the choosePlayerForm without selecting someone
            choosePlayerForm.id = -1;

            // Create and show the choosePlayerForm
            choosePlayerForm choosePlayer = new choosePlayerForm();
            choosePlayer.ShowDialog();

            // if the id is still -1, then don't do anything
            id = choosePlayerForm.id;
            if(id != -1)
            {
                // Load the player chosen by choosePlayerForm
                currentPlayer = new player();
                currentPlayer = foosballList.getPlayer(id);

                // Make the labels say the correct thing
                this.nameLabel.Text = this.nameLabel.Text + currentPlayer.name;
                this.winsLabel.Text = this.winsLabel.Text + currentPlayer.wins;
                this.lossesLabel.Text = this.lossesLabel.Text + currentPlayer.losses;
                this.winRatioLabel.Text = this.winRatioLabel.Text + currentPlayer.winRatio;

                // Make a new table. However, if the player hasn't had any matches, it'll
                // say "no matches played" instead
                DataTable table = new DataTable();
                if (foosballList.playerMatchCount(id) != 0)
                {
                    // Enables the viewMatchForm
                    viewMatchForm.matchId = 0;

                    // Creates the dataTable that the Form will show, as well as what the column
                    // headers say
                    table.Columns.Add("Match ID", typeof(int));
                    table.Columns.Add("Versus", typeof(string));
                    table.Columns.Add("Result", typeof(string));
                    
                    // Adds each match to the table
                    for (int i = 0; i < foosballList.playerMatchCount(id); i++)
                    {
                        // Find the i'th match of the player
                        currentMatch = new match();
                        otherPlayer = new player();
                        id2 = foosballList.getPlayerMatch(id, i);
                        currentMatch = foosballList.getMatch(id2);

                        // Find who they played versus, and the result for the player they're viewing
                        result = null;
                        if (id == currentMatch.playerA)
                        {
                            otherPlayer = foosballList.getPlayer(currentMatch.playerB);
                            if (currentMatch.scoreA > currentMatch.scoreB)
                            {
                                result = "W";
                            }
                            else if (currentMatch.scoreA < currentMatch.scoreB)
                            {
                                result = "L";
                            }
                        }
                        else if (id == currentMatch.playerB)
                        {
                            otherPlayer = foosballList.getPlayer(currentMatch.playerA);
                            if (currentMatch.scoreB > currentMatch.scoreA)
                            {
                                result = "W";
                            }
                            else if (currentMatch.scoreB < currentMatch.scoreA)
                            {
                                result = "L";
                            }
                        }

                        // Add it to the table
                        table.Rows.Add(id2, otherPlayer.name, result);
                    }
                }
                else
                {
                    // The table will say something else if they haven't played any matches
                    viewMatchForm.matchId = -1;
                    table.Columns.Add("No matches played", typeof(string));
                }
                // set the matchGrid to this table
                matchGrid.DataSource = table;
            }
        }
        //
        // If the user hits OK, it means they're done looking at the player
        //
        private void OKButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //
        // Automatically close the window if the user didn't choose anyone in the choosePlayerForm
        //
        private void ViewPlayerForm_Load(object sender, EventArgs e)
        {
            // if, by the time the form loads, id is still -1, just close this window automatically
            if (choosePlayerForm.id == -1)
            {
                this.Close();
            }
        }
        //
        // Double-clicking a row is the same thing as clicking on the "View Match" button
        //
        private void matchGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            viewMatchButton_Click(sender, e);
        }
        //
        // If there are no matches to look at, it'll give a message box saying so. Otherwise,
        // it will load the match into viewMathForm.matchId so that the next form can display
        // the specifics of the match.
        //
        private void viewMatchButton_Click(object sender, EventArgs e)
        {
            // Only work if there's an actual row of data to be selected
            if (viewMatchForm.matchId != -1)
            {
                // First, find out which row you're on
                int i = matchGrid.CurrentRow.Index;

                // now, using that row, find out what value is in the first cell, which will be the id
                DataGridViewRow selectedRow = matchGrid.Rows[i];

                // this variable is accessible from other forms
                viewMatchForm.matchId = Convert.ToInt32(selectedRow.Cells[0].Value);

                // Create and show the viewMatchForm
                viewMatchForm viewMatch = new viewMatchForm();
                viewMatch.ShowDialog();
            }
            else
            {
                // Will only reach here if the player has no matches played
                MessageBox.Show("No matches to view.");
            }
        }
    }
}
