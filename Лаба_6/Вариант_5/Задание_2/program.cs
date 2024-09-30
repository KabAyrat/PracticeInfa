using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        // Путь к исходному файлу с данными
        string inputFilePath = @"C:\Users\Имя_пользователя\Desktop\input.txt"; // Укажите свой путь к файлу
        string outputFilePath = @"C:\Users\Имя_пользователя\Desktop\output.txt"; // Укажите путь для файла с результатом

        // Словарь для хранения данных, сгруппированных по специфике товара
        Dictionary<string, List<string>> storeGroups = new Dictionary<string, List<string>>();

        // Проверяем, существует ли файл с входными данными
        if (File.Exists(inputFilePath))
        {
            // Читаем все строки из файла
            string[] lines = File.ReadAllLines(inputFilePath);

            // Обрабатываем каждую строку
            foreach (string line in lines)
            {
                // Разделяем строку по разделителю '|' на название, специфику товара и адрес
                string[] parts = line.Split('|');

                if (parts.Length == 3)
                {
                    string storeName = parts[0].Trim();
                    string category = parts[1].Trim();
                    string address = parts[2].Trim();

                    // Если этой категории еще нет в словаре, добавляем её
                    if (!storeGroups.ContainsKey(category))
                    {
                        storeGroups[category] = new List<string>();
                    }

                    // Добавляем запись в список для соответствующей категории
                    storeGroups[category].Add($"{storeName}, {address}");
                }
            }

            // Записываем сгруппированные данные в выходной файл
            using (StreamWriter writer = new StreamWriter(outputFilePath))
            {
                foreach (var group in storeGroups)
                {
                    writer.WriteLine($"Специфика товара: {group.Key}");
                    foreach (var store in group.Value)
                    {
                        writer.WriteLine($"- {store}");
                    }
                    writer.WriteLine(); // Пустая строка между группами
                }
            }

            Console.WriteLine("Данные успешно сгруппированы и записаны в файл.");
        }
        else
        {
            Console.WriteLine("Файл с входными данными не найден.");
        }
    }
}
