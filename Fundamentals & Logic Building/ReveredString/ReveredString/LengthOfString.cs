using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReveredString
{
    internal static class LengthOfString
    {
        public static int FindingTheLengthOfAString(string str)
        {
            int noOfCharInTheStr = 0;
            foreach (char character in str)
            {
                noOfCharInTheStr++;
            }
            return noOfCharInTheStr;
        }
    }
}
