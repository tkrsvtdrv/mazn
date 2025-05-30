using System;

class PolynomialRoots
{
    static void Main()
    {
        Console.WriteLine("=== Polynomial Root Calculator ===");
        Console.WriteLine("For quadratic equation ax² + bx + c = 0");

        Console.Write("Enter coefficient a: ");
        if (!double.TryParse(Console.ReadLine(), out double a))
        {
            Console.WriteLine("Invalid input for coefficient a!");
            return;
        }

        Console.Write("Enter coefficient b: ");
        if (!double.TryParse(Console.ReadLine(), out double b))
        {
            Console.WriteLine("Invalid input for coefficient b!");
            return;
        }

        Console.Write("Enter coefficient c: ");
        if (!double.TryParse(Console.ReadLine(), out double c))
        {
            Console.WriteLine("Invalid input for coefficient c!");
            return;
        }
        Console.WriteLine($"\nSolving: {a}x² + {b}x + {c} = 0");

        if (a == 0)
        {
            if (b == 0)
            {
                if (c == 0)
                    Console.WriteLine("Infinite solutions (0 = 0)");
                else
                    Console.WriteLine("No solution");
            }
            else
            {
                double root = -c / b;
                Console.WriteLine($"Linear equation root: x = {root:F6}");
            }
        }
        else
        {
            double discriminant = b * b - 4 * a * c;
            Console.WriteLine($"Discriminant: {discriminant:F6}");

            if (discriminant > 0)
            {
                double root1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
                double root2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
                Console.WriteLine($"Two real roots:");
                Console.WriteLine($"x₁ = {root1:F6}");
                Console.WriteLine($"x₂ = {root2:F6}");
            }
            else if (discriminant == 0)
            {
                double root = -b / (2 * a);
                Console.WriteLine($"One repeated root: x = {root:F6}");
            }
            else
            {
                double realPart = -b / (2 * a);
                double imaginaryPart = Math.Sqrt(-discriminant) / (2 * a);
                Console.WriteLine($"Two complex roots:");
                Console.WriteLine($"x₁ = {realPart:F6} + {imaginaryPart:F6}i");
                Console.WriteLine($"x₂ = {realPart:F6} - {imaginaryPart:F6}i");
            }
        }

        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}
