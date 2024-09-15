using System;
using System.Linq;

class Program
{
    static void Main()
    {
        // Пример одномерного массива
        int[] arr = { 3, -2, 5, 8, -7, 6, -4, 1 };

        // Вывод массива на экран
        Console.WriteLine("Массив: " + string.Join(", ", arr));

        // 1. Поиск максимального по модулю элемента
        int maxAbs = arr.OrderByDescending(Math.Abs).First();
        Console.WriteLine("Максимальный по модулю элемент: " + maxAbs);

        // 2. Поиск первого и второго отрицательных элементов
        int firstNegativeIndex = Array.FindIndex(arr, x => x < 0);
        int secondNegativeIndex = Array.FindIndex(arr, firstNegativeIndex + 1, x => x < 0);

        if (firstNegativeIndex != -1 && secondNegativeIndex != -1)
        {
            // 3. Вычисление среднего арифметического между первым и вторым отрицательными элементами
            int sum = 0;
            int count = 0;

            for (int i = firstNegativeIndex + 1; i < secondNegativeIndex; i++)
            {
                sum += arr[i];
                count++;
            }

            if (count > 0)
            {
                double avg = (double)sum / count;
                Console.WriteLine("Среднее арифметическое элементов между первым и вторым отрицательными элементами: " + avg);
            }
            else
            {
                Console.WriteLine("Между первым и вторым отрицательными элементами нет элементов.");
            }
        }
        else
        {
            Console.WriteLine("Недостаточно отрицательных элементов для выполнения вычислений.");
        }
    }
}
