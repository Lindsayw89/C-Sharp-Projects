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
            FirstBoard();

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
                
            // adding 4,3,2,1 for row 1
            for (int i = 4; i > 0; i--)
            {
                row1.Add(i);
            }
            //adding the rows
            board.Add(row1);
            board.Add(row2);
            board.Add(row3);
            //row2.Add(null);
        }
        
        public static void getUserSelection()
        {
            //initializing stack
            Stack<int> myStack = new Stack <int>();
            Console.WriteLine("which row do you want to move from?");
            int pieceFrom =Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("which row do you want to move to?");
            int pieceTo = Convert.ToInt32(Console.ReadLine());
            followRules(pieceFrom, pieceTo);
           

        }
        public static void followRules(int pieceFrom, int pieceTo)
        {// what ever we push on has to be less than the spot we put it on
            int movingToRow = pieceTo - 1;
            int movingFromRow = pieceFrom - 1;
            int movingFromIndex = board[movingFromRow].Count -1;
            int movingToIndex;
            int movingToPiece;
            int movingFromPiece = board[movingFromRow][movingFromIndex];

          
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

                if ((board[movingFromRow].Count != 0 && movingFromPiece < movingToPiece)) 
                {
                    board[movingToRow].Add(movingFromPiece);
                    board[movingFromRow].RemoveAt(movingFromIndex);
                }
             
            }
            if(movingFromPiece > movingToPiece)
            {
                Console.WriteLine("INVALID MOVE! TRY AGAIN!!");
            }

            //Console.WriteLine(movingToPiece+ "**");
            /*else if (board[movingFromRow].Count == 0)
            {
                Console.WriteLine("NOO");
            }*/

        }
        public static bool GameWin()
        {
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

            for (int i = 0; i < 3; i++)
            {
                Console.Write((i+1)+":");
                for (int j = 0; j < board[i].Count; j++)
                {
                    Console.Write(board[i][j]);
                }
                Console.WriteLine();
            }
        }
    }
}

