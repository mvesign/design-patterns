using DesignPatterns.Creational.Builder;
using DesignPatterns.Creational.Builder.Builders;

// Ask for several pizza's.
GetPizza(new PizzaHawaiRecipe());
GetPizza(new PizzaMargheritaRecipe());
GetPizza(new PizzaPepperoniRecipe());
GetPizza(new PizzaProsciuttoFunghiRecipe());
GetPizza(new PizzaTonnoRecipe());

static void GetPizza(PizzaRecipe pizzaRecipe)
{
    Chef.Instance.GiveRecipe(pizzaRecipe);

    Console.WriteLine(Chef.Instance.BakePizza());
}