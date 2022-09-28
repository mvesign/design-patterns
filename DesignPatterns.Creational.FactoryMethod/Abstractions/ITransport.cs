namespace DesignPatterns.Creational.FactoryMethod.Abstractions;

/// <summary>
/// Method of transportation.
/// </summary>
public interface ITransport
{
    /// <summary>
    /// Send a package.
    /// </summary>
    IEnumerable<string> SendPackage();
}