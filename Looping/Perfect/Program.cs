using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Perfect
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 2; i <= 1000; i++)
            {
                int total = 0;
                int check = i - 1;

                while (true)
                {

                    if (check <= 1)
                    {
                        break;
                    }
                    while (true)
                    {
                        if (i % check == 0)
                            total += check;

                        check--;
                    }
                }

                int perfect;
                if (total == i)
                {
                    perfect = i;
                    Console.WriteLine(perfect);

                }



            }


        }
    }
}
