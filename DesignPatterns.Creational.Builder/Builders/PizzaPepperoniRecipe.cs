using DesignPatterns.Creational.Builder.Models;

namespace DesignPatterns.Creational.Builder.Builders
{
    /// <inheritdoc />
    public class PizzaPepperoniRecipe : AbstractPizzaRecipe
    {
        /// <inheritdoc />
        public PizzaPepperoniRecipe() : base("Pepperoni") { }

        /// <inheritdoc />
        public override void AddSauce() => Pizza.Sauce = Sauce.Tomato;

        /// <inheritdoc />
        public override void AddIngredients() => Pizza.Ingredients = new[] { Ingredient.Mozzarella, Ingredient.Salami };
    }
}
