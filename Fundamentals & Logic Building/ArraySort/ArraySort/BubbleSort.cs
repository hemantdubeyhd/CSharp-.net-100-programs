using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraySort
{
    internal class BubbleSort
    {

        //////Following logic is the first basic logic, good to buld the foundation and learning and for small arrays, 
        //////but it definitely complete all th iteration irrespective if array got sorted already or array was sorted as input itsef
        ///



        //public static void BubbleSorting(int[] array)
        //{
        //    int temp;
        //    for (int i = 0; i < array.Length -1; i++)
        //    {
        //        for (int j=0; j < array.Length - i -1; j++)
        //        {
        //            if (array[j] > array[j+1])
        //            {
        //                temp = array[j];
        //                array[j] = array[j+1];
        //                array[j+1] = temp;
        //            }
        //        }
        //    }
        //}




        //So for above performance reason, we can check if no swap has cooured in any oerticular iteration,
        //we can stop then and there:
        public static void BubbleSorting(int[] array)
        {
            int temp;
            bool swapped = false;
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = 0; j < array.Length - i - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                        swapped = true;
                    }
                }
                if (!swapped)
                {
                    break;
                }
            }
        }

    }

}
