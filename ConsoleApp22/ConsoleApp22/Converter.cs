using System;

class ConvertNumberBase
{
    static void Main()
    {
        Console.WriteLine("Въведи число:");
        string input = Console.ReadLine();

        Console.WriteLine("Избери операция:");
        Console.WriteLine("1. Десетично -> Друга");
        Console.WriteLine("2. Друга -> Десетично");

        int choice = int.Parse(Console.ReadLine());

        if (choice == 1)
        {
            Console.WriteLine("Избери бройна система (напр. 2 за двоична, 8 за осмична, 16 за шестнайсетична):");
            int baseTo = int.Parse(Console.ReadLine());
            int number = int.Parse(input);
            string result = Convert.ToString(number, baseTo);
            Console.WriteLine($"Резултат: {result}");
        }
        else if (choice == 2)
        {
            Console.WriteLine("Въведи бройната система на числото (напр. 2, 8, 16):");
            int baseFrom = int.Parse(Console.ReadLine());
            int result = Convert.ToInt32(input, baseFrom);
            Console.WriteLine($"Десетично: {result}");
        }
        else
        {
            Console.WriteLine("Невалиден избор.");
        }
    }
}
