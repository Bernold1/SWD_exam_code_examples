using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    abstract class Sandwich
    {
        private List<Ingredient> ingredients = new List<Ingredient>();

        public Sandwich()
        {
            CreateIngredients();
        }

        public abstract void CreateIngredients();
        public List<Ingredient> Ingredients
        {
            get { return ingredients; }
        }

    }
}
