using DesignPatterns.AbstractFactory.Interfaces;

namespace DesignPatterns.AbstractFactory.Models
{
    /// <inheritdoc />
    public class VictorianChair : IChair
    {
        /// <inheritdoc />
        public string GetName() => nameof(VictorianChair);

        /// <inheritdoc />
        public bool HasLegs() => true;

        /// <inheritdoc />
        public bool CanSitOn() => true;
    }
}
