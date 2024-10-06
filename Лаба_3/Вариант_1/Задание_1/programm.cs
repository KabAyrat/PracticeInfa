using System;

class Program
{
    static void Main()
    {
        int[] massiv = {1,2,3,0,64,7,6,3,1,0};

        Console.Write("Исходный массив: ");
        foreach (int num in massiv)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();                            //первая задача, вывод массива
        int evenMassIndex = 1;

        for (int i = 0; i < massiv.Length; i += 2)
        {
            evenMassIndex *= massiv[i];
        }
        Console.WriteLine("Произведение четных индексов: " + evenMassIndex);               //вторая задача, произведение четных индексов

        int firstZero = Array.IndexOf(massiv, 0);
        int lastZero = Array.LastIndexOf(massiv, 0);
        Console.WriteLine($"Первый нулевой элемент находится на позиции [{firstZero}], последний нулевой элемент находится на позиции [{lastZero}]");
        int sum = 0;

        if (firstZero != -1 && lastZero != -1 && firstZero != lastZero)
        {
            
            for (int i = firstZero; i < lastZero; i++)
            {
                sum += massiv[i];
            }
            Console.WriteLine("Сумма чисел между нулями: " + sum);                         //третья задача, сумма чисел между нулями
        }
        else
        {
            Console.WriteLine("У вас нет двухх нулей");
        }
    }
}
