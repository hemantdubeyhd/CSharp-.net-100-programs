using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Palindrome;
namespace Palindrome
{
    internal static class CheckingPalindrome
    {
        public static void CheckIfPalindrome(int numberToCheck)
        {
                  
          
               int reversedNumber = ReverseTheNumber.reversingTheNuber(numberToCheck);
            //Console.WriteLine(reversedNumber.ToString());
            if (numberToCheck == reversedNumber)
            {
                Console.WriteLine($"Number {numberToCheck} is Palindrome");
            }
            else
            {
                Console.WriteLine($"Number {numberToCheck} is not a Palindrome");
            }
            
        }
    }
}