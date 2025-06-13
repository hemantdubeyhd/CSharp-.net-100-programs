using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM.Helpers

{
    internal class ConsoleHelper
    {
        public static void Pause()
        {
            Console.WriteLine("Press anykey to continue.....");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
