﻿using DesignPatterns.Creational.Builder.Models;

namespace DesignPatterns.Creational.Builder.Builders;

/// <inheritdoc />
public class PizzaHawaiRecipe : PizzaRecipe
{
    /// <inheritdoc />
    public PizzaHawaiRecipe() : base("Hawai") { }

    /// <inheritdoc />
    public override void AddSauce() => Pizza.Sauce = Sauce.Tomato;

    /// <inheritdoc />
    public override void AddIngredients() => Pizza.Ingredients = new[] {Ingredient.Mozzarella, Ingredient.Ham, Ingredient.Pineapple};
}