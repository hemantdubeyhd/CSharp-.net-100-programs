using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ReveredString
{
    internal static class InputHelper
    {
        public static string inputAString(string statement)
        {
            string inputString;
            while (true)
            {
               Console.WriteLine(statement);
               inputString = Console.ReadLine();
                if (string.IsNullOrEmpty(inputString) || string.IsNullOrWhiteSpace(inputString))
                {
                    Console.WriteLine("Please enter a valid string");
                }
                else
                {
                    return inputString;
                }
            }
        }
    }
}
