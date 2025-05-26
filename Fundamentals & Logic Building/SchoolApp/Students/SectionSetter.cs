using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Collections.Specialized.BitVector32;
using System.Xml.Linq;

namespace Students
{
    internal class SectionSetter
    {
        public void SettingSection(Student student)
        {
            if (!string.IsNullOrEmpty(student.name))
            {
                char firstLetter = char.ToUpper(student.name[0]);
                if (firstLetter >= 'A' && firstLetter <= 'P')
                {
                    student.section = 'A';
                }
                else
                {
                    student.section = 'B';
                }
            }
        }
    }
}
