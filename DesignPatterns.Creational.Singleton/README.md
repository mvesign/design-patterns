# Singleton

Singleton is a creational design pattern that lets you ensure that a class has only one instance, while providing a global access point to this instance.

## When to use

* When a class should have a single instance available to all clients.
* When stricter control over global variables is desired.

## Pros

* Can be sure that a class has a single instance.
* Can gain a global access point to the single instance.
* Can only be initialized when it’s requested for the first time.

## Cons

* Violates the Single Responsibility Principle. It solves two problems at the time.
* Can mask bad design. E.g. when components know too much about each other.
* Requires special treatment in a multithreaded environment so that multiple threads won’t create a singleton object several times.
* May be difficult to unit test client code with this instance because many test frameworks rely on inheritance when producing mock objects.
  * The constructor is private and overriding static methods is hard or impossible, requiring a creative way to mock the singleton.

## Output

```
Point #195794751
Point #195794751
Point #195794751
Point #195794751
Point #195794751
```