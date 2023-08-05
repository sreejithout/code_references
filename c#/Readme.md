https://learn.microsoft.com/en-us/dotnet/csharp/
# Get Started
https://learn.microsoft.com/en-us/dotnet/csharp/tour-of-csharp/
## Introduction
  - .NET Architecture
  - Hello World
  - Types and variables
  - Program structure
## Types
  - Classes and objects
    - Type Parameters
    - Base Classes 
  - Structs
  - Record classes and structs
  - Interfaces
  - Enums
  - Nullable types
  - Tuples
## Program building blocks
  - Members
  - Accessibility
  - Fields
  - Methods
  - Parameters
  - Method body and local variables
  - Static and instance methods
  - Virtual, override, Abstrace methods
  - Method Overloading
  - Other Function members
  - Constructors
  - Properties
  - Indexers
  - Events
  - Operators
  - Finalizers
  - Expressions
  - Statements
## Major Language Areas
- Arrays, Collections and LINQ
- String Interpolation
- Pattern Matching
- Delegates and Lambda expressions
- async/await
- Attributes

# Fundamentals
https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/program-structure/
## Program Structure
- Overview
- Main Method
  - Main and command line arguments
  - Main return values
  - Async main return values
  - Command line arguments 
- Top Level Statements
  - Only one top level file
  - No other entry points
  - 'using' directives
  - Global namespace
  - Namespaces and type definitions
    - args
    - await
  - Exit Code for the process
  - Implicit entry point method
## Type System
- Overview
  - Specifying types in variable declarations
  - Built-in Types
  - Custom types
  - The common type system
    - Value Types
    - Reference Types
  - Types of literal values
  - Generic Types
  - Implicit types, anonymous types and nullable types
  - Compile-time type and Run-time type
- Namespaces
- Classes
  - Reference Types
  - Declaring classes
  - Creating objects
  - Constructors and initialization
  - Class inheritance 
- Records
  - When to use records
    - Value equality
    - Immutability
  - How records differ from classes and structs
- Interfaces
- Generics
- Anonymous Types
## Object oriented programming
- Classes, Structs and records
  - Encapsulation
  - Members
  - Accessibility
  - Inheritance
  - Interfaces
  - GenericTypes
  - Static Types
  - Nested Types
  - Partial Types
  - Object Initializers
  - Anonymous Types
  - Extension Methods
  - Implicitly Typed Local Variables
  - Records 
- Objects
  - Struct Instances vs Class Instances
  - Object Identity vs Value Equality
- Inheritance
  - Abstract and Virtual Methods
  - Abstract base classes
  - Interfaces
  - Preventing further derivation
  - Derived class hiding of base class members
- Polymorphism
  - Virtual members
  - Hide base class members with new members
  - Prevent derived classes from overriding virtual members
  - Access base class virtual members from derived classes 
## Functional Techniques
- Pattern Matching
  - Null checks
  - Type tests
  - Compare discrete values
  - Relational patterns
  - Multiple inputs
  - List patterns
- Discards
  - Tuple and object deconstruction
  - Pattern matching with 'switch'
  - Calls to methods with 'out' parameters
  - A standalone discard
- Deconstruting tuples and other types
  - Tuples
  - Tuple elements with discards
  - User-defined types
  - User-defined type with discards
  - Extension methods for user-defined types
  - Extension methods for system types
  - 'record' types
## Exceptions and Errors
- Overview
- Using Exceptions
- Exception handling
  - Catch blocks
  - Finally blocks 
- Creating and throwing exceptions
  - Things to avoid when throwing exceptions
  - Defining exception classes 
- Compiler generated exceptions
## Coding Style
- C# identifier naming rules and conventions
  - naming rules
  - naming conventions
  - Pascal case
  - Camel case
  - Type parameter naming guidelines
  - Extra naming conventions
- C# coding conventions
  - Tools and analyzers
  - Language guidelines
    - String data
    - Arrays
    - Delegates
    - 'try-catch' and 'using' statement in exception handling
    - '&&' and '||' operators
    - 'new' operator
    - Event handling
    - Static members
    - LINQ queries
    - Implicitly typed local variables
    - Place the using directives outside the namespace declaration
  - Style guidelines
    - Comment style
    - Layout conventions
  - Security Coding guidelines
  
# Language Integrated Query (LINQ)
https://learn.microsoft.com/en-us/dotnet/csharp/linq/
## Overview of LINQ
- Query Expression Overview
- How to enable LINQ querying of your data source
  - In-memory data
  - Remote data
- Iqueryable LINQ providers
## Getting Started with LINQ in C#
- Introduction to LINQ Queries
  - Three parts of a Query Operation
  - The Data Source
  - The Query
  - Query Execution
    - Deferred Execution
    - Forcing Immediate Execution
- Query Expression Basics
  - What is a query and what does it do?
  - What is a query expression
    - Query variable
    - Explicit and Implicit typing of query variables
  - Starting a query expression  
  - Ending a query expression
    - group clause
    - select clause
    - Continuations with into
  - Filtering, Ordering and joining
    - where clause
    - orderby clause
    - join clause
    - let clause
  - Subqueries in a query expression
- Write LNQ queries in C#
  - Standard query operator extension methods
  - Lambda expression
  - Composability of queries
  - Example - Query syntax
  - Example - Method syntax
  - Example - Mixed query and method syntax
- Type relationships in LINQ query operations
  - Queries that do not Transform the Source Data
  - Queries that Transform the Source Data
  - Letting the compiler infer type information
  - LINQ and Generic types
  - IEnumerable<T> variables in LINQ queries
  - Letting the compiler handle generic type declarations
- C# features that support LINQ
  - Query Expressions
  - Implicitly typed variables (var)
  - Object and Collection initializers
  - Anonymous Types
  - Extension Methods
## Standard Query Operations
### Overview
- Query expression syntax
- Extending the standard query operators
- Obtain a data source
- Filtering
- Ordering
- Grouping
- Joining
- Selecting (Projections)
- Query Expression Syntax Table
### Data Transformations with LINQ
- Joining Multiple Inputs into One Output Sequence
- Selecting a Subset of each Source Element
- Transforming In-Memory Objects into XML
- Performing Operations on Source Elements
### Store the results of a query in memory
- ToList
- ToArray
- ToDictionary
- ToLookup
### Filtering Data
- Methods
  - OfType
  - Where
- Query Expression syntax Example
### Projection Operations
- Methods
  - Select
  - SelectMany
  - Zip
  - Select vs SelectMany 
### Set Operations
- Methods
  - Distinct
  - DistinctBy
  - Except
  - ExceptBy
  - Intersect
  - IntersectBy
  - Union
  - UnionBy
### Sorting Data
- Methods
  - OrderBy
  - OrderByDescending
  - ThenBy
  - ThenByDescending
  - Reverse
- Primary Sort Examples
  - Primary Ascending Sort
  - Primary Descending Sort
- Secondary Sort Examples
  - Secondary Ascending Sort
  - Secondary Descending Sort
### Quantifier Operations
- Methods
  - All
  - Any
  - Contains
### Partitioning Data
- Operators
  - Skip
  - SkipWhile
  - Take
  - TakeWhile
  - Chunk
### Generation Operations
- Methods
  - DefaultIfEmpty
  - Empty
  - Range
  - Repeat
### Equality Operations
- Methods
  - SequenceEqual
### Element Operations
- Methods
  - ElementAt
  - ElementAtOrDefault
  - First
  - FirstOrDefault
  - Last
  - LastOrDefault
  - Single
  - SingleOrDefault
### Converting Data Types
- Methods
  - AsEnumerable 
  - AsQueryable
  - Cast
  - OfType
  - ToArray
  - ToDictionary
  - ToList
  - ToLookup
### Concatenation Operations
- Methods
  - Concat
### Aggregation Operations
- Methods
  - Aggregate
  - Average
  - Count
  - LongCount
  - Max or MaxBy
  - Min or MinBy
  - Sum
### Join Operations
- Overview
- Methods
  - Join
  - GroupJoin
#### Perform inner joins 
- Simple key join
- Composite key join
- Multiple join
- Inner join by using grouped join
#### Perform grouped joins
- Group join
- Group join to create XML
#### Perform left outer joins
#### Order the results of a join clause
#### join by using composite keys
#### Perform custom join operations

### Grouping Data
#### Overview
#### Group query results
#### Create a nested group
#### Perform a subquery on a grouping operation
#### Group results by contiguous keys

## LINQ to objects
## Walkthrough: Writing queries in C# (LINQ)
## LINQ and file directories
## How to Articles

# Asynchronous Programming
https://learn.microsoft.com/en-us/dotnet/csharp/asynchronous-programming/
## Overview
## Asynchronous programming scenarios
## Task Asynchronous programming model
## Async return types
## Process Asynchronous tasks as they complete
## Asynchronous file access
## Cancel a list of tasks
## Cancel tasks after a period of time
## Generate and consume Asynchronous streams

# C# Concepts
https://learn.microsoft.com/en-us/dotnet/csharp/nullable-references
## Nullable reference types
## Nullable reference migrations
## Methods
## Properties
## Indexers
## Iterators
## Delegates & Events
## Versioning

# Advanced Topics
https://learn.microsoft.com/en-us/dotnet/csharp/advanced-topics/reflection-and-attributes
## Reflection and Attributes
## Interface implementations
## Expression Trees
## Native interoperability
## Performance engineering

# C# Programming Guide
https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide
## Overview
## Programming Concepts
## Statements, expressions and equality
## Types
## Classes, Structs and Records
## Interfaces
## Delegates
## Arrays 
## Strings
## Indexers
## Events
## Generics

# Specifications
https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/specifications
## C#7
## C#8
## C#9
## C#10
## C#11
## C#12

# What's new in C#

