using System;
using System.IO;

class Program
{
    static void Main()
    {
        // Чтение текста из файла
        string filePath = @"C:\Users\ayraa\Desktop\input.txt";

        string text = File.ReadAllText(filePath);

        string[] numberWords = { "ноль", "один", "два", "три", "четыре", "пять", "шесть", "семь", "восемь", "девять" };

        foreach (char c in text)
        {
            if (char.IsDigit(c))
            {
                int digit = c - '0'; 
                Console.Write(numberWords[digit] + " "); 
            }
            else
            {
                Console.Write(c); 
            }
        }
    }
}
