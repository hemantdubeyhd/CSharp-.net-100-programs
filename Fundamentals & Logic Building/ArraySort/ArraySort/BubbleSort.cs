﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraySort
{
    internal class BubbleSort
    {
        /// <summary>
        //////Following logic is the first basic logic, good to buld the foundation and learning and for small arrays, 
        //////but it definitely complete all th iteration irrespective if array got sorted already or array was sorted as input itsef
        ///
        /// </summary>


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
           
            for (int i = 0; i < array.Length - 1; i++)
            {
                bool swapped = false;
                for (int j = 0; j < array.Length - i - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                        //Can use a Tuple syntax to do above three line, that would be:
                        //(array[j], array[j + 1]) = (array[j + 1], array[j]);

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
