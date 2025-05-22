using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfArray
{
    internal static class InputHelper
    {
        public static int ValidateTheSizeOFarray(string statement)
        {
            Console.WriteLine(statement);

            while (true) 
            {
                string input = Console.ReadLine();
                if (int.TryParse(input, out var arraySize))
                {
                    if (arraySize <= 0)
                    {
                        Console.WriteLine($"You enetred the size of the array to be size {arraySize}, Pleasse enter a valid size");
                        continue;
                    }
                    return arraySize;
                }
                else
                { 
                    Console.WriteLine("Please eneter a valid size of the array");
                }
            }
        }
    }
}
