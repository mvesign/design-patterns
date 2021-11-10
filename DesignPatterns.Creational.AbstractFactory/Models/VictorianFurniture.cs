using DesignPatterns.Creational.AbstractFactory.Abstractions;

namespace DesignPatterns.Creational.AbstractFactory.Models
{
    /// <inheritdoc />
    public class VictorianChair : IChair
    {
        /// <inheritdoc />
        public FurnitureStyle GetFurnitureStyle() => FurnitureStyle.Victorian;

        /// <inheritdoc />
        public FurnitureType GetFurnitureType() => FurnitureType.Chair;
    }

    /// <inheritdoc />
    public class VictorianCoffeeTable : ICoffeeTable
    {
        /// <inheritdoc />
        public FurnitureStyle GetFurnitureStyle() => FurnitureStyle.Victorian;

        /// <inheritdoc />
        public FurnitureType GetFurnitureType() => FurnitureType.CoffeeTable;
    }

    /// <inheritdoc />
    public class VictorianSofa : ISofa
    {
        /// <inheritdoc />
        public FurnitureStyle GetFurnitureStyle() => FurnitureStyle.Victorian;

        /// <inheritdoc />
        public FurnitureType GetFurnitureType() => FurnitureType.Sofa;
    }
}
