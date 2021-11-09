using DesignPatterns.AbstractFactory.Interfaces;

namespace DesignPatterns.AbstractFactory.Models
{
    /// <inheritdoc />
    public class VictorianSofa : ISofa
    {
        /// <inheritdoc />
        public string GetName() => nameof(VictorianSofa);

        /// <inheritdoc />
        public bool HasLegs() => true;

        /// <inheritdoc />
        public bool CanSitOn() => true;
    }
}
