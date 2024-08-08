# Animal Behavior Simulation

A C# project demonstrating OOP principles through different animal behaviors.

## Features

- **Abstract base class `Animal`** with common properties and methods.
- **Subclasses** `Dog`, `Cat`, and `Frog` with specific behaviors.
- **Implementation of interfaces** `ILand` and `IWater`.
- **Usage of constants and readonly fields.**

## Usage

When initializing a specific animal, you need to provide its current mood as an integer:

- `MOOD_HAPPY = 1`
- `MOOD_SCARE = 2`

You can also initialize the animal with any integer other than 1 or 2 to represent a neutral mood.

**Example:**

Dog happyDog = new Dog(1);
Cat scaredCat = new Cat(2);
Frog neutralFrog = new Frog(3); // Neutral mood

// Change the mood later using the SET method
happyDog.SetMood(2); // Changes mood to scared

The mood parameter determines the behavior of the animal when you call the SayHello method.

## Getting Started

Clone the repository and open it in your preferred C# development environment (e.g., Visual Studio).

```bash
git clone https://github.com/osnatben/Animal-Behavior-Simulation.git



 
