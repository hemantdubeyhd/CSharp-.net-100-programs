using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeapYearCheck
{
    public static class InputYearandCheck
    {
       public static  int EnterTheYear(string statement)
        {
            Console.WriteLine($"{statement}");


            while (true)
            {
                string year = Console.ReadLine();
                if (int.TryParse(year, out int yearToCheck))
                {

                    return yearToCheck;
                }
                else
                {
                    Console.WriteLine("please neter the correct year in diguts/numbers in yyyy format");
                }
            }
        }
    }
}
