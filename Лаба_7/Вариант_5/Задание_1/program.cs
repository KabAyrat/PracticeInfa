using System;
using System.IO;



class Animal
{
    private string name;                        // Закрытые переменные
    private string animalClass;
    private double averageWeight;

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public string Class
    {
        get { return animalClass; }
        set { animalClass = value; }
    }

    public double AverageWeight
    {
        get { return averageWeight; }
        set
        {
            if (value <= 0)
            {
                Console.WriteLine("Значение должно быть больше нуля");
            }
            else
            {
                averageWeight = value;
            }
        }
    }

    // Пустой конструктор
    public Animal()
    {
        Name = "undefined";
        Class = "undefined";
        AverageWeight = 1;
    }

    public Animal(string name, string animalClass, double averageWeight)
    {
        Name = name;
        Class = animalClass;
        AverageWeight = averageWeight;
    }

    public void InputFromUser()                      // Ввод данных от пользователя
    {
        Console.Write("Введите имя животного: ");
        Name = Console.ReadLine();
        Console.Write("Введите класс животного: ");
        Class = Console.ReadLine();
        Console.Write("Введите средний вес животного: ");
        double weight;
        if (double.TryParse(Console.ReadLine(), out weight))
        {
            AverageWeight = weight;
        }
        else
        {
            Console.WriteLine("Ошибка ввода. Установлено значение по умолчанию (1).");
            AverageWeight = 1;
        }
    }

    public void ShowMessage()
    {
        Console.WriteLine($"Животное: {Name}, Класс: {Class}, Средний вес: {AverageWeight} кг.");
    }

    public void SaveToFile(StreamWriter writer)
    {
        writer.WriteLine($"Имя: {Name}");
        writer.WriteLine($"Класс: {Class}");
        writer.WriteLine($"Средний вес: {AverageWeight} кг.");
        writer.WriteLine();
    }

    public static bool operator >(Animal a1, Animal a2)
    {
        return a1.AverageWeight > a2.AverageWeight;
    }

    public static bool operator <(Animal a1, Animal a2)
    {
        return a1.AverageWeight < a2.AverageWeight;
    }

    public static Animal operator +(Animal a1, Animal a2)
    {
        return new Animal
        {
            Name = a1.Name + " и " + a2.Name,
            Class = a1.Class,
            AverageWeight = a1.AverageWeight + a2.AverageWeight
        };
    }
}

class Program
{
    static void SaveComparisonResult(Animal animal1, Animal animal2, Animal combinedAnimal, string filePath)
    {
        using (StreamWriter writer = new StreamWriter(filePath, true))
        {
            animal1.SaveToFile(writer);
            animal2.SaveToFile(writer);
            writer.WriteLine($"Суммарный вес {animal1.Name} и {animal2.Name} = {combinedAnimal.AverageWeight}");

            if (animal1 > animal2)
            {
                writer.WriteLine($"{animal1.Name} тяжелее, чем {animal2.Name}.");
                Console.WriteLine($"{animal1.Name} тяжелее, чем {animal2.Name}.");
            }
            else if (animal1 < animal2)
            {
                writer.WriteLine($"{animal1.Name} легче, чем {animal2.Name}.");
                Console.WriteLine($"{animal1.Name} легче, чем {animal2.Name}.");
            }
            else
            {
                writer.WriteLine($"{animal1.Name} и {animal2.Name} весят одинаково.");
                Console.WriteLine($"{animal1.Name} и {animal2.Name} весят одинаково.");
            }
        }

        Console.WriteLine("Информация о сравнении записана в файл.");
    }

    static void Main()
    {
        Console.WriteLine("Данные для первого животного:");
        Animal animal1 = new Animal();
        animal1.InputFromUser();
        Console.WriteLine("Данные для второго животного:");
        Animal animal2 = new Animal();
        animal2.InputFromUser();

        animal1.ShowMessage();
        animal2.ShowMessage();

        Animal combinedAnimal = animal1 + animal2;
        Console.WriteLine($"Суммарный вес животных: {combinedAnimal.AverageWeight} кг.");

        string filePath = @"C:\Users\d229\Desktop\labaaa\labaaa\TextFile1.txt";

        SaveComparisonResult(animal1, animal2, combinedAnimal, filePath);
    }
}
