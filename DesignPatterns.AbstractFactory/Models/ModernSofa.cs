using DesignPatterns.AbstractFactory.Interfaces;

namespace DesignPatterns.AbstractFactory.Models
{
    /// <inheritdoc />
    public class ModernSofa : ISofa
    {
        /// <inheritdoc />
        public string GetName() => nameof(ModernSofa);

        /// <inheritdoc />
        public bool HasLegs() => true;

        /// <inheritdoc />
        public bool CanSitOn() => true;
    }
}
