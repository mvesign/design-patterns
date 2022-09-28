namespace DesignPatterns.Structural.Adapter.Shapes;

/// <summary>
/// Details of a round peg.
/// </summary>
public class RoundPeg
{
    /// <summary>
    /// Radius of the peg.
    /// </summary>
    public virtual int Radius { get; set; }

    /// <inheritdoc />
    public override string ToString() =>
        $"with radius {Radius}";
}