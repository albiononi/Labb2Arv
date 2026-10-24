using System;
using System.Collections.Generic;
using System.Text;

namespace ZooProject.Animals
{
    // Elephant ärver från Animal
    public class Elephant : Animal
    {
        // Elefantens egen egenskap
        public double TrunkLength { get; set; }

        public Elephant(string name = "Dumbo", int age = 10)
            : base(name, age, 2000, "Grå", false)
        {
            TrunkLength = 2;
        }

        // Elefanten använder sin snabel
        public void SprayWater()
        {
            Console.WriteLine(Name + " sprutar vatten med sin snabel.");
        }

        // Elefantens eget läte
        public override void makeSound()
        {
            Console.WriteLine(Name + " säger: Tuuut!");
        }
    }
}
