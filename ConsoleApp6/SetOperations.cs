using System;
using System.Collections.Generic;
using System.Linq;

class SetOperations
{
    static void Main()
    {
        Console.WriteLine("=== Set Operations ===");

        Console.Write("Enter first set (numbers separated by spaces): ");
        string input1 = Console.ReadLine();
        HashSet<int> set1 = ParseSet(input1);

        Console.Write("Enter second set (numbers separated by spaces): ");
        string input2 = Console.ReadLine();
        HashSet<int> set2 = ParseSet(input2);

        if (set1.Count == 0 || set2.Count == 0)
        {
            Console.WriteLine("Invalid input! Please enter valid numbers.");
            return;
        }

        Console.WriteLine($"\nSet A: {{{string.Join(", ", set1.OrderBy(x => x))}}}");
        Console.WriteLine($"Set B: {{{string.Join(", ", set2.OrderBy(x => x))}}}");

        var intersection = set1.Intersect(set2).OrderBy(x => x);
        Console.WriteLine($"\nIntersection (A ∩ B): {{{string.Join(", ", intersection)}}}");

        var union = set1.Union(set2).OrderBy(x => x);
        Console.WriteLine($"Union (A ∪ B): {{{string.Join(", ", union)}}}");

        var difference1 = set1.Except(set2).OrderBy(x => x);
        Console.WriteLine($"Difference (A - B): {{{string.Join(", ", difference1)}}}");

        var difference2 = set2.Except(set1).OrderBy(x => x);
        Console.WriteLine($"Difference (B - A): {{{string.Join(", ", difference2)}}}");

        var symmetricDiff = set1.Union(set2).Except(set1.Intersect(set2)).OrderBy(x => x);
        Console.WriteLine($"Symmetric Difference (A ⊕ B): {{{string.Join(", ", symmetricDiff)}}}");

        bool aSubsetB = set1.IsSubsetOf(set2);
        bool bSubsetA = set2.IsSubsetOf(set1);

        Console.WriteLine($"\nIs A ⊆ B? {aSubsetB}");
        Console.WriteLine($"Is B ⊆ A? {bSubsetA}");

        Console.WriteLine("Press any key to exit..."); Console.ReadKey();
    }

    static HashSet<int> ParseSet(string input)
    {
        HashSet<int> set = new HashSet<int>();

        if (string.IsNullOrWhiteSpace(input))
            return set;

        string[] parts = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);

        foreach (string part in parts)
        {
            if (int.TryParse(part, out int number))
                set.Add(number);
        }

        return set;
    }
}