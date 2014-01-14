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
    public partial class MainMenuForm : Form
    {
        public MainMenuForm()
        {
            InitializeComponent();
        }

        private void CreatePlayer_Click(object sender, EventArgs e)
        {
            // Create and show the CreatePlayerForm
            CreatePlayerForm createPlayer = new CreatePlayerForm();
            createPlayer.ShowDialog();
        }

        private void ViewPlayer_Click(object sender, EventArgs e)
        {
            if (foosballList.playerCount() != 0)
            {
                // Create and show the ViewPlayerForm
                ViewPlayerForm viewPlayer = new ViewPlayerForm();
                viewPlayer.ShowDialog();
            }
            else
            {
                MessageBox.Show("You need to create a player first!");
            }
        }

        private void CreateMatch_Click(object sender, EventArgs e)
        {
            if (foosballList.playerCount() > 1)
            {
                // Create and show the CreateMatchForm
                CreateMatchForm createMatch = new CreateMatchForm();
                createMatch.ShowDialog();
            }
            else
            {
                MessageBox.Show("There must be at least two players to create a match");
            }
        }

        private void ExitProgram_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ClearDataButton_Click(object sender, EventArgs e)
        {
            foosballList.clearData();
            MessageBox.Show("All players and matches have been erased.");
        }
    }
}

