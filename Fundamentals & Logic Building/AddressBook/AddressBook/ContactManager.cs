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
      
        public void Add()
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

            

            contacts[name] = newContact;

            Console.WriteLine($"{name} was added sucessfully as follows:");
            Console.WriteLine(newContact);


        }

        public void Search()
        { 
           Console.WriteLine("Eneter a name to search contact info for");
            string name = Console.ReadLine().Trim();

            if(StringInputValidator.checkInputNullEmptyOrSpace(name))
            {
                Console.WriteLine("name cannot be empty.");
                return;
            }

            if (contacts.ContainsKey(name))
            {
                Contact foundContact = contacts[name];
                Console.WriteLine(foundContact);
            }
            else
            {

                Console.WriteLine($"there is no recors with name \"{name}\"");
            }

        }

        public void DisplayAllRecords()
        {
            int noOfRecords = contacts.Count;
            if (noOfRecords == 0)
            {
                Console.WriteLine("Address book is empty, no records found!");
                return; 
            }
            Console.WriteLine("All contacts in Address book:");
            int count = 1;
            foreach (Contact contact in  contacts.Values)
            {
                Console.WriteLine($"Conatct #{count++}");
                Console.WriteLine(contact);
                Console.WriteLine();
            }


        }

        public void Delete()
        {
            Console.WriteLine("please enter a name to delerte the record for");
            string name = Console.ReadLine().Trim();

            if (StringInputValidator.checkInputNullEmptyOrSpace(name))
            {
                Console.WriteLine("Name cant be empty");
                return;
            }

            //Two diffrernt way to impelment delete:

            //if (contacts.ContainsKey(name))
            //{
            //    contacts.Remove(name);
            //    Console.WriteLine($"{name}'s record been deleted sucessfully");

            //}


            //Another way to rmove is:
            if (contacts.Remove(name, out Contact removedContact))
            {
                Console.WriteLine("\n-----------------------------");
                Console.WriteLine($"The following contatc has been removed form record {removedContact}");
                Console.WriteLine("-----------------------------\n");

            }
            else
            {
                Console.WriteLine($"No contacts found with the name \"{name}\"");
            }

        }

        public void Update()
        {
            Console.WriteLine("Please enter contact name to update its record:");
            string name = Console.ReadLine().Trim();

            if (StringInputValidator.checkInputNullEmptyOrSpace(name))
            {
                Console.WriteLine("name cannot be empty.");
                return;
            }

            if (!contacts.TryGetValue(name, out Contact existingContact))
            {
                Console.WriteLine($"No record found with the name: {name}");
                return;
            }

            Console.WriteLine("Leave the field empty if you don't want to updte it");

            Console.WriteLine($"Current Email:{existingContact.EmailId}");
            Console.WriteLine("Please enter new Email:");
            string input = Console.ReadLine().Trim();
            if (!StringInputValidator.checkInputNullEmptyOrSpace(input))
            {
                existingContact.EmailId = input;
            }
            Console.WriteLine($"Current Phone:{existingContact.Phone}");
            Console.WriteLine("Please enter new Phone:");
            input = Console.ReadLine().Trim();

            if (!StringInputValidator.checkInputNullEmptyOrSpace(input))
            {
                existingContact.Phone = input;
            }

            Console.WriteLine($"Record has been updated sucessfully. The updated record is as follow:");
            Console.WriteLine(existingContact);


        }


    }
}
