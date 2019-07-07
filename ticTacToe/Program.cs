using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class Program
    {
        public static string playerTurn = "X";
        public static string[][] board = new string[][]
        {
            new string[] {" ", " ", " "},
            new string[] {" ", " ", " "},
            new string[] {" ", " ", " "}
        };

        static void Main(string[] args)
        {


            do
            {
                DrawBoard();
                GetInput();

            } while (!CheckForWin() && !CheckForTie());

            // leave this command at the end so your program does not close automatically
            Console.ReadLine();
        }

        public static void GetInput()
        {
            Console.WriteLine("Player " + playerTurn);
            Console.WriteLine("Enter Row:");
            int player_row = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Column:");
            int player_column = int.Parse(Console.ReadLine());
            PlaceMark(player_row, player_column);
        }

        public static void PlaceMark(int row, int column)
        {
            //checks to make sure correctly entered
            Console.WriteLine(row + "," + column);

            board[row][column] = playerTurn;

            //check for win code here, ideally call a function

            ChangePlayer();
        }

        public static void ChangePlayer()
        {
            if (playerTurn == "X")
            {
                playerTurn = "O";
            }
            else
            {
                playerTurn = "X";
            }

        }

        public static bool CheckForWin()
        {
            // your code goes here

            return false;
        }

        public static bool CheckForTie()
        {
            // your code goes here

            return false;
        }

        public static bool HorizontalWin()
        {
            //repeat of int
            int row = int.Parse(Console.ReadLine());
            int column = int.Parse(Console.ReadLine());
            if (row == 0 && column == 0 && column == 1 && column == 2)
            {
                Console.WriteLine("X is the winner!");
            }
            else if (row == 1 && column == 0 && column == 1 && column == 2)
            {
                Console.WriteLine("X is the winner!");
            }
            else if (row == 2 && column == 0 && column == 1 && column == 2)
            {
                Console.WriteLine("X is the winner!");
            }


            //is not applying to my code
            return false;
        }

        public static bool VerticalWin()
        {
            //repeating code
            int row = int.Parse(Console.ReadLine());
            int column = int.Parse(Console.ReadLine());
            if (column == 0 && row == 0 && row == 1 && row == 2)
            {
                Console.WriteLine("X is the winner!");
            }
            else if (column == 1 && row == 0 && row == 1 && row == 2)
            {
                Console.WriteLine("X is the winner!");
            }
            else if (column == 2 && row == 0 && row == 1 && row == 2)
            {
                Console.WriteLine("X is the winner!");
            }

            //not applying to my code
            return false;
        }

        public static bool DiagonalWin()
        {
            //repeating code
            int row = int.Parse(Console.ReadLine());
            int column = int.Parse(Console.ReadLine());
            if (column == 0 && column == 1 && column == 2 && row == 0 && row == 1 && row == 2)
            {
                Console.WriteLine("X is the winner!");
            }
            else if (row == 0 && row == 1 && row == 2 && column == 0 && column == 1 && column == 2)
            {
                Console.WriteLine("X is the winner!");
            }

            //not applying to code
            return false;
        }

        public static void DrawBoard()
        {
            Console.WriteLine("  0 1 2");
            Console.WriteLine("0 " + String.Join("|", board[0]));
            Console.WriteLine("  -----");
            Console.WriteLine("1 " + String.Join("|", board[1]));
            Console.WriteLine("  -----");
            Console.WriteLine("2 " + String.Join("|", board[2]));
        }

    }

    
}
