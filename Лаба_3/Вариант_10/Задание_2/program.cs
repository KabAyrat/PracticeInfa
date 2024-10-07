using System;

class Program
{
    static void Main()
    {
        // Инициализация квадратной матрицы
        int[,] matrix = {
            { 1, 2, 3, 4 },
            { 5, 6, 1, 7 },
            { 4, 3, 2, 1 },
            { 8, 9, 7, 6 }
        };

        // Вывод исходной матрицы
        Console.WriteLine("Исходная матрица:");
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);
        
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(matrix[i, j] + "\t");
            }
            Console.WriteLine();
        }

        // Поиск строки с самой длинной возрастающей последовательностью
        int maxSequenceLength = 0;
        int rowWithLongestSeq = 0;

        for (int i = 0; i < rows; i++)
        {
            int currentSeqLength = 1;
            int maxCurrentSeqLength = 1;

            for (int j = 1; j < cols; j++)
            {
                if (matrix[i, j] > matrix[i, j - 1])
                {
                    currentSeqLength++;
                }
                else
                {
                    currentSeqLength = 1;
                }

                if (currentSeqLength > maxCurrentSeqLength)
                {
                    maxCurrentSeqLength = currentSeqLength;
                }
            }

            if (maxCurrentSeqLength > maxSequenceLength)
            {
                maxSequenceLength = maxCurrentSeqLength;
                rowWithLongestSeq = i;
            }
        }

        Console.WriteLine($"\nСтрока с самой длинной возрастающей последовательностью: {rowWithLongestSeq + 1}");

        // Замена первого и второго столбцов
        for (int i = 0; i < rows; i++)
        {
            int temp = matrix[i, 0];
            matrix[i, 0] = matrix[i, 1];
            matrix[i, 1] = temp;
        }

        // Вывод изменённой матрицы
        Console.WriteLine("\nМатрица после замены столбцов:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(matrix[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
}
