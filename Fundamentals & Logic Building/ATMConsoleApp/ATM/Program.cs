// See https://aka.ms/new-console-template for more information
using ATM.Enums;
using ATM.Security;
using ATM.Services;
using ATM.Models;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Serialization;

//UserAuthenticator userAuthenticator = new UserAuthenticator();
Account account = new Account(1000);
BalanceService balanceService = new BalanceService();
balanceService.DisplayBalance(account, "Opening Balance is");
Console.ReadKey();
while (true)
{
    Console.Clear();
    Console.WriteLine("Pleasse select one of the operation:");
    Console.WriteLine($"Press {(int)ATMMenuOption.CheckBalance} to Check Balance.");
    Console.WriteLine($"Press {(int)ATMMenuOption.Deposit} to depsosite.");
    Console.WriteLine($"Press {(int)ATMMenuOption.Withdraw} to withdraw.");
    Console.WriteLine($"Press {(int)ATMMenuOption.Exit} to Exit");
   
    string input = Console.ReadLine();
    
    if (int.TryParse(input, out int choice))
    {
        if (Enum.IsDefined(typeof(ATMMenuOption), choice))
        {
            ATMMenuOption selectedOption = (ATMMenuOption)choice;
            switch (selectedOption)
            {
                case ATMMenuOption.OpenAccount:
                    Console.WriteLine("Case 1");
                    break;
                case ATMMenuOption.CheckBalance:
                    Console.WriteLine("Case 1");
                    break;
                case ATMMenuOption.Deposit:
                    Console.WriteLine("Case 2");
                    break;
                case ATMMenuOption.Withdraw:
                    Console.WriteLine("Case 3");
                    break;
                case ATMMenuOption.Exit:
                    Console.WriteLine($"Closing the app and logging off on {DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss")}....Thanks!! ");
                    Environment.Exit(0);
                    break;
            }
            
        }
        else
        {
            Console.WriteLine($"{choice} is not a valid option, please read carefully and select, press any key to continue...");

            Console.ReadKey();

        }
    }
    else
    {
        Console.WriteLine("Please eneter a valid choice!!!");
        Console.ReadKey();
    }


}

