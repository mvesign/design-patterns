using System;
using System.Drawing;

namespace DesignPatterns.Structural.Flyweight.Regular;

[Serializable]
public class OakTree
{
    public OakTree(Color bark, Color leaves, long height, long thickness)
    {
        Bark = bark;
        Leaves = leaves;
		Height = height;
		Thickness = thickness;
    }

    public long Height { get; init; }

    public long Thickness { get; init; }

    public Color Bark { get; init; }

    public Color Leaves { get; init; }
}