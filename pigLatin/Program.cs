using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pigLatin
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a word so I can translate it to pig latin");
            string translateToPig = Console.ReadLine();
            char[] vowels = new char[] { 'a', 'e', 'i', 'o', 'u' };

            int firstVowel = translateToPig.IndexOfAny(vowels);

            if (firstVowel == -1)
            {
                Console.WriteLine(translateToPig + "ay");
            }
            else
            {
                char firstLetter = translateToPig[0];
                char lastLetter = translateToPig[translateToPig.Length - 1];
                if (vowels.Contains(firstLetter) && vowels.Contains(lastLetter))
                {
                    Console.WriteLine(translateToPig + "yay");
                }
                else if (vowels.Contains(firstLetter) && !vowels.Contains(lastLetter))
                {
                    Console.WriteLine(translateToPig + "ay");

                }
                else
                {
                    Console.WriteLine(translateToPig.Substring(firstVowel) + translateToPig.Substring(0, firstVowel) + "ay");
                }
                Console.ReadKey();


            }
        }
    }
}
