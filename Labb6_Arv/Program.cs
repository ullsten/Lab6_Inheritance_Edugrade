using Labb6_Arv;

namespace Labb6_Arv_Zoo
{
    public class Program
    {
        static void Main(string[] args)
        {
            Animal beast = new Animal();
            Dog Dog = new Dog();
            Dog Labrador = new Labrador();
            Dog BullDog = new BullDog();
            Cat Cat = new Cat();
            Lion Lion = new Lion();
            Human Human = new Human();
                       
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
            Console.WriteLine("Don't be afraid now. They are quite kind:");
            Dog.MakeSound();
            Cat.MakeSound();
            Lion.MakeSound();
            Human.MakeSound();





            //Console.WriteLine();
            //beast.PrintAnimal();
            //Console.WriteLine();
            //Dog.PrintAnimal();
            //Console.WriteLine();
            //Labrador.PrintAnimal();
            //Console.WriteLine();
            //BullDog.PrintAnimal();
            //Console.WriteLine();
             //Cat.PrintAnimal();
            //Console.WriteLine();
            //Lion.PrintAnimal();
            //Console.WriteLine();
            //Human.PrintAnimal();

 

            Console.ReadLine();
        }
        public void AnimalMenu()
        {

        }
    }
}