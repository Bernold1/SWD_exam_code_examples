using AbstractFactory.Adultfood;
using AbstractFactory.Kidsfood;
using System;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Are you an adult or a child? A = Adult , C = Child ");
            string input = Console.ReadLine();
            RecipeFactory factory;
            switch (input)
            {
                case "A":
                    factory = new AdultCuisineFactory();
                    break;
                case "C":
                    factory = new KidCuisineFactory();
                    break;

                default:
                    Console.WriteLine($"What character was that? Are you an alien since you pressed {input}?");
                    factory = new NoSandwich();
                    //Man kunne også smide en exception men det er ikke sjovt
                    break;
            }
            var sandwich = factory.CreateSandwich();
            var desert = factory.CreateDessert();
            Console.WriteLine("Your sandwich is : " + sandwich.GetType().Name);
            Console.WriteLine("Your Dessert is : " + desert.GetType().Name);
            Console.ReadKey();
        }
    }
}
