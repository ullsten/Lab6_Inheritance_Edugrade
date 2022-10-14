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
        protected int weightMale { get; set; }
        public Lion()
        {
            this.name = "King/Queen";
            this.weight = 130; //for female
            this.weightMale = 190; //for male
            this.age = 8;
            this.power = 10;
            this.greet = "'Mew mew'";
            this.protective = "I will protect my territory!"; //Default value special property
            this.gender = gender;
        }
        public Lion(string name, int weight, int age, int power, string greet, string gender, string protective, int weightMale) : base(name, weight, age, power, greet, gender)
        {
            this.protective = protective;
            this.weightMale = weightMale;
        }
        public override void PrintAnimal()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Eat();
            Drink();
            Killing();
            Sleep();
            Console.ResetColor();
        }
        public override void MakeSound()
        {
            Console.WriteLine("'Grraaaauuuu Grraaaauuuu!' Fear me! I am a LION " + name + " of the Savannah!");
        }
        public override void Eat()
        {
            Console.WriteLine("We are carnivores, I like meat!");
        }
        public override void Sleep()
        {
            Console.WriteLine(" After I kill an antelope I usually sleep 'ZZzzzzZZZzzzzZZZZ'");
        }
        public override void Drink()
        {
            Console.WriteLine("It´s water we like!");
        }
        protected void Killing() //Special method for Lion
        {
            Console.WriteLine("I´m very good at killing my prey!");
        }
        public override string ToString()
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            return String.Format("Race: {0}\nName: {1}\nGender: {2}\nWeight male: {3} kg\nWeight female: {4}\nAge: {5}-16 year\nPower: {6}/10\nGreet: {7}",
            this.GetType().Name,
            this.name,
            this.gender,
            this.weightMale,
            this.weight,
            this.age,
            this.power,
            this.greet);
            Console.ResetColor();

        }
    }
}
