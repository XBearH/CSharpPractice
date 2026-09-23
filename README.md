# C# Console Practice

A progressive set of C# console exercises for building core programming skills before starting Unity projects.

Each exercise is an independent .NET console application. Work through the stages in order, write each solution yourself first, then test normal and boundary cases before comparing with any reference solution.

## Requirements

- Visual Studio Code
- .NET SDK
- Git

The projects currently target `net9.0`. Install the matching SDK, or retarget all projects to `net8.0` after installing the .NET 8 SDK.

## Run an Exercise

```powershell
dotnet run --project .\Task00\Task00.csproj
```

Create future exercises from the repository root with:

```powershell
dotnet new console -n TaskXX
```

## Learning Path

| Stage | Topics | Exercises |
| --- | --- | --- |
| 0 | Environment, console input and output | Task00 |
| 1 | Variables, operators, `if`, and `switch` | Task01-Task04 |
| 2 | `for`, `while`, and nested loops | Task05-Task08 |
| 3 | Methods, arrays, and `List<T>` | Task09-Task12 |
| 4 | Object-oriented programming | Task13-Task16 |
| 5 | Integrated console projects | Task17-Task18 |

## Exercise List

### Stage 0: Environment Familiarity

- **Task00 - Hello and Input:** Read a name and age, then print a greeting.

### Stage 1: Basic Syntax

- **Task01 - Two-Number Calculator:** Perform arithmetic and handle division by zero.
- **Task02 - Leap Year Check:** Apply the leap-year rules with logical operators.
- **Task03 - Grade Classification:** Convert a score into A-E and validate the range.
- **Task04 - Day of the Week:** Use `switch` to map a number from 1 to 7 to a weekday.

### Stage 2: Loops

- **Task05 - Sum from 1 to N:** Calculate a sum with a `for` loop.
- **Task06 - Number Guessing Game:** Use `Random` and a `while` loop.
- **Task07 - Multiplication Table:** Print the full 9 by 9 table with nested loops.
- **Task08 - Narcissistic Numbers:** Find three-digit numbers equal to the sum of their digit cubes.

### Stage 3: Methods, Arrays, and Lists

- **Task09 - Array Utilities:** Implement maximum, minimum, and average methods.
- **Task10 - Reverse an Array:** Reverse and print an integer array.
- **Task11 - Player Score Manager:** Manage scores through a `List<int>` menu.
- **Task12 - Password Validation:** Validate a password with a reusable method.

### Stage 4: Object-Oriented Programming

- **Task13 - Player Class:** Create a player with health, attack power, and behavior.
- **Task14 - Enemy Inheritance:** Derive an enemy class and override damage behavior.
- **Task15 - Protected Health Property:** Limit health to the range from 0 to 100.
- **Task16 - Turn-Based Battle:** Combine an enum, player, and enemy in a battle loop.

### Stage 5: Integrated Projects

- **Task17 - Student Management System:** Manage student records with classes and lists.
- **Task18 - Turn-Based RPG Battle:** Build a player-versus-boss console battle.

## Practice Rules

1. Complete the stages in order: 0, 1, 2, 3, 4, then 5.
2. Keep one exercise per project and use ASCII project names such as `Task00`.
3. Write the first version manually instead of copying a solution.
4. Test input validation and boundary cases before moving on.

Completing this path provides a foundation in C# syntax and object-oriented programming for later Unity development.
