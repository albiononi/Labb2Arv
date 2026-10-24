using System;
using System.Collections.Generic;
using System.Text;

namespace ZooProject.Animals
{
    // Bulldog ärver från Dog
    public class Bulldog : Dog
    {
        // En egenskap som är speciell för bulldog
        // Vi använder get och set för att ta ett värde och för att ändra ett värde. Så get betyder hämta, set betyder att placera typ. 
        // Vi använder get och set på alla egenskaper så det vill säga att vi använder det på Cat, Dog, Chihuahua osv.
        public bool HasWrinkles { get; set; }

        public Bulldog(string name = "Bosse", int age = 4)
            : base(name, age)
        {
            HasWrinkles = true;
        }

        // Bulldog har en egen metod
        public void Snore()
        {
            Console.WriteLine(Name + " snarkar högt.");
        }

        // Ändrar ljudet så bulldogen låter annorlunda
        public override void makeSound()
        {
            Console.WriteLine(Name + " säger: Voff! Grrr!");
        }
    }
}
