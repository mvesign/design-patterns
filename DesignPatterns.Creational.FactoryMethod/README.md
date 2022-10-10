# Factory Method

Factory Method is a creational design pattern that provides an interface for creating objects in a superclass, but allows subclasses to alter the type of objects that will be created.

## When to use

* When the exact types and dependencies of the objects the code should work with are not clear beforehand.
* When allowing users of a library or framework with a way to extend the internal components.
* When it's required to reuse existing objects instead of rebuilding them each time.

## Pros

* Avoid tight coupling between creator and concrete types.
* Single Responsibility Principle. Meaning product creation code can be moved into one place in the program, for easier support of the code.
* Open/Closed Principle. Possible to introduce new types without breaking existing client code.

## Cons

* Increase complexity of the code due to introduction of a lot of subclasses to implement the pattern.

## Output

```
TCP - Send SYN
TCP - SYN received
TCP - Send ACK

UDP - Send
```
