using DesignPatterns.AbstractFactory.Models;

namespace DesignPatterns.AbstractFactory.Interfaces
{
    /// <summary>
    /// Piece of furniture.
    /// </summary>
    public interface IFurniture
    {
        /// <summary>
        /// Get name of the furniture.
        /// </summary>
        /// <returns>Furniture name.</returns>
        string GetName();

        /// <summary>
        /// Whether the furniture has legs to stand on.
        /// </summary>
        /// <returns>True when legs are present; Otherwise false.</returns>
        bool HasLegs();
        
        /// <summary>
        /// Whether the furniture is made to be sit on.
        /// </summary>
        /// <returns>True when it has a seat; Otherwise false.</returns>
        bool CanSitOn();
    }
}
