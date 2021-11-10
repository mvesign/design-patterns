using System.Collections.Generic;

namespace DesignPatterns.Creational.Builder.Models
{
    /// <summary>
    /// Pizza.
    /// </summary>
    public class Pizza
    {
        private readonly string _name;

        /// <summary>
        /// Create a new pizza.
        /// </summary>
        /// <param name="name">Name of the pizza.</param>
        public Pizza(string name)
        {
            _name = name;
        }

        /// <summary>
        /// Sauce of the pizza.
        /// </summary>
        public Sauce Sauce { get; set; }

        /// <summary>
        /// Ingredients that are on top of the pizza.
        /// </summary>
        public IEnumerable<Ingredient> Ingredients { get; set; }

        /// <inheritdoc />
        public override string ToString() => $"Pizza {_name} with {Sauce} sauce and the toppings {string.Join(", ", Ingredients)}";
    }
}
