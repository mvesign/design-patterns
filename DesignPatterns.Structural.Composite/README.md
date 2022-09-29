# Composite

Composite is a structural design pattern that lets you compose objects into tree structures and then work with these structures as if they were individual objects.

## When to use

* When a tree-like object structure needs to be implemented.
* When both simple as complex elements need to be treated uniformly.

## Pros

* More convenient workflow with complex tree structures.
* Open/Closed Principle. Can introduce new element types without breaking existing code, which works with the object tree.

## Cons

* It might be difficult to provide a common interface for classes whose functionality differs too much. Overgeneralize can occur, which makes it harder to comprehend.
