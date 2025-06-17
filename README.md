> ### Using the RoadMap
>
> The **first video tutorial** in the  [Tools and Resources](#tools-and-resources)could be used as a continuous course, as it closely follows the structure of this roadmap and covers most essentials by the 7-hour mark.  
> For specific topics or deeper reference, the **second video series** (which is more standalone in nature) or the **official Microsoft Docs** can be helpful.
> This file could be used as a checklist 

---
# Essentials
---

## Environment Setup and Getting Started

- Install Visual Studio (Community Edition) or Visual Studio Code with the C# extension.
- Create a new console application
- In Visual Studio: File → New Project → Console App
- Understand the role of `.csproj` files.
- Learn how to use the `Main` method and how to run/debug the app.
---

## Language Basics and Syntax

- Value types: `int`, `float`, `double`, `bool`, `char`
- Reference types: `string`, arrays, objects
- Operators: arithmetic, logical, null-coalescing (`??`)
- Control structures: `if`, `else`, `switch`, loops (`for`, `while`, `do-while`, `foreach`)
- Type inference using `var`
- String interpolation
- Nullable value types
- Representing Constants with `enums` and `const`
- Importing namespaces
---

## Methods and Parameters

- Method declarations and return types
- Optional and named parameters
- Method overloading
- `ref`, `out`, and `params` modifiers
- Expression-bodied methods

---

## Collections

- Generic collections: `List<T>`, `Dictionary<TKey, TValue>`, `HashSet<T>` etc.
- Common collection operations (add, remove, iterate)
- LINQ : `Where`, `Select`, `FirstOrDefault`, `Any`, `All`, `ToList`
- LINQ method chaining 
- Query vs method syntax
- IEnumerable vs ICollection vs IList vs IQueryable
- Deferred execution in LINQ ( Specifically how execution is defferred in IEnumerable vs IQueryable)
---

## OOP
- The 4 Priciples 
- Defining classes and objects
- Constructors (default and parameterized)
- Fields, properties, and methods
- Access modifiers: `public`, `private`, `protected`, `internal`
- Static members
- Inheritance and base classes
- Abstract classes and interfaces
- Method overriding and the `virtual`/`override` keywords
- Sealed classes and the `new` keyword for method hiding

---

## Basics of Reflection 
- Checking types using `is`, `as`, `typeof()`, and `GetType()` 

---

## Generics

- Defining generic methods
- Defining generic classes
- Generic constraints using `where T : class`, `new()`, interface, etc.
- Real-world use: repositories, services, utilities 
	


## Extension Methods
- Declaring static methods in static classes
- Understanding `this` keyword in parameter to enable extension
- Common examples like `string.IsNullOrEmpty()`, `IEnumerable<T>.ToList()`
- When and when not to use extension methods


## Exception and Unmanaged Resource Handling

- `try`, `catch`, `finally` blocks
- Catching specific exceptions
- Custom exceptions
- Throwing exceptions
- Resource cleanup using `using` statements and `IDisposable`

---

## Working with the File System

- Reading and writing text files
  - `File.ReadAllText`, `File.WriteAllText`
  - `File.ReadAllLines`, `File.WriteAllLines`
- Using `StreamReader` and `StreamWriter` for large or streamed data
- Creating and managing folders (`Directory.CreateDirectory`, `Directory.Exists`)
- Combining and manipulating paths (`Path.Combine`, `Path.GetExtension`)
- Checking file existence (`File.Exists`)
- Deleting, copying, and moving files (`File.Delete`, `File.Move`, `File.Copy`)
- Appending content to files

## Asynchronous Programming

- Introduction to `Task` and `async/await`
- Writing asynchronous methods
- Using `Task.Run` , `Task.Delay` , `Task.WhenAll` etc.
- Exception handling in async methods


## Solution Structure and Dependencies



- Understanding the `.sln` file and solution-level organization [ref](https://learn.microsoft.com/en-us/visualstudio/ide/solutions-and-projects-in-visual-studio?view=vs-2022)
- Structure of a `.csproj` file
- Creating multiple projects within a solution 
- Referencing one project from another
- Class libraries vs executable projects
- Shared code organization and project layering (Core, UI, Service,Business, etc.)
- Avoiding circular dependencies between projects
- [External libraries using NuGet](https://learn.microsoft.com/en-us/nuget/consume-packages/install-use-packages-visual-studio)


---
# Good To Know
---
## Delegates, Lambdas, and Events

- Lambda expressions
- Anonymous methods
- Declaring and using delegates
- Built-in delegates: `Func`, `Action`, `Predicate`
- Events and event handling with `event` and `EventHandler`
- Passing Reference to Functions using delegates.
- Inline Functions
---

## Modern C# Language Features

- Switch expressions
- Pattern matching with `is` and `switch`
- Null-coalescing assignment (`??=`)
- Records and `with` expressions
- Target-typed `new` expressions e.g. `List<string> names = new();`  
- Deconstruction and tuples
- File-scoped namespaces
- Top-level statements

## Additional

- The C# Compiler (`csc.exe`)
- Common Language Runtime (CLR)
- Intermediate Language (MSIL / IL)
- The Compilation Process (C# → IL → Machine Code)
- Just-In-Time (JIT) vs Ahead-Of-Time (AOT) Compilation
- Garbage Collection and Memory Management
- NuGet package structure and versioning
- PackageReference and package restore behavior `packages.config` vs `ItemGroup`
- Common development-time and runtime dependencies
- Managing dependencies across multiple projects


---

## Best Practices

- Naming conventions (PascalCase, camelCase)
- When to use `var` vs explicit types
- Prefer properties over public fields
- Avoid magic numbers and hard-coded strings
- [Guide to conventions and Practices](https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/coding-style/coding-conventions)
---

## Tools and Resources
- [Video Tutorial](https://www.youtube.com/watch?v=M5ugY7fWydE) - Covers everything needed for most cases by the 7 hour mark 
- [The OG video tutorial series for c#, Boring but detailed](https://www.youtube.com/watch?v=SXmVym6L8dw&list=PLAC325451207E3105)
-  [Offcial Microsoft C# Guide](https://learn.microsoft.com/en-us/dotnet/csharp/)
- [Excercises](https://www.w3resource.com/csharp-exercises/)
- [dotnetfiddle.net](https://dotnetfiddle.net/) – run C# code online.
---

 
