using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal static class InputAndInputValidation
    {
      public static int getValidNumber(string statement)
        {
            Console.WriteLine(statement);
            string input;
            while (true)
            { 
                
                input = Console.ReadLine();
                if(int.TryParse(input, out int number))
                {
                    return number;
                }
                Console.WriteLine("Please enter a valid number");
            
            }
            
        }
    }
}
