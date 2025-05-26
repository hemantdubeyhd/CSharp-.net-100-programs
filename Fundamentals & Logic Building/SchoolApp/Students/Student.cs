using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students
{
    internal class Student
    {
        private string _name;
        private int _age;
        private char _section;

        public string name
        {
            get
            {
                return _name;
            }

            set
            {
                _name = value;
            }
        }

        public int age
        {
            get
            {
                return _age;
            }

            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Invalid Age!");
                }
                _age = value;
            }

        }

        public char section
        {
            get
            {
                return _section;
            }
            set
            {
                _section = value;
            }
        }

    }
}
