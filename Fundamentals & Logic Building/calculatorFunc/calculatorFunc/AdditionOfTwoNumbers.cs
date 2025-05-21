using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorFunc
{
    internal static class AdditionOfTwoNumbers
    {
        public static void addingTwoNumbers()
        {
            int firstNumberInput = InputHelper.validateTheNumber("Please enter a numbber");

            int secondNumberInput = InputHelper.validateTheNumber("Please enter a numbber");

            Console.WriteLine($"Addition of two numbers are {firstNumberInput + secondNumberInput}");
        }
    }
}
