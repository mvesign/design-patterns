using DesignPatterns.Creational.AbstractFactory.Abstractions;
using DesignPatterns.Creational.AbstractFactory.Models;

namespace DesignPatterns.Creational.AbstractFactory.Services;

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