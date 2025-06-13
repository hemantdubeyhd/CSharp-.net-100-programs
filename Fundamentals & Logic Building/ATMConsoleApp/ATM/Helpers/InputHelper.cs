using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM.Helpers
{
    internal class InputHelper
    {
        public static decimal ValidateTheInput(string statement)
        {
            Console.WriteLine(statement);
            string input = Console.ReadLine();
            if (int.TryParse(input, out int amount))
            {  
                if(amount <= 0)
                {
                    Console.WriteLine("Please enter an amount greater than $0");
                }
                return amount; 
            }
            else
            {
                Console.WriteLine("Please enter correct amount value");
            }
            return 0;
        }

    }
}
