using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseAnArray
{
    internal static class ArrayReverser
    {
        public static void ReversingTheArray(int[] array) 
        {
            int temp;
            for (int i = 0; i < array.Length /2; i++)
            {
                temp = array[i];
                
                array[i] = array[array.Length -1 -i];
                array[array.Length - 1 - i] = temp;
            }

            PrintTheArray.PrintingTheArray(array);


        }

    }
}
