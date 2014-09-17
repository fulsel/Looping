using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GetVowel
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Please enter a vowel. ");
                string input = Console.ReadLine().ToLower();

                if (input == "!")
                    break;

                if (input == "a" || input == "e" || input == "i" || input == "o" || input == "u")
                    Console.Write("OK ");
                else Console.Write("Dumbass, you didn't enter a vowel.");

            }


        }
    }
}
