using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb6_Arv
{
    public class Cat : Animal
    {
        public string jump { get; set; } //Special property
        public Cat()
        {
            this.name = "We can have many names";
            this.weight = 2;
            this.age = 0;
            this.power = 5;
            this.greet = "'Mew mew'";
            this.jump = "We can jump high"; //Default value special property
            this.gender = gender;

        }
        public Cat(string name, int weight, int age, int power, string greet, string jump, string gender) : base(name, weight, age, power, greet, gender)
        {
            this.jump = jump;
        }

        public override void PrintAnimal()
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Eat();
            Drink();
            Climb();
            Sleep();
            Console.ResetColor();
        }
        public override void MakeSound()
        {
            Console.WriteLine("'Meow Meow Meow' I´m not big but still a CAT!");
        }
        public override void Eat()
        {
            Console.WriteLine("If you give me some fish, I will love you!");
        }
        public override void Sleep()
        {
            Console.WriteLine("It's hard to climb, so I usually fall asleep when I get in'ZZzzzzZZZzzzzZZZZ'");
        }
        public override void Drink()
        {
            Console.WriteLine("After my food I like to drink water!");
        }
        protected void Climb() //Special method for Cat
        {
            Console.WriteLine("When we are outside, we sometimes like to climb trees.");
        }
        public override string ToString()
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            return String.Format("Race: {0}\nName: {1}\nGender: {2}\nWeight: {3}-8 kg\nAge: {4}-20+\nPower: {5}/10\nGreet: {6}\nCan do: {7}",
            this.GetType().Name,
            this.name,
            this.gender,
            this.weight,
            this.age,
            this.power,
            this.greet,
            this.jump);
            Console.ResetColor();
        }
    }
    
    
}
