# Flyweight

Flyweight is a structural design pattern that lets you fit more objects into the available amount of RAM by sharing common parts of state between multiple objects instead of keeping all of the data in each object.

## When to use

* Only when the application must support a huge number of objects, which barely fit into the available RAM.

## Pros

* Can save lots of RAM, assuming the application has tons of similar objects.

## Cons

* Might trade RAM over CPU cycles when some of the context data needs to be recalculated each time a flyweight method is being called.
* Increase complexity of the code. New team members will always be wondering why the state of an entity was separated in such a way.

## Output

```
Red circles
Circle with properties [Color: Red, HashCode: 43495525]
Circle with properties [Color: Red, HashCode: 43495525]
Circle with properties [Color: Red, HashCode: 43495525]

Green circles
Circle with properties [Color: Green, HashCode: 43495525]
Circle with properties [Color: Green, HashCode: 43495525]
Circle with properties [Color: Green, HashCode: 43495525]

Blue circles
Circle with properties [Color: Blue, HashCode: 43495525]
Circle with properties [Color: Blue, HashCode: 43495525]
Circle with properties [Color: Blue, HashCode: 43495525]
```
