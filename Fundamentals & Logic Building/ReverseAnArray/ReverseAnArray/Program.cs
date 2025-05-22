// See https://aka.ms/new-console-template for more information
using ReverseAnArray;


int sizeOfArray = InputHelper.ValidateTheSizeOfArray("Please enter the size of the array!");
int[] intArray = new int[sizeOfArray];

intArray = InputHelper.addingValuesToArrayAndValidation(intArray);
PrintTheArray.PrintingTheArray(intArray);

ArrayReverser.ReversingTheArray(intArray);


