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
            this.name = name;
            this.weight = weight;
            this.age = age;
            this.power = power;
            this.greet = greet; 
            this.gender = gender;
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
            Console.WriteLine("This is the place where we grow plants for different purposes!\n" +
                "Most of all, we grow to provide food for our animals, but also for medicinal purposes!");
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
            Console.WriteLine("Plants can help you to recover from ilness faster, but also be food." +
                "our animal looooove to eat plants!");
        }
        public override string ToString()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            return String.Format("Race: {0}\nName: {1}\nGender: {2}\nWeight: {3} kg\nAge: {4} year\nPower: {5}/10\nGreet: {6}",
            this.GetType().Name,
            this.name,
            this.gender,
            this.weight,
            this.age,
            this.power,
            this.greet);
            Console.ResetColor();
        }
    }

}
