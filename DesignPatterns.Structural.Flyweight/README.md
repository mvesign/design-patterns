I've always wanted to create small projects in which I could teach my self the meaning of a certain design pattern and gather the know-how on when to use it. This time I'm going to dive a bit into the `Flyweight` design pattern.

### What is a Flyweight design pattern?

Flyweight is a **structural** design pattern, where the idea is to put more objects into the available amount of RAM by sharing common parts of these objects instead of keeping all of the data in each object. E.g. a sprite image of a game or the data structures used representing characters in a word processor.

### Why do we want a Flyweight design pattern?

Mainly when we want to save memory usage of our application, we can use the Flyweight design pattern.

But only when the reason of the memory exhaustion is due to the large amount of objects in which a duplicate state is present, which we can extract and share between multiple objects.

### How does a Flyweight design pattern look like?

Before we are going to have a look at the Flyweight design pattern implementation, let's have a look how a regular class with possible duplicate properties can look like. For this example I'm using a tree object in a game design.

```csharp
public class RegularOakTree
{
    public RegularOakTree(Color bark, Color leaves, long height, long thickness)
    {
        Bark = bark;
        Leaves = leaves;
        Height = height;
        Thickness = thickness;
    }

    public long Height { get; init; }

    public long Thickness { get; init; }

    public Color Bark { get; init; }

    public Color Leaves { get; init; }
}
```

In this example we have an oak tree, where for each oak the height and thickness can vary depening of the age of the oak. But the properties defining the color of the bark or leaves will always be the same for any type of tree.

In order to reduce the memory of this game, we can implement the Flyweight design pattern by moving these properties to a predefined `Tree` class. And use this object in our `OakTree` class. So let's define the `Tree` class.

```csharp
public record Tree(Color Bark, Color Leaves);
```

An instance of this class must be given to our `OakTree` class, and used as the output for the existing `Bark` and `Leaves` properties like so.

```csharp
public class OakTree
{
    private readonly Tree _baseTree;

    public PatternOakTree(Tree baseTree, long height, long thickness)
    {
        _baseTree = baseTree;
        Height = height;
        Thickness = thickness;
    }

    public long Height { get; init; }

    public long Thickness { get; init; }

    public Color Bark => _baseTree.Bark;

    public Color Leaves => _baseTree.Leaves;
}
```

### Cool, and does this work?

Yes and no. It will work and run as expected and lowers the memory size, but is it worth the extra complexity we have added when the number of `PatternOakTree` objects is on the low side?

Let's figure that out by wrapping it up in a small `Program` class.

```csharp
public static class Program
{
    private static void Main(string[] args)
    {
        var regularTrees = Enumerable.Range(1, 5)
            .Select(_ => new RegularOakTree(Color.Brown, Color.Green, 100, 10))
            .ToArray();
        Console.WriteLine($"Trees without pattern: {regularTrees.TreesToByteArray().Length}");

        var tree = new Pattern.Tree(Color.Brown, Color.Green);
        var patternTrees = Enumerable.Range(1, 5)
            .Select(_ => new PatternOakTree(tree, 100, 10))
            .ToArray();
        Console.WriteLine($"Trees with pattern: {patternTrees.TreesToByteArray().Length}");
    }

    public static byte[] TreesToByteArray(this object[] trees)
    {
        // Yes, I know. The BinaryFormatter is not safe and should not be used.
        // But this is just to show the power of the Flyweight design pattern, so quit whining.
        #pragma warning disable SYSLIB0011
        var binaryFormatter = new BinaryFormatter();
        using var memoryStream = new MemoryStream();

        binaryFormatter.Serialize(memoryStream, trees);
        return memoryStream.ToArray();
        #pragma warning restore SYSLIB0011
    }
}
```

This small program will first create an array of 5 `RegularOakTree` objects, calculates the size of these objects by converting it into a byte array and prints it out to the console. The same will be done for 5 `PatternOakTree` objects. Giving us the output in the console.

```
Byte size of trees without pattern: 911
Byte size of trees with pattern: 882
```

The size of the `PatternOakTree` objects are lower, but the difference is not worth the extra complexity we have added with the Flyweight design pattern.

So when is the extra complexity worth it? That depends on the duplicating properties. In this case the fun really begins when we change the `Enumerable.Range(1, 5)` to `Enumerable.Range(1, 1000)`. Creating 1000 objects of each type of oak tree. Giving us the following output in the console.

```
Byte size of trees without pattern: 74541
Byte size of treese with pattern: 35707
```

### Something more about the Flyweight design pattern?

Yes. When creating a multi-threaded application in combination with the Flyweight design pattern, there are two options possible.

1. Make flyweight instantiation single-threaded. Which introduces contention and ensures one instance per value.
2. Allow concurrent threads to create multiple flyweight instances. Which eliminates contention and allows multiple instances per value.

To ensure safe sharing between threads, Flyweight objects can be made into immutable value objects. C# 9 introduced a new type which can help with this, called `Records`.

```csharp
public record BaseTree(Color Bark, Color Leaves);
```
