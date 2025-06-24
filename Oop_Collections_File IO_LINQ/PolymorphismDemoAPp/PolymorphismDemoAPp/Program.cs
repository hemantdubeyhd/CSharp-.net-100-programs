// See https://aka.ms/new-console-template for more information


//***before refactoring the code code:


//using PolymorphismDemoApp.Models;

//List<Person> persons = new List<Person>();
//Student student = new Student { Id = 2, Name = "Student", Course = "CS" };
//student.scores.Add(new SubjectScore { SubjectName = "C#", Score = 99 });
//student.scores.Add(new SubjectScore { SubjectName = "OOP", Score = 99 });

//persons.Add(new Person { Id = 1, Name = "you" });

//persons.Add(student);
//persons.Add(new Teacher { Id = 3, Name = "Teacher", Subject = "math" });
//persons.Add(new Admin { Id = 4, Name = "Admin", Department = "IT" });
//foreach (Person person in persons)
//{
//    person.DipslayInfo();
//}
//Console.ReadKey();



//***after refactoring the code code:

using PolymorphismDemoApp.Manager;
using PolymorphismDemoApp.Models;

PersonRepository personRepo = new PersonRepository();
List<Person> people = personRepo.GetAllPeople();
Console.ReadKey();