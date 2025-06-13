using ATM.Models;
using ATM.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM.Services
{
    internal class BalanceService
    {
        public static void DisplayBalance( Account account, string message = "Your current balance is:")
        {
            Console.WriteLine($"{message} ${account.Balance}");
           
        }
    }
}
