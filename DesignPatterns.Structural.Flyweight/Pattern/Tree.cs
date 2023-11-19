using System.Drawing;

namespace DesignPatterns.Structural.Flyweight.Pattern;

public class Tree : ITree
{
    private readonly BaseTree _baseTree;

    public Tree(BaseTree baseTree, long height, long thickness)
    {
        _baseTree = baseTree;
		Height = height;
		Thickness = thickness;
    }

    public long Height { get; init; }

    public long Thickness { get; init; }

    public Color Bark => _baseTree.Bark;

    public Color Leaves => _baseTree.Leaves;
}