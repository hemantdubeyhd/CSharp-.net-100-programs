// See https://aka.ms/new-console-template for more information
using ConstructorDemoApp;

Console.WriteLine("Hello, World!");
Student student1 = new Student();
Console.ReadKey();
Student student2 = new Student(1, "Qays");
Console.ReadKey();
student2.displayStudentInfo(student2);
