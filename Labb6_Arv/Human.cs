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
            this.name = "Human";
            this.weight = 450; //for male
            this.age = 122;
            this.power = 8;
            this.greet = "'Hello, Hi, Nice to meet you'";
            this.smart = "We are smart, therefore we can live in space!"; //default value speckial property
        }
        public override void PrintAnimal()
        {
            Console.Write(name + " sound: ");
            MakeSound();
        }
        public override void MakeSound()
        {
            Console.WriteLine("Hello! I can speek so you understand me!");
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
    }
}
