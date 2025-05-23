using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharFrequency
{
    internal class CharFrequencyChecker
    {
        public static void CheckCharacterFrequency(string input)
        {
           Dictionary<char,int> frequencyMap = new Dictionary<char,int>();
            foreach (char ch in input)
            {
                if (!(char.IsWhiteSpace(ch)))
                 {
                    if (frequencyMap.ContainsKey(ch))
                    {
                        frequencyMap[ch]++;
                    }
                    else
                    {
                        frequencyMap[ch] = 1;
                    } 
                }
            }

           // foreach (KeyValuePair<char,int> item in frequencyMap) //this can be easily written as:
           foreach( var item  in frequencyMap.OrderBy(x => x.Key) )
            {
                //Console.WriteLine(item); // this can be written more clearly as:
                Console.WriteLine($"Character {item.Key} occurs {item.Value} time(s)");
            }
        }
    }
}
