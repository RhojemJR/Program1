using System;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
namespace Program1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int attempts = 3;

            while (attempts > 0)
            {
                Console.Write("Username:");
                String username = Console.ReadLine();
                Console.Write("Password:");
                String password = Console.ReadLine();

                if (username == "admin" && password == "admin1234!")
                {
                    Console.WriteLine("Welcome Admin!");
                    break;
                }
                else
                {
                    attempts--;
                    Console.WriteLine("Incorrect Username or Password.");
                }
                if (attempts == 0)
                    Console.WriteLine("Access Denied.");
            }
        }
    }
}
