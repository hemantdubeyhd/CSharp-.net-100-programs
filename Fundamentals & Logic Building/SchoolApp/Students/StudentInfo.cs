using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students
{
    internal class StudentInfo
    {
        public static void setStudentInfo(Student student)
        {
            while (true)
            {
                Console.WriteLine("enter student's name");
                student.name = Console.ReadLine();
                if(string.IsNullOrEmpty(student.name) || string.IsNullOrWhiteSpace(student.name))
                {
                    Console.WriteLine("Please neter a name");
                    continue;
                }
                break;
            }

            while (true)
            {
                Console.WriteLine("enter student's age");
              
                if (int.TryParse(Console.ReadLine(), out int age))
                {
                    if (age <= 0)
                    {
                        Console.WriteLine("Please neter a valid age");
                            continue;
                    }
                    student.age = age;
                    break;
                }
                else
                {
                    Console.WriteLine("Please neter a valid age");
                }
            }

        }
    }
}
