using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace towersOfHanoi
{
    class Program
    {
        private static List<List<int>> board = new List<List<int>>();
        public static List<List<int>> Board { get => board; set => board = value; }

        static void Main(string[] args)
        {
            // the program draws how we want the board to initially look
            FirstBoard();

            //then it goes through the loop of drawing the board & getting input ,while the user has not won
            do {
                DrawBoard();
                getUserSelection();

            } while(!GameWin());

            Console.ReadKey();
        }
        
        public static void FirstBoard()
            //setting up information for the game to print
        {   //declaring row that will be used
            List<int> row1 = new List<int>(4);
            List<int> row2 = new List<int>(4);
            List<int> row3 = new List<int>(4);
                
            // adding 4,3,2,1 for row 1 in ascending order
            for (int i = 4; i > 0; i--)
            {
                row1.Add(i);
            }
            //adding the rows to the list
            board.Add(row1);
            board.Add(row2);
            board.Add(row3);
           
        }
        
        public static void getUserSelection()
        {
            

            // asking the user to enter the row number to take and row to place to
            Console.WriteLine("which row do you want to move from?");

            //system reading the user's answer to know where to move the pieces
            int pieceFrom =Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("which row do you want to move to? 1 ,2, or 3?");
            int pieceTo = Convert.ToInt32(Console.ReadLine());

            followRules(pieceFrom, pieceTo);
           
        }
        public static void followRules(int pieceFrom, int pieceTo)
        {
           
            // the row entered by user will be 1, 2, or 3. the index is one spot less than that
            int movingToRow = pieceTo - 1;
            int movingFromRow = pieceFrom - 1;

            // moving from and to index variables tell how far horizontally to place the piece
            int movingFromIndex = board[movingFromRow].Count -1;
            int movingToIndex;
            int movingToPiece;
            int movingFromPiece = board[movingFromRow][movingFromIndex]; //

          //if the the user is moving the piece to a row with no pieces, then it will add it to the first place(index zero)
          // and remove it from where it got the piece from
            if (board[movingToRow].Count==0)
            {
                movingToIndex = 0;
                board[movingToRow].Add(movingFromPiece);
                movingToPiece = board[movingToRow][movingToIndex];
                board[movingFromRow].RemoveAt(movingFromIndex);
              

            }
            else
            {
                movingToIndex = board[movingToRow].Count;
                movingToPiece = board[movingToRow][movingToIndex-1];
                // as long as row that we are grabbing a piece from is not empty and the number we are putting on is bigger
                //then we add our piece to that selected row and remove from 'remove place'
                if ((board[movingFromRow].Count != 0 && movingFromPiece < movingToPiece)) 
                {
                    board[movingToRow].Add(movingFromPiece);
                    board[movingFromRow].RemoveAt(movingFromIndex);
                }
             
            }
            // if the piece they are putting on top is bigger, then it won't let you do that
            if(movingFromPiece > movingToPiece)
            {
                Console.WriteLine("INVALID MOVE! TRY AGAIN!!");
            }

          
        }
        public static bool GameWin()
        {
            // once index row 2 on the board has all 4 pieces, the user has won the game
            if(board[2].Count == 4)
            {
                Console.WriteLine("You Won!");
               return true;
            }
            else
            {
                return false;
            }
        }
        
        public static void DrawBoard()
        {
            // outerloop is writing the numbers for the row labels
            for (int i = 0; i < 3; i++)
            {
                Console.Write((i+1)+":");
                //nested loop is writing the numbers for movable pieces, depending on how many are in that row
                for (int j = 0; j < board[i].Count; j++)
                {
                    Console.Write(board[i][j]);
                }
                Console.WriteLine();
            }
        }
    }
}

