using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfArray
{
    internal static class AddTheElementsOfTheArray
    {
        public static int AddingTheElementsOfArray(int[] array)
        {
            int sumOfArray = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sumOfArray += array[i];
            }
            return sumOfArray;
        }
    }
}
