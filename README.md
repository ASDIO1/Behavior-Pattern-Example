# Behavior-Pattern-Example
This is a project made for studying purposes.

Simple example of behavior patterns for studying purposes.

## Table of contents

- [Thematic](#thematic)
- [Solution](#solution)
- [Documentation](#documentation)
- [Program guide](#program-guide)

## Thematic

The thematic that I proposed for this project is about the process of creating glass.

I chose this thematic to implement the **State** behavior pattern.

The states of glass are: Sand, Mixed state, Melting state, Molding state and the Finished glass state.

The explanation of each state is printed by each state when excecuting the main program (program.cs).

## Solution

As I mentioned before, I chose to implement a solution for this thematic using the **State** behavior pattern.

## Documentation

I added a class diagram and a sequence diagram.

Since the main program (program.cs) just calls 1 method I decided to make the sequence diagram about the "CreateGlass()" process that starts in the GlassCreator class and then starts "creating" glass passing through all the states of glass implemented in the program using the "HandleOperation()" method.

## Program guide

Run this program with a C# compiler.

The way I run this program is by excecuting the solution (.sln) file with visual studio 2019.

The program (program.cs) uses the **State** pattern and for each state the program prints a brief description of each state of glass.

The (.sln) file can be found at: Behavior-Pattern-Example\GlassCreationStates

If you want to check the classes used for the program go to: Behavior-Pattern-Example\GlassCreationStates\ConsoleApp1

