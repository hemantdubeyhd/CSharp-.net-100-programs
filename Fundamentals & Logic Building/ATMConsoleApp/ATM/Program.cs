// See https://aka.ms/new-console-template for more information
using ATM.Enums;
using ATM.Helpers;
using ATM.Security;
using ATM.Services;
using ATM.Models;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Serialization;

//UserAuthenticator userAuthenticator = new UserAuthenticator();
Account account = null;
while (true)
{
    Console.WriteLine("Pleasse select one of the operation:");
    Console.WriteLine($"Press {(int)ATMMenuOption.OpenAccount} to Open a new account.");
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
                    if(account != null)
                    {
                        Console.WriteLine("You already have an Account");
                       
                    }
                    else
                    {
                        account = new Account(1000);
                        ATM.Services.BalanceService.DisplayBalance(account);
                    }
                    ConsoleHelper.Pause();
                    break;


                case ATMMenuOption.CheckBalance:
                  if(account == null)
                    {
                        Console.WriteLine("You don's have an account yet..");
                    }
                    else
                    {
                        ATM.Services.BalanceService.DisplayBalance(account);
                    }
                    ConsoleHelper.Pause();
                    break;


                case ATMMenuOption.Deposit:
                    if (account == null)
                    {
                        Console.WriteLine("You don's have an account yet..");
                    }
                    else
                    { 
                        DepositService.deposit(account);
                    }
                    ConsoleHelper.Pause();
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

