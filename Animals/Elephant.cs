using System;
using System.Collections.Generic;
using System.Text;

namespace ZooProject.Animals
{
    // Elephant ärver från Animal
    public class Elephant : Animal
    {
        // Elefantens egen egenskap
        // double används eftersom längden kan ha decimaler
        public double TrunkLength { get; set; }

        // Skapar elefanten med standardvärden
        // base skickar värden till Animal
        public Elephant(string name = "Dumbo", int age = 10)
            : base(name, age, 2000, "Grå", false)
        {
            TrunkLength = 2;
        }

        // Elefantens egen metod för att spruta vatten
        public void SprayWater()
        {
            Console.WriteLine(Name + " sprutar vatten med sin snabel.");
        }

        // Ändrar makeSound till elefantens ljud
        public override void makeSound()
        {
            Console.WriteLine(Name + " säger: Tuuut!");
        }
    }
}
