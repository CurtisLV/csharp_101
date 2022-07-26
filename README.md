# csharp_101

## Methods

### Method Calls and Input

-   Call a method with its name and parentheses:

    ```cs
    VisitPlanets();
    ```

-   Store a method's returned value in a variable:

    ```cs
    double result = Math.Round(3.14159, 2);
    ```

-   Define a basic method with the following syntax:

    ```cs
    static void VisitPlanets(){}
    ```

-   Every time an application is started, the `Main()` method is called.
-   Values passed to a method are called *arguments*. When defined in the method, they are *parameters*.
-   Method parameters can only be used within the method body.
-   Method parameters can be *optional* if given a default value using equals `=` syntax:

    ```cs
    static void VisitPlanets(int numberOfPlanets = 0)
    ```

-   When calling a method, pass arguments by position or by name. If using names, use the colon (`:`) syntax:

    ```cs
    VisitPlanets(numberOfPlanets: 9);
    ```

-   In *method overloading*, multiple methods can have the same name, as long as they have different method *signatures*.
-   A method *signature* is a method's name and parameter types in order.

### Method Output

-   Methods return values with the `return` keyword.
-   Every method has a return type, designated in its method signature. That type must match the type of the value actually returned.
-   If a method returns no type, its return type is `void`.
-   `out` parameters can be used to return multiple values from a method.

### Alternate Expressions

*Expression-bodied definitions* can be used for one-line method bodies.

```cs
bool isEven(int num) => num % 2 == 0;
```

*Lambda expressions* can be used to create an anonymous method:

```cs
bool hasEvenNumbers = Array.Exists(numbers, (int num) => num % 2 == 0 );
```

You learned two "sub-shortcuts" within lambda expressions:

-   You can remove the parameter type if it can be inferred:

    ```cs
    bool hasEvenNumbers = Array.Exists(numbers, (num) => num % 2 == 0 );
    ```

-   You can remove the parentheses if there is one parameter:

    ```cs
    bool hasEvenNumbers = Array.Exists(numbers, num => num % 2 == 0 );
    ```

## Loops

-   A *loop* is a structure in programming where the instructions are written once, but a computer can execute them multiple times
-   Each execution of those instructions is called an *iteration*
-   `while` loops repeat until a condition changes
-   `do...while` loops execute once, and then repeat until a condition changes
-   `for` loops repeat for a specified number of times
-   `foreach` loops repeat for each item in a collection
-   _jump statements_, like `break`, `continue`, and `return` are used to add additional control flow to loops

## Basic Classes & Objects

### Class

-   A *class* represents a custom data type. In C#, the class defines the kinds of information and methods included in a custom type.
-   The process of creating an instance is called *instantiation*. Today we *instantiate* a class; yesterday they *instantiated* a class, and so on.

### Fields

-   Fields are one type of class *member*, which is the general term for the building blocks of a class.
-   It is common practice to name fields using all lowercase (`name` instead of `Name`). This makes fields easy to recognize later on.
-   Each instance has a `name` field, but the value may differ across instances.

### Properties

Properties are another type of class member. Each property is like a spokesperson for a field: it controls the access (getting and setting) to that field. We can use this to validate values before they are set to a field. A property is made up of two methods:

-   a `get()` method, or getter: called when the property is accessed
-   a `set()` method, or setter: called when the property is assigned a value

There are also _automatic property_:

```cs
public string Size
{
    get; set;
}
```

In this form, you don't have to write out the `get()` and `set()` methods, and you don't have to define a `size` field at all! A hidden field is defined in the background for us. All we have to worry about is the `Size` property.

Say we want programs to get the value of the property, but we don't want programs to set the value of the property. Then we either:

1.  don't include a `set()` method, or
2.  make the `set()` method private.

### Methods

The third type of member in classes is *methods*.
Methods are a useful way to organize chunks of code to perform a task. But most methods belong to a class, so methods are also used to define how an instance of a class behaves. You can think of them as the "actions" that an object can perform.

### Constructors

C# has a special type of method, called a *constructor*, a method that's run every time an object is created to set those values at once.
It looks like a method, but there is no return type listed and the method name is the name of its enclosing class:

```cs
class  Forest\
{\
  public  Forest()\
  {\
  }\
}
```

If no constructor is defined in a class, one is automatically created for us. It takes no parameters, so it's called a *parameterless constructor*.

### _this_ keyword

The parameter for the constructor `area` looks a lot like the old field `area` and the new property `Area`. It's good to be explicit when writing code so that there is no room for misinterpretation. We can refer to the current instance of a class with the `this` keyword.

```cs
class Forest
{  
    public int Area  
    {
        /* property omitted */
    }   

    public Forest(int area)  
    {    
        this.Area = area;  
    }
}
```

`this.Area = area` means "when this constructor is used to make a new instance, use the argument `area` to set the value of this new instance's `Area` field".

We would call it the same way:

```cs
Forest f = new Forest(400);
```

`f.Area` now equals 400.

The word `this` might seem frustratingly vague. Think back to the "class is to instance as blueprint is to house" analogy. The class/blueprint has to use the generic `this` because the class/blueprint is going to be reused for every instance/house.

### Overloading Constructors

Just like other methods, constructors can be overloaded. For example, we may want to define an additional constructor that takes one argument:

```cs
public Forest(int area, string country)
{   
    this.Area = area;  
    this.Country = country;
}

public Forest(int area)
{   
    this.Area = area;  
    this.Country = "Unknown";
}
```

The first constructor provides values for both fields, and the second gives a default value when the country is not provided. Now you can create a `Forest` instance in two ways:

```cs
Forest f = new Forest(800, "Hungary");
Forest f2 = new Forest(400);
```

Notice how we've written duplicate code for our second constructor: `this.Area = area;`. Later on, if we need to adjust the constructor, we'll need to find every copy of the code and make the exact same change. That means more work and chances for errors.

We have two options to resolve this. In either case we will remove the duplicated code:

1.  Use default arguments. This is useful if you are using C# 4.0 or later (which is fairly common) and the only difference between constructors is default values.

```cs
public Forest(int area, string country = "Unknown")
{  
    this.Area = area;  
    this.Country = country;
}
```

2\. Use `: this()`, which refers to another constructor in the same class. This is useful for old C# programs (before 4.0) and when your second constructor has additional functionality. This example has an additional functionality of announcing the default value.

```cs
public Forest(int area, string country)
{   
    this.Area = area;  
    this.Country = country;
}

public Forest(int area) : this(area, "Unknown")
{   
    Console.WriteLine("Country property not specified. Value defaulted to 'Unknown'.");
}
```

Remember that `this.Area` refers to the current instance of a class. When we use `this()` like a method, it refers to another constructor in the current class. In this example, the second constructor calls `this()` --- which refers to the first `Forest()` constructor --- AND it prints information to the console.

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

-   Every type, eventually, inherits from `Object`
-   `Object` members include `Equals()`, `ToString()`, and `GetType()`
-   The `ToString()` method allows `Console.WriteLine()` to work for all types

### String, the exception

-   The `String` or `string` type is a reference type
-   Strings are *immutable*, which means they cannot be changed after they are created
-   Being immutable also means that a `string` reference will always point to the original object, so "modifying" one reference to a `string` will not affect other references to it
-   With the equality operator (`==`), strings are checked for value, not referential, equality
-   A `string` variable can be unassigned, `null`, or empty. Empty strings can be represented by `String.Empty` or `""` --- they're equivalent

We've already seen one `static` property `Empty` and one `static` method, `IsNullOrEmpty()`:

```cs
string s = String.Empty;
bool isEmpty = String.IsNullOrEmpty(s);
```

### Lists

```cs
using System.Collections.Generic;
```

-   A list, or `List<T>`, is a generic, sequential data structure. The specific type that it contains is specified upon instantiation.
-   Lists are effectively unlimited. They "grow" and "shrink" as the number of elements rises and falls.
-   List values can be accessed by index using square brackets: `[ ]`.
-   To create an empty list, use a basic constructor. To create a list with values, use *object initialization*.
-   `Add()` is used to add an element to a list.
-   `Remove()` is used to remove an element from the list. It returns `true` if it is successful, `false` otherwise.
-   `Count` is the number of elements in the array.
-   `Contains()` returns `true` if the argument exists in the list, `false` otherwise.

-   Lists are a type of *generic collection*, which are defined with generic type parameters. The type parameters are specified when instantiating any generic class.

-   A sequence within a list is called a *range*. There are specific methods for working with ranges, including `GetRange()`, `AddRange()`, `InsertRange()`, and `RemoveRange()`.
    -   `AddRange()` --- takes an array or list as an argument. Adds the values to the end of the list. Returns nothing.
    -   `InsertRange()` --- takes an `int` and array or list as an argument. Adds the values at the `int` index. Returns nothing.
    -   `RemoveRange()` --- takes two `int` values. The first `int` is the index at which to begin removing and the second `int` is the number of elements to remove. Returns nothing.
    -   `GetRange()` --- takes two `int` values. The first `int` is the index of the first desired element and the second `int` is the number of elements in the desired range. Returns a list of the same type.

### LINQ

```cs
using System.Linq;
```

Often times we use LINQ with generic collections (like lists), so you may see both namespaces imported into a file:

```cs
using System.Collections.Generic;
using System.Linq;
```

-   *LINQ* is a set of language and framework features for writing structured, type-safe queries over local object collections and remote data sources.
-   Use LINQ by referencing the `System.Linq` namespace in your file.
-   When a LINQ query returns a sequence of elements its type is `IEnumerable<T>`. That means it works with `foreach` loops and its length is accessible with `Count()`.
-   Store a query's result in a variable of type `var`. `var` is an implicit type, meaning it gets all of the benefits of type-checking without our specifying the actual type.
-   LINQ queries can be written in *method syntax* or *query syntax*.
-   We prefer method syntax for single operations and query syntax for most everything else.
-   The `Where` operator is used to select certain elements from a sequence.
-   The `Select` operator determines what is returned for each element in the sequence.
-   The `from` operator declares a range variable that is used to traverse the sequence.
-   LINQ can be used on arrays and lists, among other datatypes.

```cs
      string[] heroes = { "D. Va", "Lucio", "Mercy", "Soldier 76", "Pharah", "Reinhardt" };

      // Query syntax
      var queryResult = from x in heroes
                        where x.Contains("a")
                        select $"{x} contains an 'a'";

      // Method syntax
      var methodResult = heroes
        .Where(x => x.Contains("a"))
        .Select(x => $"{x} contains an 'a'");

      // Printing...
      Console.WriteLine("queryResult:");
      foreach (string s in queryResult)
      {
        Console.WriteLine(s);
      }

      Console.WriteLine("\nmethodResult:");
      foreach (string s in methodResult)
      {
        Console.WriteLine(s);
      }
```
