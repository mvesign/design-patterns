using DesignPatterns.Creational.AbstractFactory.Models;
using DesignPatterns.Creational.AbstractFactory.Services;

foreach (var type in Enum.GetValues<FurnitureStyle>())
    type.CreateFurnitureFactory().ProduceFurniture();