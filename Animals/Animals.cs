using System;
using System.Collections.Generic;
using System.Text;

namespace ZooProject.Animals
{
    public class Animal
    {
        // Egenskaper som alla djur har
        // get hämtar värdet och set används för att ändra det
        public string Name { get; set; }
        public int Age { get; set; }
        public double Weight { get; set; }
        public string Color { get; set; }
        public bool IsHungry { get; set; }

        // Konstruktorn ger djuren värden när de skapas
        // Här finns också standardvärden om vi inte anger några egna
        public Animal(string name = "Okänd", int age = 1,
                      double weight = 10, string color = "Brun",
                      bool isHungry = false)
        {
            Name = name;
            Age = age;
            Weight = weight;
            Color = color;
            IsHungry = isHungry;
        }

        // Alla djur kan äta, därför har vi metoden här
        public void Eat()
        {
            Console.WriteLine(Name + " äter mat.");
            // Djuret är inte hungrigt efter att ha ätit
            IsHungry = false;
        }

        // Alla djur kan också sova
        public void Sleep()
        {
            Console.WriteLine(Name + " sover.");
        }

        // Skriver ut informationen vi har om djuret
        public void ShowInfo()
        {
            Console.WriteLine("Namn: " + Name);
            Console.WriteLine("Ålder: " + Age);
            Console.WriteLine("Vikt: " + Weight + " kg");
            Console.WriteLine("Färg: " + Color);
            Console.WriteLine("Hungrig: " + IsHungry);
        }

        // virtual gör att andra djurklasser kan ändra metoden
        // Vi använder det eftersom alla djur gör olika ljud
        public virtual void makeSound()
        {
            Console.WriteLine("Djuret gör ett ljud.");
        }
    }
}
