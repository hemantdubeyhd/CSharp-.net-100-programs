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
        Dictionary<string, Contact> contacts = new Dictionary<string, Contact>();
      
        public void AddContacts()
        {
            Console.WriteLine("please Eneter Contact name");
            string name = Console.ReadLine().Trim();

            if (StringInputValidator.checkInputNullEmptyOrSpace(name))
            {
                Console.WriteLine("name cannot be empty.");
                return;
            }

            if (contacts.ContainsKey(name)) 
            {
                Console.WriteLine($"{name} already exists in address reords.");
                return;
            }

            Console.WriteLine("please Eneter Contact Email");
            string email = Console.ReadLine();
            if (StringInputValidator.checkInputNullEmptyOrSpace(email))
            {
                Console.WriteLine("Email cannot be empty.");
                return;
            }

            Console.WriteLine("please Eneter Contact phone");
            string phone = Console.ReadLine().Trim();
            if (StringInputValidator.checkInputNullEmptyOrSpace(phone))
            {
                Console.WriteLine("phone cannot be empty.");
                return;
            }

            Contact newContact = new Contact 
            {
                Name = name,
                Phone = phone,
                EmailId = email
            };

            Console.WriteLine($"{name} was added sucessfully");

            contacts[name] = newContact;
            
        }

    }
}
