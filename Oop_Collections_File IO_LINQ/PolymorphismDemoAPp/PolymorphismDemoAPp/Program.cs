// See https://aka.ms/new-console-template for more information

using PolymorphismDemoApp;

List<Person> persons = new List<Person>();
Student student = new Student { Id = 2, Name = "me", Course = "CS" };
student.scores.Add(new SubjectScore { SubjectName = "C#", Score = 99 });
student.scores.Add(new SubjectScore { SubjectName = "OOP", Score = 99 });

persons.Add(new Person { Id = 1, Name = "you" });

persons.Add(student);
persons.Add(new Teacher { Id = 3, Name = "us", Subject = "math" });
persons.Add(new Admin { Id = 4, Name = "who", Department = "IT" });
foreach (Person person in persons)
{
    person.DipslayInfo();
}
Console.ReadKey();