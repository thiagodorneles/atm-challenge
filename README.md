# ATM Challenge

You could find out which challenge is it [here](http://dojopuzzles.com/problemas/exibe/caixa-eletronico/)

## Stack

- C#
- Nuget - package manager
- xUnit - Testing framework
- Unity - Dependency Injection System

## Approach

The solution was designed with a few projects, and each one has one unique responsibility.

- Common = some utilities or classes that could be used for any other project. It contains some stuff like Extensions, exceptions and financial math functions.
- Models = its owns name already explain by yourself :).
- Interfaces = define the interfaces that will exist on the solution.
- Services = just business logic that implements the interfaces.
- DependencyInjection = system that controls and registers each module and your interface. And just this layer knows how to resolve each module.
- UnitTests = tests of our application.

# How to was coded

It's a simple application, so does not require a lot of explain.
But, there two things that I think important to say.

1) After decided how to architectured this application, all code was developt using TDD way.

2) I've decided to use a dependency injection (DI) system and to avoid some future issues and create a better isolating of some layers. None should know or instantiate a service directly.
The DI exists for it. Of course, for this kind of application is really small, and use a DI system could be considered an over-engineering, but I've decided to use it simulating a complex real-world application and create an architecture that already is ready to grow.

## Improvements / TODO

- Turn this application compatible with aspnet core. I didn't this right now just because of my computer (I'm using an older macbook) and it's not compatible with requirements to run the latest version of dotnet.
- Create a persistent layer with some database to persist all transactions and to know how many notes are there on the ATM machine and discount it after each withdrawal.
- Create a better layer of exceptions to be more abstract and reusable in application 