using Labb6_Arv;
using System;
using System.Linq.Expressions;
using System.Security.Cryptography;

namespace Labb6_Arv_Zoo
{
    public class Program
    {
        static void Main(string[] args)
        {
            Menu menu = new Menu();

            Console.WriteLine("Welcome! Whats your name? ");
            string username = Console.ReadLine();
            Console.WriteLine("How old are you? ");
            int age = int.Parse(Console.ReadLine());
            
                if (age < 18)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Welcome " + username + "!\n" +
                        "Unfortunately, you are not allowed to stay in the bar, due to your age: " + age + " year!");
                    Console.ResetColor();
                }
                if (age >= 18)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Welcome " + username + "!\n" +
                        "Your age of " + age + " year is good for a drink in the bar after the tour! ");
                    Console.ResetColor();
                }
            Console.WriteLine();
            Console.WriteLine("Sit back and wait to be driven out into the jungle!\n" +
                "I hope you have a nice trip!");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("* Open your car door and go through the tunnel and you will see the main entrance *");
            Console.ResetColor();
            Console.ReadKey();
            Console.Clear();
            menu.RunZoo();
            
            
        }
        
    }
}