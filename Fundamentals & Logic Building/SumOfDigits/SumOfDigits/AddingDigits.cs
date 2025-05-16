using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfDigits
{
    internal static class AddingDigits
    {
        public static void findTheSumofTheDigits(int number)
        {
            int sumOfTheDigits = 0;
            int tempNumber = number;
          
                while (tempNumber > 0)
                {
                    sumOfTheDigits +=  (tempNumber % 10);
                    tempNumber /= 10;
                }
            
            Console.WriteLine($"Sum of the digits of numebr {number} is {sumOfTheDigits }");
        }
    }
}
