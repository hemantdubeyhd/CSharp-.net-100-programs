using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArmstrongNum
{
    internal static class CheckIfPalindrome
    {
        public static void CheckingIfNumberIsArmstrong(int numberToCheck)
        {
            if (numberToCheck >= 0 && numberToCheck <= 9)
            {
                Console.WriteLine($"{numberToCheck} is a Palindrome");
            }

            int numberOfdigits =0;
            int tempNumberToCheck = numberToCheck;

            while (tempNumberToCheck > 0)
            {
                tempNumberToCheck /= 10;
                numberOfdigits++;
            }
            int numberToCompare = 0;
            int deviser = 10;
            int currentDigit;
            int result;
            //  Console.WriteLine($"No of Digits = {numberOfdigits}");
            int loopIndex = numberOfdigits;
            while (numberToCheck > 0)
            {
                currentDigit = numberToCheck % 10;
                numberToCheck = numberToCheck / 10;
                result = FindPowerOf.CalculteThePowerOf(currentDigit, numberOfdigits);

                numberToCompare += result;
            }
            Console.WriteLine($" total is = {numberToCompare}");
        }

    }
}
