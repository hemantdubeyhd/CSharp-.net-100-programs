using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccounts
{
    internal class AccountBalance
    {
        public decimal Balance {  get; set; }
        public void Diposit()
        {
            while (true)
            {
                Console.WriteLine("Please enter the amount to diposit.");
                if (int.TryParse(Console.ReadLine(), out int amount))
                {
                    Balance += amount;
                    break;
                }
                else
                {
                    Console.WriteLine("Please neter a psoitive value graeter than 0");
                }
            }

        }

        public void Withdrawal() 
        {
            while (true)
            {
                Console.WriteLine($"You have {Balance} in your account, please enter the amount to withdraw.");
                if (int.TryParse(Console.ReadLine(), out int amount))
                {
                    Balance -= amount;
                    if(Balance < 0) 
                    {
                        Balance += amount;
                        Console.WriteLine($"You have {Balance} in your account, please netr amount equla or less than this value.");
                    }
                    continue;
                }
                else
                {
                    Console.WriteLine("Please neter a psoitive value graeter than 0");
                }
            }
        }


    }
}
