using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArmstrongNum
{
    internal static class CheckIfArmstrong
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
            int currentDigit;
            int result;
            //  Console.WriteLine($"No of Digits = {numberOfdigits}");
            int temp = numberToCheck;
            while (temp > 0)
            {
                currentDigit = temp % 10;
                temp = temp/ 10;
                result = FindPowerOf.CalculteThePowerOf(currentDigit, numberOfdigits);

                numberToCompare += result;
            }
            if (numberToCompare == numberToCheck)
            {
                Console.WriteLine($"{numberToCheck} is an Armstrong number");
            }
            else
            {
                Console.WriteLine($"{numberToCheck} is NOT an Armstrong number");
            }
        }

    }
}
