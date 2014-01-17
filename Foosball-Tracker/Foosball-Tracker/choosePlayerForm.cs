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
    // This form is brought up by the viewPlayerForm automatically. It puts all the
    // player data into a table for the user to go through. Because we use dataGridView,
    // it will automatically implement the sorting function
    //
    public partial class choosePlayerForm : Form
    {
        //
        // this needs to be accessible by ViewPlayerForm
        //
        public static int id;
        //
        // Initializes the form. It also handles creating the data for the table
        // and putting it into the dataGridView. Keep in mind that the player 'id' is
        // the order that the player is created in
        //
        public choosePlayerForm()
        {
            InitializeComponent();
            
            // Creates the data table that the Form will show and sets the column titles
            DataTable table = new DataTable();
            player entry;
	        table.Columns.Add("ID", typeof(int));
	        table.Columns.Add("Name", typeof(string));
	        table.Columns.Add("Wins", typeof(int));
	        table.Columns.Add("Losses", typeof(int));
	        table.Columns.Add("Win Ratio", typeof(int));

            // add each player 1 by 1 to the data table
            for(int i = 0; i < foosballList.playerCount(); i++)
            {
                entry = new player();
                entry = foosballList.getPlayer(i);
                table.Rows.Add(i, entry.name, entry.wins, entry.losses, entry.winRatio);
            }

            // sets the grid to show whatever's in the table
            playerGrid.DataSource = table;
        }
        //
        // Finds out which entry the user selected, and saves it in the 'id' variable above.
        // This variable is accessible by viewPlayerForm
        //
        private void selectButton_Click(object sender, EventArgs e)
        {
            // First, find out which row you're on
            int i = playerGrid.CurrentRow.Index;

            // now, using that row, find out what value is in the first cell, which will be the id
            DataGridViewRow selectedRow = playerGrid.Rows[i];

            // this variable is accessible from other forms
            choosePlayerForm.id = Convert.ToInt32(selectedRow.Cells[0].Value);
            this.Close();
        }
        //
        // if the user decides to double click a row instead, it'll take the same action
        // as pressing the 'select' button
        //
        private void playerGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // same thing as clicking the "Select" button
            selectButton_Click(sender, e);
        }
    }
}
