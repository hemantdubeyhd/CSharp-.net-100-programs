using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumber
{
    internal static class CheckIfPrimeNumber
    {
        public static void checkingIfNumberIsPrime(int numberToCheck)
        {
            for (int divisor = 2; divisor <= Math.Sqrt(numberToCheck); divisor++)
            {
                if((numberToCheck % divisor) == 0)
                {
                    Console.WriteLine($"{numberToCheck} Number is not a prime numebr");
                    return;
                }
                
            }
            Console.WriteLine($"{numberToCheck} Number is a prime numebr");

        }
    }
}
