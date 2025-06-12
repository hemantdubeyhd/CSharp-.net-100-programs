using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

//Very basic Authentification, there is immense space to improve about it..
//can improve atleast : Case sentitive??, strickly numeric password??, hide password??..and more...
//Most pathetic authentification I have ever see..lol..will come back after implementing basic services.
namespace ATM.Security
{
    internal class UserAuthenticator
    {

        private const string userId = "user";
        private const string userPassword = "12";
        int count = 0;
        public UserAuthenticator()
        {
            while (true)
            { 
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("User ID: "); 
                Console.ResetColor();
                string id = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Password: ");
                Console.ResetColor();
                string password = Console.ReadLine();
                count++;
                if(id == userId &&  password == userPassword)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("login Successful..");
                    Console.ResetColor();
                    return;
                }
                if(count >= 3)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Sorry...Too many wrong attempts..");
                    Console.ResetColor();
                    Environment.Exit(0);
                }

            }

            
        }
    }
}
