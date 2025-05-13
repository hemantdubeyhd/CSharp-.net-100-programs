// See https://aka.ms/new-console-template for more information
using Palindrome;

//We are here for the sake of just the logic learning, not checking if user has eneterd negative numebrs, negatiev numbers cant be palindrome.
int numberToCheckIfPalindrom = InputHelper.GetAValidNumber("Eneter a number please");
CheckingPalindrome.CheckIfPalindrome(numberToCheckIfPalindrom);