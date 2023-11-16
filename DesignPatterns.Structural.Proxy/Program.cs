using System;
using DesignPatterns.Structural.Proxy;

var proxyService = new ProxyService();

Console.WriteLine("Attempt #1");
proxyService.GetLargeNonVolatileCollection();

Console.WriteLine("Attempt #2");
proxyService.GetLargeNonVolatileCollection();