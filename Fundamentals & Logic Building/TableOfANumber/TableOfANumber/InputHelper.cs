using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TableOfANumber
{
    internal static class InputHelper
    {
        
        public static int  GetAValidNumber(string input) 
        {
            Console.WriteLine(input);
            while (true) 
            { 
                input = Console.ReadLine();
                if(int.TryParse(input, out int number) )
                {
                    return number;
                }
                else
                {
                    Console.Write("Please enter a valid number");
                }
               
            }
        }
    }
}
