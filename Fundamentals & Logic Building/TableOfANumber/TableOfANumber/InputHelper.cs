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
            while (true) 
            { 
                input = Console.ReadLine();
                if(int.TryParse(input, out int number) )
                {
                    return number;
                }
                else
                {
                    Console.WriteLine("Please enter a valid number");
                }
               
            }
        }
    }
}
