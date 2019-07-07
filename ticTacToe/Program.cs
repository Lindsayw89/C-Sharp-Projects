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

            } while (!HorizontalWin() && !VerticalWin() && !CheckForTie() && !DiagonalWin());

            DrawBoard();
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
            if (HorizontalWin() == true || VerticalWin() == true || DiagonalWin() == true)
            {
                Console.WriteLine("WINNER!!!!!!!!!!");
            }

            else if (CheckForTie() == true)
            {
                Console.WriteLine("NO WINNER!!!!!!!");
            }

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

        public static bool CheckForTie()
        {
            bool tie1 = true;
            for (int i = 1; i <  3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (board[i][j] == " ")
                    {
                        tie1 = false;
                    }
                }
            }
            return tie1;
        }

        public static bool HorizontalWin()
        {
            bool winner = false;
            for (int i = 0; i < 3; i++)
            {
                //checks horizontal first, then vertical, example: if horizontal match AND none are blank, then winner
                if ((board[i][0] == board[i][1] && board[i][0] == board[i][2]) && (board[i][0] != " "))
                {
                    winner = true;
                }
            }

            return winner;
        }



        public static bool VerticalWin()
        {
            bool winner = false;
            for (int i = 0; i < 3; i++)
            {
                //checks vertical, AND none are blank, then winner
                if ((board[0][i] == board[1][i] && board[0][i] == board[2][i]) && (board[0][i] != " "))
                {
                    winner = true;
                }

            }
            return winner;
        }

            public static bool DiagonalWin()
            {
                bool winner = false;
                if (((board[0][0] == board[1][1] && board[0][0] == board[2][2]) && (board[0][0] != " ")) ||
                        ((board[2][0] == board[1][1] && board[2][0] == board[0][2]) && (board[2][0] != " ")))
                {
                    winner = true;
                }
                return winner;
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
    



    

