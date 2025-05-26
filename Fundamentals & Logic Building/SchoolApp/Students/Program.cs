// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using Students;

Student student1 = new Student();

InputStudentInfo inputStudentInfo = new InputStudentInfo();
inputStudentInfo.SetStudentInfo(student1);

Console.WriteLine(student1.name);
Console.WriteLine(student1.age);

SectionSetter sectionSetter = new SectionSetter();

sectionSetter.SettingSection(student1);

Console.WriteLine(student1.name);
Console.WriteLine(student1.age);
Console.WriteLine(student1.section);

