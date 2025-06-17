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
            if (id <= 0)
            {
                throw new ArgumentException("Student Id must  be greater than 0");
            }
            if (string.IsNullOrEmpty(name) || string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("Name cannot be empty or whitespace.", nameof(name));
            }
            _id = id;
            _firstName = name;
        }

        public void displayInfo()
        {
            Console.WriteLine($"Student id: {_id}, Name: {_firstName}");
        }
    }
}
