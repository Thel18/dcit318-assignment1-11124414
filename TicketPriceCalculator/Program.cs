using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.Write("Enter your age (or Q to quit): ");
            string input = Console.ReadLine()?.Trim();

            if (string.Equals(input, "Q", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Goodbye!");
                break;
            }

            if (!int.TryParse(input, out int age) || age < 0)
            {
                Console.WriteLine("Invalid input. Please enter a valid age or Q to quit.\n");
                continue;
            }

            int price = (age <= 12 || age >= 65) ? 7 : 10;
            Console.WriteLine($"Your ticket price is GHC {price}.\n");
        }
    }
}

