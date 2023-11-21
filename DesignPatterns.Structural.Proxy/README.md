I've always wanted to create small projects in which I could teach my self the meaning of a certain design pattern and gather the know-how on when to use it. This time I'm going to dive a bit into the `Proxy` design pattern.

### What is a Proxy design pattern?

Proxy is a **structural** design pattern, providing a placeholder for another object. Which, in general form, is a class acting as an interface to something like a network connection, large object in memory, database, or some other kind of resource that is expensive to duplicate.

### Why do we want a Proxy design pattern?

Because it's an interface to some kind of expensive resource, it can.

- Manage access.
  *Like in throughput or permissions.*

- Enable lazy initialization.
  *To avoid wasting system resources.*

- Perform local execution.
  *When the resource is located on a remote server.*

- Enable local caching.
  *To avoid expensive external connections when non-volatile resources in play.*

### How does a Proxy design pattern look like?

Well, because it's a class that acts like an interface, we should have a proxy class containing direct access to the resource class. In my example we're going to fake a database service that should have a direct connection with the database.

And because I like to separate functionalities we start with the database class, that can return a large collection with non-volatile records. No caching or local storing of data in this class required.

```csharp
public record NonVolatileRecord(string Name);

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
```

This fancy database service will be implemented by our proxy service. Which will only initiate the database service when required. And use a stupid way of caching to showcase the caching part as well.

```csharp
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
```

I've added some console writing so when we are going to test it, we see the power of the Proxy design pattern. But how to call this proxy service? Well, like so.

```csharp
var proxyService = new ProxyService();

Console.WriteLine("Attempt #1");
proxyService.GetLargeNonVolatileCollection();

Console.WriteLine("Attempt #2");
proxyService.GetLargeNonVolatileCollection();
```

Now we can build and run this piece of code, which will write some logging to the console.

> Attempt #1
> 
> Get large non-volatile collection via Proxy service
> Initialize database service.
> Setup large non-volatile collection in local cache.
> Attempt #2
> Get large non-volatile collection via Proxy service

And there you have it. A small project containing the Proxy design pattern.
