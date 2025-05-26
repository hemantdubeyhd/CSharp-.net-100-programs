// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using Students;

Student student1 = new Student();

InputStudentInfo inputStudentInfo = new InputStudentInfo();
inputStudentInfo.SetStudentInfo(student1);

SectionSetter sectionSetter = new SectionSetter();
sectionSetter.SettingSection(student1);

DisplayStudentInfo displayStudentInfo = new DisplayStudentInfo();
displayStudentInfo.Display(student1);
