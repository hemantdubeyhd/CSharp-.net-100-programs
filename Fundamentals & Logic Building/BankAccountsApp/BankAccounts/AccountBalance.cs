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
        string input;
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
                Console.WriteLine("Please enter the amount to withdraw.");
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


    }
}
