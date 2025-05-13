using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
    internal static class ReverseTheNumber
    {
        public static int reversingTheNuber(int numberToReverse)
        {
            int reversedNumber = 0;
            while (numberToReverse > 0)
            {
                reversedNumber = reversedNumber * 10 + numberToReverse % 10;
                numberToReverse /= 10;
            }
            return reversedNumber;
        }
    }
}
