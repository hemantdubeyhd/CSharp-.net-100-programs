﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LargestInArray
{
    internal class ArrayPrinter
    {
        public static void PrintingTheArray(int[] array)
        {

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"array[{i}] = {array[i]}");
            }
        }
    }
}
