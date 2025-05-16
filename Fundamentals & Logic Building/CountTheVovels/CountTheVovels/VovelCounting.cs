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
                if(char.ToLower(c) == 'a' || char.ToLower(c) == 'e' || char.ToLower(c) == 'i' || char.ToLower(c) == 'o' || char.ToLower(c) == 'u')
                {
                    numberOfVovels++;
                }
            }
            Console.WriteLine($"Number of vovels is {str} is {numberOfVovels}");

        }
    }
}
