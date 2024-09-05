using System;

class Program
{
    static void Main()
        {
        Console.Write("Введите a: ");
        double num = Convert.ToDouble(Console.ReadLine());
        double z = 1 - (1.0 / 4) * Math.Pow(Math.Sin(2 * num), 2) + Math.Cos(2 * num);
        Console.WriteLine(z);
    }
}

