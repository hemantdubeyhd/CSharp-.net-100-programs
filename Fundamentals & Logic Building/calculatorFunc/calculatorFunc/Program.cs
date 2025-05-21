// See https://aka.ms/new-console-template for more information
using CalculatorFunc;
using System.Xml.Serialization;


string choice = "n";

while(choice.ToLower() != "q")
{
    Console.WriteLine("Please select from the following option:");
  
    
    Console.WriteLine("Press + for addition");
    Console.WriteLine("Press - for Subtraction");
    Console.WriteLine("Press * for multiplication");
    Console.WriteLine("Press / for division");

    choice = Console.ReadLine();

    if (choice == "+")
    {
        AdditionOfTwoNumbers.addingTwoNumbers();
    }
}