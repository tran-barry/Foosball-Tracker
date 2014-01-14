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
    public partial class choosePlayerForm : Form
    {
        // this needs to be accessible by both ViewPlayerForm and CreateMatchForm
        public static int id;
        public choosePlayerForm()
        {
            InitializeComponent();
            
            // Creates the dataTable that the Form will show
            DataTable table = new DataTable();
            player entry;
	        table.Columns.Add("ID", typeof(int));
	        table.Columns.Add("Name", typeof(string));
	        table.Columns.Add("Wins", typeof(int));
	        table.Columns.Add("Losses", typeof(int));
	        table.Columns.Add("Win Ratio", typeof(int));

            for(int i = 0; i < foosballList.playerCount(); i++)
            {
                entry = new player();
                entry = foosballList.getPlayer(i);
                table.Rows.Add(i, entry.name, entry.wins, entry.losses, entry.winRatio);
            }

            playerGrid.DataSource = table;
        }

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

        private void playerGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // same thing as clicking the "Select" button
            selectButton_Click(sender, e);

        }
    }
}
