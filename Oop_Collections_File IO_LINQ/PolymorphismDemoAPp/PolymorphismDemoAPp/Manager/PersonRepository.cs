using PolymorphismDemoApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismDemoApp.Manager
{
    internal class PersonRepository
    {

        public Student CreateEmptyStudent() { return new Student(); }
        public Teacher CreateEmptyTeacher() { return new Teacher(); }
        public Admin CreateEmptyAdmin() { return new Admin(); }
        public List<Person> GetAllPeople()
        {
            List<Person> persons = new List<Person>
            {
                new Person(),new Student(), new Teacher(), new Admin()
            };
            return persons;
        }

       
    }
}
