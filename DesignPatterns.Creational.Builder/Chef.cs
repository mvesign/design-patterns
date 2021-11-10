using DesignPatterns.Creational.Builder.Builders;
using DesignPatterns.Creational.Builder.Models;

namespace DesignPatterns.Creational.Builder
{
    /// <summary>
    /// Chef who creates the pizza a.k.a. the director.
    /// </summary>
    public class Chef
    {
        private AbstractPizzaRecipe _pizzaRecipe;

        /// <summary>
        /// Give the pizza recipe to the chef.
        /// </summary>
        /// <param name="pizzaRecipe"><see cref="AbstractPizzaRecipe"/></param>
        public void GiveRecipe(AbstractPizzaRecipe pizzaRecipe) => _pizzaRecipe = pizzaRecipe;

        /// <summary>
        /// Let's bake the pizza based on a given recipe.
        /// </summary>
        /// <returns><see cref="Pizza"/></returns>
        public Pizza BakePizza()
        {
            _pizzaRecipe.LayoutDough();
            _pizzaRecipe.AddSauce();
            _pizzaRecipe.AddIngredients();

            return _pizzaRecipe.BakePizza();
        }
    }
}
