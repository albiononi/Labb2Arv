using System;
using System.Collections.Generic;
using System.Text;

namespace ZooProject.Animals
{
    // Cat ärver de gemensamma egenskaperna från Animal
    public class Cat : Animal
    {
        // Kattens egen egenskap, bool är true eller false
        public bool LikesMilk { get; set; }

        // Skapar katten med standardvärden
        // base skickar värden vidare till Animal
        public Cat(string name = "Misse", int age = 2)
            : base(name, age, 5, "Grå", true)
        {
            LikesMilk = true;
        }

        // Kattens egen metod
        public void ClimbTree()
        {
            Console.WriteLine(Name + " klättrar i ett träd.");
        }

        // Ändrar makeSound till kattens eget läte
        public override void makeSound()
        {
            Console.WriteLine(Name + " säger: Mjau!");
        }
    }
}
