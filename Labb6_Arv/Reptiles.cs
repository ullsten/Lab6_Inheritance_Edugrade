using Labb6_Arv;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb6_Arv_Zoo
{
    public class Reptiles : Animal
    {
        protected string egg = "We laying eggs"; //Special property for reptiles
        public Reptiles()
        {
            this.name = name;
            this.weight = 0;
            this.age = 0;
            this.power = 7;
            this.greet = "Depends on reptile!";
            this.gender = "Male/Female";
        }
        public Reptiles(string name, int age, int weight, int power, string greet, string gender, string egg) : base(name, weight, age, power, greet, gender)
        {
            this.egg = egg;
        }
        public override void PrintAnimal()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Due to corona restrictions, you cannot meet the reptiles today.\n" +
                "But please read the information about them.");
            Console.WriteLine();
            Console.ResetColor();
            HoursOfBirth();

        }
        public override void MakeSound()
        {
            Console.WriteLine("Reptiles have differnt sounds. Here you hear a snake: 'ssssssss ssss'");
        }
        public void HoursOfBirth() //Special method
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("One cool thing with reptiles are that they can glide, walk and swim within ours of birth.");
            Console.ResetColor();
        }
        public override string ToString()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            return String.Format("Race: {0}\nName: {1}\nGender: {2}\nWeight: {3} kg++\nAge: {4} year++\nPower: {5}/10\nGreet: {6}",
            this.GetType().Name,
            this.name,
            this.gender,
            this.weight,
            this.age,
            this.power,
            this.greet);
            Console.ResetColor();
        }
    }
}
