using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
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
                    if (number > 20 || number < 0)
                    {
                        Console.WriteLine("\"Please enter a positive integer between 0 and 20.");
                       continue;
                    }

                        return number;
                }
                
                else
                {
                    Console.WriteLine("\"Please enter a positive integer between 0 and 20.");
                }

            }
        }
    }
}
