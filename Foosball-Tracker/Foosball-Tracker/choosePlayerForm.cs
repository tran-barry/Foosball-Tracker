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
            // First, fine out which row you're on
            int i = playerGrid.CurrentRow.Index;

            // now, using that row, find out what value is in the first cell, which will be the id
            DataGridViewRow selectedRow = playerGrid.Rows[i];
            ViewPlayerForm.id = Convert.ToInt32(selectedRow.Cells[0].Value);

            string myStr = "You chose player ID: " + Convert.ToString(selectedRow.Cells[0].Value);
            MessageBox.Show(myStr);
            this.Close();
        }
    }
}
