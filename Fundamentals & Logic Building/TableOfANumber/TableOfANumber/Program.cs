// See https://aka.ms/new-console-template for more information
using TableOfANumber;
Console.WriteLine("Hello, World!");
int number = InputHelper.GetAValidNumber("Please enter anumber");
//Console.WriteLine($"number enterd: {number}");
PrintTheTable.PrintTheTableOfANumber(number);
