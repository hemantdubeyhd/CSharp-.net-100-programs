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
        else
        {
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Case 1");
                    break;
                case 2:
                    Console.WriteLine("Case 2");
                    break;
                case 3:
                    Console.WriteLine("Case 3");
                    break;
                case 4:
                    Console.WriteLine("Closing the app and logging off....Thanks!! ");
                    Environment.Exit(0);
                    break;
            }
          
        }
    }
    else
    {
        Console.WriteLine("Please eneter a valid choice!!!");
    }


}
