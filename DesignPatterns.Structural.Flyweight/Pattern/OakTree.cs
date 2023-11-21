using System;
using System.Drawing;

namespace DesignPatterns.Structural.Flyweight.Pattern;

[Serializable]
public class OakTree
{
    private readonly Tree _tree;

    public OakTree(Tree tree, long height, long thickness)
    {
        _tree = tree;
		Height = height;
		Thickness = thickness;
    }

    public long Height { get; init; }

    public long Thickness { get; init; }

    public Color Bark => _tree.Bark;

    public Color Leaves => _tree.Leaves;
}