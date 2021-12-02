# Adapter

Adapter is a structural design pattern that allows objects with incompatible interfaces to collaborate.

## When to use

- When it's desired to use an existing class, but its interface isn’t compatible with the rest of the code.
- When it's desired to reuse several existing subclasses that lack common functionality that can’t be added to the superclass.

## Pros

- Can separate the interface or data conversion code from the primary business logic of the program.
- Can introduce new types of adapters into the program without breaking existing client code.

## Cons

- Overall complexity increases due to introduction of new interfaces and classes. Can be simpler to change service class to match rest of the code.