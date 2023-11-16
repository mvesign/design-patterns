using System;
using System.Collections.Generic;
using System.Linq;

namespace DesignPatterns.Structural.Proxy;

public class ProxyService
{
    private FancyDatabaseService _fancyDatabaseService;
    private NonVolatileRecord[] _cachedCollection;
    
    public NonVolatileRecord[] GetLargeNonVolatileCollection()
    {
        Console.WriteLine("Get large non-volatile collection via Proxy service");

        if (_cachedCollection == null)
        {
            Console.WriteLine("Initialize database service.");
            _fancyDatabaseService ??= new FancyDatabaseService();

            Console.WriteLine("Setup large non-volatile collection in local cache.");
            _cachedCollection = _fancyDatabaseService.GetLargeNonVolatileCollection().ToArray();
        }

        return _cachedCollection;
    }
}