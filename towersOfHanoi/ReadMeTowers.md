## Description of the project
This project is the game Towers of Hanoi. Tell the computer to move numbers from row to row until you have all 4 numbers on the last row, in descending order. Do this without placing any larger numbers on top of any smaller numbers. 

I used a 2D list for the board. When the user enters the row, the program will find the row to place it based on the index. Then, for which spot in the row the index will adjust according to how long the list of that row is. The game is when the player wins by counting that there are 4 spots filled on the last row.

## What is the purpose
The purpose of the program is to move all the pieces from ascending order on row 1 to descending order in row 3


## How to use it
The way you use the program is by typing in the row you want to move a number out of, and then type in the number of the row that you want to place the number in. The computer will remove the piece from the first row you entered, and then add it to the second row that you entered.


## Defeciences the program has
One problem is that if you try to pull from an empty row, it will tell you the index is out of range.
Also if you enter a row number that is not 1,2, or 3, it will tell you that the index us out of range.
