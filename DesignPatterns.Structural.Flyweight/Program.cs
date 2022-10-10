using DesignPatterns.Structural.Flyweight;

var colors = new[]
{
    "Red",
    "Green",
    "Blue"
};

foreach (var color in colors)
{
    Console.WriteLine($"{color} circles");
    for (var i = 0; i < 3; i++)
    {
        var circle = ShapeFactory.GetShape(ShapeType.Circle);
        circle.SetColor(color);
        circle.Draw();
    }
    Console.WriteLine();
}
