using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class201Csharp
{
     public class Program
    {
        public static void Main(string[] args)
        {
            //Prints out a greeting and ask the user their name. Then responds with a "Bye Bob!" (replacing Bob with the name entered)


            Console.WriteLine("please enter your name ");
            string name = Console.ReadLine();
            Console.WriteLine("hello " + name);
            Console.ReadKey();

            //asking for 2 numbers and then adding their sum
            Console.WriteLine("please enter a number");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter another number");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Those two numbers together equal " + (num1 + num2));
            Console.ReadKey();

            //A method that ask the user if they prefer cats or dogs, and either "Barks" or "Meows" back depending on what they entered.

            Console.WriteLine("Do you prefer cats or dogs?");
            string answer = Console.ReadLine();
           if(answer=="cats")
            {
                Console.WriteLine("Meow");
            } 
           else if(answer=="dogs")
            {
                Console.WriteLine("Woof!!");
            } else
            {
                Console.WriteLine("Invalid");
                    }
            Console.ReadKey();

            //A method that asks the user for a number, and prints out if it is odd or even
            Console.WriteLine("enter any number");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num%2 ==0)
            {
                Console.WriteLine("That number is even");
            }else
                {
                Console.WriteLine("That number is odd");
            }
            Console.ReadKey();

            // A method that ask the user for a height in feet and returns the height converted to inches
            double inch;
            Console.Write("Type your height in feet: ");
            double feet = Convert.ToDouble(Console.ReadLine());
            inch = feet * 12;

            Console.WriteLine("{0} Feet  = {1} Inches", feet, inch);
            Console.ReadKey();

            // A method that ask the user for a word then prints it 3 times, first in all caps, then 2 more time in all lower case
            Console.WriteLine("Please enter your favorite word");
            string word = (Console.ReadLine());
            string bigger = word.ToUpper();
            Console.WriteLine(bigger);
            string smaller = word.ToLower();
            Console.WriteLine(smaller);
            Console.WriteLine(smaller);
            Console.ReadKey();

            //A method that ask the user for a weight in pounds, then converts it to killograms
            Console.WriteLine("Enter a number and I'll convert it to Kilograms");
            double pounds = Convert.ToDouble(Console.ReadLine());
            double kilograms = pounds * 0.45359237;
            Console.WriteLine(kilograms);
            Console.ReadKey();

            //A method that prints out the current date
            Console.WriteLine("The current date and time is: " + DateTime.Now);
            Console.ReadKey();

            //A method that asks the user their birth year, and print out their age
            Console.WriteLine("What year were you born?");
            int birthYear = Convert.ToInt32(Console.ReadLine());
            int currentYear = Convert.ToInt32(DateTime.Now.Year);
            int age = (currentYear - birthYear);
            Console.WriteLine("You are approximately {0} years old", age);
            Console.ReadKey();

            //A method that ask the user to guess a word, and print out 'CORRECT!!' if the word is "chsarp", otherwise prints out 'WRONG!!'
            Console.WriteLine("Try to guess the word I am thinking");
            string wordGuess = Console.ReadLine();
            if (wordGuess == "coding") 
            {
                Console.WriteLine("Amazing!!! That is correct");


            }
            else
            { 
                Console.WriteLine("WRONG!!!");
            }
            Console.ReadKey();

        }




    }
}
