using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.Adultfood
{
    //ConcreteFactory 
    class AdultCuisineFactory : RecipeFactory
    {
        public override Dessert CreateDessert()
        {
            return new CremeBrulee();
        }

        public override Sandwich CreateSandwich()
        {
            return new BLT();
        }
    }
}
