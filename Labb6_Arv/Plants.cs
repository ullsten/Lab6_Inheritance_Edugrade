using Labb6_Arv;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb6_Arv_Zoo
{
    public class Plants : Animal
    {
        public string grow { get; set; }
        public Plants()
        {
            this.name = "Depends what you grow!";
            this.weight = 100;
            this.age = 0;
            this.power = 10;
            this.greet = "In the wind you can hear us!"; 
            this.gender = "We have no gender!";
            this.grow = grow;
        }        
        public Plants(string name, int age, int weight, int power, string greet, string gender, string grow) : base(name, weight, age, power, greet, gender)
        {
            this.grow = grow;
        }
        public override void PrintAnimal()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Welcome to our garden!");
            Console.ResetColor();
            Console.WriteLine();
            Console.WriteLine("This is the place where we grow plants for different purposes!");
            Recover();
            Console.WriteLine();
            MakeSound();
        }
        public override void MakeSound()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("You can listen to our sound when the wind blows: wiieeeeiwwwwwiiiiee");
            Console.ResetColor();
        }
        public void Recover()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Plants can help you to recover from ilness faster, but also be food." +
                " Our animal looooove to eat plants!");
            Console.ResetColor();
        }
        public override string ToString()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            return String.Format("Race: {0}\nName: {1}\nWeight: {2} kg ++\nAge: {3} year++\nPower: {4}/10\nGreet: {5}",
            this.GetType().Name,
            this.name,
            this.weight,
            this.age,
            this.power,
            this.greet);
            Console.ResetColor();
        }
    }

}
