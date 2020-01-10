using FactoryMethod.ConcreteCreators_Sandwiches;
using System;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What type of sandwich do you want?");
            var turkeySandWich = new TurkeySandwich();
            var hamSandwich = new HamSandwich();
            Console.WriteLine("Write 1 for turkey and 2 for ham");
            var food = Console.ReadLine();
            //Then we can do something with these sandwiches
            switch (food)
            {
                case "1":
                    Console.WriteLine("Turkey sandwich it is!");
                    turkeySandWich.MakeTheWich();
                    break;
                case "2":
                    Console.WriteLine("Ham sandwich it is!");
                    hamSandwich.MakeTheWich();
                    break;
            }
            Console.ReadKey();
        }
    }
}
