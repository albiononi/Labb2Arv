using System;
using System.Collections.Generic;
using System.Text;

namespace ZooProject.Animals
{
    public class Animal
    {
        // Egenskaper som alla djur har
        public string Name { get; set; }
        public int Age { get; set; }
        public double Weight { get; set; }
        public string Color { get; set; }
        public bool IsHungry { get; set; }

        // Constructor som ger djuren deras värden
        // En constructor ger djuren ett värde när dem skapas, jag har ochså lagt inn standardvärde så att djuren värden även om jag inte skriver inn några själv.
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

        // Alla djur kan äta
        public void Eat()
        {
            Console.WriteLine(Name + " äter mat.");
            IsHungry = false;
        }

        // Alla djur kan sova
        public void Sleep()
        {
            Console.WriteLine(Name + " sover.");
        }

        // Visar information om djuret
        public void ShowInfo()
        {
            Console.WriteLine("Namn: " + Name);
            Console.WriteLine("Ålder: " + Age);
            Console.WriteLine("Vikt: " + Weight + " kg");
            Console.WriteLine("Färg: " + Color);
            Console.WriteLine("Hungrig: " + IsHungry);
        }

        // Virtual gör att andra djur kan ändra ljudet, det gör så att andra klasser får ändra hur metoden fungerar. 
        // Så jag använder Virtual och ovverride för att alla djur ska ha metoden makeSound, men dem ska göra olika ljud så virtual tillåter att metoden ändras, och override används för att ändra det. 
        public virtual void makeSound()
        {
            Console.WriteLine("Djuret gör ett ljud.");
        }
    }
}
