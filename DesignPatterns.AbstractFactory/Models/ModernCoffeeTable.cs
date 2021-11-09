using System;
using DesignPatterns.AbstractFactory.Interfaces;

namespace DesignPatterns.AbstractFactory.Models
{
    /// <inheritdoc />
    public class ModernCoffeeTable : ICoffeeTable
    {
        /// <inheritdoc />
        public string GetName() => nameof(ModernCoffeeTable);

        /// <inheritdoc />
        public bool HasLegs() => true;

        /// <inheritdoc />
        public bool CanSitOn() => false;
    }
}
