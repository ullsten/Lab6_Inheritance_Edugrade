using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb6_Arv
{
    public class Animal //BaseClass
    {

        //characteristics
        protected string name { get; set; } //Can also set default value here
        protected int weight { get; set; }
        protected int age { get; set; }
        protected int power { get; set; }
        protected string greet { get; set; } 
        

        public Animal() //Constructor default values
        {   
            this.name = "NoName";
            this.weight = int.MaxValue;
            this.age = int.MaxValue;
            this.power = 10;
            this.greet = "NoGreet";
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
    }
}
