using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb6_Arv
{
    public class Lion : Animal
    {
        protected string protective { get; set; } //Special property for Lion
        public Lion()
        {
            this.name = "Lion";
            this.weight = 190; //for male
            this.age = 20;
            this.power = 9;
            this.greet = "'Mew mew'";
            this.protective = "I will protect my territory!"; //Default value special property
        }
        public override void PrintAnimal()
        {
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write(name + " sound: ");
            MakeSound();
            Console.ResetColor();
        }
        public override void MakeSound()
        {
            Console.WriteLine("'Grraaaauuuu Grraaaauuuu!'");
        }
        public override void Eat()
        {
            Console.WriteLine("We are carnivores, I like meat!");
        }
        public override void Sleep()
        {
            Console.WriteLine("'ZZzzzzZZZzzzzZZZZ'");
        }
        public override void Drink()
        {
            Console.WriteLine("It´s water we like!");
        }
        protected void Killing() //Special method for Lion
        {
            Console.WriteLine("I´m very good at killing my prey!");
        }
    }
}
