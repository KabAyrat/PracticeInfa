using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите начальное значение x (xнач): ");
        double xStart = Convert.ToDouble(Console.ReadLine());
       
        Console.Write("Введите конечное значение x (xкон): ");
        double xEnd = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите шаг dx: ");
        double dx = Convert.ToDouble(Console.ReadLine());

        double R = 3;

        Console.WriteLine("{0,10} | {1,10}", "x", "y");
        Console.WriteLine(new string('-', 22));

        double x = xStart;
        while (x <= xEnd)
        {
            double y = 0;
            if (x <= -5)
            {
                y = -3;
            }
            else if (x > -5 && x <= -3)
            {
                double k = (0 - (-3)) / (-3 - (-5)); // Угловой коэффициент
                double b = -3 - k * (-5);           // Найдем b
                y = k * x + b;
            }
            else if (x > -3 && x <= 3)
            {
                y = Math.Sqrt(Math.Pow(R, 2) - Math.Pow(x, 2));
            }
            else if (x > 3 && x <= 8)
            {
                double k = (3 - 0) / (8 - 3); // Угловой коэффициент
                double b = 0 - k * 3;         // Найдем b
                y = k * x + b;
            }
            else if (x > 8)
            {
                y = 3;
            }

            Console.WriteLine("{0,10:F2} | {1,10:F2}", x, y);

            x += dx;
        }
    }
}
