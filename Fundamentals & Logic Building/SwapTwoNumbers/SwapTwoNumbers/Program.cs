// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
int num1, num2, temp;
Console.WriteLine("please enter the first number");
if (!(int.TryParse(Console.ReadLine(), out num1)))
{
    exitEnvironment();
}



if (!(int.TryParse(Console.ReadLine(), out num2)))
{
    exitEnvironment();

}

Console.WriteLine($" Before swapping \n num1 = {num1}, num2 = {num2}");

temp = num1;
num1 = num2;
num2= temp;

Console.WriteLine($" After swapping \n num1 = {num1}, num2 = {num2}");

void exitEnvironment()
{
    Console.WriteLine("Run program again and Please enter a valid number");
    Environment.Exit(0);
}

