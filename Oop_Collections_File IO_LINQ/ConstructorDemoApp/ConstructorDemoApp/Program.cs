// See https://aka.ms/new-console-template for more information
using ConstructorDemoApp;


//Default constructor
Student student1 = new Student();
student1.displayInfo();
Console.ReadKey();


//Parameterised Constuctor
try
{
    Student student2 = new Student(1, "");
    student2.displayInfo();

}
catch(Exception ex)
{
    Console.WriteLine($"Error creating student: {ex.Message}"); 
}
Console.ReadKey();
