using System;
using System.Drawing;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace DesignPatterns.Structural.Flyweight;

public static class Program
{
    private static void Main(string[] args)
    {
        var regularTrees = new []
        {
            new Regular.Tree(Color.Brown, Color.Green, 100, 10),
            new Regular.Tree(Color.Brown, Color.Green, 150, 15),
            new Regular.Tree(Color.Brown, Color.Green, 200, 20),
            new Regular.Tree(Color.Brown, Color.Green, 250, 25)
        };
        Console.WriteLine($"Trees without pattern: {regularTrees.TreesToByteArray().Length}");

        var baseTree = new Pattern.BaseTree(Color.Brown, Color.Green);
        var patternTrees = new []
        {
            new Pattern.Tree(baseTree, 100, 10),
            new Pattern.Tree(baseTree, 150, 15),
            new Pattern.Tree(baseTree, 200, 20),
            new Pattern.Tree(baseTree, 250, 15)
        };
        Console.WriteLine($"Trees with pattern: {patternTrees.TreesToByteArray().Length}");
    }

    public static byte[] TreesToByteArray(this ITree[] trees)
    {
        var binaryFormatter = new BinaryFormatter();
        using var memoryStream = new MemoryStream();

        binaryFormatter.Serialize(memoryStream, trees);
        return memoryStream.ToArray();
    }
}