using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcatArrays
{
    internal class ArrayMerger
    {
        public static void mergeArrays(int[] a, int[] b, int[] merge) 
        {
            int i = 0;
            for (; i < a.Length; i++)
            {
                merge[i] = a[i];
            }
            for(int j=0; j < b.Length; j++)
            {
                merge[i] = b[j];
                i++;
            }
        }

    }
}
