using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("Enter three side lengths (or type Q to quit):");

            Console.Write("Side A: ");
            string aInput = Console.ReadLine()?.Trim();
            if (aInput.Equals("Q", StringComparison.OrdinalIgnoreCase)) break;

            Console.Write("Side B: ");
            string bInput = Console.ReadLine()?.Trim();
            if (bInput.Equals("Q", StringComparison.OrdinalIgnoreCase)) break;

            Console.Write("Side C: ");
            string cInput = Console.ReadLine()?.Trim();
            if (cInput.Equals("Q", StringComparison.OrdinalIgnoreCase)) break;

            if (!double.TryParse(aInput, out double a) ||
                !double.TryParse(bInput, out double b) ||
                !double.TryParse(cInput, out double c) ||
                a <= 0 || b <= 0 || c <= 0)
            {
                Console.WriteLine("Invalid input. Please enter positive numbers only.\n");
                continue;
            }

            // Triangle inequality check
            if (a + b <= c || a + c <= b || b + c <= a)
            {
                Console.WriteLine("The values entered cannot form a valid triangle.\n");
                continue;
            }

            // Determine triangle type
            string type = (a == b && b == c) ? "Equilateral"
                         : (a == b || b == c || a == c) ? "Isosceles"
                         : "Scalene";

            Console.WriteLine($"This is a(n) {type} triangle.\n");
        }

        Console.WriteLine("Goodbye!");
    }
}

