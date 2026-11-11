using System;
using System.Collections.Generic;
using System.Text;

namespace ZooProject.Animals
{
    // Chihuahua ärver från Dog och får även metoder från Animal
    public class Chihuahua : Dog
    {
        // Chihuahuans egen egenskap
        public bool IsNervous { get; set; }

        // Skapar hunden med standardvärden
        // base skickar namn och ålder till Dog
        public Chihuahua(string name = "Lilla", int age = 2)
            : base(name, age)
        {
            IsNervous = true;
        }

        // Chihuahuans egen metod
        public void Shake()
        {
            Console.WriteLine(Name + " skakar lite.");
        }

        // Ändrar makeSound till chihuahuans eget ljud
        public override void makeSound()
        {
            Console.WriteLine(Name + " säger: Viff viff!");
        }
    }
}
