using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    //this is the AbstractFactory participant
    abstract class RecipeFactory
    {
        public abstract Sandwich CreateSandwich();
        public abstract Dessert CreateDessert();
    }
}
