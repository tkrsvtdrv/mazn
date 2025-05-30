using System;

class Combinatorics
{
    static void Main()
    {
        Console.WriteLine("=== Combinatorics Calculator ===");

        Console.Write("Enter n (total items): ");
        if (!int.TryParse(Console.ReadLine(), out int n) || n < 0)
        {
            Console.WriteLine("Invalid input for n");
            return;
        }

        Console.Write("Enter r (items to choose): ");
        if (!int.TryParse(Console.ReadLine(), out int r) || r < 0)
        {
            Console.WriteLine("Invalid input for r");
            return;
        }

        if (r > n)
        {
            Console.WriteLine("r cannot be greater than n");
            return;
        }

        try
        {
            long nFact = Factorial(n);
            long rFact = Factorial(r);
            long nMinusRFact = Factorial(n - r);

            long nCr = nFact / (rFact * nMinusRFact);
            long nPr = nFact / nMinusRFact;

            Console.WriteLine($"nCr (Combinations): {nCr}");
            Console.WriteLine($"nPr (Permutations): {nPr}");
        }
        catch (OverflowException)
        {
            Console.WriteLine("Calculation overflowed try smaller numbers");
        }

        Console.WriteLine("Press any key to exit");
        Console.ReadKey();
    }

    static long Factorial(int num)
    {
        if (num <= 1) return 1;
        long result = 1;
        for (int i = 2; i <= num; i++)
        {
            result *= i;
        }
        return result;
    }
}