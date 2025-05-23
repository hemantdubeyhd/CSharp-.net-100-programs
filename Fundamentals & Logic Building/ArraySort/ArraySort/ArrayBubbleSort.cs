using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraySort
{
    internal class ArrayBubbleSort
    {
        public static void BubbleSortingAnArray(int[] array)
        {
            int temp;
            for (int i = 0; i < array.Length -1; i++)
            {
                for (int j=0; j < array.Length - i -1; j++)
                {
                    if (array[j] > array[j+1])
                    {
                        temp = array[j];
                        array[j] = array[j+1];
                        array[j+1] = temp;
                    }

                }
            }
            
            ArrayPrinter.PrintingTheArray(array);
            //Console.WriteLine($"Largest Element in array is {max}");
        }
    }
   
}
