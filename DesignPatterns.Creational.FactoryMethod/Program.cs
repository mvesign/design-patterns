using System;
using DesignPatterns.Creational.FactoryMethod.Abstractions;
using DesignPatterns.Creational.FactoryMethod.Connectors;

namespace DesignPatterns.Creational.FactoryMethod
{
    internal class Program
    {
        private static void Main()
        {
            SendPackageForConnector<TcpConnector>();
            
            Console.WriteLine();

            SendPackageForConnector<UdpConnector>();
        }

        private static void SendPackageForConnector<TConnector>() where TConnector : IConnector, new() =>
            new TConnector()
                .CreateTransport()
                .SendPackage();
    }
}
