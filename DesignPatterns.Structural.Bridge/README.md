# Bridge

Bridge is a structural design pattern that lets you split a large class or a set of closely related classes into two separate hierarchies (abstraction and implementation), which can be developed independently of each other.

## When to use

* When it's desired to decouple a monolithic class that has several variants of some functionality (like when various database servers can be worked with).
* When you need to extend a class in several perpendicular/orthogonal (independent) dimensions.
* When it's desired to be able to switch implementations at runtime

## Pros

* Applies the Open/Closed Principle. Can introduce new abstractions and implementations independently from each other.
* Applies the Single Responsibility Principle. Can focus on high-level logic in the abstraction and on platform details in the implementation.

## Cons

* Overall complexity increases due to introduction of new interfaces and classes. Can be simpler to change service class to match rest of the code.
