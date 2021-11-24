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

----

### Prototype

Prototype is a creational design pattern that lets you copy existing objects without making your code dependent on their classes.

#### When to use

* When code shouldn’t depend on the concrete classes of objects that needs to be copied.
* When reducing the number of subclasses, that only differ in the way they initialize their respective objects, is desired.
** Subclasses could have been created in order to create objects with a specific configuration.

#### Pros

* Can clone objects without coupling to their concrete classes.
* Can get rid of repeated initialization code in favor of cloning pre-built prototypes.
* Can produce complex objects more conveniently.
* Get an alternative to inheritance when dealing with configuration presets for complex objects.

#### Cons

* Cloning complex objects that have circular references might be very tricky.

----

### Singleton

Singleton is a creational design pattern that lets you ensure that a class has only one instance, while providing a global access point to this instance.

#### When to use

* When a class should have a single instance available to all clients.
* When stricter control over global variables is desired.

#### Pros

* Can be sure that a class has a single instance.
* Can gain a global access point to the single instance.
* Can only be initialized when it’s requested for the first time.

#### Cons

* Violates the Single Responsibility Principle. It solves two problems at the time.
* Can mask bad design. E.g. when components know too much about each other.
* Requires special treatment in a multithreaded environment so that multiple threads won’t create a singleton object several times.
* May be difficult to unit test client code with this instance because many test frameworks rely on inheritance when producing mock objects.
  * The constructor is private and overriding static methods is hard or impossible, requiring a creative way to mock the singleton.

----

## Structural

Structural patterns explain how to assemble objects and classes into larger structures while keeping these structures flexible and efficient.

### Adapter

Adapter is a structural design pattern that allows objects with incompatible interfaces to collaborate.

#### When to use

- When it's desired to use an existing class, but its interface isn’t compatible with the rest of the code.
- When it's desired to reuse several existing subclasses that lack common functionality that can’t be added to the superclass.

#### Pros

- Can separate the interface or data conversion code from the primary business logic of the program.
- Can introduce new types of adapters into the program without breaking existing client code.

#### Cons

- Overall complexity increases due to introduction of new interfaces and classes. Can be simpler to change service class to match rest of the code.