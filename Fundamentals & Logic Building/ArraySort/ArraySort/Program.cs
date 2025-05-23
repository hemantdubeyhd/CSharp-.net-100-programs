// See https://aka.ms/new-console-template for more information
using ArraySort;

int sizeOfArray = InputHelper.ValidateTheSizeOfArray("Please enter the size of the array!");
int[] intArray = new int[sizeOfArray];

intArray = InputHelper.addingValuesToArrayAndValidation(intArray);


ArrayPrinter.PrintingTheArray(intArray);
Console.WriteLine();

ArrayBubbleSort.BubbleSortingAnArray(intArray);
ArrayPrinter.PrintingTheArray(intArray);
