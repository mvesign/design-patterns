using DesignPatterns.Creational.FactoryMethod.Abstractions;

namespace DesignPatterns.Creational.FactoryMethod.Models;

/// <inheritdoc />
public class Tcp : ITransport
{
    /// <inheritdoc />
    public IEnumerable<string> SendPackage()
    {
        yield return $"{nameof(Tcp).ToUpper()} - Send SYN";
        yield return $"{nameof(Tcp).ToUpper()} - SYN received";
        yield return $"{nameof(Tcp).ToUpper()} - Send ACK";
    }
}