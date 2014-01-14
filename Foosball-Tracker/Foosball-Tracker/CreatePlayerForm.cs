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
    public partial class CreatePlayerForm : Form
    {
        public CreatePlayerForm()
        {
            InitializeComponent();
        }
        private void CreatePlayerForm_Load(object sender, EventArgs e)
        {
            nameBox.Text = "Enter name here";
            nameBox.Select();
        }
        private void SaveButton_Click(object sender, EventArgs e)
        {
            player entry = new player();
            entry.name = nameBox.Text;
            entry.wins = 0;
            entry.losses = 0;
            entry.winRatio = 0;
            foosballList.addPlayer(entry);
            foosballList.saveData();
            this.Close();
        }
    }
}
