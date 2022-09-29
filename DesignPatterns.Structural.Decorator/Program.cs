using DesignPatterns.Structural.Decorator.Decorators;
using DesignPatterns.Structural.Decorator.Shapes;

new Circle().Draw();

Console.WriteLine();

new RedShapeDecorator(new Circle()).Draw();

Console.WriteLine();

new RedShapeDecorator(new Rectangle()).Draw();

Console.WriteLine();

new BlueBorderDecorator(new RedShapeDecorator(new Rectangle())).Draw();