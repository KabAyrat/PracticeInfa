using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите что-нибудь:");
        string input = Console.ReadLine();

        string[] words = input.Split(' ');

        Array.Reverse(words);
        string reversedWords = string.Join(" ", words);

        Console.WriteLine("Слова задом наперед:");
        Console.WriteLine(reversedWords);

        char[] charArray = input.ToCharArray();
        Array.Reverse(charArray);
        string reversedString = new string(charArray);

        Console.WriteLine("Текст задом наперед:");
        Console.WriteLine(reversedString);
    }
}
