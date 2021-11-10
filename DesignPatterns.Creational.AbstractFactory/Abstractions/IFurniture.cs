using DesignPatterns.Creational.AbstractFactory.Models;

namespace DesignPatterns.Creational.AbstractFactory.Abstractions
{
    /// <summary>
    /// Piece of furniture.
    /// </summary>
    public interface IFurniture
    {
        /// <summary>
        /// Get the style of the current furniture.
        /// </summary>
        /// <returns><see cref="FurnitureStyle"/></returns>
        FurnitureStyle GetFurnitureStyle();

        /// <summary>
        /// Get the type of the current furniture.
        /// </summary>
        /// <returns><see cref="FurnitureType"/></returns>
        FurnitureType GetFurnitureType();
    }

    /// <inheritdoc />
    public interface IChair : IFurniture
    {
    }

    /// <inheritdoc />
    public interface ICoffeeTable : IFurniture
    {
    }

    /// <inheritdoc />
    public interface ISofa : IFurniture
    {
    }
}
