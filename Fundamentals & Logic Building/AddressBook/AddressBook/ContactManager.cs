using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    internal class ContactManager
    {
        Dictionary<string, Contact> Contacts = new Dictionary<string, Contact>();
      
        public void AddContacts()
        {
            Console.WriteLine("please Eneter Contact name");
            string input = Console.ReadLine().Trim();

            if (StringInputValidator.checkInputNullEmptyOrSpace(input))
            {
                Console.WriteLine("name cannot be empty.");
                return;
            }

            if (Contacts.ContainsKey(input)) 
            {
                Console.WriteLine($"{input} already exists in address reords.");
                return;
            }

            Console.WriteLine("please Eneter Contact Email");
            if (StringInputValidator.checkInputNullEmptyOrSpace(input))
            {
                Console.WriteLine("Email cannot be empty.");
                return;
            }

            Console.WriteLine("please Eneter Contact phone");
            input = Console.ReadLine().Trim();
            if (StringInputValidator.checkInputNullEmptyOrSpace(input))
            {
                Console.WriteLine("phone cannot be empty.");
                return;
            }

            Contact newContact = new Contact();


            Contacts[nameof] = newContact;
            
        }

    }
}
