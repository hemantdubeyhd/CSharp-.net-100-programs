using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeapYearCheck
{
    public static class LeapYearChecker
    {
        public static void CheckIfLeapYear(int yearToCheck)
        {
            if ((yearToCheck % 4 == 0) && (yearToCheck % 100 != 0 || yearToCheck % 400 == 0))
            {
                Console.WriteLine($"{yearToCheck} is a leap year");
            }
            else
            {
                Console.WriteLine($"{yearToCheck} is not a leap year");
            }
        }
    }
}
