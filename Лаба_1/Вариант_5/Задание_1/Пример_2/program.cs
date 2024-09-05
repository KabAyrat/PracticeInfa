using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите a: ");
        double a = Convert.ToDouble(Console.ReadLine());
        double z = Math.Pow(Math.Cos(a), 2) + Math.Pow(Math.Cos(a), 4);
        Console.WriteLine(z);
    }
}

