using DesignPatterns.AbstractFactory.Interfaces;

namespace DesignPatterns.AbstractFactory.Models
{
    /// <inheritdoc />
    public class ModernChair : IChair
    {
        /// <inheritdoc />
        public string GetName() => nameof(ModernChair);

        /// <inheritdoc />
        public bool HasLegs() => true;

        /// <inheritdoc />
        public bool CanSitOn() => true;
    }
}
