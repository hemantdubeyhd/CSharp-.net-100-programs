// See https://aka.ms/new-console-template for more information
using ReverseAnArray;
;

int sizeOfArray = InputHelper.ValidateTheSizeOfArray("Please enter the size of the array!");
int[] intArray = new int[sizeOfArray];

intArray = InputHelper.addingValuesToArrayAndValidation(intArray);
PrintTheArray.PrintingTheArray(intArray);

ReverseTheArray.ReverseingTheArray(intArray);

//int sum = AddTheElementsOfTheArray.AddingTheElementsOfArray(intArray);

//Console.WriteLine($"Total = {sum}");

