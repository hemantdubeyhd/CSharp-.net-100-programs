using ATM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM.Services
{
    internal class BalanceService
    {
        public void DisplayBalance(string statment, Account account)
        {
            Console.WriteLine($"{statment} ${account.Balance}");
        }
    }
}
