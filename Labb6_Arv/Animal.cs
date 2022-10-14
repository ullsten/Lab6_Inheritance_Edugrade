using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb6_Arv
{
    public abstract class Animal //BaseClass
    {

        //characteristics
        protected string name { get; set; } //Can also set default value here
        protected int weight { get; set; }
        protected int age { get; set; }
        protected int power { get; set; }
        protected string greet { get; set; }
        protected string gender { get; set; }
        public Animal() //Constructor default values
        {
            this.name = "NoName";
            this.weight = int.MaxValue;
            this.age = int.MaxValue;
            this.power = 10;
            this.greet = "NoGreet";
            this.gender = "Male/Female";
        }

        public Animal(string name, int weight, int age, int power, string greet, string gender)
        {
            this.name = name;
            this.weight = weight;
            this.age = age;
            this.power = power;
            this.greet = greet;
            this.gender = gender;
        }

        public virtual void PrintAnimal()
        {
            Console.WriteLine("I´m a animal and we have many names " + name + "!");
            MakeSound();
        }

        //Method - What they do

        public virtual void MakeSound()
        {
            Console.WriteLine("Animal have differnt sounds!");
        }
        public virtual void Eat()
        {
            Console.WriteLine("Animal eats food!");
        }
        public virtual void Sleep()
        {
            Console.WriteLine("Animal is sleeping");
        }
        public virtual void Drink()
        {
            Console.WriteLine("Animal can drink water!");
        }
        public virtual void Run() //Not shared yet, but ready to be.
        {
            Console.WriteLine("Animal is running");
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
}
