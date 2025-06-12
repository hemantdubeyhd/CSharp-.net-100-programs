using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM.Models
{
    internal class Account
    {
        public decimal Balance {  get; set; }

        public Account(decimal initialBalance)
        {
            Balance = initialBalance;
        }
    }
}
