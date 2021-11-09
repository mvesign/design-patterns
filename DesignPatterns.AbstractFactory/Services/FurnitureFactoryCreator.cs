using System;
using DesignPatterns.AbstractFactory.Interfaces;
using DesignPatterns.AbstractFactory.Models;

namespace DesignPatterns.AbstractFactory.Services
{
    /// <summary>
    /// Service that can create any type of <see cref="IFurnitureFactory"/>.
    /// </summary>
    public static class FurnitureFactoryCreator
    {
        /// <summary>
        /// Create a new <see cref="IFurnitureFactory"/> based on a given <see cref="FurnitureType"/>.
        /// </summary>
        /// <param name="type"><see cref="FurnitureType"/></param>
        /// <returns><see cref="IFurnitureFactory"/></returns>
        public static IFurnitureFactory CreateFurnitureFactory(this FurnitureType type) =>
            type switch
            {
                FurnitureType.Modern => new ModernFurnitureFactory(),
                FurnitureType.Victorian => new VictorianFurnitureFactory(),
                _ => throw new ArgumentOutOfRangeException(nameof(type), type, null)
            };

        /// <summary>
        /// Produce the furniture of the factory.
        /// </summary>
        /// <param name="factory"><see cref="IFurnitureFactory"/></param>
        public static void ProduceFurniture(this IFurnitureFactory factory)
        {
            factory.CreateChair().ShowDetails();
            factory.CreateCoffeeTable().ShowDetails();
            factory.CreateSofa().ShowDetails();
        }
        
        private static void ShowDetails(this IFurniture furniture) =>
            Console.WriteLine($"{furniture.GetName()} - HasLegs: {furniture.HasLegs()}, CanSitOn: {furniture.CanSitOn()}");
    }
}
