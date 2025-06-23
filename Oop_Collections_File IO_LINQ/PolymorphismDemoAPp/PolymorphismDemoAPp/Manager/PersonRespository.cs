using PolymorphismDemoApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismDemoApp.Manager
{
    internal class PersonRespository
    {

        public Student CreateEmptyStudent()
        { 
            return new Student();
        }
        public List<Person> GrtALlPeople()
        {
            List<Person> persons = new List<Person>
            {
                new Person(),new Student(), new Teacher(), new Admin()
            };
            return persons;
        }

       
    }
}
