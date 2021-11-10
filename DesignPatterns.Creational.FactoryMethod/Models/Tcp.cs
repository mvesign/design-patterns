using System;
using System.Collections.Generic;
using DesignPatterns.Creational.FactoryMethod.Abstractions;

namespace DesignPatterns.Creational.FactoryMethod.Models
{
    /// <inheritdoc />
    public class Tcp : ITransport
    {
        /// <inheritdoc />
        public void SendPackage() =>
            new List<string>
                {
                    $"{nameof(Tcp).ToUpper()} - Send SYN",
                    $"{nameof(Tcp).ToUpper()} - SYN received",
                    $"{nameof(Tcp).ToUpper()} - Send ACK"
                }
                .ForEach(Console.WriteLine);
    }
}
