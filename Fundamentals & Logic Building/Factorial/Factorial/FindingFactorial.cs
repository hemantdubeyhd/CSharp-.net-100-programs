using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
    internal static class FindingFactorial
    {
       
        public static void FindTheFactorial(int input)
        {
             long result = 1;
            if (input == 0 || input == 1)
            {
                Console.WriteLine($"Factorial of {input} is {result}");
            }
            else
            {


                for (int i = input; i > 1; i--)
                {
                    result *= i;
                }
                Console.WriteLine($"Factorial of {input} is {result}");
            }
            Console.ReadLine();
        }

      
    }
}
