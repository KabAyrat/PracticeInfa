using System;

class Program
{
    static void Main()
    {
        // Ввод начальных значений для интервала и шага
        Console.Write("Введите начальное значение x (xнач): ");
        double xStart = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите конечное значение x (xкон): ");
        double xEnd = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите шаг dx: ");
        double dx = Convert.ToDouble(Console.ReadLine());

        // Радиус окружности
        double R = 3;

        // Шапка таблицы
        Console.WriteLine("{0,10} | {1,10}", "x", "y");
        Console.WriteLine(new string('-', 22));

        // Используем цикл while для вычисления значений
        double x = xStart;
        while (x <= xEnd)
        {
            double y = 0;

            // Проверка на каждом сегменте
            if (x <= -5)
            {
                // Сегмент 1: y = -3
                y = -3;
            }
            else if (x > -5 && x <= -3)
            {
                // Сегмент 2: Линейная зависимость от -5 до -3
                // Уравнение прямой: y = kx + b
                double k = (0 - (-3)) / (-3 - (-5)); // Угловой коэффициент
                double b = -3 - k * (-5);           // Найдем b
                y = k * x + b;
            }
            else if (x > -3 && x <= 3)
            {
                // Сегмент 3: Полуокружность, уравнение: (x - 0)^2 + (y - 0)^2 = R^2
                y = Math.Sqrt(Math.Pow(R, 2) - Math.Pow(x, 2));
            }
            else if (x > 3 && x <= 8)
            {
                // Сегмент 4: Линейная зависимость от 3 до 8
                double k = 3.0 / 5.0; // Угловой коэффициент: (3 - 0) / (8 - 3)
                y = k * (x - 3);      // Прямая с наклоном, проходящая через (3, 0)
            }
            else if (x > 8)
            {
                // Сегмент 5: y = 3
                y = 3;
            }

            // Вывод значения в таблице
            Console.WriteLine("{0,10:F2} | {1,10:F2}", x, y);

            // Увеличение x на шаг dx
            x += dx;
        }
    }
}
