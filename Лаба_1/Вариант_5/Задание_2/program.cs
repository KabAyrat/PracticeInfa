using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите значение a: ");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите значение b: ");
        double b = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите значение x: ");
        double x = Convert.ToDouble(Console.ReadLine());

        double y;

        if (Math.Abs(a - Math.Pow(b, 2)) > b)
        {
            y = Math.Log(Math.Abs(a * x - b)) - Math.Exp(Math.Atan(x));
        }
        else
        {
            y = Math.Tan(4 * x - a);
        }
        Console.WriteLine(y);
    }
}

