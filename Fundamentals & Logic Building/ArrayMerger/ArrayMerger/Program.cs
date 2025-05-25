// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using ArrayMerger;

int size = InputHelper.ValidateTheSizeOfArray("Please Enter the size of the first array");
int[] array1 = new int[size];

Console.WriteLine("Please eneter the elements of first Array");
InputHelper.addingValuesToArray(array1);


size = InputHelper.ValidateTheSizeOfArray("Please Enter the size of the second array");
int[] array2 = new int[size];

Console.WriteLine("Please eneter the elements of first Array");
InputHelper.addingValuesToArray(array2);

int[] mergedArray = new int[size + array1.Length];

//Console.WriteLine($"Lenght of merged array is {mergedArray.Length}");