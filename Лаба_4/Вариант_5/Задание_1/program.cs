using System;
using System.Collections;
using System.Collections.Generic;

class Program
{
    static void Main()
    {

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
