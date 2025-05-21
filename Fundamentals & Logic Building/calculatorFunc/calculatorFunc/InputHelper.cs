using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculatorFunc
{
    internal static class InputHelper
    {
        public static int validateTheNumber(string statement)
        {
            Console.WriteLine(statement);
            while (true) 
            {
                string inputToValidate = Console.ReadLine();
                if (int.TryParse(inputToValidate, out int input))
                {
                    return input;
                }
                else { 
                Console.WriteLine("Please enter a valid number")}
            }
        }
    }
}
