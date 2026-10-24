using System;
using System.Collections.Generic;
using System.Text;

namespace ZooProject.Animals
{
    // Chihuahua ärver från Dog
    public class Chihuahua : Dog
    {
        // En egenskap för chihuahua
        public bool IsNervous { get; set; }

        public Chihuahua(string name = "Lilla", int age = 2)
            : base(name, age)
        {
            IsNervous = true;
        }

        // Chihuahua kan skaka
        public void Shake()
        {
            Console.WriteLine(Name + " skakar lite.");
        }

        // Chihuahua har sitt eget läte
        public override void makeSound()
        {
            Console.WriteLine(Name + " säger: Viff viff!");
        }
    }
}
