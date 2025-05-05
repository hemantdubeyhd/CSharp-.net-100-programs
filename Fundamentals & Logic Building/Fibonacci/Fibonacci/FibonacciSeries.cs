using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    internal static class FibonacciSeries
    {
        public static void printFibnacci(int NoOfTermsToPrint)
        {
            long FirstTerm = 0;
            long SecondTerm = 1;
            long temp;
            Console.WriteLine(FirstTerm);
            Console.WriteLine(SecondTerm);
           // SecondTerm = FirstTerm + 1;
            for (int i = 2; i < NoOfTermsToPrint; i++)
            {
                long next = FirstTerm + SecondTerm;
                Console.WriteLine(next);
                FirstTerm = SecondTerm;
                SecondTerm = next;
            }
        }
    }
}
