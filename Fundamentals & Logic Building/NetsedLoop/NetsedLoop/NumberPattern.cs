using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetsedLoop
{
    internal static class NumberPattern
    {
        public static void printingNumberPattern(int noOfStoriesToPrint)
        {
            for (int i = 1; i <= noOfStoriesToPrint; i++)
            {
                for(int j = 1; j <= i; j++)
                {
                    Console.Write($" {j}");
                }
                Console.WriteLine();
            }
        }
    }
}
