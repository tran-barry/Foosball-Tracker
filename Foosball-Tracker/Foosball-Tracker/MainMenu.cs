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

        private void MainMenu_Load(object sender, EventArgs e)
        {
            // Create records internally for this current run
            foosballList records = new foosballList();

            // Initialize records and data
            records.initialize();
        }

        private void CreatePlayer_Click(object sender, EventArgs e)
        {
            // Create and show the CreatePlayerForm
            CreatePlayerForm createPlayer = new CreatePlayerForm();
            createPlayer.ShowDialog();
        }

        private void ViewPlayer_Click(object sender, EventArgs e)
        {
            // Create and show the ViewPlayerForm
            ViewPlayerForm viewPlayer = new ViewPlayerForm();
            viewPlayer.ShowDialog();
        }

        private void CreateMatch_Click(object sender, EventArgs e)
        {
            // Create and show the CreateMatchForm
            CreateMatchForm createMatch = new CreateMatchForm();
            createMatch.ShowDialog();
        }

        private void ExitProgram_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

