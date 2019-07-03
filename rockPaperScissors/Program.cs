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


            
            
            bool playAgain = true;

            while (playAgain)
            {

                int playerOneScore = 0;
                int CPUScore = 0;

                while (playerOneScore < 3 && CPUScore < 3)
                {
                    
                    Console.WriteLine("choose: rock, paper, or scissors");
                    string playerOne = Console.ReadLine().ToLower();

                    Random num = new Random();
                    //int inputCPU = 

                    int randomInt = num.Next(1, 4);
                    
                    switch (randomInt)
                    {
                        case 1:
                            //inputCPU = "rock";
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
                            else
                            {
                                Console.WriteLine("typo");
                            }
                            break;
                        case 2:
                            //inputCPU = "paper";
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
                            else
                            {
                                Console.WriteLine("typo");
                            }
                            break;
                        case 3:
                            //inputCPU = "scissors";
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
                            else
                            {
                                Console.WriteLine("typo");
                            }
                            break;
                   
                            //else if (playerOne == "rock" || playerOne == "paper" || playerOne == "scissors")
                            {
                                Console.WriteLine("typo");

                            }
                           

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
                else if (loop == "n")
                {
                    playAgain = false;
                }
            }

            Console.ReadKey();
        }
    }
}
