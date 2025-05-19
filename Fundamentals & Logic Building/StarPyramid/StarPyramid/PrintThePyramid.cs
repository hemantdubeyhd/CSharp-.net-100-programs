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
            int numberOfStars = 1;
            int numberOfSpaceInTheLine = noOfStorisToPrint;
            int k = 0;
            for (int i = 0; i < noOfStorisToPrint; i++)
            {
                for(int j = 0; j < numberOfSpaceInTheLine; j++)
                {
                    Console.Write(" ");
                }
                for (; k <= i; k++)
                {
                    Console.Write(" H");
                }
                Console.WriteLine("\n");

                numberOfSpaceInTheLine--;
                k = 0;
            }
        }
    }
}
