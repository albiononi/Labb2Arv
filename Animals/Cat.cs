using System;
using System.Collections.Generic;
using System.Text;

namespace ZooProject.Animals
{
    // Cat ärver från Animal
    public class Cat : Animal
    {
        // Kattens egen egenskap
        public bool LikesMilk { get; set; }

        public Cat(string name = "Misse", int age = 2)
            : base(name, age, 5, "Grå", true)
        {
            LikesMilk = true;
        }

        // Katten kan klättra i träd
        public void ClimbTree()
        {
            Console.WriteLine(Name + " klättrar i ett träd.");
        }

        // Kattens eget läte
        public override void makeSound()
        {
            Console.WriteLine(Name + " säger: Mjau!");
        }
    }
}
