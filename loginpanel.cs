using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication13
{
    class Program
    {
        static void Main(string[] args)
        {
            string a, b;
            Console.WriteLine("wellcome to login panel! enter your Email and password below:");
            Console.WriteLine("Email address:");
            a = Console.ReadLine();
            if (a != "admin@gmail.com")
            {
                Console.WriteLine("invalid Email");
            }
            else
                Console.WriteLine("enter your password:");
            b = Console.ReadLine();
            if (b != "nsj#928")
            {
                Console.WriteLine("invalid password");
            }
            else
                Console.WriteLine("wellcome back, admin!");
            Console.ReadKey();

            }
        }
    }

