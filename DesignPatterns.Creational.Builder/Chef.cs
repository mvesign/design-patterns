using DesignPatterns.Creational.Builder.Builders;
using DesignPatterns.Creational.Builder.Models;

namespace DesignPatterns.Creational.Builder;

/// <summary>
/// Chef who creates the pizza a.k.a. the director.
/// </summary>
public class Chef
{
    private PizzaRecipe _pizzaRecipe;

    private Chef() { }

    /// <summary>
    /// Get the chef of this establishment.
    /// </summary>
    public static Chef Instance { get; } = new();

    /// <summary>
    /// Give the pizza recipe to the chef.
    /// </summary>
    /// <param name="pizzaRecipe"><see cref="PizzaRecipe"/></param>
    public void GiveRecipe(PizzaRecipe pizzaRecipe) => _pizzaRecipe = pizzaRecipe;

    /// <summary>
    /// Let's bake the pizza based on the last given recipe.
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