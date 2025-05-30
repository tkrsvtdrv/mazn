using System;
using System.Linq;

class StatisticsFromList
{
    static void Main()
    {
        Console.Write("Въведи числа, разделени с ',': ");
        var nums = Console.ReadLine().Split(',').Select(double.Parse).ToList();

        double avg = nums.Average();
        double median = nums.OrderBy(n => n).ElementAt(nums.Count / 2);
        double mode = nums.GroupBy(n => n).OrderByDescending(g => g.Count()).First().Key;

        Console.WriteLine($"Средно: {avg:F2}, Медиана: {median}, Мода: {mode}");
    }
}