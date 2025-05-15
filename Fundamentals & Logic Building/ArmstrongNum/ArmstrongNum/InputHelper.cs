using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArmstrongNum
{
    internal static class InputHelper
    {

        public static int CheckTheValidityOfEnteredNumber(string statement)
        {
            Console.WriteLine(statement);
                
            while (true)
            {
               string numberToCheck =Console.ReadLine();
                if (int.TryParse(numberToCheck, out int numberToReturn))
                {
                    if(numberToReturn < 0)
                    {
                        Console.WriteLine("Please enter a valid psoitive number");
                        continue;
                    }
                    return numberToReturn;
                }
                else
                {
                    Console.WriteLine("Please enter a valid number");
                }
            }
        }
    }
}
