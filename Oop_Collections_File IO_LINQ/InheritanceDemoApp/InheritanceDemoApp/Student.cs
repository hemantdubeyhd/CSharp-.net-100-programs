using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace InheritanceDemoApp
{
    internal class Student : Person
    {
        private string _course;
        
        public string Course {
            get { return _course; }
            set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Course cannot be empty or whitespace.", nameof(Course));
                }
                _course = value;
            }
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo(); 
            Console.WriteLine($"Course :{_course}");
        }
    }
}
