using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PolymorphismDemoApp.Models
{
    internal class Student : Person
    {
        private string _course;
        public List<SubjectScore> scores = new List<SubjectScore>();

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

        public override void DipslayInfo()
        {
            base.DipslayInfo();
            Console.WriteLine($"Course: {_course}");

            if (scores != null && scores.Count > 0)
            {
                foreach (SubjectScore score in scores)
                {
                    Console.WriteLine(score.SubjectName);
                    Console.WriteLine(score.Score);
                }
            }
        }
    }
}
