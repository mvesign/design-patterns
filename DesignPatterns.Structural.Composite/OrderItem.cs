using System.Collections.Generic;
using System.Linq;

namespace DesignPatterns.Structural.Composite;

/// <summary>
/// Item on an order.
/// </summary>
public class OrderItem
{
    private readonly List<OrderItem> _subItems;
    private readonly int _price;

    /// <summary>
    /// Create an order item.
    /// </summary>
    /// <param name="name">Name of the order item.</param>
    /// <param name="price">Price of the order item.</param>
    public OrderItem(string name, int price = 0)
    {
        Name = name;
        _price = price;

        _subItems = new List<OrderItem>();
    }

    /// <summary>
    /// Name.
    /// </summary>
    public string Name { get; }

    /// <summary>
    /// Price of the order item and all of its sub order items.
    /// </summary>
    public int Price => _price + (_subItems?.Sum(_ => _.Price) ?? 0);

    /// <summary>
    /// Level of the current order item.
    /// </summary>
    public int Level { get; set; }

    /// <summary>
    /// Add a new sub order item to the current order item.
    /// </summary>
    /// <param name="orderItems">Set of order items of type <see cref="OrderItem"/>.</param>
    public void Add(params OrderItem[] orderItems)
    {
        var level = Level + 1;
        foreach (var orderItem in orderItems)
        {
            orderItem.Level = level;
            _subItems.Add(orderItem);
        }
    }

    /// <summary>
    /// Print the receipt of current order item.
    /// </summary>
    /// <returns>Total price of the current order item.</returns>
    public void PrintReceipt()
    {
        Console.WriteLine($"{new string(' ', Level)}{Price} - {Name}");
        _subItems.ForEach(_ => _.PrintReceipt());
    }
}