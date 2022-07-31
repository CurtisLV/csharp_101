# csharp_101

## Interfaces & Inheritance

### Interfaces

-   In C#, an *interface* contains definitions for a group of related functionalities that a class can implement.
-   Interfaces are useful because they guarantee how a class behaves. This, along with the fact that a class can implement multiple interfaces, helps organize and modularize components of software.
-   It is best practice to start the name of an interface with "I".

<!-- Delete/amend the below -->

-   Learned that interfaces are useful to guarantee certain functionality across multiple classes
-   Built an interface using the `interface` keyword
-   Defined properties and methods (but not constructors or fields) in the interface
-   Built classes that implemented the interface
-   Added members to the classes that weren't specified in the interface

As a last note: a class can implement multiple interfaces. For example, `Sedan` could implement `IAutomobile` and a new `IRecyclable` interface. It would be useful to separate interfaces if they aren't related, i.e. not all automobiles are recyclable.

### Inheritance

-   *Inheritance* is a way to avoid duplication across multiple classes.
-   In inheritance, one class inherits the members of another class.
-   The class that inherits is called a *subclass* or *derived class*. The other class is called a *superclass* or *base class*.
-   We can access a superclass' members using `base`. This is very useful when calling the superclass' constructor.
-   We can restrict access to a superclass and its subclasses using `protected`.
-   We can override a superclass member using `virtual` and `override`.
-   We can make a member in a superclass without defining its implementation using `abstract`. This is useful if every subclass' implementation will be different.
