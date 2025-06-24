using PolymorphismDemoApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismDemoApp.Helpers
{
    internal class InputHelper
    {
        public void FillData( Person person )
        {
            Console.WriteLine("Please Enter the id:");
            person.Id = 1;
            person.Name = "Default person";

            if (person is Student student)
            {
                student.Course = "CS";
            }
            else if (person is Teacher teacher)
            {
                teacher.Subject = "C#";
            }
            else if ( person is Admin admin)
            {
                admin.Department = "Support";
            }

            
        }
    }
}
