using AbstractFactory.Adultfood;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    class NoSandwich : RecipeFactory
    {
        public override Dessert CreateDessert()
        {
            return new Nothing();
        }

        public override Sandwich CreateSandwich()
        {
            return new Empty();
        }
    }
}
