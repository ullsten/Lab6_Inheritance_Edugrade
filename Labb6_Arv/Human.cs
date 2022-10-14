using Labb6_Arv;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb6_Arv_Zoo
{
    public class Human : Animal
    {
        protected string smart = "We are at the top of the hierarchy"; //Special property for human
        public Human()
        {
            this.name = "What ever you want";
            this.weight = 0; //for male
            this.age = 100;
            this.power = 8;
            this.greet = "'Hello, Hi, Nice to meet you'";
            this.gender = gender;
            this.smart = "We are smart, therefore we can live in space!"; //default value speckial property
        }
        public Human(string name, int weight, int age, int power, string greet, string smart, string gender) : base(name, weight, age, power, greet, gender)
        {
            this.smart = smart;
        }

        public override void PrintAnimal()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Eat();
            Drink();
            Brains();
            Sleep();
            Console.ResetColor();
        }
        public override void MakeSound()
        {
            Console.WriteLine("Human say: Welcome! Did you hear the animals? Come in and see more!");
        }
        public override void Eat()
        {
            Console.WriteLine("We eat almost everything, it's your limits that determine food!");
        }
        public override void Sleep()
        {
            Console.WriteLine("We need to sleep 6-8h day!");
        }
        public override void Drink()
        {
            Console.WriteLine("Without water we vill die!");
        }
        protected void Brains() //Special method for human
        {
            Console.WriteLine("The human has a big brain, therefore we can invent things.");
        }
        public override string ToString()
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            return String.Format("Race: {0}\nName: {1}\nWeight: {2}-450kg\nAge: {3}+\nPower: {4}/10\nGreet: {5}\nUniquely for human: {6}",
             this.GetType().Name,
             this.name,
             this.weight,
             this.age,
             this.power,
             this.greet,
             this.smart);
            Console.ResetColor();
        }
    }
}
