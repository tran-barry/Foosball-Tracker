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
            
        }

        private void CreatePlayer_Click(object sender, EventArgs e)
        {
            // Create and show the CreatePlayerForm
            CreatePlayerForm createPlayer = new CreatePlayerForm();
            createPlayer.ShowDialog();

            // create new player
            player dummyPlayer = new player();
            dummyPlayer.name = "Barry";
            dummyPlayer.wins = 10;
            dummyPlayer.losses = 0;
            dummyPlayer.winRatio = 100;
            dummyPlayer.matches.Add(0);
            dummyPlayer.matches.Add(1);
            dummyPlayer.matches.Add(3);
            dummyPlayer.matches.Add(17);

            foosballList.addPlayer(dummyPlayer);
            MessageBox.Show("added dummy player");

            foosballList.saveData();
        }

        private void ViewPlayer_Click(object sender, EventArgs e)
        {
            // Create and show the ViewPlayerForm
            ViewPlayerForm viewPlayer = new ViewPlayerForm();
            viewPlayer.ShowDialog();

            player dummyPlayer = new player();
            string myStr;
            for (int i = 0; i < foosballList.playerCount(); i++)
            {
                dummyPlayer = foosballList.getPlayer(i);
                myStr = dummyPlayer.name;
                myStr = myStr + " wins: " + dummyPlayer.wins.ToString();
                myStr = myStr + " losses: " + dummyPlayer.losses.ToString();
                myStr = myStr + " winRatio: " + dummyPlayer.winRatio.ToString();
                for (int j = 0; j < dummyPlayer.matches.Count() - 1; j++)
                {
                    myStr = myStr + "\nmatch: " + j.ToString() + ": " + dummyPlayer.matches[j];
                }
                MessageBox.Show(myStr);
            }
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

