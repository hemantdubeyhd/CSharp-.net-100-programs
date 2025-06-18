using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PolymorphismDemoAPp
{
    internal class Student : Person
    {
        private string _course;

        public string Course
        {
            get
            {
                return _course;
            }

            set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Name cannot be null, empty or whotespaces!!");
                }
                _course = value;
            }
        }
    }
}
