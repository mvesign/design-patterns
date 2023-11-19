I've always wanted to create small projects in which I could teach my self the meaning of a certain design pattern and gather the know-how on when to use it. This time I'm going to dive a bit into the `Flyweight` design pattern.

### What is a Flyweight design pattern?

Flyweight is a **structural** design pattern, where the idea is to put more objects into the available amount of RAM by sharing common parts of these objects instead of keeping all of the data in each object. E.g. a sprite image of a game or the data structures used representing characters in a word processor.

### Why do we want a Flyweight design pattern?

Mainly when we want to save memory usage of our application, we can use the Flyweight design pattern.

But only when the reason of the memory exhaustion is due to the large amount of objects in which a duplicate state is present, which we can extract and share between multiple objects.

### How does a Flyweight design pattern look like?



### Something note worthy about Flyweight design pattern?

Yes. When creating a multi-threaded application in combination with the Flyweight design pattern, there are two options possible.

1. Make flyweight instantiation single-threaded. Which introduces contention and ensures one instance per value.
2. Allow concurrent threads to create multiple flyweight instances. Which eliminates contention and allows multiple instances per value.

To ensure safe sharing between threads, Flyweight objects can be made into immutable value objects. C# 9 introduced a new type which can help with this called [Records](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/record).

```csharp
public record 
```


