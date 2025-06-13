using ATM.Helpers;
using ATM.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ATM.Services
{
    internal class WithdrawalService
    {
        public static void Withdrawal(Account account)
        {
            if (account.Balance == 0)
            {
                Console.WriteLine($"You cant make an withdrawal, your current balacne is ${account.Balance}");
                // return;
            }
            else
            {

                decimal amount = InputHelper.ValidateTheInput("Please enter the amount you want to withdraw");
                if (account.Balance - amount < 0)
                {
                    Console.WriteLine($"You cant make an withdrawal, Withdrawal amount ${amount} is greater than amount available ${account.Balance}");
                }
                else
                {
                    account.Balance -= amount;
                    Console.WriteLine($"Successg=fully withdrawn ${amount}, your current balance is {account.Balance}");
                }
            } 
        }
    }
}
