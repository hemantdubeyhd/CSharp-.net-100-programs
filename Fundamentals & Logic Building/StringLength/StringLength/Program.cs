// See https://aka.ms/new-console-template for more information
using StringLength;


string stringToCheckLenghtOf = InputHelper.receivingAString("Please Eneter a String");

int lenthOftheString = FindStringLength.findingTheLenghtOfTheString(stringToCheckLenghtOf);

Console.WriteLine(lenthOftheString);