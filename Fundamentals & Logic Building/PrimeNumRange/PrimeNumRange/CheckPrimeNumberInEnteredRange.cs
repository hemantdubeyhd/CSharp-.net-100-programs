using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumRange
{
    internal class CheckPrimeNumberInEnteredRange
    {
        public static void checkingIfNumberIsPrime(int lowerIndex, int upperIndex)
        {
            bool isPrime = true;
            for (int numberToCheck = lowerIndex; numberToCheck <=upperIndex; numberToCheck++)
            {

                for (int divisor = 2; divisor <= Math.Sqrt(numberToCheck); divisor++)
                {
                    if ((numberToCheck % divisor) == 0)
                    {
                        isPrime = false;
                        Console.WriteLine($"{numberToCheck} Number is not a prime numebr");
                       continue;
                    }

                }
                if (isPrime)
                {
                    Console.WriteLine($"{numberToCheck} Number is a prime numebr");
                }
                isPrime = true ;
            }
        }
    }
}
