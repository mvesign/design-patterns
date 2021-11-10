using System;
using DesignPatterns.Creational.Builder.Builders;

namespace DesignPatterns.Creational.Builder
{
    internal static class Program
    {
        private static void Main()
        {
            // Hire a new chef
            var chef = new Chef();

            // Ask for several pizza's.
            chef.GetPizza(new PizzaHawaiRecipe());
            chef.GetPizza(new PizzaMargheritaRecipe());
            chef.GetPizza(new PizzaPepperoniRecipe());
            chef.GetPizza(new PizzaProsciuttoFunghiRecipe());
            chef.GetPizza(new PizzaTonnoRecipe());
        }

        private static void GetPizza(this Chef chef, AbstractPizzaRecipe pizzaRecipe)
        {
            chef.GiveRecipe(pizzaRecipe);

            Console.WriteLine(chef.BakePizza());
        }
    }
}
