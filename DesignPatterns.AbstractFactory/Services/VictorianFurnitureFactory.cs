using DesignPatterns.AbstractFactory.Interfaces;
using DesignPatterns.AbstractFactory.Models;

namespace DesignPatterns.AbstractFactory.Services
{
    /// <inheritdoc />
    public class VictorianFurnitureFactory : IFurnitureFactory
    {
        /// <inheritdoc />
        public IChair CreateChair() => new VictorianChair();

        /// <inheritdoc />
        public ICoffeeTable CreateCoffeeTable() => new VictorianCoffeeTable();

        /// <inheritdoc />
        public ISofa CreateSofa() => new VictorianSofa();
    }
}
