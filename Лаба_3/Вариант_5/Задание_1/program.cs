using System;
using System.Linq;

class Program
{
    static void Main()
    {

        int[] arr = { 3, -2, 5, 8, -7, 6, -4, 1 };

        Console.WriteLine("Массив: " + string.Join(", ", arr));

        int maxModul = arr.OrderByDescending(Math.Abs).First();
        Console.WriteLine("Максимальный по модулю элемент: " + maxModul);

        // Поиск первого и второго минусового числа
        int firstNegativeChislo = Array.FindIndex(arr, x => x < 0);
        int secondNegativeChislo = Array.FindIndex(arr, firstNegativeChislo + 1, x => x < 0);

        if (firstNegativeChislo != -1 && secondNegativeChislo != -1){
            int sum = 0;
            int count = 0;

            for (int i = firstNegativeChislo + 1; i < secondNegativeChislo; i++){
                sum += arr[i];
                count++;
            }

            if (count > 0){
                double avg = (double)sum / count;
                Console.WriteLine("Среднее арифметическое: " + avg);
            }else{
                Console.WriteLine("таких элементов нет .");
            }
        }else{
            Console.WriteLine("Недостаточно отрицательных элементов");
        }
    }
}
