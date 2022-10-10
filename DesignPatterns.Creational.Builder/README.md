# Builder

Builder is a creational design pattern that lets you construct complex objects step by step. The pattern allows you to produce different types and representations of an object using the same construction code.

## When to use

* To get ride of a “telescopic constructor” (e.g. a constructor with a lot of parameters with most of them as optional).
* When different representations of the same type needs to be created during run time.
* when construction of composite trees or other complex objects is desired.

## Pros

* Can construct objects step-by-step, defer construction steps or run steps recursively.
* Can reuse the same construction code when building various representations of products.
* Single Responsibility Principle. Can isolate complex construction code from the business logic of the product.

## Cons

* Increase complexity of the code due to introduction of multiple classes to implement the pattern.

## Output

```
Pizza Hawai with Tomato sauce and the toppings Mozzarella, Ham, Pineapple
Pizza Margherita with Tomato sauce and the toppings Mozzarella, Basil
Pizza Pepperoni with Tomato sauce and the toppings Mozzarella, Salami
Pizza Prosciutto e Funghi with Tomato sauce and the toppings Mozzarella, Ham, Mushroom
Pizza Tonno with Tomato sauce and the toppings Mozzarella, Tuna, Union
```
