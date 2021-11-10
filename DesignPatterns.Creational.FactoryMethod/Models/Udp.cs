using System;
using DesignPatterns.Creational.FactoryMethod.Abstractions;

namespace DesignPatterns.Creational.FactoryMethod.Models
{
    /// <inheritdoc />
    public class Udp : ITransport
    {
        /// <inheritdoc />
        public void SendPackage() => Console.WriteLine($"{nameof(Udp).ToUpper()} - Send");
    }
}
