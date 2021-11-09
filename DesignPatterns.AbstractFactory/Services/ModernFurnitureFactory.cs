using DesignPatterns.AbstractFactory.Interfaces;
using DesignPatterns.AbstractFactory.Models;

namespace DesignPatterns.AbstractFactory.Services
{
    /// <inheritdoc />
    public class ModernFurnitureFactory : IFurnitureFactory
    {
        /// <inheritdoc />
        public IChair CreateChair() => new ModernChair();

        /// <inheritdoc />
        public ICoffeeTable CreateCoffeeTable() => new ModernCoffeeTable();

        /// <inheritdoc />
        public ISofa CreateSofa() => new ModernSofa();
    }
}
