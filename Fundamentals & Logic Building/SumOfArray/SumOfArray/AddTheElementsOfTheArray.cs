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
            int SumOfArray = 0;
            for (int i = 0; i < array.Length-1; i++)
            {
                SumOfArray += array[i];
            }
            return SumOfArray;
        }
    }
}
