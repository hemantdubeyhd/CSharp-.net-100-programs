using ATM.Helpers;
using ATM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM.Services
{
    internal class DepositService
    {
        public static void Deposit(Account account)
        {
            BalanceService.DisplayBalance(account);
            decimal amount = InputHelper.ValidateTheInput("Please enter the amount you want to deposit");
            account.Balance += amount;
            BalanceService.DisplayBalance(account);

        }
    }
}
