using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace BankAccounts
{
    internal class AccountHolder
    {
        public AccountId AccountId { get; }
        public string Name {  get; set; }
        public string EmailId {  get; set; }

        private AccountHolder(string name, string email)
        {
            AccountId = new AccountId();
            Name = name;
            EmailId = email;
        }
        public static AccountHolder Create()
        {
            Console.WriteLine("Please enter the name");
            string name = Console.ReadLine();

            Console.WriteLine("Please enter the email Id"); //Not validationg email id rn, that's not the intend at this point of time,
                                                            //rn creating classes, object and using them is importatnt.
            string email = Console.ReadLine();

            return new AccountHolder(name, email);

        }

        public override string ToString()
        {
            return $"AccountHolder: {Name}, Id: {AccountId}, Email: {EmailId}";
        }

    }
}
