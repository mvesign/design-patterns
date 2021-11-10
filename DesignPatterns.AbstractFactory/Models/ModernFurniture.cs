using DesignPatterns.AbstractFactory.Interfaces;

namespace DesignPatterns.AbstractFactory.Models
{
    /// <inheritdoc />
    public class ModernChair : IChair
    {
        /// <inheritdoc />
        public FurnitureStyle GetFurnitureStyle() => FurnitureStyle.Modern;

        /// <inheritdoc />
        public FurnitureType GetFurnitureType() => FurnitureType.Chair;
    }

    /// <inheritdoc />
    public class ModernCoffeeTable : ICoffeeTable
    {
        /// <inheritdoc />
        public FurnitureStyle GetFurnitureStyle() => FurnitureStyle.Modern;

        /// <inheritdoc />
        public FurnitureType GetFurnitureType() => FurnitureType.CoffeeTable;
    }

    /// <inheritdoc />
    public class ModernSofa : ISofa
    {
        /// <inheritdoc />
        public FurnitureStyle GetFurnitureStyle() => FurnitureStyle.Modern;

        /// <inheritdoc />
        public FurnitureType GetFurnitureType() => FurnitureType.Sofa;
    }
}
