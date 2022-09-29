# Decorator

Decorator is a structural design pattern that lets you attach new behaviors to objects by placing these objects inside special wrapper objects that contain the behaviors.

## When to use

* When it's desired to assign extra behaviors to objects during runtime without breaking the code that uses these objects.
* When it’s not possible to extend an object’s behavior by using inheritance.

## Pros

* Extend an object’s behavior without making new subclasses.
* Add or remove responsibilities from an object during runtime.
* Can combine several behaviors by wrapping an object into multiple decorators.
* Single Responsibility Principle. Meaning a monolithic class that implements many possible variants of behavior, can be divide into several smaller classes.

## Cons

* It’s hard to remove a specific wrapper from the wrappers stack.
* It’s hard to implement a decorator in such a way that its behavior doesn’t depend on the order in the decorators stack.
* The initial configuration code of layers might look pretty ugly.
