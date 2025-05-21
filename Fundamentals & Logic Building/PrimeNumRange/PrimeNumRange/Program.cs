// See https://aka.ms/new-console-template for more information
using PrimeNumRange;

int lowerIndex = InputHelper.checkTheNumberIfPrime("Please enter the lower index of range > 1");

int upperIndex = InputHelper.checkTheNumberIfPrime($"Please enter the upper index of range > {lowerIndex}");

CheckPrimeNumberInEnteredRange.checkingIfNumberIsPrime(lowerIndex, upperIndex);