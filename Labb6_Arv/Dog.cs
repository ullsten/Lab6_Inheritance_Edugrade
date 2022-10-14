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
            this.gender = gender;
        }
        public Dog(string name, int weight, int age, int power, string greet, string help, string gender) : base(name, weight, age, power, greet, gender)
        {
            this.help = help;
            
        }

        public override void PrintAnimal()
        {
            Console.Write(name + " sound: ");
            MakeSound();

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
        public override string ToString()
        {
            return String.Format("{0} Name: {1} Weight: {2} Age: {3} Power: {4} Greet",
            this.GetType().Name,
            this.name,
            this.weight,
            this.age,
            this.power,
            this.greet);

        }
    }

    //-----------------------------------------------------------------------------

    public class Labrador : Dog
    {
        protected string friendly { get; set; } //Special property
        public Labrador()
        {
            this.name = "Samy";
            this.greet = greet;
            this.weight = 28;
            this.age = 4;
            this.power = 5;
            this.friendly = "We are very friendly and good with kids"; //default value special property
            this.gender = "female";
        }
        public Labrador(string name, int weight, int age, int power, string greet, string help, string friendly, string gender) : base(name, weight, age, power, greet, help, gender)
        {
            this.friendly = friendly;
            this.gender = gender;
        }
        
        public override void PrintAnimal()
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Eat();
            Drink();
            UsedAs();
            Sleep();
            Console.ResetColor();
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
            Console.WriteLine("After training,  I like to sleep 'ZZzzzzZZZzzzzZZZZ'");
        }
        public override void Drink()
        {
            Console.WriteLine("Slurp slurp slurp I drink water when I am thirsty!");
        }        
        protected void UsedAs() //Special method for Labrador
        {
            Console.WriteLine("I can be trained to become a therapy and service dog!");
        }
        public override string ToString()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            return String.Format("Race: {0}\nName: {1}\nGender: {2}\nWeight: {3} kg\nAge: {4} year\nPower: {5}/10\nGreet: {6}\nMentality: {7}",
            this.GetType().Name,
            this.name,
            this.gender,
            this.weight,
            this.age,
            this.power,
            this.greet,
            this.friendly);
            Console.ResetColor();
        }
    }   //--------------------------------------------------------------------------------------
    public class BullDog : Dog
    {
        protected string courage { get; set; } //Special property
        public BullDog()
        {            
            this.name = "Fletcher";
            this.greet = greet;
            this.weight = 23;
            this.age = 4;
            this.power = 8;            
            this.courage = "I have reputation for courage, therefore I can be your watchdog!";
            this.gender = "male";            
        }
        public BullDog(string name, int weight, int age, int power, string greet, string courage, string help, string gender) : base(name, weight, age, power, greet, help, gender)
        {
            this.courage = courage;
            this.gender = gender;            
        }

        public override void PrintAnimal() 
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Eat();
            Drink();
            Watch();
            Sleep();
            Console.ResetColor();
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
            Console.WriteLine("When I'm not guarding you, I like to sleep 'ZZzzzzZZZzzzzZZZZ'");
        }
        public override void Drink()
        {
            Console.WriteLine("Slurp slurp slurp I love drink water!");
        }
        protected void Watch() //Special method for BullDog
        {
            Console.WriteLine("I will guard you with my life "); 
        }
        public override string ToString()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            return String.Format("Race: {0}\nName: {1}\nGender: {2}\nWeight: {3} kg\nAge: {4} year\nPower: {5}/10\nGreet: {6}\nCourage: {7}",
            this.GetType().Name,
            this.name,
            this.gender,
            this.weight,
            this.age,
            this.power,
            this.greet,
            this.courage);
            Console.ResetColor();
        }

    }
}    



