using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        string inputFilePath = @"C:\Users\ayraa\Desktop\test.txt";
        string outputFilePath = @"C:\Users\ayraa\Desktop\output1.txt";
        Dictionary<string, List<string>> storeGroups = new Dictionary<string, List<string>>();


        string[] lines = File.ReadAllLines(inputFilePath);

        foreach (string line in lines)
        {
            string[] parts = line.Split('/');

            if (parts.Length == 3)
            {
                string storeName = parts[0].Trim();
                string category = parts[1].Trim();
                string address = parts[2].Trim();

                if (!storeGroups.ContainsKey(category))
                {
                    storeGroups[category] = new List<string>();
                }

                storeGroups[category].Add($"{storeName}, {address}");
            }
        }

        using (StreamWriter writer = new StreamWriter(outputFilePath))
        {
            foreach (var group in storeGroups)
            {
                writer.WriteLine($"тип магазина: {group.Key}");
                foreach (var store in group.Value)
                {
                    writer.WriteLine($"- {store}");
                }
                writer.WriteLine();
            }
        }

        Console.WriteLine("Данные успешно записаны в файл.");

    }
}
