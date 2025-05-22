using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LargestInArray
{
    internal class ArrayMaxFinder
    {
        public static void findingTheLargestInArray(int[] array)
        {
            int max = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                  max = array[i];
                }
            }
            ArrayPrinter.PrintingTheArray(array);
            Console.WriteLine($"Largest Element in array is {max}");
        }
    }
}
