using System;
using DesignPatterns.Creational.AbstractFactory.Models;
using DesignPatterns.Creational.AbstractFactory.Services;

namespace DesignPatterns.Creational.AbstractFactory
{
    internal class Program
    {
        private static void Main()
        {
            foreach (var type in Enum.GetValues<FurnitureStyle>())
                type.CreateFurnitureFactory().ProduceFurniture();
        }
    }
}
