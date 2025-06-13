using ATM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM.Helpers
{
    internal class AccountExistHelper
    {
        public static bool IsAccountNotExist(Account account)
        {
            if (account == null) 
                return true;
            else 
                return false;
        }
    }
}
