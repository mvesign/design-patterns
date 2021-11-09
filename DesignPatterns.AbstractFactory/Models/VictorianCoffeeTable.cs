using DesignPatterns.AbstractFactory.Interfaces;

namespace DesignPatterns.AbstractFactory.Models
{
    /// <inheritdoc />
    public class VictorianCoffeeTable : ICoffeeTable
    {
        /// <inheritdoc />
        public string GetName() => nameof(VictorianCoffeeTable);

        /// <inheritdoc />
        public bool HasLegs() => true;

        /// <inheritdoc />
        public bool CanSitOn() => false;
    }
}
