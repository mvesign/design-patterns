# Design Patterns

A set of projects for possible design patterns within C#.

## Creational

Creational design patterns are concerned with the way of creating objects. These design patterns are used when a decision must be made at the time of instantiation of a class (i.e. when creating an object of a class).

### Abstract pattern

Abstract Factory is a creational design pattern that lets you produce families of related objects without specifying their concrete classes.

#### When to use

* When code needs to work with various families of related types, but dependencies on concrete classes is not desirable. Either they are not known at the moment or they need to be allowed for future extensibility.

#### Pros

* Types that are returned by the factory are compatible with each other.
* Avoid tight coupling between concrete types and client code.
* Single Responsibility Principle. Meaning product creation code can be moved into one place in the program, for easier support of the code.
* Open/Closed Principle. Possible to introduce new types without breaking existing client code.

#### Cons

* Increase complexity of the code due to introduction of a lot of interfaces and classes to implement the pattern.

----

### Builder

Builder is a creational design pattern that lets you construct complex objects step by step. The pattern allows you to produce different types and representations of an object using the same construction code.

#### When to use

* To get ride of a “telescopic constructor” (e.g. a constructor with a lot of parameters with most of them as optional).
* When different representations of the same type needs to be created during run time.
* when construction of composite trees or other complex objects is desired.

#### Pros

* Can construct objects step-by-step, defer construction steps or run steps recursively.
* Can reuse the same construction code when building various representations of products.
* Single Responsibility Principle. Can isolate complex construction code from the business logic of the product.

#### Cons

* Increase complexity of the code due to introduction of multiple classes to implement the pattern.

----

### Factory Method

Factory Method is a creational design pattern that provides an interface for creating objects in a superclass, but allows subclasses to alter the type of objects that will be created.

#### When to use

* When the exact types and dependencies of the objects the code should work with are not clear beforehand.
* When allowing users of a library or framework with a way to extend the internal components.
* When it's required to reuse existing objects instead of rebuilding them each time.

#### Pros

* Avoid tight coupling between creator and concrete types.
* Single Responsibility Principle. Meaning product creation code can be moved into one place in the program, for easier support of the code.
* Open/Closed Principle. Possible to introduce new types without breaking existing client code.

#### Cons

* Increase complexity of the code due to introduction of a lot of subclasses to implement the pattern.
