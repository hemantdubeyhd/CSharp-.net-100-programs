using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorDemoApp
{
    internal class Student
    {
        private int _id;
        private string _firstName;

        public Student()
        {
            Console.WriteLine("default Constuctur called");
            _id = 0;
            _firstName = "Unknown";
        }
        public Student(int id, string name)
        {
            _id = id;
            _firstName = name;
        }

        public void displayInfo()
        {
            Console.WriteLine($"Student id: {_id}, Name: {_firstName}");
        }
    }
}
