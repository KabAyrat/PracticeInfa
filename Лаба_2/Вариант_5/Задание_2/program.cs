using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите N (N не должно превышать 27): ");
        int N = Convert.ToInt32(Console.ReadLine());

        if (N > 27 || N < 1)
        {
            Console.WriteLine("N должно быть в диапазоне от 1 до 27");
            return;
        }

        Console.WriteLine("Трёхзначные числа, сумма цифр которых равна {0}: ", N);

        for (int i = 100; i <= 999; i++)
        {
            int sot = i / 100;
            int ten = (i / 10) % 10;
            int ones = i % 10;

            int sum = sot + ten + ones;
            if (sum == N)
            {
                Console.WriteLine(i);
            }
        }
    }
}
