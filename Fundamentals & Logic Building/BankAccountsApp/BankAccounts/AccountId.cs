using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccounts
{
    internal class AccountId
    {
        private static int _counter = 0;
        public int Value { get; }

        public AccountId()
        {
            Value = ++_counter;
        }
        public override string ToString() => Value.ToString();
        public override bool Equals(object? obj)
        {
            return obj is AccountId other && Value == other.Value; ;
        }
        public override int GetHashCode() => Value.GetHashCode();
    }
}
