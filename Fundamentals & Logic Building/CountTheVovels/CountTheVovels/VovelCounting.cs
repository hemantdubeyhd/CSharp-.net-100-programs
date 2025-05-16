using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountTheVovels
{
    internal static class VovelCounting
    {
        public static void countinTheVovels(string str)
        {
            int numberOfVovels = 0;
           
            foreach (char c in str)
            {
                char ch = char.ToLower(c);
                if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u')
                {
                    numberOfVovels++;
                }
            }
            Console.WriteLine($"Number of vovels is {str} is {numberOfVovels}");

        }
    }
}
