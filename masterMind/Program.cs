using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace masterMind
{
    class Program
    {
        static void Main(string[] args)
        {
           /*  do
            {
                DrawBoard();
                GetInput();

            } while (!HorizontalWin() && !VerticalWin() && !CheckForTie() && !DiagonalWin());
            */ //exaple from tic tac toe






            Random rnd = new Random();

            int colorRandom1 = rnd.Next(1, 4);
            int colorRandom2 = rnd.Next(1, 4);

           
            Console.WriteLine(" I am thinking of 2 random colors");
             Console.WriteLine("your color choices are red, yellow, & blue");
            Console.WriteLine("Enter your first color");
            string colorChoice1 = Console.ReadLine().ToLower();
            Console.WriteLine("enter your next color guess");
            string colorChoice2 = Console.ReadLine().ToLower();

            
                int colorA = 0;
                int colorB = 0;


                //first color
                if (colorChoice1 == "red")
                {
                    colorA = 1;
                }
                else if (colorChoice1 == "yellow")
                {
                    colorA = 2;
                }
                else if (colorChoice1 == "blue")
                {
                    colorA = 3;
                }


                //second color
                if (colorChoice2 == "red")
                {
                    colorB = 1;
                }
                else if (colorChoice2 == "yellow")
                {
                    colorB = 2;
                }
                else if (colorChoice2 == "blue")
                {
                    colorB = 3;
                }


                if (colorRandom1 == colorA && colorRandom2 == colorB)
                {
                    Console.WriteLine("you won!");
                }
                else if (colorRandom1 != colorA && colorRandom2 != colorB)
                {
                    Console.WriteLine("clue 0-0");
                }
                else if (colorRandom1 == colorB || colorRandom2 == colorA)
                {
                    Console.WriteLine("clue 1-0");
                }
                else if (colorRandom1 == colorA && colorRandom2 != colorB || colorRandom1 != colorA && colorRandom2 == colorB)
                {
                    Console.WriteLine("clue 1-1");
                } else if (colorRandom1 == colorB && colorRandom1 == colorA)
                {
                    Console.WriteLine("clue 2-0");
                }

           


            Console.WriteLine(colorA);
            Console.WriteLine(colorB);
            Console.WriteLine(colorRandom1);
            Console.WriteLine(colorRandom2);
            Console.ReadKey();


        }
    }
}
