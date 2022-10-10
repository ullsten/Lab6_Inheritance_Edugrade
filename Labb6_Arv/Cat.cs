using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb6_Arv
{
    public class Cat : Animal
    {
        protected string jump { get; set; } //Special property
        public Cat()
        {
            this.name = "Cat";
            this.weight = 11;
            this.age = 20;
            this.power = 5;
            this.greet = "'Mew mew'";
            this.jump = "We can jump high"; //Default value special property

        }
        public override void PrintAnimal()
        {
            Console.Write(name + " sound: ");
            MakeSound();
            Console.ResetColor();

        }
        public override void MakeSound()
        {
            Console.WriteLine("'Meow Meow Meow'");
        }
        public override void Eat()
        {
            Console.WriteLine("If you give me some fish, I will love you!");
        }
        public override void Sleep()
        {
            Console.WriteLine("'ZZzzzzZZZzzzzZZZZ'");
        }
        public override void Drink()
        {
            Console.WriteLine("Just give us water to drink!");
        }
        protected void Climb() //Special method for Cat
        {
            Console.WriteLine("We can climb a tree!");
        }
    }
    
    
}
