// See https://aka.ms/new-console-template for more information

using Calculator;
using System.Diagnostics;
//Console.WriteLine("Hello, World!");

//this simple program calcultes addition substration dicision and multiplication:
//here we are asking for only two number for whatever operation user chose, not ideal but this is just to learn switch case.
//in future on the basis of operation we can ask multple inputes for add, sub andmul but only two for div
//Also in fiuture we can check if divident is zero if person has enterd zero,
//also can check if any of the number for multiplication is 0, warn user.
String quitYesNo;
int choice = -1;
while (choice != 0)
{
    Console.WriteLine("Press 1 for Addition");
    Console.WriteLine("Press 2 for Substraction");
    Console.WriteLine("Press 3 for multiply");
    Console.WriteLine("Press 4 for Division (first 1st by 2nds number");
    Console.WriteLine("Press 0 to quit");
    quitYesNo = Console.ReadLine();
    int.TryParse(quitYesNo, out choice);
}

//int num1 =InputAndInputValidation.getValidNumber("Enter the first number", choice);
//int num2 = InputAndInputValidation.getValidNumber("Enter the second number", choice);

