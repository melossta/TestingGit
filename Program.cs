using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter your name: ");
        string name = Console.ReadLine();

        Console.WriteLine(name);

        Console.Write("Enter your age: ");
        int age;
        while (!int.TryParse(Console.ReadLine(), out age) || age < 0)
        {
            Console.WriteLine("Please enter a valid positive number for your age.");
            Console.Write("Enter your age: ");
        }

        int currentYear = DateTime.Now.Year;
        int birthYear = currentYear - age;

        // Display the result
        Console.WriteLine($"\nHello, {name}! Based on your age, you were likely born in {birthYear}.");

        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }
}
