using System;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите текст, заканчивающийся точкой:");
        string input = Console.ReadLine();
        string textWithoutDot = input.TrimEnd('.');
        string[] words = textWithoutDot.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
        int maxWordLength = words.Max(word => word.Count(char.IsLetter));
        Console.WriteLine($"K = {maxWordLength}");
        char ShiftChar(char c, int shift)
        {
            if (char.IsLetter(c))
            {
                char offset = char.IsUpper(c) ? 'A' : 'a';
                return (char)((((c - offset) + shift) % 26) + offset);
            }
            return c; 
        }

        string encryptedText = new string(input.Select(c => ShiftChar(c, maxWordLength)).ToArray());

        Console.WriteLine($"Зашифрованный текст: {encryptedText}");
    }
}
