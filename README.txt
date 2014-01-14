Barry Tran
Created January 10th, 2014
*******************************************************************************
BARRY'S FOOSBALL TRACKER
*******************************************************************************
VERSION HISTORY

2013/01/14	V1.0 - Initial prototype of foosball tracker
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

Player and Match "id" will be based on its position in playerList
and matchList.

Internally, players and matches will be stored in a class foosballList:
	List playerList					A list of 'player' data
	List matchList					A list of 'match' data
With the following functions:
	void initialize()				Creates internal data and creates/loads
									necessary files
	void addWin(int id)				Adds a win for the player specified by id.
									Also updates the winRatio of player
	void addLoss(int id)			Adds a loss for the player specified by id.
									Also updates the winRatio of player
	void addPlayer(player entry)	Adds a player to the end of the list. Makes
									sure to also add match "-1" for file I/O
									purposes
	void addMatch(match entry)		Adds match 'entry' to the players that were
									in this match, ensuring the last match is
									"-1" for file I/O purposes. Also determines
									who won and lost based on match record, and
									updates accordingly.
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
	int getPlayerMatch(int player, int id)
									Returns the player's "id"th match (ie if
									the second match player 5 participated in
									was match #9, calling getPlayerMatch(5, 2)
									will return 9)

Each player will have the following structure:
	string name				Player's name
	int wins				Player's total wins
	int losses				Player's total losses
	int winRatio			Player's wins divided by total games (rounded)
	List matches			A list of their matches' IDs

Each match will be stored in an	List. They will have this structure:
	int playerA				The ID of the first player in the match
	int playerB				The ID of the second player in the match
	int scoreA				The end score of the first player
	int scoreB				The end score of the second player

Externally, this information will be stored in a .dat file. We will have 2 .dat
files - players.dat and matches.dat. In the case of players.dat, the last entry
for a player will be -1, to indicate the end of their list of matches.
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
	Clear Data				Allows user to wipe all the current records
	Exit					Exits the program
With the exception of 'Exit', each option will bring the user back to the menu
at the end. Also, 'View Player' will be disabled if there isn't at least one
player in the player list. Create Match will also be disabled if there isn't at
least two players in the player list.

Creating a player will get the name of the new player from the user. It will 
create a new record with all their statistics set to 0. It will then add the
entry to the end of playerList, and update the files to match these records.

Viewing a player will have the user choose a player from the list of players
available. In this area, the user will also be able to sort user by any of the
statistics we keep track of (id, name, wins, losses, winRatio). Once they
choose a player, it will display their statistics as well as a list of the
matches they have been in (by match id). Here, the player may click on a match
or choose to go back to the main menu. Double-clicking on a match id will bring
the user to the match record, where it will display the players in the matches
as well as the final score. It will then bring the user back to the player's
statistics.

Creating a match will bring up a form where the user can choose which players
participated as well as their scores. If the user selected the same player, one
of the scores isn't 10, or if it's a tie (which is physically impossible in
foosball), it'll prompt the user to enter a valid value. If all the values are
valid, it will create the match and ensure both player records have it in their
match history. It'll also calculate who won/loss, and update the player's win
ratios.

Clearing data will prompt the user with a dialog box asking if they're sure. If
they hit yes, then all the data stored on the computer will be cleared.
-------------------------------------------------------------------------------
FUNCTION IMPLEMENTATION
-------------------------------------------------------------------------------
static void Main()
	- First, it'll initialize the program
		- create PlayerList players and List matches using namespace
		  "System.Collections"
		- use the file.Exists method from namespace "System.IO" to see if
		  players.dat and matches.dat exists
			- if one or more of these files are missing, it'll delete any
			  leftover files and make new ones
			- if true, will load these values into players and matches

mainMenuForm
	- displays a form where the user can choose between "Create Player", "View
	  Player", "Create Match", "Clear Data", and "Exit"
	- Clicking on any button will bring up a new form based on what the user
	  wants to do.
	- If there isn't at least already one player created in records, "View
	  Player" will be disabled
	- If there isn't at least two players created in records, "Create Match"
	  will be disabled
	- "Exit" will exit the program. Any other command will let the user
	  take more actions after they're done the current action

createPlayerForm
	- displays a form where the user can enter in a name as a string
	- will create new player data with wins, losses, and winRatio set to 0
	- it will use class function addPlayer(player entry) to add this entry to
	  the PlayerList
	- it will use saveData() to save the changes, then close the form,
	  allowing the user to go back to main menu

viewPlayerForm
	- First, it will open up choosePlayerForm, and wait for a selection
		- if the user closes choosePlayerForm without making a selection, this
		  form will also close
	- it will then display this player's statistics in a form as well as a list
	  of their matches
		- if the user has no matches, it'll say so as well as disable the "view
		  match" button
	- double-clicking on a match will disable this form and show a new form
	  with the statistics of the match
		- the user will be able to close this form to go back to viewPlayerForm
	- the user can close this form to bring them back to the main menu

createMatchForm
	- It will bring up a form where the user can choose values for players and
	  scores
		- User cannot choose the same players
		- User cannot have a tie in score
		- One of the scores must be 10
	- It will then create the match in the records using addMatch(match)
	- Then, it will use saveData() to save the changes, then close the form,
	  allowing the user to go back to main menu

choosePlayerForm
	- It will load all the entries already in playerList using dataGridView
	- Because we're using dataGridView, you can already sort the data in the
	  table
	- double clicking an entry or selecting OK will save the id where
	  viewPlayerForm can access it
	- if the user closes the form without making a selection, then
	  viewPlayerForm will also close

foosballList.saveData()
	- First, this function will create a file temp1.dat, which will record
	  everything in PlayerList players (using File.Create())
	- Next, it will create a file temp2.dat, which will record all the matches
	  in List matches (using File.Create())
	- it will then replace players.dat with temp1.dat using File.Replace()
	- it will also replace matches.dat with temp2.dat using File.Replace()
	- it will then delete the temp files using File.Delete()