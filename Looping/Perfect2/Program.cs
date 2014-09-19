using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Perfect2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            for(int i = 2; i<=1000; i++)
            
            {
                int checkdecrease = (i - 1), total = 0;
                while(true)
                {
                    if (checkdecrease ==0)
                        break;
                    if (i % checkdecrease == 0)
                        total +=(checkdecrease);
                        checkdecrease--;
                    if (total == i && checkdecrease <= 1)
                    {
                        Console.WriteLine(total);
                        break;
                    }
                }




            }

        }
    }
}
