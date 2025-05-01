// See https://aka.ms/new-console-template for more information

using Calculator;
using System.Diagnostics;
//Console.WriteLine("Hello, World!");

//this simple program calcultes addition substration dicision and multiplication:
//here we are asking for only two number for whatever operation user chose, not ideal but this is just to learn switch case.
//in future on the basis of operation we can ask multple inputes for add, sub andmul but only two for div
//Also in fiuture we can check if divident is zero if person has enterd zero,
//also can check if any of the number for multiplication is 0, warn user.
String quitYesNo;
int choice = -1;
while (choice != 0)
{
    Console.Clear();
    Console.WriteLine("Press 1 for Addition");
    Console.WriteLine("Press 2 for Substraction");
    Console.WriteLine("Press 3 for multiply");
    Console.WriteLine("Press 4 for Division (first 1st by 2nds number");
    Console.WriteLine("Press 0 to quit");
    quitYesNo = Console.ReadLine();
    int.TryParse(quitYesNo, out choice);
    Console.WriteLine($"Choice entered is {choice}");

    if (choice != 0 && choice != 1 && choice != 2 && choice != 3 && choice != 4)
    {
        Console.WriteLine("\nSelction does not match with options available\n Press anykey to continue.");
        Console.ReadLine();
        
        continue;
    }
    int num1 = InputAndInputValidation.getValidNumber("Enter the first number");
    int num2 = InputAndInputValidation.getValidNumber("Enter the second number");

    



    switch (choice)
    {
        case 1:
            Console.WriteLine($"{num1 + num2}");
            Console.Read();
            break;

        case 2:
            Console.WriteLine($"{num1 - num2}");
            Console.Read();

            break;

        case 3:
            Console.WriteLine($"{num1 * num2}");
            Console.Read();

            break;
        case 4:
            if(num2 == 0)
            {
                Console.WriteLine("Undefined: Deviding any number by zero is undefined, please start again");
                Console.Read();

                continue;
            }
    
            Console.WriteLine($"{num1 /num2}");
            Console.Read();

            break;
            

    }
}

