using DesignPatterns.Structural.Bridge.Images;
using DesignPatterns.Structural.Bridge.OperatingSystems;

new ConcreteImage(new Linux()).CheckImage();

Console.WriteLine();

new ConcreteImage(new MacOS()).CheckImage();

Console.WriteLine();

new ConcreteImage(new Windows()).CheckImage();