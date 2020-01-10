using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.Kidsfood
{
    class KidCuisineFactory : RecipeFactory
    {
        public override Dessert CreateDessert()
        {
            return new IceCream();
        }

        public override Sandwich CreateSandwich()
        {
            return new GrilledCheese();
        }
    }
}
