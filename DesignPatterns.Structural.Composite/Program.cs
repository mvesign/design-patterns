using DesignPatterns.Structural.Composite;

var sphere = new Dimension("Sphere");
var cylinder = new Dimension("Cylinder");
var cube = new Dimension("Cube");
var circle = new Dimension("Circle");
var square = new Dimension("Square");
var line = new Dimension("Line");
var point = new Dimension("Point");

point.Add(line);
line.Add(circle, square);
circle.Add(sphere, cylinder);
square.Add(cube);

point.Draw();