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
    // A form that allows the user to create a new player entry. All it asks for is a name.
    // The name can even be "null"
    //
    public partial class CreatePlayerForm : Form
    {
        //
        // Starts the form
        //
        public CreatePlayerForm()
        {
            InitializeComponent();
        }
        //
        // Autofills the text box, as well as makes sure it's highlighted for easy overwriting
        //
        private void CreatePlayerForm_Load(object sender, EventArgs e)
        {
            nameBox.Text = "Enter name here";
            nameBox.Select();
        }
        //
        // If the user hits "save" (or presses return - the button is set up as the default "return" button),
        // it will first set all their values to 0 (wins, losses, and winRatio), then add the player to
        // the list
        //
        private void SaveButton_Click(object sender, EventArgs e)
        {
            player entry = new player();

            // sets the name as whatever's in the text
            entry.name = nameBox.Text;
            // set everything else to 0. matches will remain null for now
            entry.wins = 0;
            entry.losses = 0;
            entry.winRatio = 0;
            // and add and save
            foosballList.addPlayer(entry);
            foosballList.saveData();
            // close the form after
            this.Close();
        }
    }
}
