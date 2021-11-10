namespace DesignPatterns.Creational.FactoryMethod.Abstractions
{
    /// <summary>
    /// Connector that can handle transportations of packages
    /// </summary>
    public interface IConnector
    {
        /// <summary>
        /// Create a transport instance.
        /// </summary>
        /// <returns><see cref="ITransport"/></returns>
        ITransport CreateTransport();
    }
}
