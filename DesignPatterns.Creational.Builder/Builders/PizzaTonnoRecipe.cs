using DesignPatterns.Creational.Builder.Models;

namespace DesignPatterns.Creational.Builder.Builders
{
    /// <inheritdoc />
    public class PizzaTonnoRecipe : AbstractPizzaRecipe
    {
        /// <inheritdoc />
        public PizzaTonnoRecipe() : base("Tonno") { }

        /// <inheritdoc />
        public override void AddSauce() => Pizza.Sauce = Sauce.Tomato;

        /// <inheritdoc />
        public override void AddIngredients() => Pizza.Ingredients = new[] { Ingredient.Mozzarella, Ingredient.Tuna, Ingredient.Union };
    }
}
