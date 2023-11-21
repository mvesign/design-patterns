using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;

namespace DesignPatterns.Structural.Flyweight;

public static class Program
{
    private static void Main(string[] args)
    {
        var regularTrees = Enumerable.Range(1, 1000)
            .Select(_ => new Regular.OakTree(Color.Brown, Color.Green, 100, 10))
            .ToArray();
        Console.WriteLine($"Byte size of trees without pattern: {regularTrees.TreesToByteArray().Length}");

        var tree = new Pattern.Tree(Color.Brown, Color.Green);
        var patternTrees = Enumerable.Range(1, 1000)
            .Select(_ => new Pattern.OakTree(tree, 100, 10))
            .ToArray();
        Console.WriteLine($"Byte size of trees with pattern: {patternTrees.TreesToByteArray().Length}");
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