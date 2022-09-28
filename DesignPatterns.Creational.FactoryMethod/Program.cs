using DesignPatterns.Creational.FactoryMethod.Abstractions;
using DesignPatterns.Creational.FactoryMethod.Connectors;

SendPackageForConnector<TcpConnector>();
            
Console.WriteLine();

SendPackageForConnector<UdpConnector>();

static void SendPackageForConnector<TConnector>() where TConnector : IConnector, new() =>
    new TConnector()
        .CreateTransport()
        .SendPackage()
        .ToList()
        .ForEach(Console.WriteLine);