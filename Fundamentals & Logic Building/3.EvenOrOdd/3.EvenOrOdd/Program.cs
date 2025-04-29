// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


int num = GetValidNumber("Please enter a number");
CheckEvenOrOdd(num);
//Console.WriteLine(num);

int GetValidNumber(string statement)
{
    Console.WriteLine(statement);
    while (true)
    {
       
        string input = Console.ReadLine();

        if (int.TryParse(input, out int validNumber))
        {
            return validNumber;
        }
        else
        {
            Console.WriteLine("Please enter a valid number");
        } 
    }
}

void CheckEvenOrOdd(int num)
{
    Console.WriteLine($"You enterd {num}, which is an {(num % 2 ==0 ? "Even" : "Odd")} number");
    //if (num % 2 == 0)
    //{
    //    Console.WriteLine("User has enterd an even number");
    //}
    //else
    //{
    //    Console.WriteLine("User has entered a odd number");
    //}
}