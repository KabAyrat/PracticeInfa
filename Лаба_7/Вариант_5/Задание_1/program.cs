using System;
using System.IO;


/*

Тигр
Млекопитающее
220

_______________________________
Карась
Рыба
1
(да, болльшой карась..)))


 */

class Animal
{
    private string name;                                                    // Закрытые переменные
    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    private string animalClass;
    public string Class                                                     // Инкапсуляция
    {
        get { return animalClass; }
        set { animalClass = value; }
    }

    private double averageWeight;
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

    public Animal()                                                         
    {
        Name = "undefined";
        Class = "undefined";
        AverageWeight = 1;
    }

    public void InputFromUser()                                              // Ввод данных от пользователя
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

    public Animal(string name, string animalClass, double averageWeight)     
    {
        Name = name;
        Class = animalClass;
        AverageWeight = averageWeight;
    }

    public void ShowMessage()                                               
    {
        Console.WriteLine($"Животное: {Name}, Класс: {Class}, Средний вес: {AverageWeight} кг.");
    }

    public void SaveToFile(string fileName)                                  
    {
        using (StreamWriter writer = new StreamWriter(fileName, true))       
        {
            writer.WriteLine($"Имя: {Name}");
            writer.WriteLine($"Класс: {Class}");
            writer.WriteLine($"Средний вес: {AverageWeight} кг.");
            writer.WriteLine();                                              
        }
        Console.WriteLine("Данные записаны в файл");
    }
    public static bool operator >(Animal a1, Animal a2)             //перегрузка операторов сравнения
    {
        return a1.AverageWeight > a2.AverageWeight;
    }

    public static bool operator <(Animal a1, Animal a2)
    {
        return a1.AverageWeight < a2.AverageWeight;
    }
    public static Animal operator +(Animal a1, Animal a2)              // перегрузка операторов сложения
    {
        return new Animal
        {
            Name = a1.Name + " и " + a2.Name, Class = a1.Class, AverageWeight = a1.AverageWeight + a2.AverageWeight
        };
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("данные для первого животного:");
        Animal animal1 = new Animal();
        animal1.InputFromUser();

        Console.WriteLine("данные для второго животного:");
        Animal animal2 = new Animal();
        animal2.InputFromUser();

        animal1.ShowMessage();
        animal2.ShowMessage();

        Animal combinedAnimal = animal1 + animal2;
        Console.WriteLine($"Суммарный вес животных: {combinedAnimal.AverageWeight} кг.");

        string filePath = @"C:\Users\ayraa\source\repos\ConsoleApp6\ConsoleApp6\TextFile1.txt";
        using (StreamWriter writer = new StreamWriter(filePath, true)) 
        {
            writer.WriteLine($"Животное 1: Имя: {animal1.Name}, Класс: {animal1.Class}, Средний вес: {animal1.AverageWeight}");

            writer.WriteLine($"Животное 2: Имя: {animal2.Name}, Класс: {animal2.Class}, Средний вес: {animal2.AverageWeight}");

            writer.WriteLine($"Суммарный вес {animal1.Name} и {animal2.Name} = {combinedAnimal.AverageWeight}");
        }

        Console.WriteLine("Информация о животных и их суммарный вес записаны в файл.");
    }
}
