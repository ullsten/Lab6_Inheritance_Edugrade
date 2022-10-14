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
            Dog dog = new Dog();
            Dog labrador = new Labrador();
            Dog bulldog = new BullDog();
            Cat cat = new Cat();
            Lion lion = new Lion();
            Human human = new Human();
            Reptiles reptiles = new();

            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("               _________________");
            Console.WriteLine("             <|                 |>");
            Console.WriteLine("             <|     THE ZOO     |>");
            Console.WriteLine("             <|_________________|>");
            Console.WriteLine();
            Console.WriteLine("    At the zoo you can see different animals, \n" +
                "   but when you first arrive at the zoo, you may\n" +
                "   hear some animal sounds from for exemple: ");
            Console.WriteLine("                /    |    |    \\");
            Console.WriteLine("              Dog " + "  Cat " + " Lion " + "Human ");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            dog.MakeSound();
            cat.MakeSound();
            lion.MakeSound();
            human.MakeSound();
            reptiles.MakeSound();
            Console.ResetColor();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("Don't be afraid! Most of them are in an enclosure!");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("Push to open door!(or just enter)");
            Console.ResetColor();
            Console.ReadLine();
            Console.WriteLine();
            AnimalMenu();
            Console.ReadLine();
        }
        public static void AnimalMenu()
        {
            bool program = true;
            do
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("|| Main entrance ||");
                Console.WriteLine();

                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("|#1|Mammal\n" +
                    "|#2|Reptiles\n" +
                    "|#3|Go home");
                Console.ResetColor();
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("What kind of animal do you want to see?");
                Console.ResetColor();
                bool answer = true;
                int animalChoise;
                if (Int32.TryParse(Console.ReadLine(), out animalChoise))

                    switch (animalChoise)
                    {
                        case 1:
                            Mammal();
                            answer = false;
                            break;
                        case 2:
                            Reptiles();
                            answer = false;
                            break;
                        case 3:
                            Console.WriteLine("Thank you for visiting, hope to see you again soon! ");
                            Environment.Exit(-1);
                            Console.ReadKey();
                            break;
                    }
                if (answer)
                {
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine("Make a choice 1-3");
                    Console.ResetColor();
                }
                Console.ReadKey();
            } while (program);
        }
        public static void Mammal() //Däggdjur
        {
            Dog dog = new Dog();
            Cat cat = new Cat();
            Labrador labrador = new Labrador();
            BullDog bulldog = new BullDog();
            Lion lion = new Lion();
            Human human = new Human();
            

            bool finished = false;
            do
            {
                Console.Clear();
                Console.WriteLine("|| Here are our mammals ||");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("|#1| Go west for Dogs\n" +
                    "|#2| Go East for Cats\n" +
                    "|#3| Go North for Human\n" +
                    "|#4| Main entranace\n" +
                    "|#5| Got home");
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("Choose your way to go and press enter");
                Console.ResetColor();
                int wayAnswer;
                if (Int32.TryParse(Console.ReadLine(), out wayAnswer)) ;
                switch (wayAnswer)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("We have two breeds running around!");
                        Console.WriteLine();
                        Console.WriteLine(labrador);
                        Console.WriteLine();
                        labrador.PrintAnimal();
                        Console.WriteLine();
                        Console.WriteLine("Oops, looks like someone is shy. A candy will help! (Enter)");
                        Console.ReadKey();
                        Console.WriteLine();
                        Console.Clear();                        
                        Console.WriteLine(bulldog);
                        Console.WriteLine();
                        bulldog.PrintAnimal();
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.WriteLine("||Tap to se mammal menu ||");
                        Console.ResetColor();
                        Console.ReadKey();
                        Mammal();
                        finished = true;
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine(" - - Cats at the Zoo - -");
                        CatMenu();
                        finished = true;
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine(human);
                        Console.WriteLine();
                        human.PrintAnimal();
                        finished = true;
                        break;
                    case 4:
                        Console.Clear();
                        Console.WriteLine("You are now at main entrance");
                        Console.WriteLine();
                        AnimalMenu();
                        finished = true;
                        break;
                    case 5:
                        Environment.Exit(-1);
                        break;

                }
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("|| A touch on enter to see the menu again ||");
                Console.ResetColor();
            } while (finished != true);
        }
        public static void Reptiles() //Reptiler
        {
            Reptiles reptiles = new Reptiles();

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("|| Here are our reptiles ||");
            Console.WriteLine();
            reptiles.PrintAnimal();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(reptiles);
            Console.WriteLine("");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("Enter to se menu again");
            Console.ResetColor();
            Console.WriteLine();
        }
        public static void CatMenu()
        {
            Lion lion = new Lion();
            Cat cat = new Cat();

            Cats:
            Console.WriteLine();
            int catChoose;
            do
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("|#1| Wild\n" +
                    "|#2| Tame\n" +
                    "|#3| Main entrance\n" +
                    "|#4| Go home");
                Console.ResetColor();
            } while (!Int32.TryParse(Console.ReadLine(), out catChoose));


            if (catChoose == 1) //Wild
            {
                Console.Clear();
                Console.WriteLine(lion);
                Console.WriteLine();
                lion.PrintAnimal();
                Console.WriteLine();
            }
            if (catChoose == 2) //Tame
            {
                Console.Clear();
                Console.WriteLine(cat);
                Console.WriteLine();
                cat.PrintAnimal();
                Console.WriteLine();
            }
            if (catChoose == 3)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("You are back at main entrance");
                Console.WriteLine();
                Console.ResetColor();
                AnimalMenu();

            }
            if (catChoose == 4)
            {
                Environment.Exit(-1);
            }
            else
            {
                goto Cats; //go back to Cats in case2
            }
        }
    }
}