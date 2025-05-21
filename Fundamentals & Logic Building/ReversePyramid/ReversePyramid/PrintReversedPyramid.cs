using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePyramid
{
    internal static class PrintReversedPyramid
    {
        public static void printingTheReversedPyramid(int noOfStoriesToPrint)
        {
            for (int i = 0; i < noOfStoriesToPrint; i++) 
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(" ");
                }
                for (int k = noOfStoriesToPrint - i; k > 0; k--)
               Console.Write(" *");

                Console.WriteLine();
            }
        }
    }
}
