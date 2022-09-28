using DesignPatterns.Creational.Builder.Models;

namespace DesignPatterns.Creational.Builder.Builders;

/// <inheritdoc />
public class PizzaMargheritaRecipe : PizzaRecipe
{
    /// <inheritdoc />
    public PizzaMargheritaRecipe() : base("Margherita") { }

    /// <inheritdoc />
    public override void AddSauce() => Pizza.Sauce = Sauce.Tomato;

    /// <inheritdoc />
    public override void AddIngredients() => Pizza.Ingredients = new[] {Ingredient.Mozzarella, Ingredient.Basil};
}