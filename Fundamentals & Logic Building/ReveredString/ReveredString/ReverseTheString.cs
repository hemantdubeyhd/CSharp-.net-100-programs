using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ReveredString
{
    internal static class ReverseTheString
    {
        public static void ReversingTheString(string strignToReverse)
        {
            var sb = new StringBuilder(); 
            int lengthOftheStringToReverse = LengthOfString.FindingTheLengthOfAString(strignToReverse);
            for (int i = lengthOftheStringToReverse - 1; i >= 0; i--)
            {
                sb.Append(strignToReverse[i]);
            }
            string reversedString = sb.ToString();
            Console.WriteLine($"Revrse of {strignToReverse} is {reversedString}");
        }

    }
}
