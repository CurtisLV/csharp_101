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

### Reference fundamentals

-   Classes and interfaces are *reference types*. A variable of this type holds a reference to the data, not the data itself. This is different from *value types* like `int` and `bool`
-   The equality operator (`==`) uses a *referential* comparison for reference types and a *value* comparison for value types
-   Multiple references can be created for a single object
-   A reference and its corresponding object do not have to be the same type. For example, we can refer to a subclass object by an inherited superclass or implemented interface reference
-   The functionality available to an object reference is determined by the reference's type, not the object's type
-   *Polymorphism* is the ability in programming to present the same interface for differing data types
-   Referencing an object by an inherited type or implemented interface is called *upcasting*. It can be done implicitly
-   Referencing an object by a derived class is called *downcasting*, which must be made explicit by adding the type name in parentheses. It may cause an `InvalidCastException` error when the code is run
-   To signify that a reference is "empty" or refers to no object, we set it equal to `null`
-   If a reference is not set to any value it is *unassigned* and cannot perform any operations

### The Object class
