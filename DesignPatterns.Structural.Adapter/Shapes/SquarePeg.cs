namespace DesignPatterns.Structural.Adapter.Shapes
{
    /// <summary>
    /// Details of the square peg.
    /// </summary>
    public class SquarePeg
    {
        /// <summary>
        /// Width of the peg.
        /// </summary>
        public int Width { get; set; }

        /// <inheritdoc />
        public override string ToString() => $"with width {Width}";
    }
}
