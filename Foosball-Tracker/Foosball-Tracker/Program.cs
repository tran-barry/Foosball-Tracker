using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Foosball_Tracker
{
    static class foosballList
    {
        static private List<player> playerList;
        static private List<match> matchList;
        static public void initialize()
        {
            // Creating list of matches and players
            playerList = new List<player>();
            matchList = new List<match>();

            /* use the file.Exists method from namespace "System.IO" to see if
	           players.dat and matches.dat exists
		        - if false, will create these files
		        - if true, will load these values into players and matches */
            if(File.Exists("players.dat") && File.Exists("matches.dat"))
            {
                BinaryReader br;
                player entry1;
                match entry2;
                int i;

                // use binary reader to load data into playerList
                br = new BinaryReader(new FileStream("players.dat", FileMode.Open));
                while(br.BaseStream.Position != br.BaseStream.Length)
                {
                    // make sure you're working with a new 'player'
                    entry1 = new player();
                    // first load the name, then wins, then losses, then winRatio
                    entry1.name = br.ReadString();
                    entry1.wins = br.ReadInt32();
                    entry1.losses = br.ReadInt32();
                    entry1.winRatio = br.ReadInt32();
                    // then, make sure all the matches are clear before loading them
                    i = 0;
                    // then, until you see match "-1", keep loading matches to this player entry
                    while (i != -1)
                    {
                        i = br.ReadInt32();
                        entry1.matches.Add(i);
                    }
                    // now that the player record is created properly, add it to playerList
                    playerList.Add(entry1);
                }
                br.Close();

                // use binary reader to load data into matchList
                br = new BinaryReader(new FileStream("matches.dat", FileMode.Open));
                while(br.BaseStream.Position != br.BaseStream.Length)
                {
                    entry2 = new match();
                    entry2.playerA = br.ReadInt32();
                    entry2.playerB = br.ReadInt32();
                    entry2.scoreA = br.ReadInt32();
                    entry2.scoreB = br.ReadInt32();
                    matchList.Add(entry2);
                }
                br.Close();
            }
            else
            {
                BinaryWriter bw, bw1;
                if (File.Exists("players.dat"))
                {
                    MessageBox.Show("Missing matches.dat - deleting players.dat and recreating files");
                    File.Delete("players.dat");
                }
                if ( File.Exists("matches.dat"))
                {
                    MessageBox.Show("Missing players.dat - deleting matches.dat and recreating files");
                    File.Delete("matches.dat");
                }

                bw = new BinaryWriter(new FileStream("players.dat", FileMode.Create));
                bw.Close();
                bw1 = new BinaryWriter(new FileStream("matches.dat", FileMode.Create));
                bw1.Close();
                MessageBox.Show("Created new files.");
            }
        }
        static public void addWin(int id)
        {
            // Adds a win for the player specified by id. Also updates winRatio of player
            player entry = new player();
            entry = playerList[id];
            entry.wins++;
            entry.winRatio = (int)(entry.wins / (entry.wins + entry.losses) );

            // Places the updated player stats into the list, removes the old one from the list
            playerList.Insert(id, entry);
            playerList.RemoveAt(id+1);
        }
        static public void addLoss(int id)
        {
            // Adds a loss for the player specified by id. Also updates winRatio of player
            player entry = new player();
            entry = playerList[id];
            entry.losses++;
            entry.winRatio = (int)(entry.wins / (entry.wins + entry.losses) );

            // Places the updated player stats into the list, removes the old one from the list
            playerList.Insert(id, entry);
            playerList.RemoveAt(id+1);
        }
        static public void addPlayer(player entry)
        {
            //If you're adding a new player, gotta make sure the last match is "-1"
            entry.matches.Add(-1);

            //Adds a player to the end of the list
            playerList.Add(entry);
        }
        static public void addMatch(int id, int id2, match matchEntry)
        {
            // Adds match 'matchEntry' to player 'id' and 'id2' list of matches, ensuring last match remains -1 for file I/O purposes
            player entry1 = new player();
            player entry2 = new player();
            entry1 = playerList[id];
            entry2 = playerList[id2];

            // add match to the list of matches
            matchList.Add(matchEntry);

            // add match id to player entries, making sure that the last match remains at -1
            entry1.matches.Insert((entry1.matches.Count - 1), matchList.Count());
            entry2.matches.Insert((entry2.matches.Count - 1), matchList.Count());
        }
        static public void saveData()
        {
            BinaryWriter bw;
            int i, j;
            player entry1;
            match entry2;

            // delete temp1.dat and temp2.dat, if it exists
            if(File.Exists("temp1.dat"))
            {
                File.Delete("temp1.dat");
            }
            if(File.Exists("temp2.dat"))
            {
                File.Delete("temp2.dat");
            }
            // Open BinaryWriter to add playerList data into temp1.dat
            bw = new BinaryWriter(new FileStream("temp1.dat", FileMode.Create));
            entry1 = new player();
            for(i = 0; i < playerList.Count(); i++)
            {
                // load entry1 with the i'th entry in playerList
                entry1 = playerList[i];
                // write the player into the temp1.dat file
                bw.Write(entry1.name);
                bw.Write(entry1.wins);
                bw.Write(entry1.losses);
                bw.Write(entry1.winRatio);
                // gotta loop for the matches
                for(j = 0; j < entry1.matches.Count(); j++)
                {
                    bw.Write(entry1.matches[j]);
                }
            }
            bw.Close();

            // Open BinaryWriter to add matchList data into temp2.dat
            bw = new BinaryWriter(new FileStream("temp2.dat", FileMode.Create));
            entry2 = new match();
            for (i = 0; i < matchList.Count(); i++)
            {
                // load entry2 with the i'th entry in playerList
                entry2 = matchList[i];
                // write the player into the temp1.dat file
                bw.Write(entry2.playerA);
                bw.Write(entry2.playerB);
                bw.Write(entry2.scoreA);
                bw.Write(entry2.scoreB);
            }
            bw.Close();

            // Now replace players.dat with temp1.dat and matches.dat with temp2.dat
            File.Copy("temp1.dat", "players.dat", true);
            File.Copy("temp2.dat", "matches.dat", true);
        }
        static public void clearData()
        {
            playerList.Clear();
            matchList.Clear();
            foosballList.saveData();
        }
        static public player getPlayer(int id)
        {
            return playerList[id];
        }
        static public int playerCount()
        {
            return playerList.Count();
        }
        static public match getMatch(int id)
        {
            return matchList[id];
        }
        static public int matchCount()
        {
            return matchList.Count();
        }
        static public int playerMatchCount(int id)
        {
            return playerList[id].matches.Count();
        }
    }
    public class player
    {
        public string name;			                        // Player's name
        public int wins;			                        // Player's total wins
        public int losses;			                        // Player's total losses
        public int winRatio;			                    // Player's wins divided by total games (rounded)
        public List<int> matches = new List<int>();			// A list of their matches' IDs
    }
    public class match
    {
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
            // initiate data structures
            foosballList.initialize();

            // Open up main menu form
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainMenuForm());
        }
    }
}
