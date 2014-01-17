using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Foosball_Tracker
{
    //
    // The main menu. When this closes, the program will also close. It'll bring
    // the user to various parts of the program based on which button they pressed
    //
    public partial class MainMenuForm : Form
    {
        //
        // Loads the main menu
        //
        public MainMenuForm()
        {
            InitializeComponent();
        }
        //
        // Opens a form that allows the user to create a new player entry
        //
        private void CreatePlayer_Click(object sender, EventArgs e)
        {
            // Create and show the CreatePlayerForm
            CreatePlayerForm createPlayer = new CreatePlayerForm();
            createPlayer.ShowDialog();
        }
        //
        // Opens a form that allows the user to view a new player entry.
        // However, if their aren't any players, it'll simply display a message
        // box prompting the user to create a player first.
        //
        private void ViewPlayer_Click(object sender, EventArgs e)
        {
            // check to make sure there's at least 1 player
            if (foosballList.playerCount() != 0)
            {
                // Create and show the ViewPlayerForm
                ViewPlayerForm viewPlayer = new ViewPlayerForm();
                viewPlayer.ShowDialog();
            }
            else
            {
                // No view player form will show
                MessageBox.Show("You need to create a player first!");
            }
        }
        //
        // Bring the user to a form that'll allow them to make a new match entry.
        // There must be at least 2 players created in order for the user to create
        // a new match. Otherwise, it'll prompt the user to create more players
        //
        private void CreateMatch_Click(object sender, EventArgs e)
        {
            // Make sure at least 2 players
            if (foosballList.playerCount() > 1)
            {
                // Create and show the CreateMatchForm
                CreateMatchForm createMatch = new CreateMatchForm();
                createMatch.ShowDialog();
            }
            else
            {
                // No create player form
                MessageBox.Show("There must be at least two players to create a match");
            }
        }
        // 
        // Another way to exit the program
        //
        private void ExitProgram_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //
        // Lets the user clear out all the data saved in the data files. It'll
        // give a message box to make sure. If the user clicks yes, it'll delete
        // the data structures, then save over the .dat files
        //
        private void ClearDataButton_Click(object sender, EventArgs e)
        {
            // "Are you sure you want to delete files? If yes, delete, if no, do nothing
            if (MessageBox.Show("Are you sure you want to erase all data?",
                "Barry's Foosball Tracker", MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                foosballList.clearData();
                MessageBox.Show("All players and matches have been erased.");
            }
        }
    }
}

