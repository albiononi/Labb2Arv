using System;
using System.Collections.Generic;
using System.Text;

namespace ZooProject.Animals
{
    // Dog ärver från Animal. Detta betyder att Dog klassen automatisk får tillgång til name, age, eat osv, det gör det lättare eftersom att vi inte behöver skriva om det.
    public class Dog : Animal
    {
        // Hundens egen egenskap
        public string FavoriteToy { get; set; }

        // Skapar en hund med standardvärden
        // Base används för att skicka värden till constructorn i base klassen Animal. jag använder Base för att skicka info till till animal klassen för då slipper jag skirva samma kod igen för varje djur.
        public Dog(string name = "Rex", int age = 3)
            : base(name, age, 15, "Brun", false)
        {
            FavoriteToy = "Boll";
        }

        // Hundens egen metod
        public void Fetch()
        {
            Console.WriteLine(Name + " hämtar sin " + FavoriteToy);
        }

        // Override gör att hunden får sitt eget läte
        public override void makeSound()
        {
            Console.WriteLine(Name + " säger: Voff voff!");
        }
    }
}
