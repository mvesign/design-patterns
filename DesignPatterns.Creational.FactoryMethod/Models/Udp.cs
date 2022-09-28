using DesignPatterns.Creational.FactoryMethod.Abstractions;

namespace DesignPatterns.Creational.FactoryMethod.Models;

/// <inheritdoc />
public class Udp : ITransport
{
    /// <inheritdoc />
    public IEnumerable<string> SendPackage()
    {
        yield return $"{nameof(Udp).ToUpper()} - Send";
    }
}