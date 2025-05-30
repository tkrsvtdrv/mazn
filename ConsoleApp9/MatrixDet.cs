using System;

class MatrixDeterminant
{
    static void Main()
    {
        Console.WriteLine("=== 3x3 Matrix Determinant Calculator ===");
        double[,] matrix = new double[3, 3];

        Console.WriteLine("Enter the 3x3 matrix elements:");

        // Input matrix elements
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write($"Enter element [{i + 1},{j + 1}]: ");
                if (double.TryParse(Console.ReadLine(), out double value))
                {
                    matrix[i, j] = value;
                }
                else
                {
                    Console.WriteLine("Invalid input! Using 0.");
                    matrix[i, j] = 0;
                }
            }
        }

        // Display the matrix
        Console.WriteLine("\nYour matrix:");
        for (int i = 0; i < 3; i++)
        {
            Console.Write("| ");
            for (int j = 0; j < 3; j++)
            {
                Console.Write($"{matrix[i, j],6:F2} ");
            }
            Console.WriteLine("|");
        }

        // Calculate determinant using the rule of Sarrus
        double determinant =
            matrix[0, 0] * (matrix[1, 1] * matrix[2, 2] - matrix[1, 2] * matrix[2, 1]) -
            matrix[0, 1] * (matrix[1, 0] * matrix[2, 2] - matrix[1, 2] * matrix[2, 0]) +
            matrix[0, 2] * (matrix[1, 0] * matrix[2, 1] - matrix[1, 1] * matrix[2, 0]);

        Console.WriteLine($"\nDeterminant: {determinant:F6}");

        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}