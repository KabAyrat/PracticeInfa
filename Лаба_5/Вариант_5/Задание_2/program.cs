using System;
using System.Linq;

class Program
{
    static void Main()
    {
        //Console.WriteLine("Введите текст:");
        //string input = Console.ReadLine();

        //string shiftedText = new string(input.Select(c =>
        //{
        //    if (char.IsLetter(c))
        //    {
        //        // Если это строчная буква
        //        if (char.IsLower(c))
        //        {
        //            if (c == 'z') 
        //            {
        //                return 'a';
        //            }
        //            else
        //            {
        //                return (char)(c + 1);
        //            }
        //        }
        //        else if (char.IsUpper(c))
        //        {
        //            if (c == 'Z') 
        //            {
        //                return 'A';
        //            }
        //            else
        //            {
        //                return (char)(c + 1);
        //            }
        //        }
        //    }
        //    return c;
        //}).ToArray());

        //Console.WriteLine($"Сдвинутый текст: {shiftedText}");

        Console.WriteLine("Введите текст, заканчивающийся точкой:");
        string input = Console.ReadLine().TrimEnd('.'); 

        string[] words = input.Split(' ', ',');

        int maxWordLength = words.Where(word => word != "").Max(word => word.Length);

        Console.WriteLine($"K = {maxWordLength}");

        string secretText = new string(input.Select(c => {
            if (char.IsLetter(c)){
                char upperLimit;
                char lowerLimit;

                if (char.IsUpper(c)){
                    upperLimit = 'Z';
                    lowerLimit = 'A';
                } else{
                    upperLimit = 'z';
                    lowerLimit = 'a';
                }

                if (c + maxWordLength > upperLimit){
                    return (char)(c + maxWordLength - 26);
                } else{
                    return (char)(c + maxWordLength);
                }
            } else{
                return c;
            }
        }).ToArray());

        Console.WriteLine($"Зашифрованный текст: {secretText}");
    }
}
