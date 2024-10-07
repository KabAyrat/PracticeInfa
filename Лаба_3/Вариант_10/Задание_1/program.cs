using System;
using System.Linq;
using System.Numerics;

class Program
{
    static void Main()
    {
        double[] mass = { 0, -7, 10, 0, 8.4, 0, 7.9, -5, 3, -4 };

        foreach (double num in mass)
        {
            Console.Write(num + " ");
        }
        int n = 0;
        double negativeSum = 0; 
        foreach (double num in mass)
        {
            if(num == 0)
            {
                n++;
            }
            if(num < 0 && num % 2 != 0)
            {
                negativeSum += num;
            }

        }
        Console.WriteLine("\n"+ n);
        Console.WriteLine(negativeSum);
    }
}
