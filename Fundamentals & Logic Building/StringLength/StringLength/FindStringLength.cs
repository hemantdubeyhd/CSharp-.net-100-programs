using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringLength
{
    internal static class FindStringLength
    {
        public static int findingTheLenghtOfTheString(string str)
        {
            int lenght = 0;
            foreach (char c in str) 
            {
                lenght++;
            }
            return lenght;
        }
    }
}
