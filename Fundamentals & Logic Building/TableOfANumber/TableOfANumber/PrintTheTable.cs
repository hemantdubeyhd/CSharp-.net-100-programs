using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TableOfANumber
{
    internal static class PrintTheTable
    {
        internal static void PrintTheTableOfANumber(int number)
        {
            if (number == 0) 
            {
                Console.WriteLine("Table of 0 is all zeros — try another number if you want something more fun!");
                Console.ReadLine();
                return;
            }
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{number,3} * {i,2} = {number * i, 3}");
            }
            Console.ReadLine();

        }
    }
}
