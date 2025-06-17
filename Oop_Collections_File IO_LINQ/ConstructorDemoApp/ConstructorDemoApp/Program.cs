// See https://aka.ms/new-console-template for more information
using ConstructorDemoApp;


//Default constructor
Student student1 = new Student();
student1.displayInfo();
Console.ReadKey();


//Parameterised Constuctor
Student student2 = new Student(1, "Qays");
student2.displayInfo();
Console.ReadKey();
