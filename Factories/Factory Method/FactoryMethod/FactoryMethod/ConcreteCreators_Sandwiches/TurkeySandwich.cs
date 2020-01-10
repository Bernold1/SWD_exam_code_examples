using FactoryMethod.Ingredients;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod.ConcreteCreators_Sandwiches
{
    class TurkeySandwich : Sandwich
    {
        public override void CreateIngredients()
        {
            Ingredients.Add(new Bread());
            Ingredients.Add(new Turkey());
            Ingredients.Add(new Lettuce());
            Ingredients.Add(new Mayo());
            Ingredients.Add(new Bread());
            Console.WriteLine("Turkey sandwich with Bread, Turkey, Lettuce and mayonaise");
        }
        public void MakeTheWich()
        {
            Console.WriteLine("adding bread");
            System.Threading.Thread.Sleep(500);
            Console.WriteLine("adding Lettuce");
            System.Threading.Thread.Sleep(500);
            Console.WriteLine("adding Turkey");
            System.Threading.Thread.Sleep(500);
            Console.WriteLine("adding Mayo");
            System.Threading.Thread.Sleep(500);
            Console.WriteLine("Order up! Thats a damn good sandwich!");

        }
    }
}
