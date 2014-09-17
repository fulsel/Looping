using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TableOfSquare
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 20; i++)
            {
                Console.WriteLine(i);
                
            }

            Console.WriteLine("Here are the squares of numbers 1 to 20.");

            for (int i = 1; i <= 20; i++)
                Console.WriteLine(i * i);
        }
    }
}
