using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    internal static class InputHelper
    {
        public static int GetAValidNumber(string input)
        {
            Console.WriteLine(input);

            while (true)
            {
                input = Console.ReadLine();
                if (int.TryParse(input, out int number))
                {
                    if (number > 92 || number < 0)
                    {
                        Console.WriteLine("Please enter a number between 2 and 92.");
                        continue;
                    }

                    return number;
                }

                else
                {
                    Console.WriteLine("Please enter a number between 2 and 92.");
                }

            }
        }
    }
}

