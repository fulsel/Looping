using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Multiplication_Table
{
    class Program
    {
        static void Main(string[] args)
        {

            for (int i = 0; i <= 10; i++)
            {
               

                Console.WriteLine("{0, 3} {1, 3} {2, 3} {3,3} {4,3} {5,3} {6,3} {7,3} {8,3} {9,3} {10,3}", i*0, i*1, i*2, i*3, i*4, i*5, i*6, i*7, i*8, i*9, i*10);
            }

        }
    }
}
