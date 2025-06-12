using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

//Very basic Authentification, there is immense space to improve about it..
//can improve atleast : Case sentitive??, strickly numeric password??, hide password??..and more...
namespace ATM.Security
{
    internal class UserAuthenticator
    {

        private const string userId = "Stall";
        private const string userPassword = "1234";
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
