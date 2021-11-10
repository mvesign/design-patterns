using System;
using DesignPatterns.Creational.AbstractFactory.Abstractions;
using DesignPatterns.Creational.AbstractFactory.Models;

namespace DesignPatterns.Creational.AbstractFactory.Services
{
    /// <summary>
    /// Service that can create any type of <see cref="IFurnitureFactory"/>.
    /// </summary>
    public static class FurnitureFactoryCreator
    {
        /// <summary>
        /// Create a new <see cref="IFurnitureFactory"/> based on a given <see cref="FurnitureStyle"/>.
        /// </summary>
        /// <param name="type"><see cref="FurnitureStyle"/></param>
        /// <returns><see cref="IFurnitureFactory"/></returns>
        public static IFurnitureFactory CreateFurnitureFactory(this FurnitureStyle type) =>
            type switch
            {
                FurnitureStyle.Modern => new ModernFurnitureFactory(),
                FurnitureStyle.Victorian => new VictorianFurnitureFactory(),
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
            Console.WriteLine($"{furniture.GetFurnitureStyle()} {furniture.GetFurnitureType()}");
    }
}
