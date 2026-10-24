namespace Labb2Arv
{

    using System;
    using ZooProject.Animals;

    class Program
    {
        static void Main(string[] args)
        {

            // Animal är en basklass det betyder att dem andra Animals klasserna kan ärva kod från den
            // Skapar våra olika djur
            Dog dog = new Dog();
            Cat cat = new Cat();
            Elephant elephant = new Elephant();
            Bulldog bulldog = new Bulldog();
            Chihuahua chihuahua = new Chihuahua();

            Console.WriteLine("Välkommen till vårt Zoo!");
            Console.WriteLine();

            // Alla djuren får göra sina ljud
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

            // Testar metoder som ärvs från Animal
            dog.Eat();
            cat.Sleep();

            Console.WriteLine();

            // Visar information om hunden
            dog.ShowInfo();
        }
    }
}