using DesignPatterns.Creational.Builder.Models;

namespace DesignPatterns.Creational.Builder.Builders;

/// <summary>
/// Recipe of a pizza a.k.a the builder.
/// </summary>
public abstract class PizzaRecipe
{
    private readonly string _name;

    /// <summary>
    /// Create a new pizza.
    /// </summary>
    /// <param name="name">Name of the pizza.</param>
    protected PizzaRecipe(string name) => _name = name;

    /// <summary>
    /// Current pizza.
    /// </summary>
    protected Pizza Pizza { get; private set; }

    /// <summary>
    /// Layout a new piece of dough.
    /// </summary>
    public void LayoutDough() => Pizza = new Pizza(_name);

    /// <summary>
    /// Add sauce on top of the doug.
    /// </summary>
    public abstract void AddSauce();

    /// <summary>
    /// Add required ingredients for the current pizza type.
    /// </summary>
    public abstract void AddIngredients();

    /// <summary>
    /// Bake the created pizza and get it out of the oven.
    /// </summary>
    /// <returns><see cref="Pizza"/></returns>
    public Pizza BakePizza() => Pizza;
}