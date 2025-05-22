// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using LargestInArray;

int sizeOfArray = InputHelper.ValidateTheSizeOfArray("Please enter the size of the array!");
int[] intArray = new int[sizeOfArray];

intArray = InputHelper.addingValuesToArrayAndValidation(intArray);
ArrayPrinter.PrintingTheArray(intArray);
ArrayMaxFinder.findingTheLargestInArray(intArray);
