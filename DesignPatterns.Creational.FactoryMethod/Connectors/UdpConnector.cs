using DesignPatterns.Creational.FactoryMethod.Abstractions;
using DesignPatterns.Creational.FactoryMethod.Models;

namespace DesignPatterns.Creational.FactoryMethod.Connectors
{
    /// <inheritdoc />
    public class UdpConnector : IConnector
    {
        /// <inheritdoc />
        public ITransport CreateTransport() => new Udp();
    }
}
