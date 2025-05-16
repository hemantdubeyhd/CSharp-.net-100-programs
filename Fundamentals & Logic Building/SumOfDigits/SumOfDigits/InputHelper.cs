using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfDigits
{
    internal static class InputHelper
    {
        public static int checkNumberIsValid(string statement)
        {
            Console.WriteLine(statement);
          
            while (true)
            {
                string input = Console.ReadLine();
                if (int.TryParse(input, out int result))
                {
                   return result;

                }
                Console.WriteLine("Please enetr a valid number");
            }
        }
    }
}
