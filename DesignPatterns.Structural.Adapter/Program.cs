using DesignPatterns.Structural.Adapter.Holes;
using DesignPatterns.Structural.Adapter.Shapes;

const int radius = 10;
const int width = 10;

var roundHole = new RoundHole(radius);

roundHole.Fits(new RoundPeg
{
    Radius = radius
});
roundHole.Fits(new SquarePegAdapter
{
    SquarePeg = new SquarePeg
    {
        Width = width
    }
});
roundHole.Fits(new SquarePegAdapter
{
    SquarePeg = new SquarePeg
    {
        Width = width * 2
    }
});