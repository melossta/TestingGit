using System;

class Calculator
{
    static void Main()
    {
        double num1, num2, result;
        string operation;

        // Display the welcome message
        Console.WriteLine("Simple Calculator");
        Console.WriteLine("-------------------");

        // Input: First number
        Console.Write("Enter the first number: ");
        while (!double.TryParse(Console.ReadLine(), out num1))
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
            Console.Write("Enter the first number: ");
        }

        // Input: Operation
        Console.Write("Enter an operation (+, -, *, /): ");
        operation = Console.ReadLine();

        // Input: Second number
        Console.Write("Enter the second number: ");
        while (!double.TryParse(Console.ReadLine(), out num2))
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
            Console.Write("Enter the second number: ");
        }

        // Perform the calculation based on the operation
        switch (operation)
        {
            case "+":
                result = num1 + num2;
                Console.WriteLine($"Result: {num1} + {num2} = {result}");
                break;
            case "-":
                result = num1 - num2;
                Console.WriteLine($"Result: {num1} - {num2} = {result}");
                break;
            case "*":
                result = num1 * num2;
                Console.WriteLine($"Result: {num1} * {num2} = {result}");
                break;
            case "/":
                if (num2 != 0)
                {
                    result = num1 / num2;
                    Console.WriteLine($"Result: {num1} / {num2} = {result}");
                }
                else
                {
                    Console.WriteLine("Error: Cannot divide by zero.");
                }
                break;
            default:
                Console.WriteLine("Invalid operation. Please enter one of (+, -, *, /).");
                break;
        }

        // Wait for the user to close the program
        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }
}
