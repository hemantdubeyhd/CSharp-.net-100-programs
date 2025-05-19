using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringLength
{
    internal static class InputHelper
    {
       
            public static string receivingAString(string statement)
            {
                Console.WriteLine(statement);
                string str;
                while (true)
                {
                    str = Console.ReadLine();
                    if (string.IsNullOrEmpty(str) || string.IsNullOrWhiteSpace(str))
                    {
                        Console.WriteLine("Please enter a valid string");
                    }
                    else
                    {
                        return str;
                    }
                }
            }
        }
    }

