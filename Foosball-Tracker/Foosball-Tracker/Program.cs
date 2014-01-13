using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Foosball_Tracker
{
    class foosballList
    {
        public void initialize()
        {
            // Creating list of matches and players
            List<player> playerList = new List<player>();
            List<match> matchList = new List<match>();
            MessageBox.Show("You just called initialize()");
        }
        public void addWin(int id)
        {
            // Adds a win for the player specified by id. Also updates winRatio of player
        }
        public void addLoss(int id)
        {
            // Adds a loss for the player specified by id. Also updates winRatio of player
        }
        public void addPlayer(player entry)
        {
            //Adds a player to the end of the list
        }
        public void addMatch(int id, int id2)
        {
            // Adds match 'id2' to player 'id' list of matches, ensuring last match remains -1 for file I/O purposes
        }
        public int getCount()
        {
            // Returns the number of entries in PlayerList using List.Count()
            return 0;
        }
        public player getPlayer(int id)
        {
            // Returns the player requested by id
            return null;
        }
    }
    public class player
    {
        int id;				                        	// Player's ID (automatically assigned @ creation)
        string name;			                        // Player's name
        int wins;			                        	// Player's total wins
        int losses;			                        	// Player's total losses
        int winRatio;			                        // Player's wins divided by total games (rounded)
        List<int> matches = new List<int>();			// A list of their matches' IDs
    }
    public class match
    {
        public int id;				                	// Match's ID (automatically assigned @ creation)
        public int playerA;				            	// The ID of the first player in the match
        public int playerB;				            	// The ID of the second player in the match
        public int scoreA;				            	// The end score of the first player
        public int scoreB;				            	// The end score of the second player
    }
    static class Program
    {

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Open up main menu form
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainMenuForm());
        }
    }
}
