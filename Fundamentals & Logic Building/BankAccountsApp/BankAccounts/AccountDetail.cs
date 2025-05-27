using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccounts
{
    internal class AccountDetail
    {
       
        public AccountHolder AccountHolder { get; }
        public AccountBalance AccountBalance { get; }

        private AccountDetail(AccountHolder holder, AccountBalance balance) 
        {
            AccountHolder = holder;
            AccountBalance = balance;
        }

        public static AccountDetail Create(AccountHolder holder, AccountBalance balance)
        {
            return new AccountDetail(holder, balance);
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Account ID: {AccountHolder.AccountId}");
            Console.WriteLine($"Name: {AccountHolder.Name}");
            Console.WriteLine($"EMail: {AccountHolder.EmailId}");
            Console.WriteLine($"Balance: {AccountBalance.Balance}");
        }
    }
}
