using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    internal class Contact
    {
        public string Name {  get; set; }
        public string Phone {  get; set; }
        public string EmailId {  get; set; }

        public override string ToString()
        {
            return $"Name: {Name} \nPhone: {Phone} \nEmail: {EmailId}";
        }
    }
}
