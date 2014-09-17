using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Looping
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int sum = 0;
            int enter;
            while (true)
            {
                
                Console.WriteLine("Please Enter a number. ");
                string input = Console.ReadLine();
                enter = Convert.ToInt32(input);
                if (enter == 999)
                {
                    Console.WriteLine("Error, you cannot enter 999.");
                    break;
                    //Console.WriteLine("Error, you cannot enter 999.");
                }
                sum = sum + enter;
                enter = 0;
                Console.WriteLine("Your sum is {0}", sum);

                
                
            }

            

        }
    }
}
