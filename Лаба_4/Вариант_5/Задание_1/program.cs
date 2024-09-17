using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Объявление и инициализация первого списка
        List<int> list1 = new List<int> { 1, 2, 3, 4, 5 };
        
        // Вывод элементов первого списка
        Console.WriteLine("Первый список:");
        PrintList(list1);

        // Добавление элемента в конец списка
        list1.Add(6);
        Console.WriteLine("\nПервый список после добавления элемента в конец:");
        PrintList(list1);

        // Объявление и инициализация второго списка
        List<int> list2 = new List<int> { 7, 8, 9 };
        
        // Вывод элементов второго списка
        Console.WriteLine("\nВторой список:");
        PrintList(list2);

        // Вставка второго списка в первый начиная с третьей позиции
        list1.InsertRange(2, list2);
        Console.WriteLine("\nПервый список после вставки второго начиная с третьей позиции:");
        PrintList(list1);

        // Вывод количества элементов в первом списке
        Console.WriteLine($"\nКоличество элементов в первом списке: {list1.Count}");

        // Вывод максимального элемента первого списка
        Console.WriteLine($"Максимальный элемент первого списка: {MaxElement(list1)}");

        // Вывод минимального элемента первого списка
        Console.WriteLine($"Минимальный элемент первого списка: {MinElement(list1)}");

        // Копирование второго списка в массив
        int[] array = list2.ToArray();
        Console.WriteLine("\nМассив, скопированный из второго списка:");
        PrintArray(array);

        // Удаление второго элемента во втором списке
        list2.RemoveAt(1);
        Console.WriteLine("\nВторой список после удаления второго элемента:");
        PrintList(list2);
    }

    // Метод для вывода списка на экран
    static void PrintList(List<int> list)
    {
        foreach (int item in list)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }

    // Метод для поиска максимального элемента списка
    static int MaxElement(List<int> list)
    {
        return list.Count > 0 ? list.Max() : int.MinValue;
    }

    // Метод для поиска минимального элемента списка
    static int MinElement(List<int> list)
    {
        return list.Count > 0 ? list.Min() : int.MaxValue;
    }

    // Метод для вывода массива на экран
    static void PrintArray(int[] array)
    {
        foreach (int item in array)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }
}












using System;
using System.Collections;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        /* List<string> names = ["<name>", "Ana", "Felipe"];
         Console.WriteLine();
         names.Add("Maria");
         names.Add("Bill");
         names.Remove("Ana");
         foreach (var name in names)
         {
             Console.WriteLine($"Hello {name.ToUpper()}!");
         }*/

        List<int> nums = new List<int>(5) {1,2,3,4,5};
        Console.WriteLine("Начальный список:");             //      1
        foreach (int x in nums)
        {
            Console.WriteLine(x);
        }
        nums.Add(6);


        Console.WriteLine("Добавили элемент в конец списка:");         
        foreach (int x in nums)
        {
            Console.WriteLine(x);
        }


        List<int> nums2 = new List<int>(3) {8, 9, 10};           //      2
        Console.WriteLine("Второй список:"); 
        foreach (int x in nums2)
        {
            Console.WriteLine(x);
        }


        nums.InsertRange(2, nums2);
        Console.WriteLine("первый список после добавдения второго в него:");            //  3
        foreach (int x in nums)
        {
            Console.WriteLine(x);
        }
        Console.WriteLine("Длина всего первого списка: "+ nums.Count) ;               //      4


        Console.WriteLine("Максимальное значение списка: "+ nums.Max());            //      5
        Console.WriteLine("Минимальное значение списка: " + nums.Min());            //      6


        foreach (int item in nums2)
        {
            Console.Write(item + " ");
        }

    }
}
