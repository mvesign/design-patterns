# Prototype

Prototype is a creational design pattern that lets you copy existing objects without making your code dependent on their classes.

## When to use

* When code shouldn’t depend on the concrete classes of objects that needs to be copied.
* When reducing the number of subclasses, that only differ in the way they initialize their respective objects, is desired.
** Subclasses could have been created in order to create objects with a specific configuration.

## Pros

* Can clone objects without coupling to their concrete classes.
* Can get rid of repeated initialization code in favor of cloning pre-built prototypes.
* Can produce complex objects more conveniently.
* Get an alternative to inheritance when dealing with configuration presets for complex objects.

## Cons

* Cloning complex objects that have circular references might be very tricky.