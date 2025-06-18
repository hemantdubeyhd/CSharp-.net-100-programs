// See https://aka.ms/new-console-template for more information

using PolymorphismDemoApp;

List<Person> persons = new List<Person>();

Console.WriteLine($" Cont: {persons.Count}, Capacity: {persons.Capacity}");
Console.ReadKey();
persons.Add(new Person { Id = 1, Name = "you" });

persons.Add(new Student { Id = 2, Name = "me", Course = "CS"});
persons.Add(new Teacher { Id = 3, Name = "us", Subject = "math" });
persons.Add(new Admin { Id = 4, Name = "who", Department = "IT" });
Console.WriteLine($" Cont: {persons.Count}, Capacity: {persons.Capacity}");
Console.ReadKey();
foreach (Person person in persons)
{
    person.DipslayInfo();
}