using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyCooking.CookingTypes
{
    class Baking : CookStrategy
    {
        public void Cook(string food)
        {
            Console.WriteLine($"\nBaking {food} in the oven.");
            Console.WriteLine("time left 3s");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("time left 2s");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("time left 1s");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine($"Done! Damn thats some tasty {food}!!");
        }
    }
}
