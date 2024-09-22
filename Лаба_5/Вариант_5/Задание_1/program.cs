using System;

class Program
{
    static string ReverseWords(string input)
    {
        string[] words = input.Split(' ');
        Array.Reverse(words);
        return string.Join(" ", words);
    }

    static string ReverseString(string input)
    {
        char[] charArray = input.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }
    static void Main()
    {

        Console.WriteLine("Введите что-нибудь:");
        string input = Console.ReadLine();

        string reversedWords = ReverseWords(input);

        Console.WriteLine("словами наоборот: ");
        Console.WriteLine(reversedWords);

        string reversedString = ReverseString(reversedWords);
        Console.WriteLine("Строка в обратном порядке:");
        Console.WriteLine(reversedString);
    }

}
