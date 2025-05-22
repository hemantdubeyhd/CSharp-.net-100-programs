// See https://aka.ms/new-console-template for more information


using SumOfArray;

int sizeOfArray = InputHelper.ValidateTheSizeOFarray("Please enter the size of the array!");
int[] intArray = new int[sizeOfArray];

intArray = InputHelper.addingValuesToArrayAndValidation(intArray);
