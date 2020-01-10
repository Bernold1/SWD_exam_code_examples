using FactoryMethod.Ingredients;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod.ConcreteCreators_Sandwiches
{
    class HamSandwich : Sandwich
    {
        public override void CreateIngredients()
        {
            Ingredients.Add(new Bread());
            Ingredients.Add(new Ham());
            Ingredients.Add(new Lettuce());
            Ingredients.Add(new Mayo());
            Ingredients.Add(new Bread());
            Console.WriteLine("Ham sandwich with Bread, Ham, Lettuce and mayonaise");
        }
        public void MakeTheWich()
        {
            Console.WriteLine("adding bread");
            System.Threading.Thread.Sleep(500);
            Console.WriteLine("adding Lettuce");
            System.Threading.Thread.Sleep(500);
            Console.WriteLine("adding Ham");
            System.Threading.Thread.Sleep(500);
            Console.WriteLine("adding Mayo");
            System.Threading.Thread.Sleep(500);
            Console.WriteLine("Order up! Thats a damn good sandwich!");
        }
    }
}
