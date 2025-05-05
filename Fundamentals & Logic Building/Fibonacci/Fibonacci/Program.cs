// See https://aka.ms/new-console-template for more information
using Fibonacci;
int NumberOfTermsToPrint = InputHelper.GetAValidNumber("Please enter a number between 2 and 92.");
//Console.WriteLine(NumberOfTermsToPrint);
FibonacciSeries.printFibnacci(NumberOfTermsToPrint);
