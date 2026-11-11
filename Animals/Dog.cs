using System;
using System.Collections.Generic;
using System.Text;

namespace ZooProject.Animals
{
    // Dog ärver från Animal och får därför dess egenskaper och metoder
    // Då slipper vi skriva om samma kod
    public class Dog : Animal
    {
        // Hundens egen egenskap
        public string FavoriteToy { get; set; }

        // Konstruktorn ger hunden standardvärden
        // base skickar värden till Animal-klassen
        public Dog(string name = "Rex", int age = 3)
            : base(name, age, 15, "Brun", false)
        {
            FavoriteToy = "Boll";
        }

        // Hundens egen metod för att hämta sin leksak
        public void Fetch()
        {
            Console.WriteLine(Name + " hämtar sin " + FavoriteToy);
        }

        // override ändrar makeSound så hunden får sitt eget ljud
        public override void makeSound()
        {
            Console.WriteLine(Name + " säger: Voff voff!");
        }
    }
}
