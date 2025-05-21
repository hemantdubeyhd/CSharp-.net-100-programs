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
            for (int numberToCheck = lowerIndex; numberToCheck <=upperIndex; numberToCheck++)
            {

                if(isPrime(numberToCheck))
                {
                    Console.WriteLine($"{numberToCheck} Number is a prime numebr");
                }
                else
                {
                    Console.WriteLine($"{numberToCheck} Number is not a prime numebr");
                }
               
            }

        }
        private static bool isPrime(int numberToCheck)
        {
            for (int divisor = 2; divisor <= Math.Sqrt(numberToCheck); divisor++)
            {
                if ((numberToCheck % divisor) == 0)
                {
                    return false;
                }

            }
            return true;
        }


    }
}
