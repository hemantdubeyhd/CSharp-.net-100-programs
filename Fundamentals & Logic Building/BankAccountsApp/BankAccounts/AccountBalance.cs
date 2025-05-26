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
                if (decimal.TryParse(Console.ReadLine(), out decimal amount) && amount > 0)
                {
                    Balance += amount;
                    Console.WriteLine($"Successfully deposit the ${amount}, new balance is {Balance}");
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
                Console.WriteLine($"You have ${Balance} in your account, please enter amount equal or less than this value.");
                if (decimal.TryParse(Console.ReadLine(), out decimal amount) && amount > 0 )
                {
                    Balance -= amount;
                    if (amount <= Balance)
                    {
                        Balance -= amount;
                        Console.WriteLine($"Successfully withdrawn the ${amount}, new balance is {Balance}");
                        break;
                    }
                    else 
                    {
                        Console.WriteLine("Insufficient balance, please try again");
                    }
                                   }
                else
                {
                    Console.WriteLine("Please enter a psoitive value graeter than 0");
                }
            }
        }


    }
}
