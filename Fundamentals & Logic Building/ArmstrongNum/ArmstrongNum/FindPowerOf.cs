using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArmstrongNum
{
    internal static class FindPowerOf
    {
       
        public static int CalculteThePowerOf(int num, int power)
        {
            int result = 1;
            for (int i = 0; i < power; i++) 
            {
                result *= num;
            }
          //  Console.WriteLine(result);
            
            return result;
        }
    }
}
