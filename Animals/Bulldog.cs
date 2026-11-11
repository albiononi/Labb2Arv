using System;
using System.Collections.Generic;
using System.Text;

namespace ZooProject.Animals
{
    // Bulldog ärver från Dog som redan ärver från Animal
    // Det här visar arv i två nivåer
    public class Bulldog : Dog
    {
        // Bulldogens egen egenskap
        public bool HasWrinkles { get; set; }

        // Skapar bulldogen med standardvärden
        // base anropar Dog som sedan skickar värden till Animal
        public Bulldog(string name = "Bosse", int age = 4)
            : base(name, age)
        {
            HasWrinkles = true;
        }

        // Bulldogens egen metod
        public void Snore()
        {
            Console.WriteLine(Name + " snarkar högt.");
        }

        // Ändrar makeSound så bulldogen har ett eget läte
        public override void makeSound()
        {
            Console.WriteLine(Name + " säger: Voff! Grrr!");
        }
    }
}
