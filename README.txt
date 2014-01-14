Barry Tran
Created January 10th, 2014
*******************************************************************************
BARRY'S FOOSBALL TRACKER
*******************************************************************************
VERSION HISTORY

2013/01/10	V1.0 - Initial prototype of foosball tracker
-------------------------------------------------------------------------------
DESCRIPTION

Around the office we play foosball, but we don’t have any ways to know who is
the best.  This is a simple application that takes the outcome of games to
create a leaderboard.  These will only be head to head games (one player per
team).
 
In this application, you can enter the 2 players, and the resulting winner and
loser. We can also display a players Win/Loss record, and sort by win percent.
 
At the base, you should be able to:
	- Create a Player record
	- Create a Match Record (which players played, and what was the result)
	- Search players and see their match history
	- Have persistent storage – so the application shouldn’t reset each time you
      close it

This application will be done in C#.
-------------------------------------------------------------------------------
DATA IMPLEMENTATION

Internally, players and matches will be stored in a class foosballList:
	List playerList					A list of 'player' data
	List matchList					A list of 'match' data
With the following functions:
	void initialize()				Creates internal data and creates/loads
									necessary files
	void addWin(int id)				Adds a win for the player specified by id.
									Also updates winRatio of player
	void addLoss(int id)			Adds a loss for the player specified by id.
									Also updates winRatio of player
	void addPlayer(player entry)	Adds a player to the end of the list
	void addMatch(int id, int id2, match entry)	
									Adds match 'entry' to player 'id' and 'id2'
									list of matches, ensuring last match
									remains -1 for file I/O purposes
	void saveData()					Updates players.dat and matches.dat with
									what's in playerList and matchList
	void clearData()				Deletes all current entries in playerList
									and matchList
	player getPlayer(int id)		Returns the player at location id
	int playerCount()				Returns number of players in file
	match getMatch(int id)			Returns the match at location id
	int matchCount()				Returns the number of matches in file
	int playerMatchCount(int id)	Returns the number of matches player 'id'
									has

Each player will have the following structure:
	int id					Player's ID (automatically assigned @ creation)
	string name				Player's name
	int wins				Player's total wins
	int losses				Player's total losses
	int winRatio			Player's wins divided by total games (rounded)
	List matches			A list of their matches' IDs

Each match will be stored in an	List. They will have this structure:
	int id					Match's ID (automatically assigned @ creation)
	int playerA				The ID of the first player in the match
	int playerB				The ID of the second player in the match
	int scoreA				The end score of the first player
	int scoreB				The end score of the second player

Externally, this information will be stored in a .dat file. We will have 2 .dat
files - players.dat and matches.dat. Each record will be one line of entry in
the .dat files. In the case of players.dat, the last entry in each line will be
-1, to indicate the end of their list of matches.
-------------------------------------------------------------------------------
PROGRAM FLOW

At the application start, it will first initialize. At first, it will look for
the .dat files, and create new ones if they can't be found. After, it will
create the List for players and matches, loading the data from the files
if there is data there. From there, it will go into the main menu.

At the main menu, there will be four options:
	Create Player			Allows user to add a new player to the application
	View Player				Allows user to view a player's matches
	Create Match			Allows user to add a new match to the application
	Exit					Exits the program
With the exception of 'Exit', each option will bring the user back to the menu
at the end. Also, 'View Player' will be disabled if there isn't at least one
player in the player list. Create Match will also be disabled if there isn't at
least two players in the player list.

Creating a player will get the name of the new player from the user. After, it
will generate an ID for the player (first registered player will have id 0,
second registered player will have id 1, ... nth registerd player will have id
n-1) and set all their statistics to 0. It will then add the entry to the end
of players.dat and bring the user back to the main menu.

Viewing a player will have the user choose a player from the list of players
available. In this area, the user will also be able to sort user by any of the
statistics we keep track of (id, name, wins, losses, winRatio). Once they
choose a player, it will display their statistics as well as a list of the
matches they have been in (by match id). Here, the player may click on a match
or choose to go back to the main menu. Clicking on a match id will bring the
user to the match record, where it will display the players in the matches as
well as the final score. It will then bring the user back to the player's
statistics.

Creating a match will first have the user choose player A and then player B
from the list of players available. If playerA == playerB, then it will ask the
user to choose a different playerB. It will then ask for playerA's score and
playerB's score. It will then determine who won based on the score. It will
then create the match, append it to the end of matches.dat, and update
players.dat with this information. To do this, it will create a temp.dat, copy
each line from players.dat into temp.dat except for the two players with
updated records (it will put their new record in). After, it will delete 
players.dat and rename temp.dat as players.dat. Once this is done, it will take
the user back to the main menu.
-------------------------------------------------------------------------------
FUNCTION IMPLEMENTATION
-------------------------------------------------------------------------------
public void initialize()
	- create PlayerList players and List matches using namespace
	  "System.Collections"
	- use the file.Exists method from namespace "System.IO" to see if
	  players.dat and matches.dat exists
		- if false, will create these files
		- if true, will load these values into players and matches

static void Main(string[] args)
	- calls upon initialize() at start of program
	- every time the form loads, it will call upon saveData()
	- displays a form where the user can choose between "Create Player", "View
	  Player", "Create Match", and "Exit"
	- Clicking on any button will close the menu form calls upon the function
	  that the user requested, except for "Exit", which will close the program
	- Once the task is completed, it will loop back to where the menu form was
	  viewable by the user.

public void createPlayer()
	- displays a form where the user can enter in a name as a string
	- will create new player data with wins, losses, and winRatio set to 0
	- player.matches will be empty
	- it will use class function addPlayer(player entry) to add this entry to
	  the PlayerList
	- it will then close the form, allowing the user to go back to main menu

public void viewPlayer()
	- First, it will call upon choosePlayer(), where it will return a player
	  for this function to work with
	- it will then display this player's statistics in a form as well as a list
	  of their matches
	- clicking on a match will disable this form and show a new form with the
	  statistics of the match
		- the user will be able to close this form to re-enable the first form
	- the user can close this form to bring them back to the main menu

public void createMatch()
	- First, it will call upon choosePlayer(), and store this in player playerA
	- It'll call upon choosePlayer() again, storing this in player playerB
		- if playerA == playerB, it'll say "can't choose same player" and bring
		  the user back to the main menu
	- It'll then ask for int Ascore and int Bscore
		- if Ascore == Bscore, or if either score is negative, it'll say
		  "impossible in a foosball game" and bring the user back to the main
		  menu
	- It'll compare the two values to determine who won and who loss
		- the winning player will use its id in PlayerList.addWin()
		- the losing player will use its id in PlayerList.addLoss()
	- It'll find the match id using List.Count()
	- It'll create a new match type data structure and add it to the end of
	  matches using List.Add()'
	- Lastly, it'll call upon PlayerList.addMatch() to add the match to both
	  players that was chosen

public player choosePlayer()
	- First, it'll create 7 new 1-dimensional arrays with size of 
	  PlayerList.getCount(), called ids, names, wins, losses, winRatio, temp1,
	  and temp2
	- starting with id, it'll list all of the information in the arrays except
	  for temp1 and temp2
	- clicking on the header of a column will copy that array into temp1 and
	  temp2
		- it'll then call upon Array.Sort(temp1, x) where x is the other arrays
		- once it has sorted x, it'll copy temp2 back into temp 1, so that it 
		  can repeat the process for the other arrays
		- Once all five arrays have been sorted, it will then re-display the
		  information in the arrays
	- user will be able to select an entry, and upon pressing OK, this function
	  will return to the original function that called it.

public void saveData()
	- First, this function will create a file temp1.dat, which will record
	  everything in PlayerList players (using File.Create())
	- Next, it will create a file temp2.dat, which will record all the matches
	  in List matches (using File.Create())
	- it will then replace players.dat with temp1.dat using File.Replace()
	- it will also replace matches.dat with temp2.dat using File.Replace()
	- it will then delete the temp files using File.Delete()