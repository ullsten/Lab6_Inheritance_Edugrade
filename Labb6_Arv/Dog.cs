using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Labb6_Arv
{

    public class Dog : Animal
    {
        protected string help { get; set; } //special property for dog
        public Dog()
        {   //Default values for class Dog - no value = values from baseclass shows
            this.name = "DOG";
            this.weight = 161;
            this.age = 20;
            this.power = 7;
            this.greet = "'Bark bark bark'";
            this.help = "I like to help"; //Default value speceial property
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
            Console.WriteLine("'Woof Woof Woof' I am a " + name + "!");
        }
        public override void Eat()
        {
            //base.Eat();
            Console.WriteLine("Dog eats dog food!");
        }
        public override void Sleep()
        {
            Console.WriteLine("'ZZzzzzZZZzzzzZZZZ'");
        }
        public override void Drink()
        {
            Console.WriteLine("Dogs drink differnt things like fresh juices, coconut water. But most of the time we just drin water.");
        }
        protected void Fetch(string thing) //Special method for dog
        {
            Console.WriteLine("I like to play with my " + thing + " when i´m outside!");
        }        
    }

    //-----------------------------------------------------------------------------

    public class Labrador : Dog
    {
        protected string Friendly { get; set; } //Special property
        public Labrador()
        {
            this.name = "Samy";
            this.Friendly = "We are very friendly and good with kids!"; //default value special property
        }
        
        public override void PrintAnimal()
        {
            Console.WriteLine("I´m a Labrador and my name is " + name + "!");
            MakeSound();
        }
        public override void MakeSound()
        {
            Console.WriteLine("This is my sound 'OhhVovvoff ohhvovoff'");
        }
        public override void Eat()
        {
            //base.Eat(); //To call and show from base.Eat();
            Console.WriteLine("I like to eat lean meats and fish, but I also like to eat fruits and vegetables!");
        }
        public override void Sleep()
        {
            Console.WriteLine("'ZZzzzzZZZzzzzZZZZ'");
        }
        public override void Drink()
        {
            Console.WriteLine("slurp slurp slurp I drink water!");
        }        
        protected void Traing() //Special method for Labrador
        {
            Console.WriteLine("I can be trained to become a therapy and service dog!");
        }

    }   //--------------------------------------------------------------------------------------

    public class BullDog : Dog
    {
        protected string Courage { get; set; } //Special property
        public BullDog()
        {
            this.name = "Fletcher";
            this.Courage = "I have reputation for courage, therefore I can be your watchdog!"; 
        }
        public override void PrintAnimal() 
        {
            Console.WriteLine("I´m a BullDog and my name is " + name + "!");
            MakeSound();
        }
        public override void MakeSound()
        {
            Console.WriteLine("Blaff Blaff Woof Woof");
            
        }
        public override void Eat()
        {
            Console.WriteLine("I like to eat pork, chicken and lamb. But sometimes I eat vegetables!");
        }
        public override void Sleep()
        {
            Console.WriteLine("'ZZzzzzZZZzzzzZZZZ'");
        }
        public override void Drink()
        {
            Console.WriteLine("slurp slurp slurp I drink water!");
        }
        protected void Watch() //Special method for BullDog
        {
            Console.WriteLine("If I become yours, I will guard you!"); 
        }

    }
}    



