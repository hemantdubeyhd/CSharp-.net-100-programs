using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayMerger
{
    internal class InputHelper
    {
        public static int ValidateTheSizeOfArray(string statement)
        {
            Console.WriteLine(statement);

            while (true)
            {
                string input = Console.ReadLine();
                if (int.TryParse(input, out int arraySize))
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

        public static void addingValuesToArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"Please enetr the valve for array[{i}]: ");
                string input = Console.ReadLine();
                if (int.TryParse(input, out int element))
                {
                    array[i] = element;
                    continue;
                }
                i--;
                Console.WriteLine("Please enter a valid integer number");


            }

        }
    }
   }
