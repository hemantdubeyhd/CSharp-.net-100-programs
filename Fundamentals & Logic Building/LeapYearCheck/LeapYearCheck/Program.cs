// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
int yearToCheck = EnterTheYear("Please eneter the year in yyyy formate");
CheckIfLeapYear(yearToCheck);
//Console.WriteLine(yearToCheck);

int EnterTheYear(string statement)
{
    Console.WriteLine($"{statement}");
    

    while (true)
    {
        string year = Console.ReadLine();
        if (int.TryParse(year, out int yearToCheck))
        {
            
            return yearToCheck;
        }
        else
        {
            Console.WriteLine("please neter the correct year in diguts/numbers in yyyy format");
        }
    }
}

void CheckIfLeapYear( int yearToCheck)
{
    if ((yearToCheck % 4 == 0) && (yearToCheck % 100 != 0 || yearToCheck % 400 == 0))
        {
        Console.WriteLine($"{yearToCheck} is a leap year");
    }
    else
    {
        Console.WriteLine($"{yearToCheck} is not a leap year");
    }
}
