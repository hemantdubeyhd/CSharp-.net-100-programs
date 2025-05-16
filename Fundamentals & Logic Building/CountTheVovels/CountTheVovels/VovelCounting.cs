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
            int numberofConsonants = 0;

            foreach (char c in str)
            {
                char ch = char.ToLower(c);
                {


                    if (char.IsLetter(ch))
                    {
                        if ("aeiou".Contains(ch))
                        {
                            numberOfVovels++;
                        }
                        else
                        {
                            numberofConsonants++;
                        }
                    }
                   
                }

                    //if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u')
                    //{
                    //    numberOfVovels++;
                    //}
                }
                Console.WriteLine($"The entered {str} contains {numberOfVovels} vovel(s) and  {numberofConsonants} consonent(s)");

            }
        }
    }

