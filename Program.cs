namespace Labb2Arv
{

    using System;
    using ZooProject.Animals;

    class Program
    {
        // Main är där programmet startar
        static void Main(string[] args)
        {

            // Skapar våra olika djur med deras standardvärden
            // new används för att skapa ett nytt objekt
            Dog dog = new Dog();
            Cat cat = new Cat();
            Elephant elephant = new Elephant();
            Bulldog bulldog = new Bulldog();
            Chihuahua chihuahua = new Chihuahua();

            Console.WriteLine("Välkommen till vårt Zoo!");
            Console.WriteLine();

            // Alla djur använder makeSound men har olika ljud
            // Det fungerar eftersom vi använder override
            dog.makeSound();
            cat.makeSound();
            elephant.makeSound();
            bulldog.makeSound();
            chihuahua.makeSound();

            Console.WriteLine();

            // Testar djurens egna metoder
            dog.Fetch();
            cat.ClimbTree();
            elephant.SprayWater();
            bulldog.Snore();
            chihuahua.Shake();

            Console.WriteLine();

            // Testar metoder som Dog och Cat ärver från Animal
            dog.Eat();
            cat.Sleep();

            Console.WriteLine();

            // Visar hundens information med metoden från Animal
            dog.ShowInfo();
        }
    }
}