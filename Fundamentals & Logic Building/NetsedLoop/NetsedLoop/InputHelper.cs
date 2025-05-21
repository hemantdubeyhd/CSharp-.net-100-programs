using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetsedLoop
{
    internal static class InputHelper
    {
        public static int validateTheInput(string statement)
        {
            Console.WriteLine(statement);
            int output = 0;
            while (true)
            {
                string input = Console.ReadLine();
                if (int.TryParse(input, out output))
                {
                    if (output <= 0)
                    {
                        Console.WriteLine("please Eneter anumber > 0");
                        continue;
                    }
                    return output;
                }
                else
                {
                    Console.WriteLine("please Eneter a valid anumber > 0");
                }
            }

        }
    }
}
