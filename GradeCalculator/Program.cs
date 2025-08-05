using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.Write("Enter a numerical grade (0–100) or Q to quit: ");
            string input = Console.ReadLine()?.Trim();

            if (string.Equals(input, "Q", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Goodbye!");
                break;
            }

            if (!int.TryParse(input, out int grade) || grade < 0 || grade > 100)
            {
                Console.WriteLine("Invalid input. Please enter a number between 0 and 100, or Q to quit.");
                continue;
            }

            string letter;
            if      (grade >= 90) letter = "A";
            else if (grade >= 80) letter = "B";
            else if (grade >= 70) letter = "C";
            else if (grade >= 60) letter = "D";
            else                  letter = "F";

            Console.WriteLine($"Your letter grade is {letter}.\n");
        }
    }
}

