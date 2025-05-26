using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students
{
    internal class DisplayStudentInfo
    {
        public void Display(Student student)
        {
            Console.WriteLine(student.name);
            Console.WriteLine(student.age);
            Console.WriteLine(student.section);
        }
    }
}
