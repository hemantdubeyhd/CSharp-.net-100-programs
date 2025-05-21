using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumber
{
    internal static class InputHelper
    {
        public static int checkTheNumberIfPrime(string statement)
        {
            int numberToCheckIfPrime;
            Console.WriteLine(statement);
            while (true)
            {
                string input = Console.ReadLine();

                if (int.TryParse(input, out numberToCheckIfPrime))
                {
                    if (numberToCheckIfPrime < 1)
                    {
                        Console.WriteLine("Please enter a valid postive number > 1");
                        continue;

                    }
                    return numberToCheckIfPrime;
                }
                else
                {
                    Console.WriteLine("Please enter a valid postive number > 1");
                }

            }
        }
    }
}
