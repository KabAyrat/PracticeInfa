using System;
using System.Linq;

class Program
{
    static void Main()
    {
        // Ввод текста
        Console.WriteLine("Введите текст, заканчивающийся точкой:");
        string input = Console.ReadLine();
        
        // Удаляем точку для анализа слов
        string textWithoutDot = input.TrimEnd('.');
        
        // Разделяем текст на слова
        string[] words = textWithoutDot.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
        
        // Находим самое длинное слово
        int maxWordLength = words.Max(word => word.Count(char.IsLetter));
        
        // Выводим K (длину самого длинного слова)
        Console.WriteLine($"K = {maxWordLength}");
        
        // Функция для сдвига символа по алфавиту
        char ShiftChar(char c, int shift)
        {
            if (char.IsLetter(c))
            {
                char offset = char.IsUpper(c) ? 'A' : 'a';
                return (char)((((c - offset) + shift) % 26) + offset);
            }
            return c; // Если символ не буква, оставляем без изменений
        }

        // Шифруем текст
        string encryptedText = new string(input.Select(c => ShiftChar(c, maxWordLength)).ToArray());

        // Выводим зашифрованный текст
        Console.WriteLine($"Зашифрованный текст: {encryptedText}");
    }
}
