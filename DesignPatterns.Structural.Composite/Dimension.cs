using System.Collections.Generic;

namespace DesignPatterns.Structural.Composite;

/// <summary>
/// Geometric dimension.
/// </summary>
public class Dimension
{
    /// <summary>
    /// Create a dimension.
    /// </summary>
    /// <param name="name">Name of the dimension.</param>
    public Dimension(string name)
    {
        Name = name;
    }

    /// <summary>
    /// Level of the dimension.
    /// </summary>
    public int Level { get; set; }

    /// <summary>
    /// Name of the dimension.
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Set of follow-up dimensions.
    /// </summary>
    public List<Dimension> Dimensions { get; } = new();

    /// <summary>
    /// Add a new dimension in the follow-up dimension level.
    /// </summary>
    /// <param name="dimensions">Set of dimensions.</param>
    public void Add(params Dimension[] dimensions)
    {
        var level = Level + 1;
        foreach (var dimension in dimensions)
        {
            dimension.Level = level;
            Dimensions.Add(dimension);
        }
    }

    /// <summary>
    /// Draw the current dimension and its follow-up dimensions.
    /// </summary>
    public void Draw()
    {
        Console.WriteLine($"{new string(' ', Level)}{Level} - {Name}");
        Dimensions.ForEach(_ => _.Draw());
    }
}