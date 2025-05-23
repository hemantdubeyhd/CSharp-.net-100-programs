using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharFrequency
{
    internal class InputHelper
    {
        public static string ValidatingStrinInput(string statement)
        {
            Console.WriteLine(statement);
            string input;
            while (true)
            {
                input = Console.ReadLine();
                if (string.IsNullOrEmpty(input))
                {
                    Console.WriteLine("Please enter a valid string");
                    continue;
                }
                return input;
            }
        }
    }
}
