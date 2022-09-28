namespace DesignPatterns.Creational.AbstractFactory.Abstractions;

/// <summary>
/// Factory that can create different types of furniture.
/// </summary>
public interface IFurnitureFactory
{
    /// <summary>
    /// Create a furniture of the type <see cref="IChair"/>.
    /// </summary>
    /// <returns><see cref="IChair"/></returns>
    IChair CreateChair();

    /// <summary>
    /// Create a furniture of the type <see cref="ICoffeeTable"/>.
    /// </summary>
    /// <returns><see cref="ICoffeeTable"/></returns>
    ICoffeeTable CreateCoffeeTable();

    /// <summary>
    /// Create a furniture of the type <see cref="ISofa"/>.
    /// </summary>
    /// <returns><see cref="ISofa"/></returns>
    ISofa CreateSofa();
}