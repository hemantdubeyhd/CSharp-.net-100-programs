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
        public Person person = new Person();
        public Student student = new Student();
        public Teacher teacher = new Teacher();
        public Admin admin = new Admin();


    }
}
