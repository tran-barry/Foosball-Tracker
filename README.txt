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

Internally, players will be stored in an ArrayList of player records. Each
player will have the following structure:
	int id					Player's ID (automatically assigned @ creation)
	string name				Player's name
	int wins					Player's total wins
	int losses				Player's total losses
	float winRatio			Player's wins divided by total games (1 decimal)
	ArrayList matches		A list of their matches' IDs
For file input/output purposes, the last match in 'matches' will always be -1.

Each match will be stored in an ArrayList. They will have this structure:
	int id					Match's ID (automatically assigned @ creation)
	int playerA				The ID of the first player in the match
	int playerB				The ID of the second player in the match
	int scoreA				The end score of the first player
	int scoreB				The end score of the second player

Externally, this information will be stored in a .dat file that isn't encoded.
We will have 2 .dat files - players.dat and matches.dat. Each record will be
one line of entry in the .dat files. In the case of players.dat, the last entry
in each line will be -1, to indicate the end of their list of matches.
-------------------------------------------------------------------------------
PROGRAM FLOW

At the application start, it will first initialize. At first, it will look for
the .dat files, and create new ones if they can't be found. After, it will
create the ArrayList for players and matches, loading the data from the files
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