https://github.com/TelerikAcademy/Data-Structures-and-Algorithms/blob/master/Exams/2017-January/Day-1/1.%20Player%20ranking/README.md


Player ranking
Description
You are implementing a player ranking system. Each player has a name, type, age and current position. The ranking system should be able to add new players, find all players of certain type and get the ranking in some range (start and end positions).

You are given a sequence of commands that must be implemented:

add PLAYER_NAME PLAYER_TYPE PLAYER_AGE PLAYER_POSITION - adds new player to the rank list
PLAYER_NAME can be any sequence from 1 to 20 characters and may not be unique
PLAYER_TYPE can be any sequence from 1 to 10 characters and may not be unique
PLAYER_AGE can be any integer between 10 and 50
PLAYER_POSITION can be any integer between 1 and the current players count plus one (e.g. if the ranking system already has 2 players, PLAYER_POSITION can be 1, 2 or 3). If a player is inserted to an already used position, all players' positions from this position till the end are incremented by one (e.g. if the ranking system has Player1 in poistion 1, Player2 in position 2 and is inserting Player3 in position 1 => Player1 goes to position 2 and Player2 goes to position 3).
Print "Added player PLAYER_NAME to position PLAYER_POSITION"
find PLAYER_TYPE - finds the top 5 units, first ordered by name in ascending order and then by age in descending order
Print the results in the following format "Type PLAYER_TYPE: PLAYER; PLAYER; PLAYER" where PLAYER should be printed in the format "PLAYER_NAME(PLAYER_AGE)". If no players are found just print "Type PLAYER_TYPE: " (ending with one space).
ranklist START END - prints the rank list from START to END positions
START can be any integer between 1 and current players count.
END can be any integer between 1 and current players count (and will be greater than or equal to START).
end - marks the end of the commands and no other commands will follow afterwards.
Input
Input is read from the console
The input consists of a sequence of commands, each at a separate line, ending by the command "end". The commands will be valid (as described in the above list), in the specified format, within the constraints given below. There is no need to check the input data explicitly.
Output
Output should be printed on the console
For each command from the input sequence print at the standard output its results as a single line.