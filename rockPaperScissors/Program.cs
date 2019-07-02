using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {





            string inputCPU;
            int playerOneScore = 0;
            int CPUScore = 0;
            bool playAgain = true;

            while (playAgain)
            {
                while (playerOneScore < 3 && CPUScore < 3)
                {

                    Console.WriteLine("choose: rock, paper, or scissors");
                    string playerOne = Console.ReadLine();

                    Random rnd = new Random();

                    int randomInt = rnd.Next(1, 4);

                    switch (randomInt)
                    {
                        case 1:
                            inputCPU = "rock";
                            Console.WriteLine("Computer chose Rock");
                            if (playerOne == "rock")
                            {
                                Console.WriteLine("Draw!");
                            }
                            else if (playerOne == "paper")
                            {
                                Console.WriteLine("You Win!");
                                playerOneScore++;
                                Console.WriteLine("YOUR SCORE: " + playerOneScore);

                            }
                            else if (playerOne == "scissors")
                            {
                                Console.WriteLine("You lose!");
                                CPUScore++;
                                Console.WriteLine("COMPUTER SCORE: " + CPUScore);
                            }
                            break;
                        case 2:
                            inputCPU = "paper";
                            Console.WriteLine("Computer chose paper");
                            if (playerOne == "rock")
                            {
                                Console.WriteLine("you lose!");
                                CPUScore++;
                                Console.WriteLine("COMPUTER SCORE: " + CPUScore);
                            }
                            else if (playerOne == "paper")
                            {
                                Console.WriteLine("Draw!");
                            }
                            else if (playerOne == "scissors")
                            {
                                Console.WriteLine("You win!");
                                playerOneScore++;
                                Console.WriteLine("YOUR SCORE: " + playerOneScore);
                            }
                            break;
                        case 3:
                            inputCPU = "scissors";
                            Console.WriteLine("Computer chose scissors");
                            if (playerOne == "rock")
                            {
                                Console.WriteLine("you win!");
                                playerOneScore++;
                                Console.WriteLine("YOUR SCORE: " + playerOneScore);
                            }
                            else if (playerOne == "paper")
                            {
                                Console.WriteLine("You lose!");
                                CPUScore++;
                                Console.WriteLine("COMPUTER SCORE: " + CPUScore);
                            }
                            else if (playerOne == "scissors")
                            {
                                Console.WriteLine("Draw!");
                            }
                            break;
                        default:
                            {
                                Console.WriteLine("you made a typo, try again");
                            }
                            break;

                    }

                }
                Console.ReadKey();
                if (playerOneScore == 3)
                {
                    Console.WriteLine("you won the game!!!!!!");
                }
                else if (CPUScore == 3)
                {
                    Console.WriteLine("You lost this game!!");
                }

                Console.WriteLine("do you want to play again? y/n");
                string loop = Console.ReadLine();
                if (loop == "y")
                {
                    playAgain = true;
                }
                else if (loop == "n") ;
                {
                    playAgain = false;
                }
            }

            Console.ReadKey();
        }
    }
}
