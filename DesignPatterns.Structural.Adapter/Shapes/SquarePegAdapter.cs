namespace DesignPatterns.Structural.Adapter.Shapes;

/// <summary>
/// Adapter for the square peg.
/// </summary>
public class SquarePegAdapter : RoundPeg
{
    /// <summary>
    /// Details of the square peg.
    /// </summary>
    public SquarePeg SquarePeg { get; set; }

    /// <summary>
    /// Calculated radius of the square peg.
    /// </summary>
    public override int Radius => (int)(SquarePeg.Width * Math.Sqrt(2) / 2);

    /// <inheritdoc />
    public override string ToString() =>
        $"{SquarePeg} and {base.ToString()}";
}