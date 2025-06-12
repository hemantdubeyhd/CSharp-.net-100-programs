// See https://aka.ms/new-console-template for more information
using ATM.Security;
using System.Xml.Serialization;

UserAuthenticator userAuthenticator = new UserAuthenticator();

while (true)
{
    Console.Clear();
    Console.WriteLine("Pleasse select one of the operation:");
    Console.WriteLine("Press 1 to Check Balance.");
    Console.WriteLine("Press 2 to Deposite.");
    Console.WriteLine("Press 3 For Withdrawal.");
    Console.WriteLine("Press 4 to Exit the Menu.");
    string input = Console.ReadLine();

    
    if (int.TryParse(input, out int choice))
    {
        if (choice < 1 || choice > 4)
        {
            Console.WriteLine($"{choice} is not a valid option, please read carefully and select, press any key to continue...");

            Console.ReadLine();
        }
        else {
            if(choice == 4)
            {
                Environment.Exit(0);
            }
        }
    }
    else
    {
        Console.WriteLine("Please eneter a valid choice!!!");
    }


}
