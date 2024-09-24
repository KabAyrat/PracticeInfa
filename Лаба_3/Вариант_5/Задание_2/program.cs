using System;

class Program
{
    static void Main()
    {
        int[,] matrix = {
            { 2, 4, 6 },
            { 7, 8, 10 },
            { 12, 14, 16 }
        };

        int size = matrix.GetLength(0);

        Console.WriteLine("Исходная матрица:");
        PrintMatrix(matrix);

        Console.WriteLine("\nНомера строк, состоящих только из четных элементов:");
        for (int i = 0; i < size; i++)
        {
            bool allEven = true;
            for (int j = 0; j < size; j++)
            {
                if (matrix[i, j] % 2 != 0)
                {
                    allEven = false;
                    break;
                }
            }
            if (allEven)
            {
                Console.WriteLine($"Строка {i + 1}");
            }
        }

        SwapRows(matrix, 0, 2);

        Console.WriteLine("\nМатрица после замены 1 и 3 строк:");
        PrintMatrix(matrix);
    }

    static void PrintMatrix(int[,] matrix)
    {
        int size = matrix.GetLength(0);
        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                Console.Write(matrix[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }

    static void SwapRows(int[,] matrix, int row1, int row3)
    {
        int size = matrix.GetLength(1);
        for (int j = 0; j < size; j++)
        {
            int temp = matrix[row1, j];
            matrix[row1, j] = matrix[row3, j];
            matrix[row3, j] = temp;
        }
    }
}
