using System.Collections.Generic;

namespace DesignPatterns.Structural.Proxy;

public class FancyDatabaseService
{
    public IEnumerable<NonVolatileRecord> GetLargeNonVolatileCollection()
    {
        yield return new NonVolatileRecord("Vitorino Derbiled");
        yield return new NonVolatileRecord("Apostol Iosifu");
        yield return new NonVolatileRecord("Davit Khan");
        yield return new NonVolatileRecord("Cerdic Oswine");
        yield return new NonVolatileRecord("Mordred Nil");
    }
}