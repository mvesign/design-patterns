using DesignPatterns.Structural.Adapter.Shapes;

namespace DesignPatterns.Structural.Adapter.Holes;

/// <summary>
/// Details of a round hole.
/// </summary>
public class RoundHole
{
    /// <summary>
    /// Default constructor
    /// </summary>
    /// <param name="radius"><see cref="Radius"/></param>
    public RoundHole(int radius)
    {
        Radius = radius;
    }

    /// <summary>
    /// Radius of the hole.
    /// </summary>
    public int Radius { get; set; }

    /// <summary>
    /// Whether the peg will fit in the round hole or not.
    /// </summary>
    /// <param name="peg"><see cref="RoundPeg"/></param>
    public void Fits(RoundPeg peg)
    {
        Console.WriteLine($"Peg {peg}.");
        Console.WriteLine($"But does it fit in hole with radius {Radius}? {(Radius >= peg.Radius ? "Yes!" : "No!")}");
        Console.WriteLine();
    }
}