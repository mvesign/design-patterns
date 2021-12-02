# Abstract pattern

Abstract Factory is a creational design pattern that lets you produce families of related objects without specifying their concrete classes.

## When to use

* When code needs to work with various families of related types, but dependencies on concrete classes is not desirable. Either they are not known at the moment or they need to be allowed for future extensibility.

## Pros

* Types that are returned by the factory are compatible with each other.
* Avoid tight coupling between concrete types and client code.
* Single Responsibility Principle. Meaning product creation code can be moved into one place in the program, for easier support of the code.
* Open/Closed Principle. Possible to introduce new types without breaking existing client code.

## Cons

* Increase complexity of the code due to introduction of a lot of interfaces and classes to implement the pattern.