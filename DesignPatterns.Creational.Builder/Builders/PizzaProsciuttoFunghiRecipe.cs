using DesignPatterns.Creational.Builder.Models;

namespace DesignPatterns.Creational.Builder.Builders;

/// <inheritdoc />
public class PizzaProsciuttoFunghiRecipe : PizzaRecipe
{
    /// <inheritdoc />
    public PizzaProsciuttoFunghiRecipe() : base("Prosciutto e Funghi") { }

    /// <inheritdoc />
    public override void AddSauce() => Pizza.Sauce = Sauce.Tomato;

    /// <inheritdoc />
    public override void AddIngredients() => Pizza.Ingredients = new[] { Ingredient.Mozzarella, Ingredient.Ham, Ingredient.Mushroom };
}