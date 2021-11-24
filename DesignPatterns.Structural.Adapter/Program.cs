using DesignPatterns.Structural.Adapter.Holes;
using DesignPatterns.Structural.Adapter.Shapes;

namespace DesignPatterns.Structural.Adapter
{
    internal class Program
    {
        private const int Radius = 10;
        private const int Width = 10;

        private static void Main()
        {
            var roundHole = new RoundHole(Radius);

            roundHole.Fits(new RoundPeg
            {
                Radius = Radius
            });
            roundHole.Fits(new SquarePegAdapter
            {
                SquarePeg = new SquarePeg
                {
                    Width = Width
                }
            });
            roundHole.Fits(new SquarePegAdapter
            {
                SquarePeg = new SquarePeg
                {
                    Width = Width * 2
                }
            });
        }
    }
}
