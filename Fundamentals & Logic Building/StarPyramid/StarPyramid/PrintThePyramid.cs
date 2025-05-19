using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarPyramid
{
    internal static class PrintThePyramid
    {
      
        public static void printingThePyramid(int noOfStorisToPrint)
        {
           
            for (int i = 0; i < noOfStorisToPrint; i++)
            {
                for(int j = 0; j < noOfStorisToPrint - i; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 0; k <= i; k++)
                {
                    Console.Write(" H");
                }
                Console.WriteLine();

            }
        }
    }
}
