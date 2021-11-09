using System;
using DesignPatterns.AbstractFactory.Models;
using DesignPatterns.AbstractFactory.Services;

namespace DesignPatterns.AbstractFactory
{
    internal class Program
    {
        private static void Main()
        {
            foreach (var type in Enum.GetValues<FurnitureType>())
                type.CreateFurnitureFactory().ProduceFurniture();
        }
    }
}
