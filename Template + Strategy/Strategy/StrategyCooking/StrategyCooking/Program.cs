using StrategyCooking.CookingTypes;
using System;

namespace StrategyCooking
{
    class Program
    {
        static void Main(string[] args)
        {
            CookMethod cookMethod = new CookMethod();

            Console.WriteLine("What food do you want to cook?");
            string food = Console.ReadLine();
            cookMethod.SetFoodType(food);

            Console.WriteLine($"So you want to cook some {food} eh? You can grill, slow cook or bake your food.");
            Console.WriteLine("Type your cooking method:");
            string input = Console.ReadLine();
                switch (input)
                {
                    case "grill":
                        cookMethod.SetCookStrat(new Grilling());
                        cookMethod.Cook();
                        break;
                    case "bake":
                        cookMethod.SetCookStrat(new Baking());
                        cookMethod.Cook();
                        break;
                    case "slow cook":
                        cookMethod.SetCookStrat(new SlowCooker());
                        cookMethod.Cook();
                        break;
                    default:
                        Console.WriteLine("I dont think I know how to cook like that try again.");
                    break;
                }
            Console.ReadKey();
        }
    }
}
