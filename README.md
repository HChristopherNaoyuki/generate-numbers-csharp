# Generate Numbers in C#

## Description
GenerateNumbersCs is a simple C# console application that generates three random numbers between 1 and 6 and displays them on the console. This project demonstrates the use of the `Random` class and basic exception handling in C#.

## Features
- Generates three random numbers between 1 and 6.
- Outputs the generated numbers to the console.
- Includes exception handling for unexpected errors.

## Code Overview
The `Program` class contains the `Main` method, which:
1. Creates a `Random` object instance.
2. Generates three random numbers between 1 and 6.
3. Outputs the generated numbers to the console.
4. Handles any unexpected exceptions and displays error messages.

## C# Script
```csharp
using System;

namespace GenerateNumbersCs
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            try
            {
                // Create a Random object instance
                Random rnd = new Random();

                // Generate three random numbers between 1 and 6 (inclusive)
                int num1 = rnd.Next(1, 7);
                int num2 = rnd.Next(1, 7);
                int num3 = rnd.Next(1, 7);

                // Output the generated numbers to the console
                Console.WriteLine(num1);
                Console.WriteLine(num2);
                Console.WriteLine(num3);
            }
            catch (Exception ex)
            {
                // Handle any unexpected exceptions
                Console.WriteLine("An error occurred: " + ex.Message);
            }
            finally
            {
                // Ensure that the program waits for a key press before exiting
                Console.ReadKey();
            }
        }
    }
}
```

---
