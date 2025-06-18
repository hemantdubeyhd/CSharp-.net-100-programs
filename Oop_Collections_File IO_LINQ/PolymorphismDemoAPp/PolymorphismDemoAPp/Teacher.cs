using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismDemoApp
{
    internal class Teacher: Person
    {
        private string _subject;

        public string Subject
        {
            get
            {
                return _subject;
            }

            set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Name cannot be null, empty or whotespaces!!");
                }
                _subject = value;
            }
        }

        public override void DipslyInfo()
        {
            Console.WriteLine($"Subject: {_subject}");
        }
    }
}

